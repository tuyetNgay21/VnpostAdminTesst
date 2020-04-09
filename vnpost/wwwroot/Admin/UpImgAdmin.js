$(function () {//tat ca cac phuong thuc o duoi day phai cho lam 1 hàm  nhưng rải ra cho tầm nhìn rõ ràng hơn
    $("#BtnUpLoadFileImgChuDe").click(function () {
        $("#fileUpLoadImgChuDe").trigger("click");
        $("#fileUpLoadImgChuDe").change(function () {
            if (window.FormData !== undefined) {
                fileUpload = $("#fileUpLoadImgChuDe").get(0);
                Fileup = fileUpload.files;
                var formdata = new FormData();
                formdata.append('upload', Fileup[0]);
                $.ajax({
                    type: "Post",
                    url: "/Admin/Theme/UpLoadCKEditor",
                    contentType: false,
                    processData: false,
                    data: formdata,
                    success: function (url) {
                        $("#ImgUpLoadShowUserView").attr("src", url);
                        $(".AnhChuDeAddLen").val(url);
                    },
                    error: function () {
                        alert("có lỗi sảy ra");
                    }
                });
            }
        });
    });

    $("#BtnUpLoadFileImgLoaiChuDe").click(function () {
        $("#fileUpLoadImgLoaiChuDe").trigger("click");
        $("#fileUpLoadImgLoaiChuDe").change(function () {
            if (window.FormData !== undefined) {
                fileUpload = $("#fileUpLoadImgLoaiChuDe").get(0);
                Fileup = fileUpload.files;
                var formdata = new FormData();
                formdata.append('upload', Fileup[0]);
                $.ajax({
                    type: "Post",
                    url: "/Admin/Species/UpLoadCKEditor",
                    contentType: false,
                    processData: false,
                    data: formdata,
                    success: function (url) {
                        $("#ImgUpLoadShowUserView").attr("src", url);
                        $(".AnhChuDeAddLen").val(url);
                    },
                    error: function () {
                        alert("có lỗi sảy ra");
                    }
                });
            }
        });
    });
    $("#BtnUpLoadFileImgPost").click(function () {
        $("#fileUpLoadImgPost").trigger("click");
        $("#fileUpLoadImgPost").change(function () {
            if (window.FormData !== undefined) {
                fileUpload = $("#fileUpLoadImgPost").get(0);
                Fileup = fileUpload.files;
                var formdata = new FormData();
                formdata.append('upload', Fileup[0]);
                $.ajax({
                    type: "Post",
                    url: "/Admin/Post/UpLoadCKEditorSingGer",
                    contentType: false,
                    processData: false,
                    data: formdata,
                    success: function (url) {
                        $("#ImgUpLoadShowUserView").attr("src", url);
                        $(".AnhChuDeAddLen").val(url);
                    },
                    error: function () {
                        alert("có lỗi sảy ra");
                    }
                });
            }
        });
    });
    $("#BtnUpLoadFileImgNav").click(function () {
        $("#fileUpLoadImgNav").trigger("click");
        $("#fileUpLoadImgNav").change(function () {
            if (window.FormData !== undefined) {
                fileUpload = $("#fileUpLoadImgNav").get(0);
                Fileup = fileUpload.files;
                var formdata = new FormData();
                formdata.append('upload', Fileup[0]);
                $.ajax({
                    type: "Post",
                    url: "/Admin/CaroselSinger/UpLoadCKEditor",
                    contentType: false,
                    processData: false,
                    data: formdata,
                    success: function (url) {
                        $("#ImgUpLoadShowUserView").attr("src", url);
                        $(".AnhChuDeAddLen").val(url);
                    },
                    error: function () {
                        alert("có lỗi sảy ra");
                    }
                });
            }
        });
    });
});
