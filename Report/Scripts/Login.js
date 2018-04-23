layui.use(['form', 'layedit', 'laydate'], function () {
    var form = layui.form
        , layer = layui.layer
        , layedit = layui.layedit
        , laydate = layui.laydate
        , $ = layui.$;

    $('#Admin').on('click', function () {
        var win = layer.open({
            content: '<label class="layui-form-label">请输入密码：</label> <br/> <input type="text" id="txInput" name="title" lay-verify="title" autocomplete="off" placeholder="此处输入密码" class="layui-input">'
            , btn: ['登陆', '游客']
            , yes: function (index, layero) {
                $.ajax({
                    type: 'post'
                    , url: 'First.aspx'
                    , dataType: 'text'
                    , data: { action: 'ToWCFAndReturnName', name: $('#txInput').val() }
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
        SetTbxShowTx: function (id, val) {
            $('#' + id).val(val);
        }
    }
});
//layui.use('layer', function () { //独立版的layer无需执行这一句
//    var $ = layui.$, layer = layui.layer; //独立版的layer无需执行这一句

//    $('#Admin').on('click', function () { showLogin(); })

//    function showLogin() {
//        layer.open({
//            type: 1
//            , title: false //不显示标题栏
//            , closeBtn: false
//            , area: '300px;'
//            , shade: 0.8
//            , id: 'LAY_layuipro' //设定一个id，防止重复弹出
//            , btn: ['登陆', '游客']
//            , btnAlign: 'c'
//            , moveType: 1 //拖拽模式，0或者1
//            , content: '<br/><input type="text" name="username" lay-verify="title" autocomplete="off" placeholder="账号" class="layui-input"><br/><input type="text" name="pwd" lay-verify="title" autocomplete="off" placeholder="密码" class="layui-input">'
//            , success: function (layero) {
//                var btn = layero.find('.layui-layer-btn');
//                btn.find('.layui-layer-btn0').attr({
//                    href: ''
//                    , target: '_blank'
//                });
//                //登陆成功后 都隐藏输入指令，显示退出按钮
//            }
//        });
//    }

//    //window.onload = function () {
//    //    //判断 有三种状态，0没登陆，1登陆，2游客
//    //    if (1 == 1) {
//    //        //showLogin();
//    //    }
//    //};
//})