namespace DiamondKataTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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
            var resultList = new List<string>();
            resultList.Add(input.ToString());
            
            return resultList;
        }
    }
}