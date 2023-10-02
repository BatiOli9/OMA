//const int analogInPin = A0;
const int analogOutPin = 9;  

int sensorValue = 0;
int outputValue = 0;

void setup() {
 Serial.begin(9600);
}

void loop() {
  while(Serial.available()==0){}
  String recibido=Serial.readStringUntil('\n');
  //sensorValue = analogRead(analogInPin);
  //outputValue = map(recibido.toInt(), 0, 1023, 0, 255);
  analogWrite(analogOutPin, recibido.toInt());
  analogWrite(10,recibido.toInt());
  analogWrite(11,recibido.toInt());

  delay(2);  
}
