using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTestEntwickler;
using Xunit;

namespace WebTestEntiwicklerXUniTest
{
    //===============================================================================+
    //-- Beschreibung: Entwickler Test
    //-- Unternehmen: ORBIT Gesellschaft für Applikations und Informationssysteme GmbH
    //-- Projekt: Testprojekt  - Entwickler Test
    //-- ============================================================================+
    //-- Gesprächspartner : Bruno Casari, Jochen Kock und Christian Lamp. 
    //-- Entwickler: Julio Tavares
    //-- Datum: 25/03/2024
    //-- Grund: Unit Test
    //-- ============================================================================+
    public class TextParserUnitTest
    {
        TextParser textParser = new TextParser();

        [Fact]
        public void Test_1()
        {
            //Arrange
            var strEingabe = "##Kopfzeile";
            var erwarteter_Wert = "<h1>Kopfzeile</h1>";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }


        [Fact]
        public void Test_2()
        {
            //Arrange
            var strEingabe = "## Kopfzeile";
            var erwarteter_Wert = "<h2>Kopfzeile</h2>";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }


        [Fact]
        public void Test_3()
        {
            //Arrange
            var strEingabe = "###### Header";
            var erwarteter_Wert = "<h6>Header</h6>";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }


        [Fact]
        public void Test_4()
        {      
            //Arrange
            var strEingabe = "####### Header";
            var erwarteter_Wert = "(zu viele Hashes)";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }


        [Fact]
        public void Test_5()
        {
            //Arrange
            var strEingabe = "###  Header";
            var erwarteter_Wert = "zu viele Leerzeichen dazwischen";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }


        [Fact]
        public void Test_6()
        {
            //Arrange
            var strEingabe = "Header";
            var erwarteter_Wert = "(keine Hashes)";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }


        [Fact]
        public void Test_7()
        {   
            //Arrange
            var strEingabe = "`*'_1234567890ß;:_>";
            var erwarteter_Wert = "Ungültige Zeichenkette.";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }

        [Fact]
        public void Test_8()
        {
            //Arrange
            var strEingabe = "";
            var erwarteter_Wert = "Ungültige Zeichenkette.";

            //Act
            var ausgabe = textParser.MarkdownParser(strEingabe);

            //Assert
            Assert.Equal(erwarteter_Wert, ausgabe);
        }
    }
}

