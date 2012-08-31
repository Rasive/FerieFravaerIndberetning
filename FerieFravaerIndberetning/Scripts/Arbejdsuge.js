$("#arbejdsugeeditbutton").click(function () {
    $(".hidden").removeClass("hidden");
    $(this).parent().parent().addClass("hidden");
});

$(".sum").keyup(function () {
    var sum = 0;
    $(".sum").each(function () {
        sum += Number($(this).val());
    });
    $(".arbejdsugetimersum").html(parseFloat(sum.toFixed(2)));
});