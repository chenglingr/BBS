
$(document).ready(function () {

    //注册提交按钮单击事件
    $("#BtnOK").click(function () {

        var txtuname = $("#txtuname").val(); //获取文本框的值
        var txtupassword = $("#txtupassword").val();
        var txtuemail = $("#txtuemail").val();
        var txtubirthday = $("#txtubirthday").val();
        var txtustatement = $("#txtustatement").val();
        var usex = true;

        var sexCheck = $('input:radio[name="sex"]:checked').val();//得到单选按钮选中项的值
        if (sexCheck == '女') { usex = false; }

        if ("" != txtuname && "" != txtupassword && "" != txtuemail) {   //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 
            $.ajax({
                type: "Post",
                url: "../ashx/ADD.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "Action": "Add", "uname": txtuname, "upassword": txtupassword, "uemail": txtuemail, "ubirthday": txtubirthday, "ustatement": txtustatement, "usex": usex },
                dataType: "text",
                success: function (data) {
                    //返回类型为text时 要处理一下 
                    var json = eval('(' + data + ')');
                    alert(json.info);
                    window.location.href = "../index.html";
                },
                error: function (err) {
                    alert(err);
                }
            });
        }
        else {
            alert("输入非法！");
        }
    });

    //注册重置按钮单击事件
    $("#btnReset").click(function () {
        $("#txtuname").val('');
        $("#txtupassword").val('');
        $("#txtuemail").val('');
    });
});

