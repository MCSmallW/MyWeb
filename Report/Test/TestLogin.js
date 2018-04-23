layui.use(['form', 'layedit', 'laydate'], function () {
    var form = layui.form
        , layer = layui.layer
        , layedit = layui.layedit
        , laydate = layui.laydate
        , $ = layui.$;

    $('#layerDemo').on('click', function () {
        var win = layer.open({
            content: '请输入密码： <br/> <input type="text" id="txInput" name="title" lay-verify="title" autocomplete="off" placeholder="此处输入密码" class="layui-input">'
            , btn: ['确定', '取消']
            , yes: function (index, layero) {
                $.ajax({
                    type: 'post'
                    , url: 'TestLogin.aspx'
                    , dataType: 'text'
                    , data: { action: 'ToWCFAndReturnName', name: $('#txInput').val() }
                    , success: function (data) {
                        action.SetTbxShowTx('txShow', data);
                    }
                    , error: function (ex) {
                        layer.msg(ex);
                    }
                });
                layer.close(win);
                layer.msg('登陆成功');
            }
            , btn2: function (index, layero) {
                layer.msg('你取消了..');
            }
        });
    });

    var action = {
        SetTbxShowTx: function (id, val) {
            $('#' + id).val(val);
        }
    }
});