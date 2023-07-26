namespace TeamBuilding;
public class Leader{
    public static int count;
    private static  Leader _ref;
    private Leader(){       //private constructor can call from inside class only
        count++;

    }

    public static Leader  GetLeader(){  //can make object of Leader(this) class only by calling this method
        if(_ref == null){           //making singleton object
           _ref=new Leader();     //calling private constructor
        }
        return _ref;
    }

}