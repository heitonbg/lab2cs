﻿using System;

namespace lab2cs {
  class Txt : Document {
    string DocumentTxtStringCount, DocumentTxtSignCount;

    public Txt(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath,
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
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nКоличество строк: {DocumentTxtStringCount}\n" +
        $"Количество символов: {DocumentTxtSignCount}\n");
    }
  }
}