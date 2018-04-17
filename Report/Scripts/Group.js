layui.use('table', function () {
    var table = layui.table;

    table.render({
        elem: '#Group'
        , url: '/demo/table/user/'
        , page: { //支持传入 laypage 组件的所有参数（某些参数除外，如：jump/elem） - 详见文档
            layout: ['limit', 'count', 'prev', 'page', 'next', 'skip'] //自定义分页布局
            //,curr: 5 //设定初始在第 5 页
            , groups: 1 //只显示 1 个连续页码
            , first: false //不显示首页
            , last: false //不显示尾页

        }
        , cols: [[
            { field: 'id', width: 80, title: 'ID', sort: true }
            , { field: 'username', width: 100, title: '用户名' }
            , { field: 'city', width: 80, title: '城市' }
            , { field: 'sign', title: '签名', minWidth: 150 }
            , { field: 'experience', width: 80, title: '积分', sort: true }
            , { field: 'score', width: 80, title: '评分', sort: true }
            , { field: 'classify', width: 80, title: '职业' }
            , { field: 'wealth', width: 135, title: '财富', sort: true }
        ]]

    });
});