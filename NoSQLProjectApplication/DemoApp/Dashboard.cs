﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;


namespace DemoApp
{
    public partial class Dashboard : Form
    {
        private List<Ticket> allTickets;

        public Dashboard()
        {
            InitializeComponent();
        }


    }
}
