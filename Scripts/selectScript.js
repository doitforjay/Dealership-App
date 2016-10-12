// Select list get selected function

$(document).ready(function () {
    $('#dealers').change(function () {
        var dlr = $("#dealers option:selected").index();
        var nm = $("#dealers option:selected").html();
        var offset = dlr + 1;
        $.get("Dealer/FilterTable", { ID: offset }, function (data) {
            $('#tab').html(data)
            $('#nme').html(nm)
        })

    })

});


