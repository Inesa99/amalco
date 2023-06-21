 
    //$('.middlemenuelement').hover(function () {
    //    $('.middleborderd').addClass("forwhitebg");
    //});

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".menu-item").on("click", function () {
    //$(this).toggleClass("active-menu");
    var currentChild = $(this).find(".childs");
    $(".childs").not(currentChild).hide();
    $(currentChild).slideToggle();
});
$(function () {
    $.ajaxSetup({ cache: false });
    $('#wrapper').delegate('a.modalform', 'click', function (e) {

        if ($(this).is("[disabled]")) {
            return false;
        }
        $(e.target).closest('.btn-group').children('.dropdown-toggle').dropdown('toggle');
        $('#dialogContent').load(this.href, function () {
            $('#dialogDiv').modal({
                keyboard: true,
                backdrop: 'static',
            }, 'show');
            
        });
        
        return false;
    });
});

 

$(".slider").slick({
    slidesToShow: 3,
    slidesToScroll: 1,
    variableWidth: true,
    arrows: false,
    autoplay: true,
    loop:true,
    responsive: [
        {
            breakpoint: 768,
            settings: {
                slidesToShow: 1
            }
        }
    ],
    infinite: true,
    pauseOnHover: false,
    pauseOnFocus: false,
});

$('form').submit(function (e) {
    e.preventDefault();
    $("form button").text("Отправка").prop("disabled",true);





    var form_data = new FormData(this);

    $.ajax({

        type: 'post',
        url: '/addorder',
        data: form_data,
        cache: false,
        contentType: false,
        processData: false,
        success: function (msg) {
           
            $("form button").text("Отправить").prop("disabled", false);
         
            $('#dialogDiv').modal('show'); 
            $("#myModalLabel").text("Ваша заявка отправлена! Спасибо");
            $("form").reset();
        }

    })
});
   
$(document).on("submit", "#callOrderForm", function (e) {
    e.preventDefault();
   
    var l = Ladda.create(document.querySelector('#callOrderForm button[type=submit]'));

    // Start loading
    l.start();




    var form_data = new FormData(this);

    $.ajax({

        type: 'post',
        url: this.action,
        data: form_data,
        cache: false,
        contentType: false,
        processData: false,
        success: function (msg) {
            if (msg.success) {
                
                $("#callResult").text("Спасибо! Ваша заявка отправлена").show();
            }
            l.stop();
            //$("form button").text("Отправить").prop("disabled", false);

            //$('#dialogDiv').modal('show');
            //$("#myModalLabel").text("Ваша заявка отправлена! Спасибо");
           
        }

    });
});
 
jQuery(function ($) {
    $(".phone-number").mask("+7 999 999-99-99");
});

$(".v-apply").on("click", function (e) {
    e.preventDefault();
    $('#dialogContent').load(this.href, function () {
        $('#dialogDiv').modal({
            keyboard: true,
            backdrop: 'static',
        }, 'show');

        bindForm(this);
    });
});

function DisplayThankYou()
    {
    $('#dialogDiv').modal('show');
    $("#myModalLabel").text("Ваша заявка отправлена! Спасибо");
}