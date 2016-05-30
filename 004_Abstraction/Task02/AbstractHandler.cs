using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  abstract class AbstractHandler
  {
    public enum DocType { XML, TXT, DOC }

    protected string msgOpen = null;
    protected string msgCreate = null;
    protected string msgChange = null;
    protected string msgSave = null;
    string type = null;

    public AbstractHandler(DocType t)
    {
      switch (t)
      {
        case DocType.XML:
          type = "XML";
          break;
        case DocType.TXT:
          type = "TXT";
          break;
        case DocType.DOC:
          type = "DOC";
          break;
        default:
          type = "Unknown document type";
          break;
      }

      msgOpen = type + " Open";
      msgCreate = type + " Create";
      msgChange = type + " Change";
      msgSave = type + " Save";
    }

    public virtual void Open()
    { Console.WriteLine(msgOpen); }
    public virtual void Create()
    { Console.WriteLine(msgCreate); }
    public virtual void Change()
    { Console.WriteLine(msgChange); }
    public virtual void Save()
    { Console.WriteLine(msgSave); }
  }

  class XMLHandler : AbstractHandler
  {
    public XMLHandler() : base(DocType.XML)
    { }
  }
  class TXTHandler : AbstractHandler
  {
    public TXTHandler() : base(DocType.TXT)
    { }
  }
  class DOCHandler : AbstractHandler
  {
    public DOCHandler() : base(DocType.DOC)
    { }
  }
}
