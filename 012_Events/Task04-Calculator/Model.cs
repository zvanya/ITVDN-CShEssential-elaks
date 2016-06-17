using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_Calculator
{
  class Model
  {
        double x1 = 0, x2 = 0;
        double res = 0;
        string operation = null;
        bool bEQClick = false;

        public string Operation(string operation, string x)
        {
            double t1 = x1, t2 = x2;
            switch (operation)
            {
                case "bEQ":
                    if (bEQClick == false)
                    {
                        bEQClick = true;
                        if (double.TryParse(x, out this.x2))
                        {
                            switch (this.operation)
                            {
                                case "bAdd":
                                    t1 = x1; t2 = x2;
                                    res = t1 + t2;
                                    x1 = res;
                                    return Convert.ToString(res);
                                case "bMin":
                                    t1 = x1; t2 = x2;
                                    res = t1 - t2;
                                    x1 = res;
                                    return Convert.ToString(res);
                                case "bDiv":
                                    t1 = x1; t2 = x2;
                                    if (t2 == 0) { x1 = x2 = 0; return "Err"; }
                                    else
                                    {
                                        res = t1 / t2;
                                        x1 = res;
                                        return Convert.ToString(res);
                                    }
                                case "bMul":
                                    t1 = x1; t2 = x2;
                                    res = t1 * t2;
                                    x1 = res;
                                    return Convert.ToString(res);
                                default:
                                    x1 = x2;
                                    return x;
                            }
                        }
                        else
                        {
                            bEQClick = false;
                            x1 = x2 = 0;
                            return "Второй аргумент не парсится в число";
                        }
                    }
                    else
                    {
                        switch (this.operation)
                        {
                            case "bAdd":
                                t1 = x1; t2 = x2;
                                res = t1 + t2;
                                x1 = res;
                                return Convert.ToString(res);
                            case "bMin":
                                t1 = x1; t2 = x2;
                                res = t1 - t2;
                                x1 = res;
                                return Convert.ToString(res);
                            case "bDiv":
                                t1 = x1; t2 = x2;
                                if (t2 == 0) { x1 = x2 = 0; return "Err"; }
                                else
                                {
                                    res = t1 / t2;
                                    x1 = res;
                                    return Convert.ToString(res);
                                }
                            case "bMul":
                                t1 = x1; t2 = x2;
                                res = t1 * t2;
                                x1 = res;
                                return Convert.ToString(res);
                            default:
                                x1 = x2;
                                return x;
                        }
                    }
                default:
                    bEQClick = false;
                    double.TryParse(x, out this.x1);
                    this.operation = operation;
                    return "0";
            }
        }

        public string Clear()
        {
            x1 = x2 = 0;
            return "0";
        }

        public string DisplayType(string btnN, string displayText)
        {
            //TODO: Добавить проверку количества разрядов
            string n = null;

            switch (btnN)
            {
                case "bN0":
                    n = "0";
                    return displayText == "0" ? n : displayText + n;
                case "bN1":
                    n = "1";
                    return displayText == "0" ? n : displayText + n;
                case "bN2":
                    n = "2";
                    return displayText == "0" ? n : displayText + n;
                case "bN3":
                    n = "3";
                    return displayText == "0" ? n : displayText + n;
                case "bN4":
                    n = "4";
                    return displayText == "0" ? n : displayText + n;
                case "bN5":
                    n = "5";
                    return displayText == "0" ? n : displayText + n;
                case "bN6":
                    n = "6";
                    return displayText == "0" ? n : displayText + n;
                case "bN7":
                    n = "7";
                    return displayText == "0" ? n : displayText + n;
                case "bN8":
                    n = "8";
                    return displayText == "0" ? n : displayText + n;
                case "bN9":
                    n = "9";
                    return displayText == "0" ? n : displayText + n;
                default:
                    return displayText;
            }
        }
    }
}
