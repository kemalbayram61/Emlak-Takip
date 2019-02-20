using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiteTakip
{
    public partial class KasaBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public KasaBilgileri()
        {
            InitializeComponent();
        }

        private void KasaBilgileri_Load(object sender, EventArgs e)
        {
            Kasaislem kasaislem = new Kasaislem();
            gridControl1.DataSource = kasaislem.KasaIslemTablosu();
        }
    }
}