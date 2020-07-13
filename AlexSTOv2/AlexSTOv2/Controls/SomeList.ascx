<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SomeList.ascx.cs" Inherits="AlexSTOv2.Controls.SomeList" %>

<%= CreateHomeLinkHtml()%>

<% 
    foreach (string item in GetCategories())
    {
        Response.Write(CreateLinkHtml(item));
    }
%>
    