﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void LoadInfo(FoodModel food)
        {
            picFood.ImageLocation = food.PicLocal;
            lblName.Text = food.Name;
            lblPrice.Text = food.Price.ToString();
        }
    }
}
