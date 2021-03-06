﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="AlexSTOv2.Pages.Listing" MasterPageFile="~/Pages/STO.Master" %>
<%@ Import Namespace="System.Web.Routing" %>
<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
  
  
      <asp:Repeater ItemType="AlexSTOv2.Models.Service" SelectMethod="GetServices" runat="server">
          <ItemTemplate>
              <div class="item">
                  
                  <h3><%# Item.MyOrder.MyGood.Name %></h3>
                  <%# Item.Description %>
                  <h4> <%# Item.Price.ToString("c") %></h4>
                  <button name="add" type="submit" value="<%# Item.ServiceId %>">
                      В корзину
                  </button>
              </div>
          </ItemTemplate>
      </asp:Repeater>
    </div>
    <div class="pager">
        <%
            for (int i = 1; i <= MaxPage; i++)
            {
                string selectedCategory = (string)Page.RouteData.Values["category"] ?? Request.QueryString["category"];
                string path = RouteTable.Routes.GetVirtualPath(null, null, new RouteValueDictionary() { { "category", selectedCategory }, { "page", i } }).VirtualPath;
                Response.Write(String.Format("<a href='{0}' {1}>{2}</a>", path, i == CurrentPage ? "class='selected'" : "", i));
            }
        %>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentBanner" runat="server">
        <div id="banner" style="position: absolute; top: 94%; width: 100%; height: 5%; text-align: center; font-size: 25px; left: 6px;">
            Самая популярная услуга: </div>
</asp:Content>
