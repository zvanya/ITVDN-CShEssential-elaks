using System;

namespace AddTask
{
    class Title : DocumentPart
    {
      noContent = "Заголовок отсутствует."; //подчеркивает красным noContent =

      

    }

  abstract class DocumentPart
  {
    protected string content = null;
    protected string noContent = "Контент отсутствует";

    string Content
    {
      set { content = value; }
      get
      {
        if (content != null)
          return content;
        else
          return noContent;
      }
    }

    void Show(ConsoleColor color)
    {
      Console.ForegroundColor = color;
      Console.WriteLine(Content);
      Console.ForegroundColor = ConsoleColor.Gray;
    }
  }
}
