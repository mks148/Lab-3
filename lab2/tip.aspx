<%@ Page Title="Tip Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tip.aspx.cs" Inherits="lab2.tip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Tip Calculator</h1>
    <div class="form-group">
        <label for="txtamount" class="control-label col-sm-2">Amount:</label>
        <asp:TextBox id="txtamount" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="ddlpercent" class="control-label col-sm-2">Tip %</label>
        <asp:DropDownList id="ddlpercent" runat="server">
            <asp:ListItem value=".1" Text="10%" />
            <asp:ListItem value=".15" Text="15%" />
            <asp:ListItem value=".2" Text="20%" />
        </asp:DropDownList>
    </div>
    <asp:Button id="btnCalculate" runat="server" Text="Calculate Tip"  cssclass="btn btn-success col-sm-offset-2" OnClick="btnCalculate_Click"/>
    <div> Tip: <asp:Label id="lblTip" runat="server" cssclass="alert alert-info"></asp:Label></div>
    <div> Total: <asp:Label id="lbltotal" runat="server" cssclass="alert alert-info"></asp:Label></div>

</asp:Content>
