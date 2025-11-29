
Light light = new Light();

ICommand turnOn = new TurnOnCommand(light);
ICommand turnOff = new TurnOffCommand(light);

RemoteControl remote = new RemoteControl();

remote.SetCommand(turnOn);
remote.PressButton();   // Light is ON

remote.SetCommand(turnOff);
remote.PressButton();   // Light is OFF