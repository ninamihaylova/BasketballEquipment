 class BasketballEquipment
 {
     public static void Main(String[] args)
     {
         int annualFee = int.Parse(Console.ReadLine());
         double basketballSneakers = annualFee - annualFee * 0.40;
         double basketballUniform = basketballSneakers - basketballSneakers * 0.20;
         double basketballBall = basketballUniform / 4;
         double basketballAccessories = basketballBall / 5;
         
         double total_price=annualFee+basketballSneakers+basketballUniform+basketballBall+basketballAccessories;
           Console.WriteLine(total_price);  
         
             
     }
 }