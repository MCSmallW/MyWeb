layui.use(['form', 'layedit', 'laydate'], function () {
    var form = layui.form
        , layer = layui.layer
        , layedit = layui.layedit
        , laydate = layui.laydate
        , $ = layui.$;

    $("#Submit").on('click', function (){
        $.ajax({
            type: 'post',
            url: '',
            dataType: '',
            data: { action: "SendBug", name: $("#GetBug").val(), number: $("#JobNum").val() },
            success: function (data) {
                //成功把文本框的值 传到后台

            },
            error: function (ex) {
                layer.msg(ex);
            }
        });
    }
});