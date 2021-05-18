﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class ÅbentHusUI : Form
    {
        ÅbentHusDAL åbentHusDAL;

        public ÅbentHusUI()
        {
            InitializeComponent();

            åbentHusDAL = new ÅbentHusDAL(åbentHus_boligListe_lbox);
            Thread t1 = new Thread(new ThreadStart(åbentHusDAL.GenerateBolig));
            t1.IsBackground = true;
            t1.Start();
        }
    }
}
