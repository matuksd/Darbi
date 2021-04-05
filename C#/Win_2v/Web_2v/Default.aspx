<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <p>Name = </p>
<p> a= <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"  /></p>
<asp:RadioButton ID="radioButton1" runat="server" Text="Surname" GroupName="sport" />
<asp:RadioButton ID="radioButton2" runat="server" Text="Run 100m" GroupName="sport" />
<asp:RadioButton ID="radioButton3" runat="server" Text="Lenght" GroupName="sport" />
<asp:RadioButton ID="radioButton4" runat="server" Text="Height" GroupName="sport" />
<asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click"  />
      <br />  <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</form>
</body>
</html>
