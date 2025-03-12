﻿using System;

namespace lab2cs {
  class Pdf : Document {
    string DocumentPdfDateEdit; 
    string DocumentPdfPageCount;

    public Pdf(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath, string documentTopic) {
      this.DocumentTitle = documentTitle;
      this.DocumentAuthor = documentAuthor;
      this.DocumentKeyWord = documentKeyWord;
      this.DocumentPath = documentPath;
      this.DocumentTopic = documentTopic;

      Console.WriteLine("Введите количество строк: ");
      DocumentPdfPageCount = Console.ReadLine();

      Console.WriteLine("Введите дату редактирования: ");
      DocumentPdfDateEdit = Console.ReadLine();
    }

    public override void DocumentInfo() {
      base.DocumentInfo();
      Console.WriteLine($"Дата редактирования: {DocumentPdfDateEdit}\n" +
      $"Количество страниц: {DocumentPdfPageCount}\n");
    }
  }
}