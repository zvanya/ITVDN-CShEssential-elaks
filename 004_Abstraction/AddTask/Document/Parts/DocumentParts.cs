using System;

namespace AddTask
{
  class Title : DocumentPart
  {
    public Title()
    {
      noContent = "Заголовок отсутствует.";
      color = ConsoleColor.Cyan;
    }
  }
  class Body : DocumentPart
  {
    public Body()
    {
      noContent = "Тело документа отсутствует.";
      color = ConsoleColor.Green;
    }
  }
  class Footer : DocumentPart
  {
    public Footer()
    {
      noContent = "Нижний колонтитул отсутствует.";
      color = ConsoleColor.Yellow;
    }
  }

  abstract class DocumentPart
  {
    protected string content = null;
    protected string noContent = "Контент отсутствует";
    protected ConsoleColor color;

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

    public virtual void Show()
    {
      Console.ForegroundColor = color;
      Console.WriteLine(Content);
      Console.ForegroundColor = ConsoleColor.Gray;
    }
  }
}
