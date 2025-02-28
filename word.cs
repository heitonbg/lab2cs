﻿using System;

namespace lab2cs {
  class Word : Document {
    string DocumentWordPageCount, DocumentWordUsedFonts;

    public Word(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath,
      string documentTopic) {
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
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nКоличество страниц: {DocumentWordPageCount}\n" +
        $"Используемые шрифты: {DocumentWordUsedFonts}");
    }
  }
}