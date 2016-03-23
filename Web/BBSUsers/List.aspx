<%@ Page Title="BBSUsers" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="BBS.Web.BBSUsers.List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="Uid" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Uname" HeaderText="Uname" SortExpression="Uname" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPassword" HeaderText="UPassword" SortExpression="UPassword" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UEmail" HeaderText="UEmail" SortExpression="UEmail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UBirthday" HeaderText="UBirthday" SortExpression="UBirthday" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Usex" HeaderText="Usex" SortExpression="Usex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UClass" HeaderText="UClass" SortExpression="UClass" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UStatement" HeaderText="UStatement" SortExpression="UStatement" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="URegDate" HeaderText="URegDate" SortExpression="URegDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UState" HeaderText="UState" SortExpression="UState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPoint" HeaderText="UPoint" SortExpression="UPoint" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="Uid" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="Uid" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>

