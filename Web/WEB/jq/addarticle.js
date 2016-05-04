
$(document).ready(function () {
    //页面加载后判断是否登陆
    $.ajax({
        type: "post",
        url: "../ashx/addarticle.ashx",
        data: { "Action": "Load" },
        dataType: "text",
        success: function (data) {
            //返回类型为text时 要处理一下 
            var json = eval('(' + data + ')');
            if (json.info == '未登录') {
                alert('请先登录');
                window.location.href = "login.html";
            }
        },

    });

    //注册提交按钮单击事件
    $("#BtnOK").click(function () {

        var txtUserName = $("#txtLoginID").val(); //获取文本框的值
        var txtPassWord = $("#txtLoginPWD").val();
        var txtRealName = $("#AdminName").val();
        var adminSex = true;

        var sexCheck = $('input:radio[name="sex"]:checked').val();//得到单选按钮选中项的值
        if (sexCheck == '女') { adminSex = false; }
        if ("" != txtUserName && "" != txtPassWord && "" != txtRealName) {   //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 
            $.ajax({
                type: "Post",
                url: "../ashx/ADDarticle.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "Action": "Add", "UserName": txtUserName, "PassWord": txtPassWord, "RealName": txtRealName, "adminSex": adminSex },
                dataType: "text",
                success: function (data) {
                    //返回类型为text时 要处理一下 
                    var json = eval('(' + data + ')');
                    alert(json.info);
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
        $("#txtLoginID").val('');
        $("#txtLoginPWD").val('');
        $("#AdminName").val('');
    });
});

