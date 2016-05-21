using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class DocumentWorker
  {
    public virtual void Open()
    {
      Console.WriteLine("Документ открыт");
    }
    public virtual void Edit()
    {
      Console.WriteLine("Редактирование документа доступно в версии Про");
    }
    public virtual void Save()
    {
      Console.WriteLine("Сохранение документа доступно в версии Про");
    }
  }

  class ProDocumentWorker : DocumentWorker
  {
    public override void Edit()
    {
      Console.WriteLine("Документ отредактирован");
    }
    public override void Save()
    {
      Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
    }
  }

  class ExpertDocumentWorker : ProDocumentWorker
  {
    public override void Save()
    {
      Console.WriteLine("Документ сохранен в новом формате.");
    }
  }
}
