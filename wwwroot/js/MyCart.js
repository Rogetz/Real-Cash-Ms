/*$(document).ready(function(){
    var finalSummaryTotal = 0;
    var changed = false;
    function finalSummaryCalc(){
        $(".subTotal").each(function(index,subtotalField){
            var multiplier = parseFloat($(subtotalField).siblings(".cart-input input").val());
            var inputValue = parseFloat($(subtotalField).siblings(".priceClass").text());
            var subTotalGenerated = multiplier * inputValue;
            finalSummaryTotal += subTotalGenerated.toFixed();
        });
        return finalSummaryTotal;
    }
    $(".side-subTotal").text(finalSummaryCalc().toFixed(2));
        $(".cart-input input").click(function(){
            if(changed == false){
                $(this).css("background-image","linear-gradient(rgba(50,0,255,0.9),rgba(255,150,50,0.8))");
                changed = true;
            }
            else{
                $(this).css("background-image","linear-gradient(rgba(255,255,255,0.5),rgba(150,100,255,0.8))");
                changed = false;
            }
        }
    );
    $(".cart-input input").change(function(){
        // for the input data use the val instead of the text
        var quantityInput = parseFloat($(this).val());
        var frontEndPrice = parseFloat($(this).siblings(".priceClass").text());
        var FinalPrice = quantityInput * frontEndPrice;
        finalSummaryTotal -= parseFloat($(this).siblings(".subTotal").text());
        finalSummaryTotal += FinalPrice.toFixed(2);
        $(this).siblings(".subTotal").text(FinalPrice.toFixed(2));
        $(".side-subTotal").text(finalSummaryTotal);
    });
}
);*/
$(document).ready(function(){

    /*function subTotalCalc(){
        var finalSubTotal = parseInt($(".priceClass").text()) * parseInt($(".cart-Input input").val());
        return finalSubTotal;
    }*/

    $("tr").each(function(){
        var pricing = parseInt($(this).children(".priceClass").text());
        // Be very carefull even simple mistyping erors can cause some serious damage.
        var quantityValue = parseFloat($(this).children(".cart-input").children("input").val());
        var finalValue = pricing*quantityValue;
        
        $(this).children(".subTotal").text(finalValue);
    });
    
    $(".cart-input").children("input").change(function(){
        var inputValue = parseFloat($(this).val());
        var priceValue = parseFloat($(this).parent().siblings(".priceClass").text());
        var finalSubTotal = inputValue * priceValue;
        $(this).parent().siblings(".subTotal").text(finalSubTotal);
        //added this for the side subtotal to update.
        $(".side-subTotal").text(sideTotalCalc());
    }); 
     
    
    function  sideTotalCalc(){
        let sideTotal = 0;
        $(".subTotal").each(function(){
            sideTotal += parseFloat($(this).text());
        });
        return sideTotal.toFixed();
    }
    $(".side-subTotal").text(sideTotalCalc());
    /*$(".cart-input").click(function(){
        let inputValue;
        $(this).children("input").change(function(){
            inputValue = parseFloat($(this).val()); 
        }
        );
        var priceValue = parseFloat($(this).siblings(".priceClass").text());
        var finalSubTotal = inputValue * priceValue;
        $(this).siblings(".subTotal").text(finalSubTotal.toFixed(2));
    }); */
    //$(".priceClass").text(700);
    /*$(".subTotal").text(subTotalCalc());*/
    //$(".cart-input input").val(5);
});