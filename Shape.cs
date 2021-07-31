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
