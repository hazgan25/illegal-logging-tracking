String kirimVB;

//parsing
char bacadata;
String bufferdata = "";
boolean parsing = false;
String dp[10];
int i = 0, x = 0;

void setup() {
  Serial.begin(9600);
}

void loop() {
    cek_data(); 
    if (x == 1) 
    {
      kirimVB = dp[0] + "," + dp[1] + "," + dp[2] + "," + dp[3] + "," + dp[4] + "\n"; 
        Serial.print(kirimVB); 
        x = 0; //set x = 0
    }
    if (x == 2) 
    {
      kirimVB = dp[0] + "," + dp[1] + "," + dp[2] + "," + dp[3] + "," + dp[4] + "\n"; 
        Serial.print(kirimVB); 
        x = 0; //set x = 0
    }
}

void cek_data() 
{ 
  if (Serial.available () > 0) 
  {
  bacadata = Serial.read(); 
  bufferdata += bacadata; 
  if (bacadata == '\n') 
  {   
      parsing = true; 
  }
  }
  if (parsing) 
  {
    ParsingData(); 
    parsing = false; 
    bufferdata = ""; 
  }
}

void ParsingData() 
{
  int j = 0; 
  dp[j] = ""; 
  for (i = 1; i < bufferdata.length(); i++) 
  {  
    if ((bufferdata[i] == '#') || (bufferdata[i] == ',')) 
    { 
      j++; 
      dp[j] = "";      
    }
    else 
    {
      dp[j] = dp[j] + bufferdata[i]; 
    }
    if (dp[0] == "1") 
    {
      x = 1;
    }
    if (dp[0] == "2") 
    {
      x = 2;
    }
  }
}
