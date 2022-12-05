namespace RealCashMs.Models;

// frontend model. Its method is used by the Customer model to calculate the cost of a customers order based on the meal type and the meal quantity in the sorted dictionary.
public class CustomerFeeCalc{
    public static int amountCalc(SortedDictionary<int,int> mealVsQuantity){
        int totalAmount = 0;
        // find a way of traversing through the dictionary
        // for each key, multiply its price from the meal table.
        // Then multiply the price by the quantity, to get its total payable amount.
        // After getting each payable amount of a key increment the totalAmount each time.
        foreach(KeyValuePair<int,int> kvp in mealVsQuantity){
            totalAmount += kvp.Key * kvp.Value;
        }
        return totalAmount;        
    }
}