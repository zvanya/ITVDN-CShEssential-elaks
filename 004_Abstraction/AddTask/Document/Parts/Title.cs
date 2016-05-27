using System;

namespace AddTask
{
  class Title : DocumentPart
  {
    public Title()
    {
      noContent = "Заголовок отсутствует.";
    }
  }

  abstract class DocumentPart
  {
    protected string content = null;
    protected string noContent = "Контент отсутствует";

    public virtual string Content
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

    public virtual void Show(ConsoleColor color)
    {
      Console.ForegroundColor = color;
      Console.WriteLine(Content);
      Console.ForegroundColor = ConsoleColor.Gray;
    }
  }
}
