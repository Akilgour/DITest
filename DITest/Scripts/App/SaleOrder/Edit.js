$(document).ready(function () {

    $(document).on("click", "#btnCreateDialog", function (e) {
        $.ajax({
            url: "/SaleOrder/CreateDialog",
            datatype: "text",
            data: { },
            type: "GET",
            complete: function () {
                $("form").each(function () { $.data($(this)[0], 'validator', false); });
                $.validator.unobtrusive.parse("form");
            }
        })
        .done(function (partialViewResult) {
            $(".modal-content").html(partialViewResult);
        });
    });


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
            $(".modal-content").html(partialViewResult);
        });
    });

    $(document).on("click", "#btnRemoveSaleOrder", function (e) {
        $.ajax({
            url: "/SaleOrder/RemoveSaleOrder",
            datatype: "text",
            data: {
                'saleOrderId': $(this).attr('data-saleOrderId'),
                'fullName': $(this).attr('data-fullName')
            },
            type: "GET",
            complete: function () {
                $("form").each(function () { $.data($(this)[0], 'validator', false); });
                $.validator.unobtrusive.parse("form");
            }
        })
        .done(function (partialViewResult) {
            $(".modal-content").html(partialViewResult);
        });
    });

    $(document).on("click", "#btnAdd", function (e) {
        $.ajax({
            url: "/SaleOrder/AddSaleOrderItem",
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
            $(".modal-content").html(partialViewResult);
        });
    });


    $('form').submit(function () {
        if ($(this).valid()) {
            $.ajax({
                url: this.action,
                type: this.method,
                data: $(this).serialize(),
                success: function (result) {
                    $('#ShowTimeName').val("");
                    $('#theaterShowList').html(result);
                }
            });
        }
        return false;
    });
 
})

var ajaxSuccess = function () {
    alert('this is ajaxSuccess');
}
