var PageCount = 0;   //总条目数
var pageIndex = 0;     //页面索引初始值   
var pageSize = 5;     //每页显示条数初始化，修改显示条数，修改这里即可   
var UID =0;
var ID = 0;
var sqlwhere = "";
//注意 页面里要引入 jquery-1.4.1.min.js 才行 其他版本不行
$(function () {
    UID = getUrlParam('UID');
    ID = getUrlParam('ID'); 
    if (UID != 0) { sqlwhere = "tuid=" + UID; }//通过用户ID找
 
    if (ID != 0) { sqlwhere = "tsid="+ID; }//通过版块ID找
    getNum(sqlwhere);//获取记录总条数
 
    //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
     $("#Pagination").pagination(PageCount, {
        callback: PageCallback,
        prev_text: '上一页',       //上一页按钮里text
        next_text: '下一页',       //下一页按钮里text
        items_per_page: pageSize,  //显示条数
        num_display_entries: 6,    //连续分页主体部分分页条目数
        current_page: pageIndex,   //当前页索引
        num_edge_entries: 2 ,      //两侧首尾分页条目数
        current_page: pageIndex   //当前页索引
    });
    //翻页调用   
    function PageCallback(index, jq) {
        InitTable(index,sqlwhere);  
    }  
    //请求数据   
    function InitTable(pageIndex,sqlwhere) {
        $("#Result").empty();
        $.ajax({   
            type: "POST",  
            dataType: "json",  
            url: 'ashx/ArticleList.ashx',      //提交到一般处理程序请求数据   
            data: "pageIndex=" + (pageIndex) + "&pageSize=" + pageSize+ "&sqlwhere=" + sqlwhere,          //提交两个参数：pageIndex(页面索引)，pageSize(显示条数)                   
            success: function (data) {
               
                     //移除Id为Result的表格里的行，从第二行开始（这里根据页面布局不同页变）   
                $.each(data.List, function (index, item) {//显示数据1
                   //  tid,tsid,tuid,treplycount,TTopic,TContents100=SUBSTRING(TContents,0,100),TTime,TClickCount,TLastClickT
                 var str='<div">\
                                <h3> <a href="ContentSimple.html?ID=' + item.tid + '">' + item.TTopic + '</a></h3>\
                                <div >\
                                     <span">创建时间：' + item.TTime + '</span>\
                                     <span"><a href="ArticleList.html?ID=' + item.tsid + '">本版帖子</a></span>\
                                     <span><a href="ArticleList.html?UID=' + item.tuid + '">作者其他帖子</a></span>\
                                     <span>' + item.treplycount + ' 评论</span>\
                                     <span>' + item.TClickCount + '</span>\
                               </div>\
                               <div>' + item.TContents100 + '...<br/> <a class="readmore-link" href="ContentSimple.html?ID=' + item.tid + '">Read more</a></div></div>';
                 $("#Result").append(str);

                });
             
                          //将返回的数据追加到表格   
            }  
        }); 
    }
    function getNum(sqlwhere) {
        $.ajax({
            type: "Post",
            async : false, //这里要这样 才能给全局变量赋值
            url: "ashx/getNum.ashx",
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
});

function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    if (r != null) return unescape(r[2]); return 0; //返回参数值
}
