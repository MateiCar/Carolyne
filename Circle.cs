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

*****************

Rectangle.cs File:

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
