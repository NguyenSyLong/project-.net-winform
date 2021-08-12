
import java.util.List;
import java.util.Collections;
import java.util.Comparator;

public class MyFan implements IFan {
    
    @Override
    public void f1(List<Fan> t, String xCode) {
        String u;
        double v;
        for(int i=0;i<t.size();i++){
            u = t.get(i).getCode();
            v = t.get(i).getPrice();
            if(u.startsWith(xCode)){
                t.get(i).setPrice(v*1.1);
            }
        }
    }

    @Override
    public int f2(List<Fan> t, double xPrice) {
        int count=0;
        for(int i=0; i< t.size();i++){
            if(t.get(i).getPrice()<=xPrice){
                count++;
            }
        }
        return count;
    }

    @Override
    public void f3(List<Fan> t) {
       Collections.sort(t, new Comparator<Fan>(){
           @Override
           public int compare(Fan o1, Fan o2){
            if(o1.price>o2.price){
             return 1;   
            }else if(o1.price==o2.price){
                return o1.code.compareToIgnoreCase(o2.code);
            }else{
                return -1;
            }   
           }
       }
               );
    }

}
