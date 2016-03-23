<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BBS.Web.BBSSection.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		SID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SMasterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSMasterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SStatement
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSStatement" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SClickCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSClickCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		STopicCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTopicCount" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




