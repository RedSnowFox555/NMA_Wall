﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NMA_Wall.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadArea" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyArea" runat="server">
    <div class="login-page">
        <div class="form">
            <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" />
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" />
            <asp:Button ID="btnSubmit" Text="Submit!" runat="server" />
        </div>
    </div>
</asp:Content>
