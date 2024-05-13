$(document).ready(function () {
    GetCountry();
    $('#Country').change(function () {
        var id = $(this).val();
        $('#City').empty();
        $('#City').append('<Option> ------- City-------</Option>');
        $.ajax({
            url: '/Resume/City?countryID=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#City').append('<Option value=' + data.id + '/>' + data.name + '</Option>')
                })
            }
        });
    })
})

function GetCountry() {
    $.ajax({
        url: '/Resume/Country',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#Country').append('<Option value=' + data.id + '>' + data.countryName + '</Option>');
            });
        }
    });
}