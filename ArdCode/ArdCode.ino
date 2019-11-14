#include <SimpleDHT.h>
#include <LiquidCrystal.h>

#define POTCHECK oldVal != val &&  oldVal != (val + 1) &&  oldVal != (val - 1)
#define TEMPCHECK oldTemp != temp
#define interruptNumber 0
//Pins
int potPin = 0;    // select the input pin for the potentiometer
int ledPin = 13;   // select the pin for the LED
int pinDHT11 = 6;
int buzzer = 3;
const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2;

//Varibles
int val = 0;
int oldVal = 0;
int output = 0;
int temp = 0;
int oldTemp = 0;
int hum = 0;

String text;

volatile byte temperature = 0;
volatile byte humidity = 0;
volatile byte sensorInterruptFlag = 0;


LiquidCrystal lcd(rs, en, d4, d5, d6, d7);
SimpleDHT11 dht11(pinDHT11);

//Setup
void setup() {
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);  // declare the ledPin as an OUTPUT
  Serial.println(map(analogRead(potPin), 0, 1023, 0, 100));
  dht11.read(&temperature, &humidity, NULL);
  Serial.println((int)temperature);
  lcd.begin(16, 2);
  lcd.setCursor(0, 0);
  lcd.print("Start up test");
  attachInterrupt(digitalPinToInterrupt(0), interruptServiceRoutine, CHANGE);
}

void lcdOperation() {
  if (Serial.available() > 0) {
    text = Serial.readString();
    //Set 2 lines for LCD screen
    String line1 = text.substring(0, 16);
    String line2 = text.substring(16, 32);
    if (text.length() > 0) {
      lcd.setCursor(0, 0);
      lcd.print("                ");
      lcd.setCursor(0, 1);
      lcd.print("                ");
    }
    lcd.setCursor(0, 0);
    lcd.print(line1);
    lcd.setCursor(0, 1);
    lcd.print(line2);
  }
}

int potOutput() {
  val = analogRead(potPin);
  output = map(val, 0, 1023, 0, 100);
  return output;
}

int tempOutput(){
  int err = SimpleDHTErrSuccess;
  err = dht11.read(&temperature, &humidity, NULL);
  //Temp
  return (int)temperature;
  //Humidity
  hum = (int)humidity;
}
int humOutput(){
    int err = SimpleDHTErrSuccess;
  err = dht11.read(&temperature, &humidity, NULL);
  //Humidity
  return (int)humidity;
}

void loop() {
  //Call differnt functions
  lcdOperation();
  output = potOutput();
  temp = tempOutput();
  hum = humOutput();
    if(POTCHECK||TEMPCHECK){
    Serial.println(output);
    Serial.println(temp);
    Serial.println(hum);
    oldVal = val;
    oldTemp = temp;
    sensorInterruptFlag = 1;
    }
    

}

 void interruptServiceRoutine(){
 
 
 }
