
namespace RealCashMs.Models;

public class ImageClass{
    public string ImgName{get;set;} = null!;
    public string Name{get;set;} = null!;

    public int Price{get;set;}
    public int Quantity{get;set;} = 1;

    public ImageClass(string imgName, string name, int price){
        ImgName = imgName;
        Name = name;
        Price = price;
    }
    public ImageClass(){

    }
}