namespace Exam1;

public interface IStrategy{

}

public class NoDiscountStrategy : IStrategy{
    public double percent = 0.0;
}
public class PercentageDiscountStrategy : IStrategy{
    public double percent;
    public PercentageDiscountStrategy(double off){
        this.percent = off;
    }
}
public class PricingEngine : IStrategy{
    public double discount;
    NoDiscountStrategy Strategy_N;
    PercentageDiscountStrategy Strategy_P;
    public PricingEngine(NoDiscountStrategy strat){
        this.Strategy_N = strat;
    }
    public PricingEngine(PercentageDiscountStrategy strat){
        this.Strategy_P = strat;
    }
    public void SetStrategy(object strat){
        if (strat is NoDiscountStrategy){
            discount = 0.0;
        }
        else{
            PercentageDiscountStrategy strattemp = strat as PercentageDiscountStrategy;
            discount = strattemp.percent;
        }
    }
    public double CalculatePrice(double price){
        return price * (1.0-discount);
    }
}