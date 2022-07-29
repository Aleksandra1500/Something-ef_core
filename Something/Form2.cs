using Dapper;
using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Something
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var cs = @"Data Source=.\sqlexpress;Initial Catalog=Ola;Integrated Security=True";
            using var con = new SqlConnection(cs);
            con.Open();

            
            var ewid = con.Query<AdrEwid>("select * from adr__Ewid").ToList();
            //ewid.ToList();
            var emails = con.Query<AdrEmail>("select * from adr_Email join adr__Ewid on adr_Email.am_IdAdres = adr__Ewid.adr_Id").ToList();
            //emails.ToList();
            //var towary = con.Query<Towar>("select * from tw__Towar join sl_Rabat on tw__Towar.tw_IdRabat = sl_Rabat.rt_id;");
            //towary.ToList();

            //rabats.ForEach(rabat => Console.WriteLine(rabat));
            //gridControl1.DataSource = ewid;
        }
    }
}
