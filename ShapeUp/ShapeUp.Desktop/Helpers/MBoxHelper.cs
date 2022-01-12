using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeUp.Desktop.Helpers
{
    public class MBoxHelper
    {

        public void Error(string message)
        {
            MessageBox.Show(message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Inform(string message)
        {
            MessageBox.Show(message, "Obavjestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Delete(string message)
        {
            DialogResult result = MessageBox.Show(message, "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            
            return false;
        }
    }
}
