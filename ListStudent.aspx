<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListStudent.aspx.cs" Inherits="Student.ListStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td>Student Details</td></tr>
        <tr><td>
        <asp:GridView ID="gvDetails" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"   AutoGenerateColumns="false" OnRowEditing="gvDetails_RowEditing" onRowUpdating="gvDetails_RowUpdating" OnRowDeleting="gvDetails_RowDeleting" OnRowCancelingEdit="gvDetails_RowCancelingEdit">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            <Columns>
                            <asp:TemplateField>  
                    <ItemTemplate>  
                      
                        <asp:Button ID="btnedit" runat="server" Text="Edit" CommandName="edit"   /> 
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="delete"  /> 
                        
                    </ItemTemplate>  
                    <EditItemTemplate>  
                     
                       
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                        <asp:Button ID="btn_delete" runat="server" Text="Delete" CommandName="Delete"  /> 
                        
                    </EditItemTemplate>  
                </asp:TemplateField>
                
                
                <asp:TemplateField HeaderText="StudentName">  
                    <ItemTemplate>  
                        <asp:TextBox ID="txtStudentName" runat="server" Text='<%#Eval("Student_name") %>'></asp:TextBox>  
                    </ItemTemplate>  
                        </asp:TemplateField> 

                 <asp:TemplateField HeaderText="Address">  
                    <ItemTemplate>  
                        <asp:TextBox ID="txtAddress" runat="server" Text='<%#Eval("Address") %>'></asp:TextBox>  
                    </ItemTemplate>  
                        </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Gender">  
                    <ItemTemplate>  
                        <asp:TextBox ID="txtGender" runat="server" Text='<%#Eval("Gender") %>'></asp:TextBox>  
                    </ItemTemplate>  
                        </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Email">  
                    <ItemTemplate>  
                        <asp:TextBox ID="txt_email" runat="server" Text='<%#Eval("Emails") %>'></asp:TextBox>  
                    </ItemTemplate>  
                        </asp:TemplateField>
                </Columns>
        </asp:GridView> </td></tr>
    <tr>
        <td>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" /></td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
