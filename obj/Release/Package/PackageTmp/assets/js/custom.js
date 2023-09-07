(function ($) {
    'use strict';
    $(".loginpassword").on("blur", function () {
        let hashedvalue = $(".loginpassword").val();
        if (hashedvalue.length > 0) {
            hashedvalue = sha1(hashedvalue);
        }
        else {
            hashedvalue = '';
        }
        $(".loginpassword").val(hashedvalue);
        $(".loginpassword").prop("disabled", true);
    });
    $(".loginpassword2").on("blur", function () {
        let hashedvalue = $(".loginpassword2").val();
        if (hashedvalue.length > 0) {
            hashedvalue = sha1(hashedvalue);
        }
        else {
            hashedvalue = '';
        }
        $(".loginpassword2").val(hashedvalue);
        //$(".loginpassword2").prop("disabled", true);
    });

})(jQuery);