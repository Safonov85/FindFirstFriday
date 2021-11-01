using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindFirstFriday
{
    public partial class Form1 : Form
    {
        FindFristFridayRegular findRegular = new FindFristFridayRegular();

        public Form1()
        {
            InitializeComponent();

            findRegular.CreateFirstFriDays();
            findRegular.CreateFirstFridayLINQ();
            findRegular.CreateFirstFridayLINQTest();
            findRegular.CreateFirstFridayLINQTest2();
            findRegular.CreateFirstFridayLINQTest3();
            findRegular.CreateFirstFridayLINQTest4();
            findRegular.CreateFirstFridayLINQTest5();

            foreach (var item in findRegular.allFridaysList)
            {
                RegularFindListBox.Items.Add(item);
            }

            foreach (var item in findRegular.numberNamesList)
            {
                //LINQlistBox.Items.Add(item);
                LINQlistBox.Items.Add(item);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
