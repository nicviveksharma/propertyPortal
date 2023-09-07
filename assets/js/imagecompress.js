var fileReader = new FileReader();
var filterType = /^(?:image\/bmp|image\/cis\-cod|image\/gif|image\/ief|image\/jpeg|image\/jpeg|image\/jpeg|image\/pipeg|image\/png|image\/svg\+xml|image\/tiff|image\/x\-cmu\-raster|image\/x\-cmx|image\/x\-icon|image\/x\-portable\-anymap|image\/x\-portable\-bitmap|image\/x\-portable\-graymap|image\/x\-portable\-pixmap|image\/x\-rgb|image\/x\-xbitmap|image\/x\-xpixmap|image\/x\-xwindowdump)$/i;

fileReader.onload = function (event) {
    var image = new Image();

    image.onload = function () {
        var canvas = document.createElement("canvas");
        max_size = 600, // TODO : pull max size from a site config
            width = image.width,
            height = image.height;
        if (width > height) {
            if (width > max_size) {
                height *= max_size / width;
                width = max_size;
            }
        } else {
            if (height > max_size) {
                width *= max_size / height;
                height = max_size;
            }
        }
        canvas.width = width;
        canvas.height = height;
        var context = canvas.getContext("2d");
        context.drawImage(image, 0, 0, image.width, image.height, 0, 0, canvas.width, canvas.height);
        document.getElementById("ContentPlaceHolder1_ucProperty_imgpreview").src = canvas.toDataURL('image/jpeg', 0.8);
        document.getElementById("ContentPlaceHolder1_ucProperty_imgpreview").height = "100";
        document.getElementById("ContentPlaceHolder1_ucProperty_imgpreview").width = "100";
        document.getElementById("hidimagefile").value = canvas.toDataURL('image/jpeg', 0.8);
        //document.getElementById("fileuploadcustom").value = "";
    }
    image.src = event.target.result;
};

var loadImageFile = function () {
    var uploadImage = document.getElementById("fileuploadcustom");

    //check and retuns the length of uploded file.
    if (uploadImage.files.length === 0) {
        return;
    }

    //Is Used for validate a valid file.
    var uploadFile = document.getElementById("fileuploadcustom").files[0];
    if (!filterType.test(uploadFile.type)) {
        alert("Please select a valid image.");
        return;
    }

    fileReader.readAsDataURL(uploadFile);
}