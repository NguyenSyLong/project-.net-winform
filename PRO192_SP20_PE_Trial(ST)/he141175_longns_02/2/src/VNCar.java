public class VNCar extends Car {
  private int series;
    public VNCar() {
    }
    public VNCar(String name, double price, int series) {
       super(name,price);
       this.series = series;
    }
    
    public double  getSalePrice() {
      double price1=price;
      if(series<300){
          price1 = price + price * 0.1;
      }
      return price1;
    }  

    @Override
    public String toString() {
        return name.trim()+" "+price +" "+series ;
    }
}
