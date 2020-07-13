<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="AlexSTOv2.Controls.WebUserControl1" %>

<%= CreateHomeLinkHtml()%>

<% 
    foreach (string item in GetCategories())
    {
        Response.Write(CreateLinkHtml(item));
    }
%>
    