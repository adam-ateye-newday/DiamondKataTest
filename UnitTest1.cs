namespace DiamondKataTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var input = 'A';
            var expected = new List<string>{"A"};
            // act
            var actual = MakeDiamond(input);
            // assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equal(expected[0], actual[0]);
        }
        public void Test2()
        {
            // arrange
            var input = 'B';
            var expected = new List<string> {" A","B"};  
            // act
            var actual = MakeDiamond(input);
            // assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equal(expected[2], actual[2]);
        }

            public List<string> MakeDiamond(char input)
        {
            var firstLetter = (int)'A';
            var lastLetter = (int)input;
            var dif = lastLetter - firstLetter;

            var resultList = new List<string>();
            resultList.Add(input.ToString());

            return resultList;
        }
    }


}