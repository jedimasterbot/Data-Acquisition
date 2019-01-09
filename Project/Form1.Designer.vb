<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtoutput = New System.Windows.Forms.TextBox()
        Me.txtreading = New System.Windows.Forms.TextBox()
        Me.txtcurrent = New System.Windows.Forms.TextBox()
        Me.txtreadingleft = New System.Windows.Forms.TextBox()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.txtcom = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnconnect = New System.Windows.Forms.Button()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.connecting_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtrich = New System.Windows.Forms.Label()
        Me.showData = New System.Windows.Forms.Button()
        Me.clr = New System.Windows.Forms.Button()
        Me.sav = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Outout File Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. of Reading:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Current Data:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Readings Remaining:"
        '
        'txtoutput
        '
        Me.txtoutput.Location = New System.Drawing.Point(136, 81)
        Me.txtoutput.Name = "txtoutput"
        Me.txtoutput.Size = New System.Drawing.Size(151, 20)
        Me.txtoutput.TabIndex = 5
        '
        'txtreading
        '
        Me.txtreading.Location = New System.Drawing.Point(136, 131)
        Me.txtreading.Name = "txtreading"
        Me.txtreading.Size = New System.Drawing.Size(151, 20)
        Me.txtreading.TabIndex = 7
        '
        'txtcurrent
        '
        Me.txtcurrent.Location = New System.Drawing.Point(136, 181)
        Me.txtcurrent.Name = "txtcurrent"
        Me.txtcurrent.Size = New System.Drawing.Size(151, 20)
        Me.txtcurrent.TabIndex = 8
        '
        'txtreadingleft
        '
        Me.txtreadingleft.Location = New System.Drawing.Point(136, 236)
        Me.txtreadingleft.Name = "txtreadingleft"
        Me.txtreadingleft.Size = New System.Drawing.Size(151, 20)
        Me.txtreadingleft.TabIndex = 9
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(48, 331)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(92, 28)
        Me.btnstart.TabIndex = 10
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(48, 380)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(92, 28)
        Me.btnexit.TabIndex = 11
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(307, 81)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Transparent
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(595, 278)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(540, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "No.of Readings"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(648, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Time:"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(450, 51)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(171, 20)
        Me.txtdate.TabIndex = 17
        '
        'txttime
        '
        Me.txttime.Location = New System.Drawing.Point(687, 51)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(171, 20)
        Me.txttime.TabIndex = 18
        '
        'txtcom
        '
        Me.txtcom.FormattingEnabled = True
        Me.txtcom.Items.AddRange(New Object() {"COM1", "COM2"})
        Me.txtcom.Location = New System.Drawing.Point(10, 38)
        Me.txtcom.Name = "txtcom"
        Me.txtcom.Size = New System.Drawing.Size(153, 21)
        Me.txtcom.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "COM Port:"
        '
        'btnconnect
        '
        Me.btnconnect.Location = New System.Drawing.Point(177, 31)
        Me.btnconnect.Name = "btnconnect"
        Me.btnconnect.Size = New System.Drawing.Size(110, 28)
        Me.btnconnect.TabIndex = 22
        Me.btnconnect.Text = "Connect"
        Me.btnconnect.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Location = New System.Drawing.Point(309, 34)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(62, 13)
        Me.Timer_LBL.TabIndex = 23
        Me.Timer_LBL.Text = "Timer : OFF"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'connecting_Timer
        '
        Me.connecting_Timer.Interval = 250
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(915, 66)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(155, 353)
        Me.RichTextBox1.TabIndex = 25
        Me.RichTextBox1.Text = ""
        '
        'txtrich
        '
        Me.txtrich.AutoSize = True
        Me.txtrich.Location = New System.Drawing.Point(953, 50)
        Me.txtrich.Name = "txtrich"
        Me.txtrich.Size = New System.Drawing.Size(79, 13)
        Me.txtrich.TabIndex = 26
        Me.txtrich.Text = "Received Data"
        '
        'showData
        '
        Me.showData.Location = New System.Drawing.Point(166, 331)
        Me.showData.Name = "showData"
        Me.showData.Size = New System.Drawing.Size(91, 28)
        Me.showData.TabIndex = 27
        Me.showData.Text = "Show"
        Me.showData.UseVisualStyleBackColor = True
        '
        'clr
        '
        Me.clr.Location = New System.Drawing.Point(956, 425)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(92, 28)
        Me.clr.TabIndex = 28
        Me.clr.Text = "Clear"
        Me.clr.UseVisualStyleBackColor = True
        '
        'sav
        '
        Me.sav.Location = New System.Drawing.Point(165, 380)
        Me.sav.Name = "sav"
        Me.sav.Size = New System.Drawing.Size(92, 28)
        Me.sav.TabIndex = 29
        Me.sav.Text = "Save"
        Me.sav.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 467)
        Me.Controls.Add(Me.sav)
        Me.Controls.Add(Me.clr)
        Me.Controls.Add(Me.showData)
        Me.Controls.Add(Me.txtrich)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.btnconnect)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcom)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.txtreadingleft)
        Me.Controls.Add(Me.txtcurrent)
        Me.Controls.Add(Me.txtreading)
        Me.Controls.Add(Me.txtoutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtoutput As System.Windows.Forms.TextBox
    Friend WithEvents txtreading As System.Windows.Forms.TextBox
    Friend WithEvents txtcurrent As System.Windows.Forms.TextBox
    Friend WithEvents txtreadingleft As System.Windows.Forms.TextBox
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents txtcom As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnconnect As System.Windows.Forms.Button
    Friend WithEvents Timer_LBL As System.Windows.Forms.Label
    Friend WithEvents connecting_Timer As System.Windows.Forms.Timer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtrich As System.Windows.Forms.Label
    Public WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents showData As System.Windows.Forms.Button
    Friend WithEvents clr As System.Windows.Forms.Button
    Friend WithEvents sav As System.Windows.Forms.Button

End Class
