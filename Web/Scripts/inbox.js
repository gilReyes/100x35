var Inbox = function () {
    var handleEditorInit = function () {
        $('.inbox-wysihtml5').wysihtml5({
            "stylesheets": ["../../assets/global/plugins/bootstrap-wysihtml5/wysiwyg-color.css"]
        });
    }

    var handleDiscardBtn = function () {
        $('.btn-discard').on('click', function (e) {
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
            if ($(this).validate()) {
                $.ajax({
                    url: siteUrl + "Inbox/Compose",
                    type: "POST",
                    data: $(this).serialize()
                }).success(function(data) {
                    $('#Body').html(data);
                    handleEditorInit();
                    handleCompose();
                    handleInbox();
                }).error(function() {
                    showError();
                });
            } else {
                
            }
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
            if ($(this).valid()) {
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
            }
        });
    }

    var handleReply = function () {
        handleMessageReply();
        $('#ReplyBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Reply",
                type: "GET",
                data: { replyingToId: $(this).attr('data-messageid') }
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

    var handleMessageDelete = function () {
        $('#DeletedBtn').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/Delete",
                type: "POST",
                data: { id: $(this).attr('data-messageid') }
            }).success(function (data) {
                $('#Body').html(data);
                handleRead();
                handleCompose();
                handleInbox();
            }).error(function () {
                showError();
            });
        });
    }

    var handleInbox = function () {
        $('#InboxBtn, .goto-inbox-btn').on('click', function (e) {
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
        $('#TrashBtn, .goto-trash-btn').on('click', function (e) {
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
        $('#SentBtn, .goto-sent-btn').on('click', function (e) {
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
                url: siteUrl + "Inbox/ViewInboxMessage",
                type: "GET",
                data: { id: $(this).attr('data-messageid') }
            }).success(function (data) {
                $('#Body').html(data);
                handleMessageDelete();
                handleCompose();
                handleReply();
            }).error(function () {
                showError();
            });
        });

        $('.message-sent').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/ViewSentMessage",
                type: "GET",
                data: { id: $(this).attr('data-messageid') }
            }).success(function (data) {
                $('#Body').html(data);
                handleReply();
            }).error(function () {
                showError();
            });
        });

        $('.message-trash').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: siteUrl + "Inbox/ViewSentMessage",
                type: "GET",
                data: { id: $(this).attr('data-messageid') }
            }).success(function (data) {
                $('#Body').html(data);
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