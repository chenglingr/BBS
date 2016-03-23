<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BBS.Web.BBSReply.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		RID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RTID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRTID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RSID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRSID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RUID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRUID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RTopic
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRTopic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RContents
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRContents" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RClickCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRClickCount" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




