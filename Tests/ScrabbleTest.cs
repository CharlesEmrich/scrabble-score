using Xunit;
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

    [Fact]
    public void Score_ScoresMultipleLetter_True()
    {
      //arrange
      string input = "eat";
      ScrabbleWord test = new ScrabbleWord(input);
      int expectedOutput = 3;
      //act
      int output = test.Score();
      //assert
      Assert.Equal(expectedOutput, output);
    }
  }
}
