<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WebApp3.Pages.Students" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Students</h1>
    </div>
    <div class="table-responsive">
        <asp:GridView ID="StudentsGridview" runat="server" CssClass="table table-hover table-condensed" />
    </div>
</asp:Content>