$(".btn").click(e => {
    var x = parseInt($("#fieldX").val());
    var y = parseInt($("#fieldY").val());
    $.ajax({
        url: "http://localhost:4040/Simplex.asmx/KBA.AddS",
        data: {
            x, y
        }
    }).done(data => {
        $("#result").html(data);
    })
})