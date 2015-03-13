var YOUR_TURN = "Your turn!";
var OTHER_TURN = "Your opponent turn.";
var WAIT_OPPONENT = "Waiting your opponent for accept your invintation...";
var LEAVE_GAME = "Your opponent has leaved the game! You are win!"
var YOU_WIN = "Your win!";
var OPPONENT_WIN = "You lose! Game over!"

function load(iName, source) {
    document.images[iName].src = source;
}

function click_handler(elemId) {
    turn = $("#turn").val();

    // in case of our turn
    if (turn != "0") {              
        var cell = $("#" + elemId);
        if (cell.attr("class") == "empty_cell") {
            var playerColor = getPlayerColor();
            if (playerColor == "red")
                cell.attr("class", "red_cell");
            else if (playerColor == "blue")
                cell.attr("class", "blue_cell");
            else
                alert("Error: unknown player color");

            makeTurn(playerColor, elemId);
        }        
    }
}

function getPlayerColor(){
    return  $("#player_color").val();
}

function isGameOver() {
    return $("#winner").val() != "null";
}

function makeTurn(playerColor, elemId) {
    $.ajax({
        url: "/home/turn?player=" + playerColor + "&cell=" + elemId,             // указываем URL и
        dataType: "json",                     // тип загружаемых данных
        success: onTurnSuccess,
        error: onAjaxError,
        complete: onAjaxComplete
    });
}

function onTurnSuccess(data, textStatus) {
    if (data == null)
        window.location = "index";
    else if (data == "win") {
        $("#winner").val(getPlayerColor());
        $("#turn").val("0");
        message(YOU_WIN);
    }
    else {
        $("#turn").val("0");
        message(OTHER_TURN);
    }
}

function onAjaxComplete(data, textStatus) {
    //alert("AJAX completed: data=" + data + ", status=" + textStatus);
}

function onAjaxError(data, textStatus, error) {
    //alert("AJAX error: " + data + ", status=" + textStatus + ", error=" + error);
}

function onTimerTick() {    
    if (!isGameOver())
        checkTurn();
}

// response for check_turn
function onTimeCheckTurnResponse(data, textStatus) {
    if (isGameOver())
        return;
    else if (data == "GameLeave")
        window.location = "index?message=Your opponent leaved the game";
    else if (data == "opponent_win") {
        message(OPPONENT_WIN);
        $("#winner").val(getPlayerColor() == "red" ? "blue" : "red");
        initField();
    }   
    else if (data != null) {
        $("#turn").val("1");
        message(YOUR_TURN);
        showField(data);
    }
    
}

function showField(field) {
    $.each(field, function (key, value) {
        $("#" + value.Name).attr("class", value.Sign == 1 ? "red_cell" : "blue_cell");
    });
}

function checkTurn() {
    $.ajax({
        url: "/home/check_turn",             // указываем URL и
            dataType: "json",                     // тип загружаемых данных
            success: onTimeCheckTurnResponse,
            error: onAjaxError
        });
}

function getFieldResponse(data, textStatus)
{
    showField(data);
}

function initField() {
    $.ajax({
        url: "/home/get_field",
        dataType: "json",
        success: getFieldResponse
        });
}

$(window).load(function () {
    window.setInterval(onTimerTick, 500);

    initField();
    if (!isStarted())
        message(WAIT_OPPONENT);
    //else if ()
    else if ($("#turn").val() == "1")
        message(YOUR_TURN);
    else
        message(OTHER_TURN);

    $("#lower_message").text("Your color is " + $("#player_color").val());
});

function isStarted() {
    var w;
    w = $("#started").val()
    return w != "0";
}

function message(text) {
    $("#message").text(text);
}