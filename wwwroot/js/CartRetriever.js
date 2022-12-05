$(document).ready(function(){
    $(".CartForm").submit(function(e){
        e.preventDefault();
        $.ajax({
            url: "/Api/Cart",
            method : "POST",
            contentType: "application/json",
            // simply eliminated the datatype part that restricted the type of data that it needed to receive and it worked.
            data : JSON.stringify({ImgName:this.elements["ImgName"].value,Name:this.elements["Name"].value, Price:this.elements["Price"].value,Quantity : "1"}) 
            ,
            success : function(data,textStatus,jQXHR){
                alert("Aded to the cart successfully");
                console.log("added" +JSON.parse(data)+"to the cart successfully Confirm if this is the data you wanted");
            },
            error: function(err){
                alert("an error occured:-"+err.ImgName);
                console.error(err);
            }
        });
    });
});


/*$(document).ready(function(){
    $(".CartForm").submit(function(e){
        e.preventDefault();
        $.ajax({url: "Api/Cart",contentType: "application/json",method:"POST"},data : JSON.stringify({ImgName:this.elements["ImageName"].value,Name:this.elements["Name"].value, Price:this.elements["Price"].value})
        ,success: function(data){
            alert("Added to cart successfully");
            }
        });
    });
});*/
