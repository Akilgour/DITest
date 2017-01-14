$(document).ready(function () {

    $(document).on("click", "#checkBoxNine", function (e) {
        alert("checkBoxNine click");

        var checked = this.checked
        var clickedElementName = this.name;
        $('form :input').each(function (i, e) {
            if ((e.type == "number") || (e.type == "text")) {
                if (e.name != clickedElementName) {
                    $(e).val("");
                    $(e).prop('disabled', checked);
                }
            }
        });
    })
});