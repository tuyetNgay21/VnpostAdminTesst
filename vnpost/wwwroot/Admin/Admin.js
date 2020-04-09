$(document).ready(function () {
    CKEDITOR.replace('editor', {
        height: 400,
        filebrowserUploadUrl: '/Admin/Post/UpLoadCKEditor'
    });
    $('.SaveCkEditor').click(() => {
        var editorText = CKEDITOR.instances['editor'].getData();
    });
    $('.ViewCkEditor').click(() => {
        var editorText = CKEDITOR.instances['editor'].getData();
        $('#ViewDataCKEditor').html(editorText);
        $('.ContentPostViewAdmin').val(editorText);
    });
});

