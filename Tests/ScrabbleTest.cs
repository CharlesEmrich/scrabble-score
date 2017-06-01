using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class ScrabbleTest
  {
    [Fact]
    public void Score_ScoresSingleLetter_True()
    {
      //arrange
      string input = "a";
      ScrabbleWord test = new ScrabbleWord(input);
      int expectedOutput = 1;
      //act
      int output = test.Score();
      //assert
      Assert.Equal(expectedOutput, output);
    }
  }
}
