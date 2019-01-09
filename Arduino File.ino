
boolean debug = true;
const byte numChars = 20;
char receivedChars[numChars];
double x;
boolean newData = false;
boolean feedback = true;
String inString = "";
String con = "";
int convertedtoint;
String ab;
String bc;
int a;
int b;

void setup()
{
  Serial.begin(9600);
  sendStartMessage();
}

void loop()
{
  if (Serial.available() > 0)     {
    recvWithStartEndMarkers();
  }

  if (newData) {

    parseData();
  }

}

void sendStartMessage()
{
  Serial.println(" ");
  Serial.println("Pulse Counting System Activated");
  Serial.println(" ");



}

void parseData()
{
  newData = false;
  if (debug) {
    Serial.println( receivedChars );
  }
  if (strcmp(receivedChars, "HELLO")  == 0)
  {
    Serial.println("HELLO");
    digitalWrite(13, HIGH);
    delay(1000);
    digitalWrite(13, LOW);
  }

  if (strcmp(receivedChars, "START")  == 0)
  {
    sendStartMessage();
  }

  if (receivedChars[0] == 'P'   )
  { while (receivedChars[5] == 'N')
    {


      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      recvWithStartEndMarkers();
      if ( receivedChars[4] == 'O' && receivedChars[5] == 'N' ) {
        int sensorValue = analogRead(A0);
        float voltage = sensorValue * (5.0 / 1023.0);
        delay(1150);
        writeString("A");
        while (voltage >= 1)
        {
          voltage = voltage - 1;
          a++;
        }
        b = voltage * 100;
        ab = String(a);
        bc = String(b);
        delay(1150);
        Serial.write(a);
        delay(1150);
        Serial.write(b);
        a = 0;
        b = 0;
      }
      if ( receivedChars[4] == 'O' && receivedChars[5] == 'F' ) {


        loop() ;
      }
    }
  }




}
void recvWithStartEndMarkers()
{
  static boolean recvInProgress = false;
  static byte ndx = 0;
  char startMarker = '<';
  char endMarker = '>';
  char rc;
  rc = Serial.read();
  if (recvInProgress == true)
  {
    if (rc != endMarker)
    {
      receivedChars[ndx] = rc;
      ndx++;
      if (ndx >= numChars) {
        ndx = numChars - 1;
      }
    }
    else
    {
      receivedChars[ndx] = '\0'; // terminate the string
      recvInProgress = false;
      ndx = 0;
      newData = true;
    }
  }

  else if (rc == startMarker) {
    recvInProgress = true;
  }
}
String converter(float voltage) {
  const int BUF_MAX = 64;
  char buf[BUF_MAX];
  const int VAL_MAX = 16;
  char val[VAL_MAX];
  strcpy_P(buf, (const char*) F(""));
  dtostrf(voltage, 8, 6, val);
  return strcat(buf, val);
}

void writeString(String stringData) {
  for (int i = 0; i < stringData.length(); i++)
  {
    Serial.write(stringData[i]);
  }
}
