$(function () {
    var $loginForm = $('#LoginForm');

    $loginForm.submit(function (e) {
        e.preventDefault();

        abp.ui.setBusy(
            $('#LoginArea'),

            abp.ajax({
                contentType: 'application/x-www-form-urlencoded',
                url: $loginForm.attr('action'),
                data: $loginForm.serialize()
            })
        );
    });
});
