$(document).ready(function () {
    //注册提交按钮单击事件
    $("#BtnOK").click(function () {

        var txtUserName = $("#txtLoginID").val(); //获取文本框的值
        var txtPassWord = $("#txtLoginPWD").val();

        if ("" != txtUserName && "" != txtPassWord) {   //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 
            $.ajax({
                type: "Post",
                url: "../ashx/LOGIN.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "UserName": txtUserName, "PassWord": txtPassWord },
                dataType: "text",
                success: function (data) {
                    //返回类型为text时 要处理一下 
                    var json = eval('(' + data + ')');
                    //   $("#result").val(json); 
                    alert(json.info + " 编号为：" + json.ID);
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

    // 下面这个按钮 为了演示jquery的代码编辑方法
    $("#BtnCancel").click(function () {
        //jquery修改/追加/删除html网页中的内容示例
        $("#result").html("—jquery专栏---");//html() 函数改变所匹配的 HTML 元素的内容（innerHTML）。
        $("#result").append("追加");//append() 函数向所匹配的 HTML 元素内部追加内容

        $("#result").after(" after");// after() 函数在所有匹配的元素之后插入 HTML 内容。
        $("#result").before(" before");// before()  在每个匹配的元素之前插入内容。  

    });

});
