<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTestEntwickler._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

          <div class="col-md-6" style="border:solid;justify-content:center;align-items:center;flex-direction:row" >
                <label style="font-style:unset;font-size:xx-large">Text Parser</label>
                <br />
                <p>Text to parse:  
                    <asp:TextBox ID="txtEingabe" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="btnSenden" runat="server" OnClick="Button1_Click" Text="Senden" />
                </p>
                &nbsp;&nbsp;
                <br>
                <br>
                <p style="font-weight: bold">Parsed text: <asp:Label ID="lblResParse" runat="server" Width="376px"></asp:Label></p>
                
         </div>
       
</asp:Content>
