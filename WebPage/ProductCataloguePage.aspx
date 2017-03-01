<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCataloguePage.aspx.cs" Inherits="WebPage.ProductCataloguePage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 runat="server" ID="ProductCatalogueNameLabel"></h1>
    <asp:ListView runat="server" ID="CatalogueEntriesListView" OnItemCommand="CatalogueEntriesListView_OnItemCommand" GroupItemCount="4" OnPagePropertiesChanging="CatalogueEntriesListView_OnPagePropertiesChanging">
        <LayoutTemplate>
            <ul class="productList">
                <li runat="server" id="groupPlaceholder"></li>

            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <li>
                <asp:LinkButton runat="server" ID="CatalogueEntryButton">
                    <asp:Panel runat="server" HorizontalAlign="Center">
                        <img src='<%# Eval("ImageUrl") %>' style="max-height: 175px; max-width: 200px"/>
                        <h4><%# Eval("Name") %></h4>
                        <h3><%# Eval("Price") %> €</h3>
                    </asp:Panel>
                </asp:LinkButton>
            </li>
        </ItemTemplate>
        <GroupTemplate>
            <ul>
                <li runat="server" id="itemPlaceholder"></li>
            </ul>
        </GroupTemplate>
    </asp:ListView>
    <asp:DataPager ID="EntriesDataPager" runat="server" PagedControlID="CatalogueEntriesListView" PageSize="16">
    <Fields>
        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="false" ShowPreviousPageButton="True"
            ShowNextPageButton="False" />
        <asp:NumericPagerField ButtonType="Link" />
        <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="true" ShowLastPageButton="false" ShowPreviousPageButton = "false" />
    </Fields>
</asp:DataPager>
</asp:Content>
