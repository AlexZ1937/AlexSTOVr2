<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="AlexSTOv2.Pages.Admin.Services" MasterPageFile="~/Pages/Admin/Admin.Master" %>

<asp:Content ID="Cont1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ListView ID="ListView1" runat="server"
        ItemType="AlexSTOv2.Models.Service"
        SelectMethod="GetServices" >
          <LayoutTemplate>
            <div>
                <table id="goodsTable">
                    <tr>
                        <th>Услуга</th>
                        <th>Цена</th>
                         <th>Деталь</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
             <tr>
                <td><%# Item.Description %></td>
                <td><%# Item.Price.ToString("C") %></td>
                  <td><%# Item.MyOrder.MyGood.Name %></td>
                <td>
                    <asp:Button ID="Button1" CommandName="Edit" Text="Изменить" runat="server" />
                    <asp:Button ID="Button2" CommandName="Delete" Text="Удалить" runat="server" />
                </td>
            </tr>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>
