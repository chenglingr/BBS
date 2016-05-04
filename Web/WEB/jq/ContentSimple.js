function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    if (r != null) return unescape(r[2]); return null; //返回参数值
}

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
    }
    else { alert('地址有误'); }


});

