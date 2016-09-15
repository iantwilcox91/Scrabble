using System;
using System.Collections.Generic;


namespace ScrabbleScore.Objects
{
  public class ScrabbleWord
  {
    private string _userWord;
    private int _userScore;

    public ScrabbleWord(string userWord)
    {
      _userWord = userWord;
      _userScore = 0;
    }
    public string GetUserWord()
    {
      return _userWord;
    }
    public void SetUserWord(string userWord)
    {
      _userWord = userWord;
    }
    public int GetUserScore()
    {
      return _userScore;
    }
    public void SetUserScore()
    {
      _userScore = CalculateScore();
    }
    public int CalculateScore()
    {
      string inputWord = this.GetUserWord();
      string inputCapWord = inputWord.ToUpper();
      int score = 0;
      foreach(char letter in inputCapWord)
      {
        if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'L' || letter == 'N' || letter == 'R' || letter == 'S' || letter == 'T' )
        {
          score += 1;
        }
        else if (letter == 'D' || letter == 'G')
        {
          score +=2;
        }
        else if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P')
        {
          score +=3;
        }
        else if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y')
        {
          score +=4;
        }
        else if (letter == 'K')
        {
          score +=5;
        }
        else if (letter == 'J' || letter == 'X')
        {
          score +=8;
        }
        else if (letter == 'Q' || letter == 'Z' )
        {
          score += 10;
        }
        else
        {
          score += 0;
        }
      }

      return score;
    }
  }
}
