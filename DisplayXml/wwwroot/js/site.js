$("#reloadId").on("click", function () {


    $('#loader').css('display', 'block');
    $('.articles').css('display', 'none');
    (function loading() {
        myVar = setTimeout(showLoading, 1000);
    })();
    
    function showLoading() {
        $('#loader').css('display', 'none');
        $('.articles').css('display', 'block');

        $.get("/Home/Index", {
        });
    }
    
});
