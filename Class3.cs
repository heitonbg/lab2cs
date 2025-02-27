﻿using System;

namespace lab2cs {
  class HTML : Document {
    string DocumentHTMLClassesUsed, DocumentHTMLStringCount;

    public HTML(string DocumentTitle, string DocumentAuthor, string DocumentKeyWord, string DocumentPath,
      string DocumentTopic) {
      this.DocumentTitle = DocumentTitle;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWord = DocumentKeyWord;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.WriteLine("Введите количество строк: ");
      DocumentHTMLStringCount = Console.ReadLine();

      Console.WriteLine("Введите используемые классы: ");
      DocumentHTMLClassesUsed = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nИспользуемые классы: {DocumentHTMLClassesUsed}\n" +
        $"Количество строк: {DocumentHTMLStringCount}\n");
    }
  }
}