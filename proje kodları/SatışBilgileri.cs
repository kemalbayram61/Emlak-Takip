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
    public partial class SatışBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public SatışBilgileri()
        {
            InitializeComponent();
        }

        private void SatışBilgileri_Load(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            gridControl1.DataSource = satis.SatisIslemlerTablosu();
        }
    }
}