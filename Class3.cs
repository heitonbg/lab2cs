﻿using System;

namespace lab2cs {
  class Html : Document {
    string DocumentHtmlClassesUsed, DocumentHtmlStringCount;

    public Html(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath,
      string documentTopic) {
      this.DocumentTitle = documentTitle;
      this.DocumentAuthor = documentAuthor;
      this.DocumentKeyWord = documentKeyWord;
      this.DocumentPath = documentPath;
      this.DocumentTopic = documentTopic;

      Console.WriteLine("Введите количество строк: ");
      DocumentHtmlStringCount = Console.ReadLine();

      Console.WriteLine("Введите используемые классы: ");
      DocumentHtmlClassesUsed = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nИспользуемые классы: {DocumentHtmlClassesUsed}\n" +
        $"Количество строк: {DocumentHtmlStringCount}\n");
    }
  }
}