<%@ Page Title="Week 4-Hello" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hello.aspx.cs" Inherits="lab2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hello</h1>
   <div> <asp:label id="lblMessage" runat="server" cssclass="alert alert-info" visible="false"></asp:label> </div>
    <asp:textbox id="txtname" runat="server" placeholder="Enter Your Name"></asp:textbox>
    <asp:button id="btnsubmit" runat="server" text="submit" cssclass="btn btn-success" OnClick="btnsubmit_Click" />
</asp:Content>

