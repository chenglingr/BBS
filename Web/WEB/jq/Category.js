$(document).ready(function () {

    $.ajax({
        type: "Post",
        url: "ashx/Category.ashx",
        data: { "Action": "Show" },
        dataType: "json",
        success: function (data) {

            var tbody = $('#CategoryList');
            if (jQuery.isEmptyObject(data)) { //json数据为空

                alert("无数据");
            }
            else {
                //用json返回数据行时
                //
                var n = data.CategoryList.length;
                var strcc;
                $.each(data.CategoryList, function (index, item) {//显示数据1
                
                   
                    var cc = 'CategoryList' + ((index) / 3);//下一个div名
                   
                    var str = ' <section class="span4">\
                                  <h4 class="category"><a href="ArticleList.html?ID='
                                        + item.SID +
                                              '">'
                                              + item.SName +
                                      '</a></h4>\
                                  <div class="category-description">\
                                      <p>' + item.SStatement + '</p>\
                                  </div>\
                               </section>';
                    if (index % 3 == 0) {
                        if (index != 0) { strcc = strcc + '</div>' }
                        tbody.append(strcc);
                        strcc = '<div class="row-fluid top-cats" id="' + cc + '"> ';//插入
                        strcc = strcc + str;
                    }
                    else {
                        strcc = strcc + str;
                    }
                    //最后一行
                    if (index == n - 1) {
                        strcc = strcc + '</div>' 
                        tbody.append(strcc);
                    }
                  
                });

               
            }

        },
        error: function (err) {
            alert(err);
        }
    });

});