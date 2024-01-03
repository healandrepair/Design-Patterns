// See https://aka.ms/new-console-template for more information

// This is the client calling the controller. 

// Controller is a class that has a relationship to the device, and is using a Bridge to connect the abstraction to the implementation (device).

// Other examples could include ->
 
// Client -> Calls the frontene, frontend talks to the backend
using Bridge;
Device xbox = new Xbox();

Controller controller = new Controller(xbox);

controller.ControlLeftThumbstick();
controller.ControlRightThumbstick();


Playstation playstation = new Playstation();

Controller controller1 = new Controller(playstation);

controller1.ControlLeftThumbstick();

controller1.ControlRightThumbstick();


