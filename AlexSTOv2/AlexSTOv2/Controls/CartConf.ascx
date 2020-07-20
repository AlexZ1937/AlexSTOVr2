<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartConf.ascx.cs" Inherits="AlexSTOv2.Controls.CartConf" %>


<div id="cartSummary">
    <span class="caption">
        <b>В корзине</b>
        <span id="csQuantity" runat="server">товаров, </span>
        <span> на </span>
        <span id="csTotal" runat="server"></span>
    </span>
    <a id="csLink" runat="server">Корзина</a>
</div>