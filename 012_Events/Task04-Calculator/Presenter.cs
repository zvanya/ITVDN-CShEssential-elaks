using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Task04_Calculator
{
  class Presenter
  {
        Model model = null;
        MainWindow mw = null;

        public Presenter(MainWindow mw)
        {
            this.mw = mw;
            model = new Model();
            this.mw.btnNClick += new EventHandler(mw_btnNClick);
            this.mw.btnOperationClick += new EventHandler(mw_btnOperationClick);
            this.mw.btnClearClick += new EventHandler(mw_btnClearClick);
        }

        void mw_btnNClick(object sender, System.EventArgs e)
        {
            mw.textBox.Text = model.DisplayN(((Button)sender).Name, mw.textBox.Text);
        }
        void mw_btnOperationClick(object sender, System.EventArgs e)
        {
            mw.textBox.Text = model.Operation(((Button)sender).Name, mw.textBox.Text);
        }
        void mw_btnClearClick(object sender, System.EventArgs e)
        {
            mw.textBox.Text = model.Clear();
        }
    }
}
