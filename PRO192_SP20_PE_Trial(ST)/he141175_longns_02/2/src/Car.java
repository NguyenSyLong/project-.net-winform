public class Car {
    public String name;
    public double price;

    public Car(String name, double price) {
        this.name = name;
        this.price = price;
    }

    public Car() {
    }

    public String getName() {
        return name;
    }

    public double getPrice() {
        return price;
    }
    @Override
    public String toString() {
        return name.trim() +" "+price;
    }
   
}
