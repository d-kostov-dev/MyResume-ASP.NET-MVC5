$('.showModal').on('click', function (evt) {
    evt.preventDefault();
    evt.stopPropagation();

    var modalPlace = $('#ModalPopup');
    //var url = $(this).data('url');
    var url = $(this).attr('href');

    $.get(url, function (data) {
        modalPlace.html(data);
        $('#ModalLayout').modal('toggle');
    });
});