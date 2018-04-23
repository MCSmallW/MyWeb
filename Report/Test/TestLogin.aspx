<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestLogin.aspx.cs" Inherits="Report.Test.TestLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <%--<script src="TestLogin.css"></script>--%>
    <link rel="stylesheet" src="../Lib/layui/css/layui.css" media="all" />
    <style type="text/css">
        .style1
        {
            height: 64px;
        }
        .style2
        {
            width: 38%;
        }
    </style>
</head>
<body>
            <button data-method="P" id="layerDemo" class="layui-btn layui-btn-danger">输入指令</button>
            <input type="text" id="txShow" name="title" lay-verify="title" autocomplete="off" placeholder="在此处展示值" class="layui-input"/>
           
   
    <script src="../Lib/layui/layui.js" type="text/javascript"></script>
    <script src="TestLogin.js" type="text/javascript"></script>
</body>
</html>
