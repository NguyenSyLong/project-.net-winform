
/**
 *
 * @author DELL
 */
public class MyString implements IString{
    @Override
    public int f1(String str){
        int s=0;
        int k;
        char c;
        for(int i=0;i<str.length();i++){
            c = str.charAt(i);
            if(Character.isDigit(c)){
                k = Integer.parseInt("" + c);
                s=s+k;
            }
        }
        
    return (s);
    }
    @Override
    public String f2(String str){
      char a[]=str.toCharArray();
      String s="";
      int k;
      for(int i=0;i<str.length();i++){
          
          if(Character.isDigit(a[i])){
             k=Integer.parseInt(""+a[i]); 
             if(k<9){
                 k++;
             }
             s=s+k;
          }else
              s=s+a[i];
      }
      return(s);
    }
    
}
