//library
#include<Wire.h>
#include<TinyGPS++.h>
#include<SoftwareSerial.h>
#include<LiquidCrystal_I2C.h>

//deklarasi lcd dengan default i2c
LiquidCrystal_I2C lcd(0x27, 20, 4);

//variabel sensor getar
const int senGetar=7;
//sensor suara
const int senAnalog=A0;
long nilaiSuara=00;

//variabel modul gps
static const int TX=10, RX=11;
static const uint32_t GPSBaund=9600;
TinyGPSPlus gps;
SoftwareSerial gpsSerial(TX, RX);
float lattitude, longitude;
String titikLat, titikLong, kirimLat, kirimLong;
String kirimdata, id="2", kondisi="";

//nilai batas setiap sensor
int batasGetar=1000, batasSuara=200;

void setup() {
  
  //deklarasi setiap komponen
  lcd.init();
  lcd.backlight();
  Serial.begin(9600);
  gpsSerial.begin(9600);
  pinMode(senGetar, INPUT);
  pinMode(senAnalog, INPUT);
  
}

void loop() {
  
  //Keadaan awal Hardware sensor suara, getar, dan lcd
  long nilaiGetar = algoritmaSenGetar();
  delay(50);
  nilaiSuara = analogRead(senAnalog);
  lcd.setCursor(0, 0);
  lcd.print("Sen GTR : "); lcd.print(nilaiGetar);
  lcd.setCursor(0, 1);
  lcd.print("Sen SRA : "); lcd.print(nilaiSuara);
  
  modulGPS();
  kirimdata = '*' + id + ',' + nilaiGetar + ',' + nilaiSuara + ',' + kirimLat + ',' + kirimLong + ',' +  '#' + '\n';
  Serial.print(kirimdata);
  delay(1650);
}

//function algoritma sensor getar
long algoritmaSenGetar(){
  delay(10);
  long lama=pulseIn(senGetar, HIGH);
  return lama;
}

//function modul GPS
void modulGPS(){
  for(unsigned long start = millis(); millis() - start < 1000;){
    while (gpsSerial.available() > 0){
      int data = gpsSerial.read();
      gps.encode(data);
      if(gps.location.isUpdated()){
        lattitude = (gps.location.lat());
        longitude = (gps.location.lng());
        kirimLat = String(gps.location.lat(), 7);
        kirimLong = String(gps.location.lng(), 7);
        
      }
    }
  }
}
