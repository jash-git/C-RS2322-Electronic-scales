int incomingByte = 0;	// 用來儲存收進來的 data byte
const int ledPin = 13;

void setup() {
  // 開啟 Serial port, 通訊速率為 9600 bps
  Serial.begin(9600);
  
  pinMode(ledPin, OUTPUT);
}

void loop() {
  // 檢查是否有資料可供讀取
  if (Serial.available() > 0) {
    // 讀取一個 byte
    incomingByte = Serial.read();

    // 決定打開或關掉 LED
    if (incomingByte == '1')
      digitalWrite(ledPin, HIGH);    // 打開 LED     
    else
      digitalWrite(ledPin, LOW);     // 關掉 LED
  }
}

