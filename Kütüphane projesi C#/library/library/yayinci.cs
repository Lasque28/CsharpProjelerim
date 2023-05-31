﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace library
{
    public partial class yayinci : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb");
        public yayinci()
        {
            InitializeComponent();
        }

        private void yayinci_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from kitaplar", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
              
                ekle.SubItems.Add(oku["yayinevi"].ToString());
              
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }
    }
}
