<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAX.aspx.cs" Inherits="AspDollNetStudySys.Component.AJAX" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" href="../Lib/layui/css/layui.css" media="all" />
</head>
<body>
    <style type="text/css">
        .layui-form-item > *
        {
            margin-top:20px;
        }
    </style>
    <form id="Form1" class="layui-form" runat="server">
        <div class="layui-form-item layui-col-lg6">
            <label class="layui-form-label">单行输入框</label>
            <div class="layui-input-block">
                <input type="text" id="txShow" name="title" lay-verify="title" autocomplete="off" placeholder="在此处展示值" class="layui-input">
            </div>
        </div>
        <div class="layui-form-item layui-col-lg6">
            <button type="button" id="AjaxGetName" class="layui-btn layui-btn-primary">异步发送，获取数据</button>
            <button type="button" id="GetNameFromWCF" class="layui-btn layui-btn-primary">从WCF服务上获取值</button>
        </div>
    </form>


    <script type="text/javascript" src="../Lib/layui/layui.js"></script>
    <script>
        layui.use(['form', 'layedit', 'laydate'], function () {
            var form = layui.form
                , layer = layui.layer
                , layedit = layui.layedit
                , laydate = layui.laydate
                , $ = layui.$;

            $('#AjaxGetName').on('click', function () {
                var win = layer.open({
                    content: '你的名字是? <br/> <input type="text" id="txInput" name="title" lay-verify="title" autocomplete="off" placeholder="此处输入名字" class="layui-input">'
                    , btn: ['确定', '取消']
                    , yes: function (index, layero) {
                        $.ajax({
                            type: 'post'
                            , url: 'AJAX.aspx'
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
                        layer.msg('值绑定成功');
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
    </script>
</body>
</html>