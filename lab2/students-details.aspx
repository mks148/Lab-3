<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="students-details.aspx.cs" Inherits="lab2.students_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Student Details</h2>

    <div class="form-group">
        <label for="txtLast" class="col-sm-3 control-label">Last Name:</label>
        <asp:TextBox ID="txtLast" runat="server"  />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Fill the form" ControlToValidate="txtLast"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="txtFirst" class="col-sm-3 control-label">First Name:</label>
        <asp:TextBox ID="txtFirst" runat="server"  />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Fill the form" ControlToValidate="txtFirst"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="txtEnrollment" class="col-sm-3 control-label">Date :</label>
        <asp:TextBox ID="txtEnrollment" runat="server"  type="date"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Fill the form" ControlToValidate="txtEnrollment"></asp:RequiredFieldValidator>
    </div>
    <asp:Button class="btn btn-success col-sm-offset-3" id="btnSend" runat="server" text="Send"  OnClick="btnSend_Click"/>
</asp:Content>
