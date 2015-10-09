var Inbox = function () {
    var handleEditorInit = function () {
        $('.inbox-wysihtml5').wysihtml5({
            "stylesheets": ["../../assets/global/plugins/bootstrap-wysihtml5/wysiwyg-color.css"]
        });
    }

    var handleDiscardBtn = function() {
        $('#btn-discard').on('click', function(e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Inbox",
                type: "GET"
            }).success(function (data) {
                $('#Body').html(data);
                handleRead();
                handleCompose();
            }).error(function () {
                showError();
            });
        });
    }

    var handleMessageCompose = function () {
        handleDiscardBtn();
        $('#ComposeForm').on('submit', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Compose",
                type: "POST",
                data: $(this).serialize()
            }).success(function (data) {
                $('#Body').html(data);
                handleEditorInit();
                handleCompose();
                handleInbox();
            }).error(function () {
                showError();
            });
        });
    }

    var handleCompose = function () {
        handleMessageCompose();
        $('#ComposeBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Compose",
                type: "GET"
            }).success(function (data) {
                $('#Body').html(data);
                handleEditorInit();
                handleCompose();
                handleInbox();
            }).error(function () {
                showError();
            });
        });
    }

    var handleMessageReply = function () {
        handleDiscardBtn();
        $('#ReplyForm').on('submit', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Reply",
                type: "POST",
                data: $(this).serialize()
            }).success(function (data) {
                $('#Body').html(data);
                handleEditorInit();
                handleCompose();
                handleInbox();
            }).error(function () {
                showError();
            });
        });
    }

    var handleReply = function () {
        handleMessageReply();
        $('#ReplyBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Reply",
                type: "GET"
            }).success(function (data) {
                $('#Body').html(data);
                handleEditorInit();
                handleCompose();
                handleInbox();
            }).error(function () {
                showError();
            });
        });
    }

    var handleInbox = function () {
        $('#InboxBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Inbox",
                type: "GET"
            }).success(function (data) {
                $('#Body').html(data);
                handleRead();
                handleCompose();
            }).error(function () {
                showError();
            });
        });
    }

    var handleTrash = function () {
        $('#TrashBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Deleted",
                type: "GET"
            }).success(function (data) {
                $('#Body').html(data);
                handleRead();
                handleCompose();
            }).error(function () {
                showError();
            });
        });
    }

    var handleSent = function () {
        $('#SentBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Outbox",
                type: "GET"
            }).success(function (data) {
                $('#Body').html(data);
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
                $('#Body').html(data);
                handleCompose();
                handleReply();
            }).error(function () {
                showError();
            });
        });
    }

    var handleSelection = function () {
        $('.tab-option').on('click', function (e) {
            e.preventDefault();
            if (!$(this).hasClass('active')) {
                $('.active.tab-option').removeClass('active');
                $(this).addClass('active');
            }
        });
    }

    return {
        init: function () {
            handleInbox();
            handleRead();
            handleTrash();
            handleSent();
            handleCompose();
            handleSelection();
        }
    }
}();