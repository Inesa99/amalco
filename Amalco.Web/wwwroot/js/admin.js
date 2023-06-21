$(".add-resp").on("click", function () {
    var html = $(".res-input").first().clone().val("");
    $(this).before(html);
});
$(function () {
    $.ajaxSetup({ cache: false });
    $('#wrapper').delegate('a.modalform', 'click', function (e) {

        if ($(this).is("[disabled]")) {
            return false;
        }
        $(e.target).closest('.btn-group').children('.dropdown-toggle').dropdown('toggle');
        $('#dialogContent').load(this.href, function () {
            $('#dialogDiv').modal({
                keyboard: true,
                backdrop: 'static',
            }, 'show');

        });
        return false;
    });
});