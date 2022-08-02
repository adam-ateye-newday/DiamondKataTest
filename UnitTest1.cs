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

        [Fact]
        public void TwoLine()
        {
            // arrange
            var input = 'B';
            var expected = new List<string>() { " A", "B B" };
            // act
            var actual = MakeDiamond(input);
            // assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
        }

        [Fact]
        public void ThreeLine()
        {
            // arrange
            var input = 'C';
            var expected = new List<string>() { "  A", " B B", "C   C" };
            // act
            var actual = MakeDiamond(input);
            // assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
            Assert.Equal(expected[2], actual[2]);
        }

        public List<string> MakeDiamond(char input)
        {
            var dif = (int)input - (int)'A';

            var resultList = new List<string>();

            for (var i = 0; i <= dif; i++)
            {
                var currentLetter = (char)((int)'A' + i);

                var between = currentLetter == 'A' ? 0 : i * 2 - 1;
                
                var line = GenerateSpaces(dif - i) + currentLetter + GenerateSpaces(between);
                if(between > 0) 
                {
                    line += currentLetter;
                }

                resultList.Add(line);
            }

            return resultList;
        }

        public string GenerateSpaces(int spaces)
        {
            return new string(' ', spaces);
      
        }
    }
}