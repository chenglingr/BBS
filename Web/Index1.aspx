<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index1.aspx.cs" Inherits="Web.Index1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="Scripts/jquery.pagination.js"></script>
     <script type="text/javascript" src="Scripts/jquery-1.10.2.min.js"></script>
    <link href="Content/pagination.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript">
    var pageIndex = 0;     //页面索引初始值
    var pageSize = 10;     //每页显示条数初始化，修改显示条数，修改这里即可
    $(function () {
        InitTable(0);    //Load事件，初始化表格数据，页面索引为0（第一页）   
        //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
        $("#Pagination").pagination(<%=pageCount %>, {
            callback: PageCallback,
            prev_text: '上一页',       //上一页按钮里text
            next_text: '下一页',       //下一页按钮里text
            items_per_page: pageSize,  //显示条数
            num_display_entries: 6,    //连续分页主体部分分页条目数
            current_page: pageIndex,   //当前页索引
            num_edge_entries: 2        //两侧首尾分页条目数
        });
        //翻页调用
        function PageCallback(index, jq) {
            InitTable(index);
        }

        //请求数据
        function InitTable(pageIndex) {
            $.ajax({
                type: "POST",
                dataType: "json",
                url: 'SupplyAJAX.aspx',      //提交到一般处理程序请求数据
                data: "type=show&random=" + Math.random() + "&pageIndex=" + (pageIndex + 1) + "&pageSize=" + pageSize, //提交两个参数：pageIndex(页面索引)，pageSize(显示条数)    
                error: function () { alert('error data'); },  //错误执行方法  
                success: function (data) {
                    $("#Result tr:gt(0)").remove();        //移除Id为Result的表格里的行，从第二行开始（这里根据页面布局不同页变）
                    var json = data; //数组 
                    var html = "";
                    $.each(json.data, function (index, item) {
                        //循环获取数据  
                        var id = item.Id;
                        var name = item.Name;
                        var sex = item.Sex;
                        html += "<tr><td>" + id + "</td><td>" + name + "</td><td>" + sex + "</td></tr>";
                    });
                    $("#Result").append(html);             //将返回的数据追加到表格
                }
            });
        }
    }); 
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MenuContent" runat="server">
    <ul class="list-group">
      <li class="list-group-item">Cras justo odio</li>
      <li class="list-group-item">Dapibus ac facilisis in</li>
      <li class="list-group-item">Morbi leo risus</li>
      <li class="list-group-item">Porta ac consectetur ac</li>
      <li class="list-group-item">Vestibulum at eros</li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <table id="Result" cellspacing="0" cellpadding="0">
        <tr>
            <th>
                编号
            </th>
            <th>
                姓名
            </th>
            <th>
                性别
            </th>
        </tr>
    </table>
    <div id="Pagination">
    </div>
</asp:Content>