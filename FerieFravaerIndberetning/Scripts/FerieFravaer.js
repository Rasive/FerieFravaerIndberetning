var selected;
$("[name=Indberetningstype]").change(function () {
    if (selected != null)
        selected.addClass("hidden");
    $("#" + $(this).val()).removeClass("hidden");
    selected = $("#" + $(this).val());
});

$(document).ready(function () {
    $('input:text.date.time').datetimepicker({
        dateFormat: "dd-mm-yy",
        timeFormat: "hh:mm"
    });
    $('input:text.date').datepicker({
        dateFormat: "dd-mm-yy"
    });
});

var Ferie_FoersteFeriedag = $("#Ferie_FoersteFeriedag");
var Ferie_SidsteFeriedag = $("#Ferie_SidsteFeriedag");
$("input:text.date").change(function () {
    if (Ferie_FoersteFeriedag.val().length > 0 && Ferie_SidsteFeriedag.val().length > 0) {
        var datearr, fromYear, fromMonth, fromDay, toYear, toMonth, toDay;

        datearr = Ferie_FoersteFeriedag.val().split("-");
        fromDay = datearr[0];
        fromMonth = datearr[1];
        fromYear = datearr[2];

        datearr = Ferie_SidsteFeriedag.val().split("-");
        toDay = datearr[0];
        toMonth = datearr[1];
        toYear = datearr[2];

        var url = "/FerieFravaer/CalcFeriedageOgTimer?fromYear=" + fromYear + "&fromMonth=" + fromMonth + "&fromDay=" + fromDay + "&toYear=" + toYear + "&toMonth=" + toMonth + "&toDay=" + toDay;
        $.get(url, function (data) {
            var dataarr = data.split(";");
            $("#Feriedage").html(dataarr[0]);
            $("#Ferietimer").html(dataarr[1]);
        });
    }
});