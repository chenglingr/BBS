<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BBS.Web.BBSTopic.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		tid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltsid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tuid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltuid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		treplycount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltreplycount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TTopic
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTTopic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TContents
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTContents" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TClickCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTClickCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TLastClickT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTLastClickT" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




