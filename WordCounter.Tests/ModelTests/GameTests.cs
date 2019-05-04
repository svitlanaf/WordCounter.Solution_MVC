using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfWord_Word()
    {
      Game newWord = new Game("hello", "hello there");
      Assert.AreEqual(typeof(Game), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string wordInput = "sun";
      Game newWord = new Game (wordInput, "");
      string result = newWord.GetWord();
      Assert.AreEqual(wordInput, result);
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string sentenceInput = "sun is shining";
      Game newWord = new Game ("", sentenceInput);
      string result = newWord.GetSentence();
      Assert.AreEqual(sentenceInput, result);
    }

    [TestMethod]
    public void CheckWordIsString_UserInputsWord_ReturnTrue()
    {
      Game testWord = new Game("dog", "");
      Assert.AreEqual(true, testWord.CheckWordIsString());
    }

    [TestMethod]
    public void CheckWordIsString_UserInputsNonWord_ReturnFalse()
    {
      Game testWord = new Game("", "");
      Assert.AreEqual(false, testWord.CheckWordIsString());
    }

    [TestMethod]
    public void CheckWordsAreMatching_UserInputsWordAndSentenceOfOneWord_ReturnCount1()
    {
      Game testWords = new Game("sun", "sun");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotMatching_UserInputsWordAndSentenceOfOneWord_ReturnCount0()
    {
      Game testWords = new Game("sun", "cat");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive1_UserInputsWordAndSentenceOfOneWord_ReturnCount1()
    {
      Game testWords = new Game("sun", "sUn");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive2_UserInputsWordAndSentenceOfOneWord_ReturnCount1()
    {
      Game testWords = new Game("fan", "FAN");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordIsNone_UserInputWordIsNone_ReturnCount0()
    {
      Game testWords = new Game("", "dog");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckSentenceIsNone_UserInputSentenceIsNone_ReturnCount0()
    {
      Game testWords = new Game("cat", "");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckSentenceAndWordAreNone_UserInputSentenceIsNoneAndUserInputWordIsNone_ReturnCount0()
    {
      Game testWords = new Game("", "");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreMatching_UserInputsWordAndSentence_ReturnCount1()
    {
      Game testWords = new Game("sun", "sun fun run");
      Assert.AreEqual(1, testWords. CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotMatching_UserInputsWordAndSentence_ReturnCount0()
    {
      Game testWords = new Game("sun", "gun fun run");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsInSentenceAreNotCaseSensitive_UserInputsWordAndSentence_ReturnCount3()
    {
      Game testWords = new Game("fan", "FAN Fan faN man");
      Assert.AreEqual(3, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckFullWordsAreMatching_UserInputsWordAndSentenceThatHaveWordsStartsWithSameLettersAsWord_ReturnCount1()
    {
      Game testWords = new Game("cat", "Cat has a hat at the cathedral");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    }
  }
