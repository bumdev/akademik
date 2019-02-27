<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSingleMenu.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="akademik_app.Employees" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="styles/grid.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:UpdatePanel runat="server" ID="up1">
<ContentTemplate>
    <script src="scripts/openimage.js" type="text/javascript" ></script>     
<div style="width:100%; border:0px solid black; min-height:300px;">
<div>
   
    
  <telerik:RadGrid runat="server" ID="radgrid" AutoGenerateColumns="false"   PageSize="25"
        onneeddatasource="radgridDevice_NeedDataSource" CssClass="rad" AllowPaging="True"  Font-Names="Arial Unicode MS"
        Culture="ru-RU" oninsertcommand="radgrid_InsertCommand" ClientEvents-OnRequestStart="onRequestStart"
        AllowAutomaticInserts="true" ondeletecommand="radgrid_DeleteCommand" onupdatecommand="radgridServices_UpdateCommand"
        onitemdatabound="radgrid_ItemDataBound" OnItemCommand="radgrid_itemcommand"
        AllowSorting="true" RenderMode="Auto">
      
      <ClientSettings Selecting-AllowRowSelect="true" EnablePostBackOnRowClick="true" >
         
      </ClientSettings>

         <ExportSettings ExportOnlyData="true" IgnorePaging="true">
    <Pdf DefaultFontFamily="Arial Unicode MS" PageTopMargin="2" PageLeftMargin="2" PageRightMargin="2" PageBottomMargin="2"/>
    </ExportSettings>
      
        <MasterTableView EditMode="PopUp" IsFilterItemExpanded="True" EditFormSettings-PopUpSettings-Width="900px" DataKeyNames="ID" Width="100%" CommandItemDisplay="Top" AllowAutomaticUpdates="true" Name="Employees"  AllowFilteringByColumn="true" >
            <CommandItemSettings ShowAddNewRecordButton="true" AddNewRecordText="Добавить сотрудника" ShowRefreshButton="False" />
            
            <Columns>
                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" ButtonType="ImageButton"></telerik:GridEditCommandColumn> 
                
                <%--<telerik:GridDropDownColumn UniqueName="ep" HeaderStyle-HorizontalAlign="Center" DropDownControlType="RadComboBox" DataField="employee_id" HeaderText="Сотрудник" DataSourceID="dsEmployees" 
                    ListTextField="name" FilterControlWidth="300" ListValueField="id" ItemStyle-Wrap="true" ItemStyle-Width="300" HeaderStyle-Width="300">
                    <FilterTemplate>
                        <telerik:RadComboBox runat="server"  Width="250px" ID="point_id" DataSourceID="dsEmployees" DataTextField="name"
                            DataValueField="id" AppendDataBoundItems="true" SelectedValue='<%# ((GridItem)Container).OwnerTableView.GetColumn("ep").CurrentFilterValue %>'
                            runat="server" OnClientSelectedIndexChanged="DirectEmployees" Filter="Contains"
                            EmptyMessage="Поиск...">
                            <Items>
                                <telerik:RadComboBoxItem />
                            </Items>
                        </telerik:RadComboBox>
                        <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
                            <script type="text/javascript">
                                function DirectEmployees(sender, args) {
                                    var tableView = $find("<%# ((GridItem)Container).OwnerTableView.ClientID %>");
                                    tableView.filter("ps", args.get_item().get_value(), "EqualTo");
                                }
                            </script>
                        </telerik:RadScriptBlock>
                    </FilterTemplate>
                </telerik:GridDropDownColumn>--%>
                <telerik:GridBoundColumn DataField="name" runat="server" HeaderText="ФИО" AllowFiltering="false"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="sex" runat="server" HeaderText="Пол"  AllowFiltering="false"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="position" runat="server" HeaderText="Должность"  AllowFiltering="false"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="phone" runat="server" HeaderText="Телефон"  AllowFiltering="false"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="growth" runat="server" HeaderText="Рост"  AllowFiltering="false"></telerik:GridBoundColumn>
                <telerik:GridDateTimeColumn CurrentFilterFunction="EqualTo" ShowFilterIcon="false" FilterControlWidth="170" AutoPostBackOnFilter="true" DataField="birthday" ReadOnly="true" HeaderText="День рождения" />
                <telerik:GridBoundColumn DataField="Address" runat="server" HeaderText="Адрес"  AllowFiltering="false"></telerik:GridBoundColumn>  
                <%--<telerik:GridBoundColumn DataField="par_data" runat="server" HeaderText="Итог" AllowFiltering="false" ></telerik:GridBoundColumn>--%>
                
                <%--<telerik:GridNumericColumn DataField="total_ratio" runat="server"  HeaderText="Итог" AllowFiltering="false"></telerik:GridNumericColumn>--%>
                
                

                <telerik:GridButtonColumn runat="server" CommandName="Delete" Text="Delete" ButtonType="ImageButton" ConfirmText="Вы точно хотите удалить?" />
                
        </Columns>
        <EditFormSettings>
                <EditColumn ButtonType="ImageButton" />            
        </EditFormSettings>
        

        </MasterTableView>
     
</telerik:RadGrid>
    
        

<%--<asp:SqlDataSource ID="dsPoints" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>" SelectCommand="RetrievePoints"></asp:SqlDataSource>--%>
<%--<asp:SqlDataSource ID="dsSensors" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>" SelectCommand="RetrieveSensors"></asp:SqlDataSource>--%>


<asp:SqlDataSource ID="dsJournal" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>" 
    SelectCommand="RetrieveEmployees" SelectCommandType="StoredProcedure"
    UpdateCommand="Update Employees" UpdateCommandType="StoredProcedure"
    InsertCommand="CreateEmployees" InsertCommandType="StoredProcedure" 
    DeleteCommand="DeleteEmplyees" DeleteCommandType="StoredProcedure"
    >
</asp:SqlDataSource>
</div>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>


