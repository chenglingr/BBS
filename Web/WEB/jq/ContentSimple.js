function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    if (r != null) return unescape(r[2]); return 0; //返回参数值
}
var PageCount = 0;   //总条目数
var pageIndex = 0;     //页面索引初始值   
var pageSize = 5;     //每页显示条数初始化，修改显示条数，修改这里即可   

var TID = 0;
var sqlwhere = "";
$(document).ready(function () {
    var id = getUrlParam('ID');
    if (id != null) {
        $.ajax({
            type: "Post",
            url: "ashx/ContentSimple.ashx",
            //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
            data: { "ID": id },
            dataType: "json",
            success: function (data) {
                if (jQuery.isEmptyObject(data)) { //json数据为空

                    var tbody = $('#title');
                    //用json返回一个对象数据
                    tbody.append("该帖不存在");
                }
                else {
                    var tbody = $('#title');
                    //用json返回一个对象数据
                    tbody.append(data.TTopic);

                    tbody = $('#content');
                    tbody.append(data.TContents);
                }
            },
            error: function (err) {
                alert(err);
            }
        });

        $("#submitComment").click(function () {
            var tid = id; //获取文本框的值
            var title = $("#title1").val();
            alert(title);
            var content = $("#comment").val();
            $.ajax({
                type: "Post",
                url: "ashx/AddComment.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "TID": id, "title": title, "content": content },
                dataType: "json",
                success: function (data) {
                    if (jQuery.isEmptyObject(data)) { //json数据为空

                        var tbody = $('#showADD');
                        //用json返回一个对象数据
                        tbody.html("<strong>评论失败,请先登录</strong>");
                    }
                    else {
                        var tbody = $('#showADD');
                        //用json返回一个对象数据
                        tbody.html("<strong>评论成功</strong>");
                        $("#title1").val("无标题");
                        $("#comment").val("");
                    }
                },
                error: function (err) {
                    alert(err);
                }
            });
        });
        $("#getComment").click(function () {
            TID = getUrlParam('ID');; //获取文本框的值
            if (TID != 0) { sqlwhere = "RTID=" + TID; }
            getNum(sqlwhere);//获取记录总条数
            $("#Pagination").pagination(PageCount, {
                callback: PageCallback,
                prev_text: '上一页',       //上一页按钮里text
                next_text: '下一页',       //下一页按钮里text
                items_per_page: pageSize,  //显示条数
                num_display_entries: 6,    //连续分页主体部分分页条目数
                current_page: pageIndex,   //当前页索引
                num_edge_entries: 2,      //两侧首尾分页条目数
                current_page: pageIndex   //当前页索引
            });
            //翻页调用   
            function PageCallback(index, jq) {
                InitTable(index, sqlwhere);
            }
            //请求数据   
            function InitTable(pageIndex, sqlwhere) {
                $("#Result").empty();
                $.ajax({
                    type: "POST",
                    dataType: "json",
                    url: 'ashx/CommentList.ashx',      //提交到一般处理程序请求数据   
                    data: "pageIndex=" + (pageIndex) + "&pageSize=" + pageSize + "&sqlwhere=" + sqlwhere,          //提交两个参数：pageIndex(页面索引)，pageSize(显示条数)                   
                    success: function (data) {
                        //RTopic,RContents,RTime
                        //移除Id为Result的表格里的行，从第二行开始（这里根据页面布局不同页变）   
                        $.each(data.List, function (index, item) {//显示数据1
                            // 
                            var str = '<blockquote>\
                                          <p>' + item.RTopic + '&nbsp;&nbsp;&nbsp;&nbsp;' + item.RTime + '</p>\
                                          <p>' + item.RContents + '</p>\
                                       </blockquote>';
                            $("#Result").append(str);

                        });

                        //将返回的数据追加到表格   
                    }

                });
            }
        });
      
    }
    else { alert('地址有误'); }


});

function getNum(sqlwhere) {
    $.ajax({
        type: "Post",
        async : false, //这里要这样 才能给全局变量赋值
        url: "ashx/getCommentNum.ashx",
        data: "sqlwhere=" + sqlwhere,
        //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
        dataType: "text",
        success: function (data) {
            //返回类型为text时 要处理一下 
            var json = eval('(' + data + ')');
            PageCount = json.info;
               
        }
    });
 }