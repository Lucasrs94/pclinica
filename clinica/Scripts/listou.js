$(function () {


    function listaInsumoBack(json) {
        $("#selectInsumo").empty();
        var option = "";
        $.each(json, function (index, value) {
            option = option + '<option value="' + value.IdPaciente + '">' + value.IdPaciente + '</option>';
        });
        $("#selectInsumo").html(option);
    }


});