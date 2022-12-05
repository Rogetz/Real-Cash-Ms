

namespace RealCashMs.Models;

public class myResult{
    public string resultValue {get;set;} = null!;
    public  int initialValue {get;set;} = 1;

    public void ResultCalculator(){
        if( initialValue == 1){
            resultValue = "Successful";
        }
        else
        {
            resultValue = "Failed Terribly";
        }
    }

}