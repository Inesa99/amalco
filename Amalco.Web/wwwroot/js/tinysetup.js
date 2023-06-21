$(document).ready(function () {

    tinymce.init({
        selector: "textarea.tiny",
        width: 708,
        height: 600,
        theme: "modern",
        schema: "html5",
        image_advtab: true,
        relative_urls: false,
        convert_urls: false,
        remove_script_host: true,
        paste_as_text: true,
        fontsize_formats: "8px 9px 10px 11px 12px 13px 14px 15px 16px 17px 18px 19px 20px 21px 22px 23px 24px 25px 30px 32px 34px 36px",
        plugins: [
            "advlist autolink lists link image charmap print preview hr anchor pagebreak", "autoresize",

            "searchreplace wordcount visualblocks visualchars code fullscreen",
            "insertdatetime media nonbreaking save table contextmenu directionality",
            "emoticons template paste textcolor"],
        toolbar: "insertfile undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image  preview media | forecolor backcolor emoticons| fontsizeselect fontselect",
        fontsize_formats: "8px 9px 10px 11px 12px 13px 14px 15px 16px 17px 18px 19px 20px 21px 22px 23px 24px 25px 30px 32px 34px 36px",
        style_formats: [
            { title: 'H1', block: 'h1' },
            { title: 'H2', block: 'h2' },
            { title: 'H3', block: 'h3' },
            { title: 'H4', block: 'h4' },
            { title: 'H5', block: 'h5' },
            { title: 'H6', block: 'h6' },
            { title: 'Bold', inline: 'b' },
            { title: 'Strong', inline: 'strong' },
            { title: 'Italic', inline: 'i' }
        ],
        formats: {
            bold: { inline: 'b' },
            italic: { inline: 'i' },
            customformat: { inline: 'span', attributes: { 'id': 'serviceForm' } }
        },
    });
});

$(document).ready(function () {
    $("#imageUploadForm").change(function () {
        var css = "style='"+ $("#imgcss").val()+"'";
        var formData = new FormData();
        var totalFiles = document.getElementById("imageUploadForm").files.length;
        for (var i = 0; i < totalFiles; i++) {
            var file = document.getElementById("imageUploadForm").files[i];

            formData.append("image", file);
        }
        $.ajax({
            type: "POST",
            url: '/Admin/ServiceManage/Upload',
            data: formData,
            dataType: 'json',
            contentType: false,
            processData: false,
            success: function (response) {
                if (response.success) {
                    tinyMCE.activeEditor.execCommand("mceInsertContent", true, "<img src='/images/uploads/" + response.message + "' class='img-responsive' "+css+" />");
                }
                else {
                    alert("errror");
                }
            },
        });
    });
});