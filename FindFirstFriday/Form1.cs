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

            foreach (var item in findRegular.allFridaysList)
            {
                RegularFindListBox.Items.Add(item);
            }
        }
    }
}
