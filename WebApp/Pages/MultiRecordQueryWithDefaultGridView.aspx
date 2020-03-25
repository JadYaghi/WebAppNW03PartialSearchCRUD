<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MultiRecordQueryWithDefaultGridView.aspx.cs" Inherits="WebApp.ExercisePages.MultiRecordQueryWithDefaultGridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Multi Record Query with Default GridView</h1>
    <div class="offset-2">
        <asp:DataList ID="Message" runat="server" Enabled="False">
        <ItemTemplate>
            <%# Container.DataItem %>
        </ItemTemplate>
    </asp:DataList>
    <br />
        <asp:Label ID="Label1" runat="server" Text="Select an Item: "></asp:Label>&nbsp;&nbsp
        <asp:TextBox ID="PartialProductNameV2" runat="server"></asp:TextBox>
        <asp:Button ID="SearchProductsPartial" runat="server" Text="Search Products"
            OnClick="SearchProductsPartial_Click" />
        <br />
        <br />
        <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        <br />
        <asp:GridView ID="ProductGridViewV2" runat="server">
        </asp:GridView>




        
    </div>
</asp:Content>
