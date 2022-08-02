namespace DiamondKataTest
{
    public class UnitTest1
    {
        [Fact]
        public void OneLine()
        {
            // arrange
            var input = 'A';
            var expected = new List<string>() { "A"};
            // act
            var actual = MakeDiamond(input);
            // assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equal(expected[0], actual[0]);
        }

        public List<string> MakeDiamond(char input)
        {
            var dif = (int)input - (int)'A';
            var before = dif;
            //int between = 0;

            var resultList = new List<string>();

            for (var i = 0; i <= dif; i++)
            {
                var line = GenerateSpaces(dif - i) + (char)((int)'A' + i);
                resultList.Add(line);
            }

            return resultList;
        }

        public string GenerateSpaces(int spaces)
        {
            var result = "";

            while (result.Length < spaces)
            {
                result = result + " ";
            } 

            return result;
        }
    }
}