$("input[name=godkend]").click(function () {
    var id = $(this).parent().parent().attr("id");
    var type = $(this).parent().parent().parent().parent().attr("id");
    var url = "/Leader/Godkend?id=" + id + "&type=" + type;
    alert(url);
    $.get(url);
    $(this).parent().parent().attr("class", "green");
});

$("input[name=afvis]").click(function () {
    var id = $(this).parent().parent().attr("id");
    var type = $(this).parent().parent().parent().parent().attr("id");
    var url = "/Leader/Afvis?id=" + id + "&type=" + type;
    $.get(url);
    $(this).parent().parent().attr("class", "red");
});