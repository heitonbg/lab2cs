﻿using System;

namespace lab2cs {
  class Word : Document {
    string DocumentWordPageCount;
    string DocumentWordUsedFonts;

    public Word(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath, string documentTopic) {
      this.DocumentTitle = documentTitle;
      this.DocumentAuthor = documentAuthor;
      this.DocumentKeyWord = documentKeyWord;
      this.DocumentPath = documentPath;
      this.DocumentTopic = documentTopic;

      Console.WriteLine("Введите количество страниц: ");
      DocumentWordPageCount = Console.ReadLine();

      Console.WriteLine("Введите используемые шрифты: ");
      DocumentWordUsedFonts = Console.ReadLine();
    }
    
    public override void DocumentInfo() {
      base.DocumentInfo();
      Console.WriteLine($"Количество страниц: {DocumentWordPageCount}\n" +
      $"Используемые шрифты: {DocumentWordUsedFonts}");
    }
  }
}