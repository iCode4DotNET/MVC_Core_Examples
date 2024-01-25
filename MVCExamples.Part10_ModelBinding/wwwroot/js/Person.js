$(document).ready(function() {
    $("#AddFavorite").click(function () {

        $.get(getFavoritesPath, function (data) {
            $("#FavoritesPlaceHolder").append(data);
            $("#Favorites:last-child").focus();
        });
    });
});