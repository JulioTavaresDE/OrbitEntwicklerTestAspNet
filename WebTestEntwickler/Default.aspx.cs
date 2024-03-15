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
            string strAusgabe = MarkdownParser(txtEingabe.Text);
            string strHtmlEncode = HttpUtility.HtmlEncode(strAusgabe).ToString();
            lblResParse.Text = "''" + strHtmlEncode + "''";
            
        }

        public string MarkdownParser(string str)
        {
            string strEingabe = str;
            char[] leerZeichenChar = { ' ' };
            string retEingabe = str.TrimEnd(leerZeichenChar).TrimStart();

            int countHasches = retEingabe.ToString().Count(x => x == '#');
            int countLeerzeichen = retEingabe.ToString().Count(x => x == ' ');
            string ret = string.Empty;
            string retAusgabe = string.Empty;

            for (int i = 0; i <= countHasches; i++)
            {
                if (countHasches == 6 && countLeerzeichen == 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 5 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 4 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 3 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 3 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }    
                }

                if (countHasches == 2 && countLeerzeichen == 1 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Kopfzeile</h{i}>";
                    }
                }

                if (countHasches == 2 && countLeerzeichen == 0 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i - 1}>Kopfzeile</h{i - 1}>";
                    }
                }

                if (countHasches == 1 && countLeerzeichen == 0 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches > 6 && countLeerzeichen == 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = "(zu viele Hashes)";
                    }
                }

                if (countHasches > 0 && countLeerzeichen > 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = "zu viele Leerzeichen dazwischen";
                    }
                }

                if (countHasches == 0 && countLeerzeichen == 0 && retEingabe.Contains("Header"))
                {
                    if (i == countHasches)
                    {
                        ret = "(keine Hashes)";
                    }
                }
                    
                if (countHasches >= 0 && countLeerzeichen >= 0 && !retEingabe.Contains("Header".TrimStart().TrimEnd()) && !retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = "Ungültige Zeichenkette.";
                    }                
                }
            }
            return ret;
        }
    }
}
