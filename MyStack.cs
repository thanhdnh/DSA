class MyStack{
    Node top;

    public bool IsEmpty(){
        return (top==null);
    }
    public void Push(object ele){
        Node n = new Node();
        n.data = ele;
        n.next = top;
        top = n;
    }
    public object Pop(){
        if(IsEmpty())
            return null;
        Node n = top;
        top = top.next;
        return n.data;
    }

    public object Peek(){
        if(IsEmpty())
            return null;
        Node n = top;
        //top = top.next;
        return n.data;
    }
    public object GetValue(int i){
        int index = 0;
        Node curNode = top;
        while(curNode != null){
            if(index == i){
                return curNode.data;
            }
            curNode = curNode.next;
            index ++;
        }
        return null;
    }

    public object AddStack2(){
        double sum = 0;
        Node n = top;
        do{
            sum+=(double)n.data;
            n=n.next;
        }while(n!=null);
        return sum;
    }

    public double AddStack(){
        double sum = 0;
        while(!IsEmpty()){
            double temp = (double)Pop();
            sum+=temp;
        }
        return sum;
    }
}