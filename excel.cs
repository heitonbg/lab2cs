﻿using System;

namespace lab2cs {
  class Excel : Document {
    string DocumentExcelRowCount, DocumentExcelColumnCount;

    public Excel(string DocumentTitle, string DocumentAuthor, string DocumentKeyWord, string DocumentPath,
      string DocumentTopic) {
      this.DocumentTitle = DocumentTitle;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWord = DocumentKeyWord;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.WriteLine("Введите количество столбцов: ");
      DocumentExcelColumnCount = Console.ReadLine();

      Console.WriteLine("Введите количество строк: ");
      DocumentExcelRowCount = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nКоличество строк: {DocumentExcelRowCount}\n" +
        $"Количество столбцов: {DocumentExcelColumnCount}\n");
    }
  }
}