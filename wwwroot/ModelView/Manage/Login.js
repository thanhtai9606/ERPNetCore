
var HTMLLogin = (function () {
   toastr.options = {
        "closeButton": true,
        "debug": false,
        "progressBar": false,
        "positionClass": "toast-top-right",
        "onclick": null,
        "showDuration": "400",
        "hideDuration": "1000",
        "timeOut": "2000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
    var validLogin = function () {

        var currentUser = $('#form').serialize();       
        // ajax load process and valid Login
        $.ajax({
            url: "/Authentication/ValidateLogin/",
            type: "POST",
            data: currentUser,
            dataType: "JSON",
            success: function (data) {
                //console.log(data.statusCode);
                if (data.statusCode === 200) //if success close modal and reload ajax table
                {
                    toastr.success(data.status, "Đăng nhập thành công!");                   
                    window.setTimeout(function () {
                        window.location.href = '/Dashboards/Dashboard_1';
                    }, 1000);
                }
                else
                    if (data.statusCode === 400) {
                        toastr.warning(data.status, "Lỗi đăng nhập!");
                        //window.setTimeout(function () {
                        //    window.location.href = 'Login';
                        //}, 2000);
                    }

            },
            error: function (jqXHR, textStatus, errorThrown) {
               toastr.error('Error adding / update data ' + textStatus);
            }
        });

    }
    return {
        resetForm: function () {
            $('#form2')[0].reset(); // reset form on modals
        },
        loginEvent : function () {           
            document.addEventListener("keydown", function (event) {               
                if (event.keyCode === 13) {
                    validLogin();
                }
            });
        },
        onClick: function () {
            validLogin();
            
        },
       
    }
    
})();
HTMLLogin.loginEvent();

