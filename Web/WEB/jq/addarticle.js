
$(document).ready(function () {
    //页面加载后判断是否登陆
    $.ajax({
        type: "post",
        url: "../ashx/addarticle.ashx",
        data: { "Action": "Load" },
        dataType: "json",
        success: function (data) {
            //返回类型为text时 要处理一下 
          
            if (data.info == '未登录') {
                alert('请先登录');
                window.location.href = "login.html";
            }
            else { 
                $.each(data.BBSSection, function (index, item) {
                    var str = '<option value="' + item.SID + '">' + item.SName + '</option>';
                    $("#section").append(str);
                });
            }
        },

    });

    //注册提交按钮单击事件
    $("#save").click(function () {

        var txtContent = UM.getEditor('myEditor').getContent(); //获取文本框的值
        var section = jQuery("#section  option:selected").val();
        var title = $("#title").val();
        alert(txtContent);
        if (UM.getEditor('myEditor').hasContents()) {   //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 

            $.ajax({
                type: "Post",
                url: "../ashx/ADDarticle.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "Action": "Add", "Content": encodeURIComponent(txtContent), "section": section, "title": title },
                dataType: "json",
                success: function (data) {
                    //返回类型为text时 要处理一下 
               
                    alert(data.info);
                },
                error: function (err) {
                    alert(err);
                }
            });
        }
        else {
            alert("内容不得为空！");
        }
    });

    //注册重置按钮单击事件
    $("#clear").click(function () {
        UM.getEditor('myEditor').setContent("");
    });
});

