
/**
 *
 * @author DELL
 */
public class Fan {
    public String code;
    public double price;
    
    public Fan(){
        
    }
    public Fan(String code, double price){
        this.code=code;
        this.price=price;
    }

    public String getCode() {
        return code.toUpperCase();
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }
    
    
}
