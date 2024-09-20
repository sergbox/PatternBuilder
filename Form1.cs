﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatternBuilder.DBCon;
using PatternBuilder.BuilderBurger;

namespace PatternBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

            if (ComboBoxBurger.SelectedItem.ToString() == "Бургер стандартный")
                burgerDirector.BuildDefault();
            else
                burgerDirector.BuildWithBeacon();
            try
            {
                model.Burgers.Add(burgerBuilder.GetBurgers());
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }
        private void LoadData()
        {
            ComboBoxBurger.SelectedIndex = 0;
            dataGridView1.DataSource = model.Burgers.ToList();
        }
    }
}
