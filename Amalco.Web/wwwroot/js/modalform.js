

 
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
            $('#DOB').flatpickr({
                dateFormat: 'd.m.Y',

            });
            bindForm(this);
        });
        return false;
    });
});



$('#createForm').on('show.bs.modal', function (e) {
    var taskFlatpickrConfig = {
        mode: "range"
    };

    var test = flatpickr("#DOB", taskFlatpickrConfig);
})
function bindForm(dialog) {
    var form = $('form', dialog);
    if (!form.length) {
        return;
    }

    $.validator.unobtrusive.parse(form);

    if (form.find('.dropzone').length) {
        if (form[0].dropzone) {
            return;
        }

        form.dropzone({
            previewsContainer: ".dropzone-previews",
            clickable: '.dropzone-previews',

            autoProcessQueue: false,
            uploadMultiple: true,
            parallelUploads: 100,
            maxFiles: 100,
            acceptedFiles: 'image/*',

            init: function () {
                var myDropzone = this;

                this.element.querySelector("button[type=submit]").addEventListener("click", function (e) {
                    e.preventDefault();
                    e.stopPropagation();

                    if ($(form).valid()) {
                        $(form).find('.btn').attr('disabled', 'disabled');
                        $(form).find("a").removeAttr('href');

                        if (myDropzone.files && myDropzone.files.length) {
                            myDropzone.processQueue();
                        }
                        else {
                            performAjaxPost(form);
                        }
                    }

                });

                this.on('success', function (file, result) {
                    handleResponse(result);
                })
            }
        });
    }
    else {

        $(form).submit(function () {
            if ($(this).valid()) {

                $(this).find('.btn').attr('disabled', 'disabled');
                $(this).find("a").removeAttr('href');

                performAjaxPost($(this));
            }
            return false;
        });
    }
}

function performAjaxPost(form) {
    var formdata= new FormData(form)
    $.ajax({
        url: form.attr('action'),
        type: form.attr('method'),
        data:formdata/* $(form).serialize()*/,
        processData:false,
        success: function (result) {
            handleResponse(result);
        }
    });
}

function handleResponse(result) {
    if (result.success) {
        $('#dialogDiv').modal('hide');
        //if (result.replaceUrl) {
        //    if ($("#replacetarget").length) {
        //        $('#replacetarget').load(result.replaceUrl);
        //    }
        //}
        //else
        if (result.redirectUrl) {
            location.href = result.redirectUrl;
        }
        else {
            location.reload();
        }
        //location.reload();
    }
    else {
        $('#dialogContent').html(result);
        bindForm($('#dialogContent'));
    }
}



$(".modalform").on("click", function (e) {
   
    e.preventDefault();
    $('#dialogContent').load(this.href, function () {
        $('#dialogDiv').modal({
            keyboard: true,
            backdrop: 'static',
        }, 'show');
        
        
    });
    return false;
});

