$(function () {
   
    $("a.detail").click(function () {
        const id = $(this).attr('data-app-id');
        document.location.href = "/Tender/Details" + id;

        /*
        $.ajax({
            url:"/Tender/Details" + id,
            success: function(result){}
        });
        */
    });
});