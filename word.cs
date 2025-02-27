﻿using System;

namespace lab2cs {
  class Word : Document {
    string DocumentWordPageCount, DocumentWordUsedFonts;

    public Word(string DocumentTitle, string DocumentAuthor, string DocumentKeyWord, string DocumentPath,
      string DocumentTopic) {
      this.DocumentTitle = DocumentTitle;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWord = DocumentKeyWord;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

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