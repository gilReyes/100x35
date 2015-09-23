var Inbox = function () {
    var handleEditorInit = function () {
        $('.inbox-wysihtml5').wysihtml5({
            "stylesheets": ["../../assets/global/plugins/bootstrap-wysihtml5/wysiwyg-color.css"]
        });
    }

    var handleCompose = function () {
        $('#ComposeBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Compose",
                type: "GET"
            }).success(function (data) {
                $('#InboxBody').html(data);
                handleEditorInit();
                handleCompose();
                handleInbox();
            }).error(function () {
                showError();
            });
        });
    }

    var handleReply = function () {
        $('#ReplyBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Reply",
                type: "GET"
            }).success(function (data) {
                $('#InboxBody').html(data);
                handleCompose();
                handleInbox();
            }).error(function () {
                showError();
            });
        });
    }

    var handleInbox = function() {
        $('#InboxBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Inbox",
                type: "GET"
            }).success(function (data) {
                $('#InboxBody').html(data);
                handleRead();
                handleCompose();
            }).error(function () {
                showError();
            });
        });
    }

    var handleRead = function () {
        $('.message').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/View",
                type: "GET",
                data: { id: $(this).attr('data-messageid') }
            }).success(function (data) {
                $('#InboxBody').html(data);
                handleCompose();
                handleReply();
            }).error(function () {
                showError();
            });
        })
    }

    return {
        init: function () {
            handleInbox();
            handleRead();
        }
    }
}();