$(document).ready(function() {
    $("#AddFavorite").click(function () {

        $.get(getFavoritesPath, function (data) {
            $("#FavoritesPlaceHolder").append(data);
            $("#Favorites:last-child").focus();
        });
    });


    $("#AddPhones").click(function () {

       // Second Way
       // var phonesCount = $("#PhonesCount").val();


        var getPhonesPathNew = "";

        if ($(".indexer input").last().val() != undefined) {
            var sum = parseInt($(".indexer input").last().val(), 10) + parseInt(1, 10)
            getPhonesPathNew = getPhonesPath + '/' + sum;
        }
        if (getPhonesPathNew == "") {
            getPhonesPathNew = getPhonesPath;
        }

        $.get(getPhonesPathNew, function (data) {
            $("#PhonesPlaceHolder").append(data);
            $("#Phones:last-child").focus();
        });
    });
});