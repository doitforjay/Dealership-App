// UI dailog
$(function () {
    $('#dialog').dialog({
        autoOpen: false,
        width: 500,
        resizable: false,
        title: 'Edit Inventory',
        modal: true,
        buttons: {
            "Close": function () {
                $(this).dialog("close");
            }
        }
    });
    // Display ui dailog on click
    $("#tab").on('click', ".details", function () {
        var me = this,
        $di = $('#dialog');
        $di.load("Dealer/modal",
                function (response, status, xhr) {
                    $di.dialog('open');
                    $('#picture').attr('src', $(me).data('image'));
                    var Make,
                    Model,
                    Color,
                    Year,
                    Miles,
                    $rowthing = $(me).parent().parent().find('td');
                    
                    // Auto fill input fields based on inventory selection
                    Make = $rowthing.eq(0).data('id');
                    Model = $rowthing.eq(1).data('id');
                    Color = $rowthing.eq(2).data('id');
                    Year = $rowthing.eq(3).html();
                    Miles = $rowthing.eq(4).html();
                    $("select#mk").val(Make);
                    $("select#md").val(Model);
                    $("select#cl").val(Color);
                    $(".yr").val(Year);
                    $(".ml").val(Miles);
                });
    });
});

