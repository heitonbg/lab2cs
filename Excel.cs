﻿using System;

namespace lab2cs {
  class Excel : Document {
    string DocumentExcelRowCount; 
    string DocumentExcelColumnCount;

    public Excel(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath, string documentTopic) {
      this.DocumentTitle = documentTitle;
      this.DocumentAuthor = documentAuthor;
      this.DocumentKeyWord = documentKeyWord;
      this.DocumentPath = documentPath;
      this.DocumentTopic = documentTopic;

      Console.WriteLine("Введите количество столбцов: ");
      DocumentExcelColumnCount = Console.ReadLine();

      Console.WriteLine("Введите количество строк: ");
      DocumentExcelRowCount = Console.ReadLine();
    }

    public override void DocumentInfo() {
      base.DocumentInfo();
      Console.WriteLine($"Количество строк: {DocumentExcelRowCount}\n" +
      $"Количество столбцов: {DocumentExcelColumnCount}\n");
    }
  }
}