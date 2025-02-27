using System;

namespace lab2cs {
  class Document {
    public string DocumentTitle, DocumentAuthor,
      DocumentKeyWord, DocumentPath, DocumentTopic;

    public virtual void DocumentInfo() {
      Console.WriteLine($"Title: {DocumentTitle}\nAuthor: {DocumentAuthor}\nKey word: {DocumentKeyWord}\n" +
        $"Path: {DocumentPath}\nTopic: {DocumentTopic}\n");
    }
  }
}