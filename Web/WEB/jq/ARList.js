//Uid, Uname, UPassword, UEmail, UBirthday, Usex, UClass, UStatement, URegDate, UState, UPoint
//在你要搜索的那一列加入data-sortable="true"，其他列data-sortable="false" 在前端使用bootstrap-table插件，实现按列搜索功能
$(document).ready(function () {
    
  
    $('#table').bootstrapTable({
        url: "../ashx/ARList.ashx",//数据源
        sidePagination: 'server',//设置为服务器端分页
        pagination: true, //是否分页
        pageSize: 5,//每页的行数 
        pageList: [5, 10, 20],
        pageNumber: 1,//显示的页数
        showRefresh: true,
        striped: true,//条纹
        queryParams: queryParams,
    });
    //不写查询参数时 有默认的有：每页第一条数据的位置，每页的行数 两参数。要传别的
    function queryParams(params) {
        var ID = getUrlParam('ID');
        return {
            limit: params.limit, //每页数量
            offset: params.offset,//偏移量
            UID: ID //用户ID
        };

    }

    //删除按钮
    $("#BtnDel").click(function () {
        var DelNumS = getCheck();//获取选中行的人的编号
        //    alert(DelNumS);

        //判断是否为空。。前面是否有多余的 逗号.(如果是全选，前面会多个，)
        if (DelNumS.charAt(0) == ",") { DelNumS = DelNumS.substring(1); }

        if (DelNumS == "") { alert("请选择额要删除的数据"); }
        else
        {
            $.ajax({
                type: "post",
                url: "../ashx/delAricle.ashx",
                data: { "Action": "Del", "DelNums": DelNumS },
                dataType: "text",
                success: function (data) {
                    var json = eval('(' + data + ')');
                    alert(json.info);
                    //刷新页面
                    //  window.location.reload();
                    $('#table').bootstrapTable('refresh');
                }
            });

        }
    });
});



function editFormatter(value, row, index) { //处理操作

    var str = '<a target="_blank" href="../ContentSimple.html?ID=' + value + '">详情</a>'
    value = str;
    return value;
}

function getCheck() { //获取表格里选中的行 的编号
    var data = [];//数组
    $("#table").find(":checkbox:checked").each(function () {
        var val = $(this).parent().next().text();//当前元素的上一级---里的下一个元素--的内容
        data.push(val);
    });
    return data.join(",");//用，连接
}

function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    if (r != null) return unescape(r[2]); return 0; //返回参数值
}