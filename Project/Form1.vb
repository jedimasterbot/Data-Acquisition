
Imports System
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting.Chart
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop
Imports System.IO
'My.Computer.FileSystem.WriteAllText("C:\TestFolder1\test.txt","This is new text to be added.",True)

Public Class Form1
    'Global variables
    Dim s As New Series
    Dim data As String
    Dim i As Integer = -1
    Dim j As Integer = 0
    Dim f As Integer = -1
    Dim array(50) As String
    Dim c1 As String
    Dim voltage As Double
    Dim y As Double
    Dim s2 As String
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim connected As Boolean = False
    Dim stp As Boolean = False
    Dim count = 0
    Dim Incoming1 As String
    Dim a As String
    Dim b As String
    Dim c As String
    Dim d As String
    Dim con As Double
    Dim inputString As String = "Data Record:" & vbCrLf

    Dim fileTest As String = "E:\Temp\ExcelTest\\testfile.txt"

    Dim oExcel As Object
    Dim oBook As Excel.Workbook
    Dim oSheet As Excel.Worksheet
    Dim Rng As Excel.Range
    Dim StartRow, StartCol

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtoutput.Text = "testfile"
        Me.Chart1.Series("Series1").BorderWidth = 5
        If File.Exists(fileTest) Then
            File.Delete(fileTest)
        End If
        txtdate.Text = DateTime.Now.ToLongDateString()
        txttime.Text = DateTime.Now.ToString("hh:mm")
        Timer1.Enabled = False
        populateCOMport()
    End Sub
    Private Sub populateCOMport()
        comPORT = ""
        txtcom.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            txtcom.Items.Add(sp)
        Next
    End Sub
    Private Sub txtcom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcom.SelectedIndexChanged
        If (txtcom.SelectedItem <> "") Then
            comPORT = txtcom.SelectedItem
        End If
    End Sub
    Private Sub btnconnect_Click(sender As Object, e As EventArgs) Handles btnconnect.Click
        comPORT = txtcom.SelectedItem
        If (btnconnect.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                Console.WriteLine("zdsfdxtghfh")
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = IO.Ports.Parity.None
                SerialPort1.StopBits = IO.Ports.StopBits.One
                SerialPort1.Handshake = IO.Ports.Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000
                SerialPort1.Open()
                'See if the Arduino is there
                count = 0
                SerialPort1.WriteLine("<HELLO>")
                btnconnect.Text = "Connecting..."
                connecting_Timer.Enabled = True
                txtreading.Text = "10"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            'connect_BTN.Text = "Dis-connect"
            'close the connection a reset the button and timer label
            Timer1.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
            SerialPort1.Close()
            connected = False
            btnconnect.Text = "Connect"
            populateCOMport()
        End If
    End Sub
    Private Sub connecting_Timer_Tick(sender As Object, e As EventArgs) Handles connecting_Timer.Tick
        connecting_Timer.Enabled = False
        count = count + 1
        If (count <= 8) Then
            receivedData = receivedData & ReceiveSerialData()
            If (Microsoft.VisualBasic.Left(receivedData, 5) = "HELLO") Then
                'if we get an HELLO from the Arduino then we are connected
                connected = True
                btnconnect.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Timer: ON"
                receivedData = ReceiveSerialData()
                receivedData = ""
                SerialPort1.WriteLine("<START>")
            Else
                'start the timer again and keep waiting for a signal from the Arduino
                connecting_Timer.Enabled = True
            End If
        Else
            'time out (8 * 250 = 2 seconds)
            RichTextBox1.Text &= vbCrLf & "ERROR" & vbCrLf & "Can not connect" & vbCrLf
            btnconnect.Text = "Connect"
            populateCOMport()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        RichTextBox1.Text &= receivedData
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function
    Function FunctionEval2(ByVal X As Double) As Double
        FunctionEval2 = voltage
    End Function
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    Private Sub txtoutput_TextChanged(sender As Object, e As EventArgs) Handles txtoutput.TextChanged
    End Sub
    Private Sub txtcount_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub txtreading_TextChanged(sender As Object, e As EventArgs) Handles txtreading.TextChanged

    End Sub
    Private Sub txtcurrent_TextChanged(sender As Object, e As EventArgs) Handles txtcurrent.TextChanged
    End Sub
    Private Sub txtreadingleft_TextChanged(sender As Object, e As EventArgs) Handles txtreadingleft.TextChanged
    End Sub
    Private Sub txtgraphtime_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub txttime_TextChanged(sender As Object, e As EventArgs) Handles txttime.TextChanged
    End Sub
    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs) Handles txtdate.TextChanged
    End Sub
    Private Sub Timer_LBL_Click(sender As Object, e As EventArgs) Handles Timer_LBL.Click
    End Sub
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        If ((connected) And (stp = False)) Then
            If (btnstart.Text = "Start") Then
                SerialPort1.WriteLine("<P004ON>")
                btnstart.Text = "Stop"
                stp = True
                j = 1
                While j <= Convert.ToInt16(txtreading.Text) 'usman ka code ki pheli line
                    txtreadingleft.Text = txtreading.Text - j
                    j += 1
                    wait(0.6)
                    Incoming1 = SerialPort1.ReadChar()
                    ' MsgBox(Incoming1)
                    If ((Incoming1 = 65)) Then
                        ' MsgBox("INCOMING2")
                        Saving()
                    End If
                End While
                SerialPort1.WriteLine("<P004OF>")
                btnstart.Text = "Start"
                stp = False
            End If
        ElseIf ((connected) And (stp = True)) Then
            SerialPort1.WriteLine("<P004OF>")
            btnstart.Text = "Start"
            stp = False
        End If
        If (connected = False) Then
            MsgBox("Not connected")
        End If
    End Sub
    Function Saving() As Double
        ' MsgBox("INCOMING3")
        a = SerialPort1.ReadByte()
        ' MsgBox(a)
        b = SerialPort1.ReadByte()
        'MsgBox(b)
        c = a + "." + b
        ' MsgBox(c)
        txtcurrent.Text = c
        inputString &= c & vbCrLf
        con = Convert.ToDouble(c)
        f = f + 1
        Me.Chart1.Series("Series1").Points.AddXY(f, con)
        'MsgBox(con)
        '  Dim sensorValue As Double = SerialPort1.ReadByte()
        '  voltage = sensorValue * (5.0 / 1023.0)
        '  MsgBox(Convert.ToString(voltage))
        Showing()
        Return con
    End Function
    Function Showing() As String
        i = i + 1
        array(i) = con
        Return array(i)
    End Function
    Private Sub showData_Click(sender As Object, e As EventArgs) Handles showData.Click
        ' For j As Integer = 0 To array.Length
        ' If (j = array.Length) Then
        'Exit For
        ' End If
        ' Console.WriteLine(array(j))
        ' Next

        Dim result As New System.Text.StringBuilder
        Dim j As Integer
        For j = 0 To array.Length - 1
            result = result.Append(Convert.ToString(array(j)))
            If (j < (array.Length - 1)) Then result.Append(",")
        Next j
        MsgBox(Convert.ToString(result))
        ' Console.WriteLine(result.ToString()) *\
    End Sub
    Private Sub wait(ByVal seconds As Double)
        For i As Double = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        RichTextBox1.Text = ""
        'Chart1.ChartAreas.Clear()
    End Sub

    Private Sub sav_Click(sender As Object, e As EventArgs) Handles sav.Click
       
        My.Computer.FileSystem.WriteAllText("E:\Temp\ExcelTest\\testfile.txt", inputString, False)
        If (Not (txtoutput.Text = "testfile")) Then
            My.Computer.FileSystem.RenameFile("E:\Temp\ExcelTest\\testfile.txt", txtoutput.Text & ".txt")
        End If


        'oExcel = CreateObject("Excel.Application")
        'oBook = oExcel.Workbooks.Add
        'oSheet = oExcel.Worksheets(1)
        'oSheet.Name = "Test Name"
        '  Dim g As Integer
        'For g = 0 To f
        'oSheet.Range("A1").Value = "some value"    
        'Next g
        'StartRow = 1
        'With oSheet
        ' Rng = .Range(.Cells(StartRow, "A"), _
        '        .Cells(UBound(array, 1) - LBound(array, 1) + StartRow, _
        '              UBound(array, 2) - LBound(array, 2) + "A"))
        'End With
        ' Rng.Value = array ' Column
        'oBook.SaveAs(fileTest)
        'oBook.Close()
        'oBook = Nothing
        '  oExcel.Quit()
        ' oExcel = Nothing
    End Sub
   
End Class
