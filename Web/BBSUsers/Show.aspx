<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BBS.Web.BBSUsers.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Uid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Uname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPassword
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUPassword" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UEmail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUEmail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UBirthday
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUBirthday" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Usex
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUsex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UClass
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUClass" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UStatement
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUStatement" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		URegDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblURegDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUPoint" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




