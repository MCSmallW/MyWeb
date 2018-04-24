<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendBug.aspx.cs" Inherits="Report.Component.SendBug" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>反馈页面</title>
    <link rel="stylesheet" href="../Lib/layui/css/layui.css"/>
</head>
<body>
          
<blockquote class="layui-elem-quote layui-text">
  该页面用于反馈问题
</blockquote>

 
<form class="layui-form layui-form-pane" action="">
  
  <div class="layui-form-item layui-form-text">
    <label class="layui-form-label">这里输入问题</label>
    <div class="layui-input-block">
      <textarea placeholder="请输入内容" class="layui-textarea" id="GetBug"></textarea>
    </div>
  </div>
    <div class="layui-form-item">
    <label class="layui-form-label">工号：</label>
    <div class="layui-input-inline">
      <input id="JobNum" type="text" name="username" lay-verify="required" placeholder="请输入工号" autocomplete="off" class="layui-input"/>
    </div>
  </div>
  <div class="layui-form-item">
    <button class="layui-btn" lay-submit="" lay-filter="demo2" id="Submit">提交</button>
  </div>
</form>
          
    <script src="../Lib/layui/layui.js" type="text/javascript"></script>
    <script src="../Scripts/Bug.js" type="text/javascript"></script>
</body>
</html>
