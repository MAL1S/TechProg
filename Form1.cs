using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nasledovanie
{
    public partial class Form1 : Form
    {
        List<Gadget> gadgetList = new List<Gadget>();

        public Form1()
        {
            InitializeComponent();
            //refillButton.PerformClick();
            ShowInfo();
        }

        private void refillButton_Click(object sender, EventArgs e)
        {
            gadgetList.Clear();
            outputBox.Clear();
            Random rnd = new Random();
            for(var i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:                       
                        gadgetList.Add(Notebook.generate());
                        break;
                    case 1:
                        gadgetList.Add(Smartphone.generate());
                        break;
                    case 2:
                        gadgetList.Add(Tablet.generate());
                        break;
                }
                outputBox.Items.Add(gadgetList[i].ToString());
            }
            label1.Text = "->";
            ShowInfo();
        }

        private void ShowInfo()
        {
            int notebookCount = 0;
            int smartphoneCount = 0;
            int tabletCount = 0;

            foreach (var gadget in gadgetList)
            {
                if (gadget is Notebook)
                {
                    notebookCount++;
                }
                else if (gadget is Smartphone)
                {
                    smartphoneCount++;
                }
                else if (gadget is Tablet)
                {
                    tabletCount++;
                }
            }

            //txtInfo.Text = "Ноутбуки \tСмартфоны \tПланшеты";
            //txtInfo.Text += "\n";
            //txtInfo.Text += String.Format("{0} \t{1} \t{2}", notebookCount, smartphoneCount, tabletCount);
            notebookCountLabel.Text = notebookCount.ToString();
            smartphoneCountLabel.Text = smartphoneCount.ToString();
            tabletCountLabel.Text = tabletCount.ToString();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            if (gadgetList.Count == 0)
            {
                txtOut.Text = "Пусто 0_о";
                return;
            }
            else if (gadgetList.Count == 1) label1.Text = "";

            var gadget = gadgetList[0];
            gadgetList.RemoveAt(0);

            txtOut.Text = gadget.getInfo();
            outputBox.Items.RemoveAt(0);
            ShowInfo();
        }
    }
}