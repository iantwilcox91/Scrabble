using Xunit;
using ScrabbleScore.Objects;
using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class Tests
  {
    [Fact]
    public void Test1_UserEntersA_1()
    {
      string newstring = "a";
      ScrabbleWord newScrabbleWord = new ScrabbleWord(newstring);
      Assert.Equal( 1 , newScrabbleWord.CalculateScore() );
    }

    [Fact]
    public void Test2_UserEntersAA_2()
    {
      string newstring = "aa";
      ScrabbleWord newScrabbleWord = new ScrabbleWord(newstring);
      Assert.Equal( 2 , newScrabbleWord.CalculateScore() );
    }

    [Fact]
    public void Test3_UserEntersAD_3()
    {
      string newstring = "ad";
      ScrabbleWord newScrabbleWord = new ScrabbleWord(newstring);
      Assert.Equal( 3 , newScrabbleWord.CalculateScore() );
    }

    [Fact]
    public void Test4_UserEntersHowdy_15()
    {
      string newstring = "howdy";
      ScrabbleWord newScrabbleWord = new ScrabbleWord(newstring);
      Assert.Equal( 15 , newScrabbleWord.CalculateScore() );
    }

    [Fact]
    public void Test5_UserEntersNum_0()
    {
      string newstring = "1";
      ScrabbleWord newScrabbleWord = new ScrabbleWord(newstring);
      Assert.Equal( 0 , newScrabbleWord.CalculateScore() );
    }
  }
}
