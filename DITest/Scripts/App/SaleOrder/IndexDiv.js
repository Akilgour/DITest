$(document).ready(function () {

    var numItems = $('.divTableRowBackgroundColour').length
    var i = 0;
    while (i < numItems) {
        $('.divTableRowBackgroundColour').eq(i).css('background-color', 'red')
        $('.divTableRowBackgroundColour').eq(i + 1).css('background-color', 'blue')
        i = i + 4
    }
})
