using System;

namespace lab2cs {
  class Singletone {
    private static Singletone s_instance;

    public static Singletone Instance { 
      get { 
        s_instance = new Singletone(); 
        return s_instance; 
      } 
    }

    enum Types {
      Txt = 1,
      Word,
      Excel,
      Html,
      Pdf,
    }

    string DocumentTitle, DocumentAuthor,
      DocumentKeyWord, DocumentPath, DocumentTopic;

    public void DataInput() {
      Console.WriteLine("Выберите формат файла:\n1. TXT\n2. Word\n3. Excel\n4. HTML\n5. PDF");
      int userChoice = int.Parse(Console.ReadLine());

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

      switch (userChoice) {
        case (int)Types.Txt:
          Txt DocumentTxt = new Txt(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentTxt.DocumentInfo();
          break;
        case (int)Types.Word:
          Word DocumentWord = new Word(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentWord.DocumentInfo();
          break;
        case (int)Types.Excel:
          Excel DocumentExcel = new Excel(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentExcel.DocumentInfo();
          break;
        case (int)Types.Html:
          Html DocumentHtml = new Html(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentHtml.DocumentInfo();
          break;
        case (int)Types.Pdf:
          Pdf DocumentPdf = new Pdf(DocumentTitle, DocumentAuthor, DocumentKeyWord, DocumentPath, DocumentTopic);
          DocumentPdf.DocumentInfo();
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