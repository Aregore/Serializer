using System.Xml.Serialization;

namespace Serializer
{   
    [XmlRoot(ElementName = "Input")]
    public class Input
    {
        [XmlElement(ElementName = "K")]
        public int K { get; set; }
        [XmlElement(ElementName = "Sums")]
        public decimal[] Sums { get; set; }
        [XmlElement(ElementName = "Muls")]
        public int[] Muls { get; set; }
    }
}
