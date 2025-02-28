﻿using System;

namespace lab2cs {
  class Pdf : Document {
    string DocumentPdfDateEdit, DocumentPdfPageCount;

    public Pdf(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath,
      string documentTopic) {
      this.DocumentTitle = documentTitle;
      this.DocumentAuthor = documentAuthor;
      this.DocumentKeyWord = documentKeyWord;
      this.DocumentPath = documentPath;
      this.DocumentTopic = documentTopic;

      Console.WriteLine("Введите количество строк: ");
      DocumentPdfPageCount = Console.ReadLine();

      Console.WriteLine("Введите используемые классы: ");
      DocumentPdfDateEdit = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nДата редактирования: {DocumentPdfDateEdit}\n" +
        $"Количество страниц: {DocumentPdfPageCount}\n");
    }
  }
}