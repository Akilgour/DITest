$(document).ready(function () {

    $(document).on("click", "#checkBoxNine", function (e) {
        alert("checkBoxNine click");
        //  alert(e.val());

        var clickedElementName = this.name;
        $('form :input').each(function (i, e) {
            if (e.name != clickedElementName) {
               // $(e).css('backgroundColor', 'red');
                $(e).val("");
                $(e).prop('disabled', true);
            }
        });
        this.prop('disabled', false);
    })
});