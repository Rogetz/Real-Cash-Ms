namespace RealCashMs.Models;

// FrontEnd model
// This is a frontend model no wonder it has a list of items.
public class Cart{
    public List<ImageClass> imgObjects{get;set;} = new List<ImageClass>();

    public void AddToCart(ImageClass imageInstance){
        imgObjects.Add(imageInstance);
    }
}