<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Presentation.aspx.cs" Inherits="PresentationLayer.Presentation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 606px;
        }

        .auto-style2 {
            width: 100%;
            height: 230px;
        }

        .auto-style3 {
            text-align: center;
            color: #009933;
            height: 65px;
        }

        .auto-style10 {
            width: 98px;
        }

        .auto-style5 {
            width: 150px;
        }

        .auto-style8 {
            width: 102px;
        }

        .auto-style9 {
            width: 306px;
        }

        .auto-style11 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server" class="auto-style1">
        <div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3" colspan="3">CRUD OPERATION ON ADDRESSBOOK CONNECTED ARCHITECTURE&nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Text="AddressId"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtAddressId" runat="server" Height="29px" Width="244px"></asp:TextBox>
                    </td>
                    <td rowspan="5">
                        <br />
                        <asp:GridView ID="GridViewAddressBook" runat="server" CssClass="auto-style6" Height="157px" Width="202px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Text="FirstName"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtFirstname" runat="server" Height="29px" Width="244px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Text="LastName"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TxtLastName" runat="server" Height="29px" Width="244px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" Text="EmailId"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtEmailId" runat="server" Height="29px" Width="244px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" Text="PnoneNo"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtPhoneNo" runat="server" Height="29px" Width="244px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style8">
                        <asp:Button ID="btnInsertAddress" runat="server" Height="39px" OnClick="btnInsertAddress_Click" Text="Insert" Width="116px" />
                    </td>
                    <td class="auto-style9">

                        <asp:Button ID="btnUpdateAddress" runat="server" Height="39px" OnClick="btnUpdateAddress_Click" Text="Update" Width="116px" />

                        <asp:Button ID="btndelete" runat="server" Height="39px" Text="delete" Width="116px" OnClick="btndelete_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnviewAddressbook" runat="server" Height="39px" OnClick="btndelete0_Click" Text="Browse All Entries" Width="116px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="3">
                        <asp:Label ID="meslabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="True" Text="LastName"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtlastnamefind" runat="server" Height="29px" Width="244px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnfind" runat="server" Height="39px" OnClick="btnfind_Click" Text="Find" Width="116px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
  
</body>
</html>
