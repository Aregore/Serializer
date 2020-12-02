using NUnit.Framework;

namespace Serializer
{
    [TestFixture]
    public class Test
    {
        private Output output = new Output()
        {
            SumResult = 1.0M,
            MulResult = 4,
            SortedInputs = new decimal[] { 1.4M, 2.01M, 3.0M }
        };
        private string jsonTestString = "{\"SumResult\":1.0,\"MulResult\":4,\"SortedInputs\":[1.4,2.01,3.0]}";
        private string xmlTestString = "<Output><SumResult>1.0</SumResult><MulResult>4</MulResult><SortedInputs><decimal>1.4</decimal><decimal>2.01</decimal><decimal>3.0</decimal></SortedInputs></Output>";

        [Test]
        public void JsonSerialization()
        {
            var serializer = new JSONSerializer();
            var result = serializer.Serialize(output);

            Assert.AreEqual(result, jsonTestString);
        }

        [Test]
        public void JsonDeserialization()
        {
            var serializer = new JSONSerializer();
            var result = serializer.Deserialize<Output>(jsonTestString);

            Assert.AreEqual(result.SumResult, output.SumResult);
            Assert.AreEqual(result.MulResult, output.MulResult);
            Assert.AreEqual(result.SortedInputs, output.SortedInputs);
        }

        [Test]
        public void XmlSerialization()
        {
            var serializer = new XMLSerializer();
            var result = serializer.Serialize(output);

            Assert.AreEqual(result, xmlTestString);
        }

        [Test]
        public void XmlDeserialization()
        {
            var serializer = new XMLSerializer();
            var result = serializer.Deserialize<Output>(xmlTestString);

            Assert.AreEqual(result.SumResult, output.SumResult);
            Assert.AreEqual(result.MulResult, output.MulResult);
            Assert.AreEqual(result.SortedInputs, output.SortedInputs);
        }
    }
}
