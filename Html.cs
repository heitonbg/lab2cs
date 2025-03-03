﻿using System;

namespace lab2cs {
  class Html : Document {
    string DocumentHtmlClassesUsed; 
    string DocumentHtmlStringCount;

    public Html(string documentTitle, 
      string documentAuthor, 
      string documentKeyWord, 
      string documentPath,
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
      base.DocumentInfo();
      Console.WriteLine($"\nИспользуемые классы: {DocumentHtmlClassesUsed}\n" +
      $"Количество строк: {DocumentHtmlStringCount}\n");
    }
  }
}