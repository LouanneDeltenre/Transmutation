


const int boutonM = 2;
const int boutonE = 3;
const int boutonO = 4;
const int boutonI = 5;
const int boutonR = 6;
const int boutonA = 7;
const int boutonD = 8;
const int boutonU = 9;
const int boutonP = 11;
const int boutonSEND = 12;

void setup() {

  Serial.begin(9600);

  pinMode(boutonM, INPUT_PULLUP);
  pinMode(boutonE, INPUT_PULLUP);
  pinMode(boutonO, INPUT_PULLUP);
  pinMode(boutonI, INPUT_PULLUP);
  pinMode(boutonR, INPUT_PULLUP);
  pinMode(boutonA, INPUT_PULLUP);
  pinMode(boutonD, INPUT_PULLUP);
  pinMode(boutonU, INPUT_PULLUP);
  pinMode(boutonP, INPUT_PULLUP);
  pinMode(boutonSEND, INPUT_PULLUP);
  
}

void loop() {

  if (digitalRead(boutonM) == 0) {
    Serial.println("m");
  }
  if (digitalRead(boutonE) == 0) {
    Serial.println("e");
  }
  if (digitalRead(boutonO) == 0) {
    Serial.println("o");
  }
  if (digitalRead(boutonI) == 0) {
    Serial.println("i");
  }
  if (digitalRead(boutonR) == 0) {
    Serial.println("r");
  }
  if (digitalRead(boutonA) == 0) {
    Serial.println("a");
  }
  if (digitalRead(boutonD) == 0) {
    Serial.println("d");
  }
  if (digitalRead(boutonU) == 0) {
    Serial.println("u");
  }
  if (digitalRead(boutonP) == 0) {
    Serial.println("p");
  }
  if (digitalRead(boutonSEND) == 0) {
    Serial.println("k");
  }

  delay(33);



}
