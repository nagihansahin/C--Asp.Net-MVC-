
function errorMes(message, errorTitle) {
    toastr.error(message, errorTitle, toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    })
};

function sucMess(message, sucTitle) {
    toastr.success(message, sucTitle, toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    })
};

function warMess(message, warTitle) {
    toastr.warning(message, warTitle, toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    })
};

function LoginControl() {
    var veri = {
        UserName: $("#UserName").val(),
        Password: $("#Password").val(),
    }

    $.ajax({
        url: "/Login/LoginControl",
        type: "post",
        data: veri,
        success: function(e) {
            if (veri.UserName == "" && veri.Password == "") {
                warMess("Kullanıcı Adı ve Parola Boş Geçilmez", "Hata!");
            }
            else {
                if (e != true) {
                    errorMes("Kullanıcı Adı ve Parola Hatalı", "Hata!");
                    setInterval(function() {
                        window.location.replace("/");
                    }, 3000);
                }
                else {
                    sucMess(veri.UserName, "Hoşgeldin");
                    setInterval(function() {
                        window.location.replace("/Home/Index");
                    }, 3000);
                }
            }
        }
    });
}

function SearchCustomer() {
    var data = {
        Phone: $("#SearchPhone").val()
    };
    $.ajax({
        url: "/Customer/CustomerSearch",
        type: "post",
        data: data,
        success: function (e) {
            if (e != false) {
                $("#CustomerName").attr("disabled","disable");
                $("#CustomerPhone").attr("disabled","disable");
                $("#CustomerAddress").attr("disabled","disable");
                $("#MarketID").attr("disabled", "disable");
                $("#saveData").attr("disabled", "disable");

                $("#CustomerName").val(e.CustomerName);
                $("#CustomerPhone").val(e.CustomerPhone);
                $("#CustomerAddress").html(e.CustomerAddress);
                $("#MarketID").val(e.MarketID);

                errorMes("Müşteri Daha Önce Eklenmiş", "Hata!");
                $("#statusBar").removeAttr("hidden");
                $("#statusBar").addClass("text-danger");
                $("#statusBar").html("Bu Müşteri Ekli Başka Numara Giriniz...")
            }
            else {
                $("#CustomerName").removeAttr("disabled", "disable");
                $("#CustomerPhone").removeAttr("disabled", "disable");
                $("#CustomerAddress").removeAttr("disabled", "disable");
                $("#MarketID").removeAttr("disabled", "disable");

                $("#CustomerName").val("");
                $("#CustomerPhone").val("");
                $("#CustomerAddress").html("");
                $("#MarketID").val(1);

                sucMess("Müşteri Daha Önce Eklenmemiş", "Müşteri Eklenebilir...")
                $("#statusBar").removeAttr("hidden");
                $("#statusBar").addClass("text-success");
                $("#statusBar").removeClass("text-danger");
                $("#statusBar").html("Bu Müşteri Eklenmemiş Yeni Müşteri Olarak Ekleyebilirsiniz...")

                $("#saveData").removeAttr("disabled", "disable");
            }
        }
    })

}