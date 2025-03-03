﻿using System;

namespace lab2cs {
  class Txt : Document {
    string DocumentTxtStringCount; 
    string DocumentTxtSignCount;

    public Txt(string documentTitle, 
      string documentAuthor,
      string documentKeyWord,
      string documentPath,
      string documentTopic) {
      this.DocumentTitle = documentTitle;
      this.DocumentAuthor = documentAuthor;
      this.DocumentKeyWord = documentKeyWord;
      this.DocumentPath = documentPath;
      this.DocumentTopic = documentTopic;

      Console.WriteLine("Введите количество символов: ");
      DocumentTxtSignCount = Console.ReadLine();

      Console.WriteLine("Введите количество строк: ");
      DocumentTxtStringCount = Console.ReadLine();
    }

    public override void DocumentInfo() {
      base.DocumentInfo();
      Console.WriteLine($"\nКоличество строк: {DocumentTxtStringCount}\n" +
      $"Количество символов: {DocumentTxtSignCount}\n");
    }
  }
}