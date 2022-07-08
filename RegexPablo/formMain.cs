using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexPablo
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void txRegex_TextChanged(object sender, EventArgs e)
        {

            var matches = ChangedRegexPattern(txRegex.Text);

            txRegex.ForeColor = (matches == null) ? Color.Red : SystemColors.WindowText;           


        }

        /// <summary>
        /// Gestiona el cambio del patron de expresión
        /// regular pasado como argumento.
        /// </summary>
        /// <param name="regexPattern">Patrón de expresión regular.</param>
        private MatchCollection ChangedRegexPattern(string regexPattern) 
        {

            Regex regex = null;

            try 
            { 

                regex = new Regex(regexPattern);

            } 
            catch (Exception ex) 
            {

                var errMessage = ex.Message;
                
            }

            if (regex != null) 
                return regex.Matches(rtTextInput.Text);

            return null;

        }

    }
}
