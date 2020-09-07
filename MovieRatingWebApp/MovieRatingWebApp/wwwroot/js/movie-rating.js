$(function () {
    $("img.rating").mouseover(function () {
        //giveRating($(this), "star-filled.jpg");
        //$(this).css("cursor", "pointer");
    });

    $("img.rating").mouseout(function () {
        //giveRating($(this), "star-empty.png");
        //refilRating($(this));
    });

    $("img.rating").click(function (e) {
        $(this).css('color', 'red');
        giveRating($(this), "star-filled.jpg");
        $(this).css("cursor", "pointer");

        // calls SaveRating method ( ajax ) to update the database
        var url = "/Ratings/SaveRating?rate=" + parseInt($(this).attr("id")) + "&movieId=" + parseInt($(this).attr("movieId"));

        $.post(url, null, function (data) {
            console.log(data);

        });

    });

});

function giveRating(img, image) {
    img.attr("src", "/Images/" + image).prevAll("img.rating").attr("src", "/Images/" + image);
}

function refilRating(img1) {
    var rt = $(img1).closest('tr').find("span.avr").text();
    var img = $(img1).closest('tr').find("img[id='" + parseInt(rt) + "']");
    img.attr("src", "/images/star-filled.png").prevAll("img.rating").attr("src", "/images/star-filled.jpg");
}