function onAjaxComplete(data, textStatus) {
    //alert("AJAX completed: data=" + data + ", status=" + textStatus);
}

function onAjaxError(data, textStatus, error) {
    //alert("AJAX error: " + data + ", status=" + textStatus + ", error=" + error);
}

function onTimerTick()
{
    checkInvite();
}

function onTimerResponse(data, textStatus)
{
    $("#interactPanel").html(data);    
}

function checkInvite() {
    $.ajax({
        url: "/home/check_invite",             // указываем URL и
        dataType: "html",                     // тип загружаемых данных
        success: onTimerResponse,
        error: onAjaxError
    });
}

$(window).load(function ()
{
    window.setInterval(onTimerTick, 500);
});