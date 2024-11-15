using System;
using System.Xml;

class Program
{
    public static void Main()
    {
        CreateXMLFile();
        ReadXMLFile();
    }

    static void CreateXMLFile()
    {
        XmlWriterSettings settings = new XmlWriterSettings
        {
            Indent = true,
            IndentChars = "\t"
        };

        using (XmlWriter writer = XmlWriter.Create("GPS.xml", settings))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("GPS_Log");

            writer.WriteStartElement("Position");
            writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
            writer.WriteElementString("x", "65.8973342");
            writer.WriteElementString("y", "72.3452346");

            writer.WriteStartElement("SatteliteInfo");
            writer.WriteElementString("Speed", "40");
            writer.WriteElementString("NoSatt", "7");
            writer.WriteEndElement();//end sat info

            writer.WriteEndElement();//end position

            writer.WriteStartElement("Image");
            writer.WriteAttributeString("Resolution", "1024x800");
            writer.WriteElementString("Path", @"\images\sat.jpg");
            writer.WriteEndElement();//end image

            writer.WriteEndElement();//ed gps log
            writer.WriteEndDocument();
        }

        Console.WriteLine("XML file 'GPS.xml' created successfully.");
    }

    static void ReadXMLFile()
    {

        Console.WriteLine("\nReading XML file GPS.xml");

        using (XmlReader reader = XmlReader.Create("GPS.xml"))
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    Console.WriteLine($"Element: {reader.Name}");

                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            Console.WriteLine($"  Attribute: {reader.Name} = {reader.Value}");
                        }
                    }
                }
                else if (reader.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine($"  Text: {reader.Value}");
                }
            }
        }
    }
}
