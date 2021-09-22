<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="Ejemplo_1.Alumno1" %>

<!DOCTYPE html>  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
    <style type="text/css">  
        .auto-style1 {  
            width: 100%;  
        }  
        .auto-style2 {  
            width: 100px;  
        }  
        .auto-style3 {  
            width: 95px;  
        }  
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
        <div>  
            <table class="auto-style1">  
                <tr>  
                    <td class="auto-style2">  
                       <asp:Label runat="server" Text="Id" ID="Label8"></asp:Label></td>  
                    <td>  
                       <asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">  
                       <asp:Label runat="server" Text="Carnet" ID="usernamelabelId"></asp:Label></td>  
                    <td>  
                       <asp:TextBox ID="txtCarnet" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Nombre"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Carrera"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="txtCarrera" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2"></td>  
                    <td>  
                        <asp:Button ID="ButtonId" runat="server" Text="Guardar" OnClick="ButtonId_Click" /></td>  
                </tr>  
            </table>  
        </div>  
    <div>  
        <asp:Label ID="Label1" runat="server"></asp:Label>  
    </div>  
    </form>  
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style3">  
                <asp:Label ID="lblIdHead" runat="server"></asp:Label></td>  
            <td>  
                <asp:Label ID="lblId" runat="server"></asp:Label></td>  
        </tr>  
        <tr>  
            <td class="auto-style3">  
                <asp:Label ID="lblCarnetHead" runat="server"></asp:Label></td>  
            <td>  
                <asp:Label ID="lblCarnet" runat="server"></asp:Label></td>  
        </tr>  
        <tr>  
            <td class="auto-style3">  
                <asp:Label ID="lblNombreHead" runat="server"></asp:Label></td>  
            <td>  
                <asp:Label ID="lblNombre" runat="server"></asp:Label></td>  
        </tr>  
        <tr>  
            <td class="auto-style3">  
                <asp:Label ID="lblCarreraHead" runat="server"></asp:Label></td>  
            <td>  
                <asp:Label ID="lblCarrera" runat="server"></asp:Label></td>  
        </tr> 
    </table>  
    </body>  
</html>  