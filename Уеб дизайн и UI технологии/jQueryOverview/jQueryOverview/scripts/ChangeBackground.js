$('#colorBackground').on('change', function () {
    var color = $('#colorBackground').val();
    $('body').css('background', color);
});