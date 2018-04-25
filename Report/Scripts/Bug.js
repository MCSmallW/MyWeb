layui.use(['form', 'layedit', 'laydate'], function () {
    var form = layui.form
        , layer = layui.layer
        , layedit = layui.layedit
        , laydate = layui.laydate
        , $ = layui.$;

    $("#Submit").on('click', function (){
        $.ajax({
            type: 'get',
            url: '',
            dataType: '',
            data: { action: "SendBug", name: $("#GetBug").val(), number: $("#JobNum").val() },
            success: function (data) {
                //成功把文本框的值 传到后台
                layer.msg('反馈成功');
            },
            error: function (ex) {
                layer.msg(ex);
            }
        });
    }
});