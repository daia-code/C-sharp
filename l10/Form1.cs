using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacte
{
    public partial class FormContacte : Form
    {
        public FormContacte()
        {
            InitializeComponent();
        }

        private void contactInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBContacteDataSet);

        }

        private void FormContacte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBContacteDataSet.ContactInfo' table. You can move, or remove it, as needed.
            this.contactInfoTableAdapter.Fill(this.dBContacteDataSet.ContactInfo);

        }
    }
}
