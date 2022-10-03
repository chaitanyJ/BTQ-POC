
function AjaxSubmit() {
    alert("hello")
    var url = $("#myForm").attr("action");
    var m = JSON.stringify($("#myForm").serializeArray());
    console.log(m)
    $.ajax({
        type: 'POST',
        url: url,
        data: m,
    })
    });
}
