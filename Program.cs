using System;

namespace lab2cs {
  class Singletone {
    private static Singletone instance;

    public static Singletone Instance { 
      get { 
        instance = new Singletone(); 
        return instance; 
      } 
    }

    enum Types {
      TXT = 1,
      Word,
      Excel,
      HTML,
      PDF,
    }

    string DocumentTitle, DocumentAuthor,
      DocumentKeyWord, DocumentPath, DocumentTopic;

    public void DataInput() {
      Console.WriteLine("Выберите формат файла:\n1. TXT\n2. Word\n3. Excel\n4. HTML\n5. PDF");
      int UserChoice = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите Имя файла: ");
      DocumentTitle = Console.ReadLine();

      Console.WriteLine("Введите автора: ");
      DocumentAuthor = Console.ReadLine();

      Console.WriteLine("Введите ключевые слова (через пробел): ");
      DocumentKeyWord = Console.ReadLine();

      Console.WriteLine("Введите путь к файлу: ");
      DocumentPath = Console.ReadLine();

      Console.WriteLine("Введите основную тему файла: ");
      DocumentTopic = Console.ReadLine();

      switch (UserChoice) {
        case (int)Types.TXT:
          TXT DocumentTXT = new TXT(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentTXT.DocumentInfo();
          break;
        case (int)Types.Word:
          Word DocumentWord = new Word(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentWord.DocumentInfo();
          break;
        case (int)Types.Excel:
          Excel DocumentExcel = new Excel(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentExcel.DocumentInfo();
          break;
        case (int)Types.HTML:
          HTML DocumentHTML = new HTML(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentHTML.DocumentInfo();
          break;
        case (int)Types.PDF:
          PDF DocumentPDF = new PDF(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentPDF.DocumentInfo();
          break;
      }

    }
  }

  class Program {
    static void Main(string[] args) {
      Singletone.Instance.DataInput();

      Console.ReadKey();
    }
  }
}