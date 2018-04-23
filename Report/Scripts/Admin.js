layui.use(['form', 'layedit', 'laydate'], function () {
    var form = layui.form
        , layer = layui.layer
        , layedit = layui.layedit
        , laydate = layui.laydate
        , $ = layui.$;

    $('#Admin').on('click', function () {
        var win = layer.open({
            content: '<input type="text" id="txAdmin" name="title" lay-verify="title" autocomplete="off" placeholder="此处输入密码" class="layui-input">'
            , btn: ['登陆', '游客']
            , yes: function (index, layero) {
                $.ajax({
                    type: 'post'
                    , url: 'First.aspx'
                    , dataType: 'text'
                    , data: { action: 'ToWCFAndAdmin', name: $('#txAdmin').val() }
                    , success: function (data) {
                        //成功的时候调用的函数
                        //action.SetTbxShowTx('txShow', data);
                    }
                    , error: function (ex) {
                        layer.msg(ex);
                    }
                });
                layer.close(win);
                layer.msg('登陆成功');
            }
            , btn2: function (index, layero) {
                layer.msg('你选择了游客模式..');
            }
        });
    });

    var action = {
        SetTbxShowTx: function (val) {
            
        }
    }
});