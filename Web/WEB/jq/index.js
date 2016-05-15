$(document).ready(function () {

    $.ajax({
        type: "Post",
        url: "ashx/index.ashx",
        data: { "Action": "Show" },
        dataType: "json",
        success: function (data) {
            
            var tbody = $('#hotArticles');
            if (jQuery.isEmptyObject(data)) { //json数据为空

                alert("无数据");
            }
            else {
                //用json返回数据行时
                //tid,tsid,tuid,treplycount,TTopic,TContents,TTime,TClickCount,TLastClickT
                $.each(data.hotArticles, function (index, item) {//显示数据1
                    var str = '<li class="article-entry standard">\
                              <h4><a href="ContentSimple.html?ID='
                             + item.tid+
                            '">'
                            + item.TTopic +
                            '</a></h4>\
                              <span class="article-meta">'
                              + item.TTime +
                              '  <a href="ArticleList.html?UID='
                     + item.tuid +
                    '" title="作者 ">'
                            + item.Uname +
                            '</a> <a href="ArticleList.html?ID='
                     + item.tsid +
                    '" title="版块 ">'
                            + item.SName +
                            '</a></span>\
                              <span class="like-count">'
                            + item.TClickCount +
                            '</span>\
                              </li>';
                    tbody.append(str);
                });

                tbody = $('#newArticles');
                $.each(data.newArticles, function (index, item) {//显示数据2
                    var str = '<li class="article-entry standard">\
                              <h4><a href="ContentSimple.html?ID='
                             + item.tid +
                            '">'
                            + item.TTopic +
                            '</a></h4>\
                              <span class="article-meta">'
                              + item.TTime +
                              '  <a href="ArticleList.html?UID='
                     + item.tuid +
                    '" title="作者 ">'
                            + item.Uname +
                            '</a> <a href="ArticleList.html?ID='
                     + item.tsid +
                    '" title="版块 ">'
                            + item.SName +
                            '</a></span>\
                              <span class="like-count">'
                            + item.TClickCount +
                            '</span>\
                              </li>';
                    tbody.append(str);
                });
            }

        },
        error: function (err) {
            alert(err);
        }
    });

});