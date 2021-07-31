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
