using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;



namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle1 = new Circle("Red" , 2.5);
            Circle circle2 = new Circle("Green", 8.0);
            Circle circle3 = new Circle("Purple", 12.3);

            Rectangle rect1 = new Rectangle("Blue", 20.0, 10.0);
            Rectangle rect2 = new Rectangle("Blue", 45.0, 18.0);

            Console.WriteLine(rect1.Area);
            Console.ReadLine();

            List<Circle> circles = new List<Circle>();
            circles.Add(circle1);
            circles.Add(circle2);
            circles.Add(circle3);

            List<Rectangle> rects = new List<Rectangle>();
            rects.Add(rect1);
            rects.Add(rect2);

            SerializeClass.SerializeObject(circles, "shapes.xml");

        }

        public static class SerializeClass
        {
            public static void SerializeObject( List<Circle> list, string fileName)
            {
                var serializer = new XmlSerializer(typeof(List<Circle>));
                using (var stream = File.OpenWrite(fileName))
                {
                    StreamWriter writer = new StreamWriter(fileName);
                    serializer.Serialize(writer, list);
                }
            }

            public static void Deserialize( List<Circle> list, string fileName)
            {
                var serializer = new XmlSerializer(typeof(List<Circle>));
                using (var stream = File.OpenRead(fileName))
                {
                    var other = (List<Circle>)(serializer.Deserialize(stream));
                    list.Clear();
                    list.AddRange(other);
                }
            }
        }


    }
}
