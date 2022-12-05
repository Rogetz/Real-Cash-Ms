
var splashText = document.querySelector(".splash-text");
var logo = document.querySelector(".logo");
var splashDiv = document.querySelector(".splash-div");
var splashLetter = document.querySelectorAll(".splash-letter");
let letterInitialTimeout = 0;

window.addEventListener("load", function(){
    logo.classList.add("active");
    splashText.classList.add("active");   
    splashLetter.forEach(function (letter, index){
        letterInitialTimeout += 200;
        this.setTimeout(function(){
            letter.classList.add("active");
        },letterInitialTimeout)
    });
    this.setTimeout(function(){
       splashDiv.classList.add("offline"); 
    },5000);
    /*added for the togglemenu header*/
    $(".menu-titles").click(function(){
        $(".menu-titles").children(".drop-down-group").removeClass("active");
        $(this).children(".drop-down-group").addClass("active");
        /*not tested the rotate feature, taste it later though.*/
        $(this).next(".fa-circle-chevron-down").css("rotate : -90deg");
    });
});
