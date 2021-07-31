# Carolyne
/* Exercise04.cs file*
using System;

using System.Collections.Generic;

using System.Xml.Serialization;

using System.IO;

namespace SerializeDemo

{

class Program

{

static void Main(string[] args)

{

string filePath = "Shapes.xml";

// create a list of Shapes to serialize

var listOfShapes = new List<Shape>

{

new Circle { Colour = "Red", Radius = 2.5 },

new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },

new Circle { Colour = "Green", Radius = 8 },

new Circle { Colour = "Purple", Radius = 12.3 },

new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }

};

// Serialize the object

XmlSerializer serializerXml = new XmlSerializer(typeof(List<Shape>));

System.IO.FileStream fileXmlSerialize = System.IO.File.Create(filePath);

serializerXml.Serialize(fileXmlSerialize, listOfShapes);

fileXmlSerialize.Close();

//Deserialize the object

using (StreamReader fileXml = new StreamReader(filePath))

{

List<Shape> loadedShapesXml = serializerXml.Deserialize(fileXml) as List<Shape>;

foreach (Shape item in loadedShapesXml)

{

Console.WriteLine($"{item.GetType().Name} is {item.Colour} and has an area of { item.Area}");

}

}

Console.ReadLine();

}

}

}
/* 
Shape.cs file
*/

using System;

using System.Xml.Serialization;

namespace SerializeDemo

{

[XmlInclude(typeof(Circle))]

[XmlInclude(typeof(Rectangle))]

[Serializable]

public abstract class Shape

{

public string Colour { get; set; }

public abstract double Area { get; }

}

}
/* 
Circle.cs file*/

using System;

namespace SerializeDemo

{

[Serializable]

public class Circle:Shape

{

public double Radius { get; set; }

// circle Area = pi * radius^2

public override double Area { get { return 3.14 * Radius * Radius; } }

}

}
/*Rectangle.cs file*/

using System;

namespace SerializeDemo

{

[Serializable]

public class Rectangle:Shape

{

public double Height { get; set; }

public double Width { get; set; }

// Rectangle Area = Height * Width

public override double Area { get { return Height * Width; } }

}

}
/* Sample Run


Circle is Red and has an area of 19.625 Rectangle is Blue and has an area of 200 Circle is Green and has an area of 200.96 Ci
