$(document).ready(function () {

    $(document).on("click", "#btnEdit", function (e) {
        $.ajax({
            url: "/SaleOrder/EditAddress",
            datatype: "text",
            data: {
                'saleOrderId': $(this).attr('data-saleOrderId')
            },
            type: "GET",
            complete: function () {
                $("form").each(function () { $.data($(this)[0], 'validator', false); });
                $.validator.unobtrusive.parse("form");
            }
        })
        .done(function (partialViewResult) {
            $(".editAddress").html(partialViewResult);
        });
    });

})