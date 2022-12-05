$(document).ready(function(){
    /* 
    $(".link-item").mouseover(function(){
        /*This style of using the next method is the best because it prevents toggling all instances of the menu item execpt the one thats currnetly in context
        It  enables specificity.*/
        /*next is used for siblings, like brothers and sisters. */
        /*$(this).next(".sub-menu").slideDown();  
        $(".drop-down").AddClass("rotating-drop-down")
    });*/
    $(".drop-down").click(function(){
        $(this).toggleClass("rotating-drop-down");
        $(this).parent().parent().children(".sub-menu").slideToggle();
    });
    /* 
    (".link-item").mouseout(function(){
        $(".drop-down").removeClass("rotating-drop-down");
        $(this).next(".sub-menu").slideUp();
    });*/
});