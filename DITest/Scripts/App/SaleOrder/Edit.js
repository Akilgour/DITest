$(document).ready(function () {
    $(document).on("click", "#btnCreateDialog", function (e) {
        $.ajax({
            url: "/SaleOrder/CreateDialog",
            datatype: "text",
            data: {},
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
            alert("a");
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

  //(function ($) {
  //    $.validator.unobtrusive.addValidation = function (selector) {
  //        //get the relevant form
  //        var form = $(selector);
  //        // delete validator in case someone called form.validate()
  //        $(form).removeData("validator");
  //        $.validator.unobtrusive.parse(form);
  //    }
  //});

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

var ajaxSuccess = function (e) {
    //alert('this is ajaxSuccess');

    if (e.success) {
        //alert("good")

        $.ajax({
            url: "/SaleOrder/ShowItemList",
            datatype: "text",
            data: {
                'saleOrderId': 1
            },
            type: "GET",
            //complete: function () {
            //    $("form").each(function () { $.data($(this)[0], 'validator', false); });
            //    $.validator.unobtrusive.parse("form");
            //}
        })
              .done(function (partialViewResult) {
                  $('#dialogEdit').modal('hide');

                  $("#itemsList").html(partialViewResult);
              });

      //  $(".itemsList").modal('hide');
        //$('#modal')

      //  $(".modal-content").hide();
    } else {
        alert("bad");
    }
}