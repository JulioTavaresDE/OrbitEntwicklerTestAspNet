using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//===============================================================================+
//-- Beschreibung: Entwickler Test
//-- Unternehmen: ORBIT Gesellschaft für Applikations und Informationssysteme GmbH
//-- Projekt: Testprojekt  - Entwickler Test
//-- ============================================================================+
//-- Gesprächspartner : Bruno Casari, Jochen Kock und Christian Lamp. 
//-- Entwickler: Julio Tavares
//-- Datum: 25/03/2024
//-- Grund: Entwickler Test
//-- ============================================================================+

namespace WebTestEntwickler
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextParser textParser = new TextParser();
            string strAusgabe = textParser.MarkdownParser(txtEingabe.Text);
            string strHtmlEncode = HtmlEncodeTextParse(strAusgabe);
            lblResParse.Text = "''" + strHtmlEncode + "''";   
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTextEncodeParse"></param>
        /// <returns></returns>
        private string HtmlEncodeTextParse(string strTextEncodeParse)
        {
            string strHtmlEncode = HttpUtility.HtmlEncode(strTextEncodeParse).ToString();
            return strHtmlEncode;
        }
    }
}
