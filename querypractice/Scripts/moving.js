$(document).ready(function () {


    $(".btn1").click(function () {
        $("p").hide(2000);
    });


    $(".btn2").click(function () {
        $("p").show(2000);
    });

    $(".flat").click(function () {
        $("#div1").fadeIn();
    });


});


function feel() {

    var store = document.getElementById('real').value;

    document.getElementById('work').innerHTML=("Hello Joe  " + store);
};






