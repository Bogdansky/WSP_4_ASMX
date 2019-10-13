$(".btn").click(e => {
    var x = parseInt($("#fieldX").val());
    var y = parseInt($("#fieldY").val());
    $.ajax({
        url: "Simplex.asmx/KBA.AddS",
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({
            x: x, y: y
        })
    }).done(data => {
        debugger
        $("#result").html(data.d);
    })
})