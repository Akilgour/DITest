$(document).ready(function () {

    var numItems = $('.divTableRowBackgroundColour').length
    var i = 0;
    while (i < numItems) {
        $('.divTableRowBackgroundColour').eq(i).addClass('divTableRowAltBackgroundColour')
        $('.divTableRowBackgroundColour').eq(i + 1).addClass('divTableRowAltBackgroundColour')
        i = i + 4
    }
})
