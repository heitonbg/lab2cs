﻿using System;

namespace lab2cs {
  class Excel : Document {
    string documentExcelRowCount, documentExcelColumnCount;

    public Excel(string documentTitle, string documentAuthor, string documentKeyWord, string documentPath,
      string documentTopic) {
      this.DocumentTitle = documentTitle;
      this.DocumentAuthor = documentAuthor;
      this.DocumentKeyWord = documentKeyWord;
      this.DocumentPath = documentPath;
      this.DocumentTopic = documentTopic;

      Console.WriteLine("Введите количество столбцов: ");
      documentExcelColumnCount = Console.ReadLine();

      Console.WriteLine("Введите количество строк: ");
      documentExcelRowCount = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nКоличество строк: {documentExcelRowCount}\n" +
        $"Количество столбцов: {documentExcelColumnCount}\n");
    }
  }
}