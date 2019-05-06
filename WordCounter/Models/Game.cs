using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Game
  {
    private string _wordInput;
    private string _sentenceInput;

    public Game (string wordInput, string sentenceInput)
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
      if (_wordInput == "" || _wordInput == null)
      {
        return false;
      }
      foreach (char character in _wordInput)
      {
        if (!char.IsLetter(character))
        {
          return false;
        }
      }
      return true;
    }

    public int GetCount()
    {
      int count = 0;
      if (CheckWordIsString() == false || _sentenceInput == null)
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

    
