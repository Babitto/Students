<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Student.Registration" %>

<!DOCTYPE h
    tml>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td>Student Registration form</td></tr>
        <tr>
        <td>Student Name</td>
        <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">Address</td>
        <td class="auto-style1"><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
        </tr>
   <tr>
            <td>Gender</td>
        <td>
       <asp:RadioButton ID="rbtMale" runat="server" GroupName="Gender" Text="Male"/>
            
       <asp:RadioButton ID="rbtFemale"  runat="server" GroupName="Gender" Text="Female" />
            </td>
     
           </tr>
           <tr>
            <td>Email</td>
        <td><asp:TextBox ID="txtMail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Phone Numer</td>
        <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
        </tr>
      <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" style="height: 26px" /></td>
             <td>
                  <asp:Button ID="btnRedirect" runat="server" Text="List Details" style="height: 26px" OnClick="btnRedirect_Click" />
                  <asp:Button ID="btnreset" runat="server" Text="Reset" style="height: 26px" OnClick="btnreset_Click"/>
             </td>
      </tr>


    </table>
    </div>
    </form>
</body>
</html>
