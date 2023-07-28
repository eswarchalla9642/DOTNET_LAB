// Write a program working with forms using ASP.NET

//WebForm.aspx

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Registration.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter first name: "></asp:Label>

    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>  <br />
    
    <asp:Label ID="Label2" runat="server" Text="Enter last name: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>    <br />

    <asp:Label ID="Label3" runat="server" Text="Email ID: "></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>   <br />

    <asp:Label ID="Label4" runat="server" Text="Phone number: "></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  <br />

    <asp:Label ID="Label5" runat="server" Text="Age :"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  <br />
   
    <asp:Button ID="Button1" runat="server" Text="submit" />

</asp:Content>


//WebForm.aspx.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
