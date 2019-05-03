using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Game
  {
    private string _wordInput;
    private string _sentenceInput;

    public Words (string wordInput, string sentenceInput)
    {
      _wordInput = wordInput;
      _sentenceInput = sentenceInput;
    }

    public string GetWord()
    {
      return _wordInput;
    }

    public string GetSentence()
    {
      return _sentenceInput;
    }

    public bool CheckWordIsString()
    {
      if (_wordInput == "")
      {
        return false;
      }
      foreach (char character in _wordInput)
      {
        if (!Char.IsLetter(character))
        {
          return false;
        }
      }
      return true;
    }

    public int CountWordMatchInSentence()
    {
      int count = 0;
      if (CheckWordIsString() == false)
      {
        return 0;
      }
      string userWord = _wordInput.ToLower();
      string userSentence = _sentenceInput.ToLower();

      string [] splitWords = userSentence.Split(' ');
      foreach (string eachWord in splitWords)
      {
        if (userWord == eachWord)
        {
          count ++;
        }
      }
      return count;
    }
  }
}

    // public static void ClearAll()
    // {
    //   _allGames.Clear();
    // }
