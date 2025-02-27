﻿using System;

namespace lab2cs {
  class PDF : Document {
    string DocumentPDFDateEdit, DocumentPDFPageCount;

    public PDF(string DocumentTitle, string DocumentAuthor, string DocumentKeyWord, string DocumentPath,
      string DocumentTopic) {
      this.DocumentTitle = DocumentTitle;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWord = DocumentKeyWord;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.WriteLine("Введите количество строк: ");
      DocumentPDFPageCount = Console.ReadLine();

      Console.WriteLine("Введите используемые классы: ");
      DocumentPDFDateEdit = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nДата редактирования: {DocumentPDFDateEdit}\n" +
        $"Количество страниц: {DocumentPDFPageCount}\n");
    }
  }
}