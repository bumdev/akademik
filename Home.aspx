<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="akademik_app.Home" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" Runat="Server">
    <link href="styles/default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <telerik:RadPageLayout runat="server" ID="RadPageLayout1">
        <Rows>
            <telerik:LayoutRow>
                <Columns>
                    <telerik:LayoutColumn CssClass="jumbotron">
                        

                    </telerik:LayoutColumn>
                </Columns>
            </telerik:LayoutRow>
            <telerik:LayoutRow>
                <Columns>
                    <telerik:LayoutColumn HiddenMd="true" HiddenSm="true" HiddenXs="true">
                        
                    </telerik:LayoutColumn>
                </Columns>
            </telerik:LayoutRow>
        </Rows>
    </telerik:RadPageLayout>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <telerik:RadPageLayout runat="server" ID="Content1">
        <Rows>
            <telerik:LayoutRow>
                <Columns>
                    <%--<telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        
                        <telerik:RadButton runat="server" ID="CatComp" Text="Обновить категории жалоб" ButtonType="SkinnedButton" OnClick="CatComp_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>

                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                       
                        <telerik:RadButton runat="server" ID="OrgButt" Text="Обновить организацию" ButtonType="SkinnedButton" OnClick="OrgButt_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>

                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        
                        <telerik:RadButton runat="server" ID="MailButt" Text="Обновить тип почты" ButtonType="SkinnedButton" OnClick="Mail_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>--%>
                    <%--<telerik:LayoutColumn runat="server" Span="4" SpanMd="12" HiddenXs="true">
                        <a href="Dossier.aspx">
                        <div style="width:230px; height:230px; border:1px solid white; float:left; margin-top: 15px; margin-right: 15px; background-color:White; border-radius: 250px;" id="box1">
                            <span style="font-size:16px;position:absolute; font-family:Verdana; margin-left:15px; margin-top:230px; color: black;">Основная информация</span>
        
                            <div style="width:128px; height:128px; background-image:url('images/dossier (1).png'); margin-left:50px;margin-top:50px; border:0px solid black;"></div>
                        </div>
                    </a>
                    </telerik:LayoutColumn>--%>
                 
                    <telerik:LayoutColumn runat="server" Span="4" SpanMd="12" HiddenXs="true">
                        <a href="Admin/Default.aspx">
                        <div style="width:230px; height:230px; border:1px solid white; float:left; margin-top: 15px; margin-right: 15px; background-color:White; border-radius: 250px;" id="box1">
                            <span style="font-size:16px;position:absolute; font-family:Verdana; margin-left:15px; margin-top:230px; color: black;">Админ панель</span>
        
                            <div style="width:128px; height:128px; background-image:url('images/admin.png'); margin-left:0px;margin-top:50px; border:0px solid black;"></div>
                        </div>
                    </a>
                    </telerik:LayoutColumn>
                    <telerik:LayoutColumn runat="server" Span="4" SpanMd="12" HiddenXs="true">
                        <a href="Synchronization.aspx">
                        <div style="width:230px; height:230px; border:1px solid white; float:left; margin-top: 15px; margin-right: 15px; background-color:White; border-radius: 250px;" id="box1">
                            <span style="font-size:16px;position:absolute; font-family:Verdana; margin-left:15px; margin-top:230px; color: black;">Синхронизация</span>
        
                            <div style="width:128px; height:128px; background-image:url('images/cloud-computing.png'); margin-left:10px;margin-top:50px; border:0px solid black;"></div>
                        </div>
                    </a>
                    </telerik:LayoutColumn>
                    
                    <telerik:LayoutColumn runat="server" Span="4" SpanMd="12" HiddenXs="true">
                        <a href="LogOut.aspx">
                        <div style="width:230px; height:230px; border:1px solid white; float:left; margin-top: 15px; margin-right: 15px; background-color:White; border-radius: 250px;" id="box1">
                            <span style="font-size:16px;position:absolute; font-family:Verdana; margin-left:15px; margin-top:230px; color: black;">Выход</span>
        
                            <div style="width:128px; height:128px; background-image:url('images/exit (1).png'); margin-left:-20px;margin-top:50px; border:0px solid black;"></div>
                        </div>
                    </a>
                    </telerik:LayoutColumn>
                    
                    
                   <%-- <a href="#" class="logo">
                                <img src="images/logo_akadem.png" alt="site logo"/>
                            </a>--%>
                    
                    
                </Columns>
            </telerik:LayoutRow>
        </Rows>
    </telerik:RadPageLayout>    
</asp:Content>

<%--<asp:Content runat="server" ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3">
    <telerik:RadPageLayout runat="server" ID="Content5">
        <Rows>
            <telerik:LayoutRow>
                <Columns>
                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        
                        <telerik:RadButton runat="server" ID="ServiceButt" Text="Обновить службы" ButtonType="SkinnedButton" OnClick="ServiceButt_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>
                    
                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        
                        <telerik:RadButton runat="server" ID="DistrButt" Text="Обновить районы" ButtonType="SkinnedButton" OnClick="DistrictButt_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>
                    
                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        
                        <telerik:RadButton runat="server" ID="EnterButt" Text="Обновить предприятия" ButtonType="SkinnedButton" OnClick="Enterprises_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>
                    
                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        
                        <telerik:RadButton runat="server" ID="QuestButt" Text="Обновить типы вопросов жалоб" ButtonType="SkinnedButton" OnClick="Question_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>

                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        
                        <telerik:RadButton runat="server" ID="ResponButt" Text="Обновить ответственные лица" ButtonType="SkinnedButton" OnClick="Respon_OnClick"></telerik:RadButton>
                    </telerik:LayoutColumn>
                </Columns>
            </telerik:LayoutRow>
        </Rows>
    </telerik:RadPageLayout>
</asp:Content>--%>
