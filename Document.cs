using System;

namespace lab2cs {
  class Document {
    public string DocumentTitle;
    public string DocumentAuthor;
    public string DocumentKeyWord;
    public string DocumentPath; 
    public string DocumentTopic;

    public virtual void DocumentInfo() {
      Console.WriteLine($"Title: {DocumentTitle}\n" +
      $"Author: {DocumentAuthor}\n" +
      $"Key word: {DocumentKeyWord}\n" +
      $"Path: {DocumentPath}\n" +
      $"Topic: {DocumentTopic}");
    }
  }
}