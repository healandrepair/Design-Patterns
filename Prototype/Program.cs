// Initialise Prototype.
using Prototype;

Rectangle rectangle = new Rectangle();
rectangle._x = 6;
rectangle._y = 10;
rectangle.width = 50;
rectangle.height = 20;
rectangle._colour = "Blue";

rectangle.printObject();

// Clone the rectangle
Rectangle rectangle2 = (Rectangle) rectangle.Clone();

rectangle2.printObject();

// Initalise the circle
Circle circle = new Circle(15);

circle.printObject();


// Clone the circle
var circle2 = (Circle)circle.Clone();
circle2.printObject();