$(document).ready(function () {
    //页面加载后判断是否登陆
    $.ajax({
        type: "post",
        url:"ashx/nav.ashx",
        data: { "Action": "Load" },
        dataType: "json",
        success: function (data) {
            //返回类型为text时 要处理一下 
            if (jQuery.isEmptyObject(data)) {
                $("#exit").hide();
            }
            else {
               
                $("#name").append('['+data.info+'] ');
                $("#reg").hide();
                $("#login").hide();
            }
        },

    });
});
