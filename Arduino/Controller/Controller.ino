int up_button = 2;
int down_button = 4;
int left_button = 5;
int right_button = 3;
int start_button = 6;
int select_button = 7;
int joystick_button = 8;
int joystick_axis_x = A0;
int joystick_axis_y = A1;
int buttons[] = {up_button, down_button, left_button, right_button, start_button, select_button, joystick_button};

//debounce button up
int debounceBtnUp1;
int debounceBtnUp2;
int buttonStateUp;

//debounce button left
int debounceBtnLeft1;
int debounceBtnLeft2;
int buttonStateLeft;

//debounce button down
int debounceBtnDown1;
int debounceBtnDown2;
int buttonStateDown;

//debounce button left
int debounceBtnRight1;
int debounceBtnRight2;
int buttonStateRight;

void BtnUpClick()
{
  //kijkt of je op de knop drukt + debounce
  debounceBtnUp1 = digitalRead(up_button);
  delay(10);
  debounceBtnUp2 = digitalRead(up_button);
  if (debounceBtnUp1 == debounceBtnUp2)
  {
    if (debounceBtnUp1 != buttonStateUp)
    {
      if (debounceBtnUp1 == LOW)
      {
        Serial.println("up");
      }
    }
  }
  buttonStateUp = debounceBtnUp1;
}

void BtnLeftClick()
{
  //kijkt of je op de knop drukt + debounce
  debounceBtnLeft1 = digitalRead(left_button);
  delay(10);
  debounceBtnLeft2 = digitalRead(left_button);
  if (debounceBtnLeft1 == debounceBtnLeft2)
  {
    if (debounceBtnLeft1 != buttonStateLeft)
    {
      if (debounceBtnLeft1 == LOW)
      {
        Serial.println("left");
      }
    }
  }
  buttonStateLeft = debounceBtnLeft1;
}

void BtnDownClick()
{
  //kijkt of je op de knop drukt + debounce
  debounceBtnDown1 = digitalRead(down_button);
  delay(10);
  debounceBtnDown2 = digitalRead(down_button);
  if (debounceBtnDown1 == debounceBtnDown2)
  {
    if (debounceBtnDown1 != buttonStateDown)
    {
      if (debounceBtnDown1 == LOW)
      {
        Serial.println("Down");
      }
    }
  }
  buttonStateDown = debounceBtnDown1;
}

void BtnRightClick()
{
  //kijkt of je op de knop drukt + debounce
  debounceBtnRight1 = digitalRead(right_button);
  delay(10);
  debounceBtnRight2 = digitalRead(right_button);
  if (debounceBtnRight1 == debounceBtnRight2)
  {
    if (debounceBtnRight1 != buttonStateRight)
    {
      if (debounceBtnRight1 == LOW)
      {
        Serial.println("right");
      }
    }
  }
  buttonStateRight = debounceBtnRight1;
}

void JoyStick()
{   
  if (map(analogRead(joystick_axis_x), 0, 1000, -1, 1) == 1)
  {
    Serial.println("camera turns right");
  }
  
  if (map(analogRead(joystick_axis_x), 0, 1000, -1, 1) == -1)
  {
    Serial.println("camera turns left");
  }
  
  if (map(analogRead(joystick_axis_y), 0, 1000, -1, 1) == 1)
  {
    Serial.println("moving forward");
  }

    if (map(analogRead(joystick_axis_y), 0, 1000, -1, 1) == -1)
  {
    Serial.println("moving backwards");
  }
}

void setup() {
  for (int i; i < 7; i++)
  {
   pinMode(buttons[i], INPUT);
   digitalWrite(buttons[i], HIGH);
  }
  Serial.begin(9600);
}

void loop() {
  /*Serial.print("UP = "),Serial.print(digitalRead(up_button)),Serial.print("\t");
  Serial.print("DOWN = "),Serial.print(digitalRead(down_button)),Serial.print("\t");
  Serial.print("LEFT = "),Serial.print(digitalRead(left_button)),Serial.print("\t");
  Serial.print("RIGHT = "),Serial.print(digitalRead(right_button)),Serial.print("\t");
  Serial.print("START = "),Serial.print(digitalRead(start_button)),Serial.print("\t");
  Serial.print("SELECT = "),Serial.print(digitalRead(select_button)),Serial.print("\t");
  Serial.print("ANALOG = "),Serial.print(digitalRead(joystick_button)),Serial.print("\t");
  Serial.print("X = "),Serial.print(map(analogRead(joystick_axis_x), 0, 1000, -1, 1));Serial.print("\t");
  Serial.print("Y = "),Serial.print(map(analogRead(joystick_axis_y), 0, 1000, -1, 1));Serial.print("\n");  
  Serial.print("X = "),Serial.print(analogRead(joystick_axis_x));Serial.print("\t");
  Serial.print("Y = "),Serial.print(analogRead(joystick_axis_y));Serial.print("\n");  
  delay(1000);*/

  BtnUpClick();
  BtnLeftClick();
  BtnDownClick();
  BtnRightClick();
  JoyStick();
}

 
