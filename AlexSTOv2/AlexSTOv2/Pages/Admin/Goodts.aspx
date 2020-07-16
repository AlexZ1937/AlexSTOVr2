<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Goodts.aspx.cs" Inherits="AlexSTOv2.Pages.Admin.Goodts" MasterPageFile="~/Pages/Admin/Admin.Master" %>

<asp:Content ID="Cont1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ListView ID="ListView1" runat="server"
        ItemType="AlexSTOv2.Models.Good"
        SelectMethod="GetGames" >
          <LayoutTemplate>
            <div>
                <table id="goodsTable">
                    <tr>
                        <th>Деталь</th>
                        <th>Цена</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
             <tr>
                <td><%# Item.Name %></td>
                <td><%# Item.Price.ToString("C") %></td>
                <td>
                    <asp:Button ID="Button1"Нача CommandName="Edit" Text="Изменить" runat="server" />
                    <asp:Button ID="Button2" CommandName="Delete" Text="Удалить" runat="server" />
                </td>
            </tr>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>