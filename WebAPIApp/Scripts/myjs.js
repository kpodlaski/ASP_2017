function kliknieto() {
    //alert('Klik');
    var content2 = document.getElementById("Content2");
    content2.style.color = "blue";
    for (i = 0; i < 30; i++) {
        content2.innerHTML += "<button >" + i + "</button>";
    }

    content2.fun = function () {
        //...
    }
}

$(document).ready(function () {

    $('button').click(function () {
        alert('new klik');
        $('#Content2').toggle();
        $(".myClass").css({ 'color': 'yellow' });
    });

    $('#GetButton').click(function () {
        $.ajax({
            url: 'http://localhost:62899/api/Authors',
            type: 'GET', //POST,PUT,DELETE
            //data: 'twitterUsername=jquery4u',
            success: function (_data) {
                //called when successful
                alert(JSON.stringify(_data));
                alert(_data[0].Sname);
            },
            error: function (e) {
                //called when there is an error
                alert(e.message);
            }
        });
    });

    var nobiekt = {
        "Name": "Adam",
        "Surname": "Mickiewicz",
        "Sname": "A. Mickiewicz"
    };

    $('#PostButton').click(function () {
        $.ajax({
            url: 'http://localhost:62899/api/Authors',
            type: 'POST', 
            data: nobiekt,
            success: function (_data) {
                //called when successful
                alert(JSON.stringify(_data));
            },
            error: function (e) {
                //called when there is an error
                alert(e.message);
            }
        });
    });

});