public class Main{
	public static void main(String[] args){
		System.out.println("Java main starts");
		for(int i = 0;i < args.length; i++){
			System.out.println("args[" + i + "]:" + args[i]);
		}
		System.out.println("Java main ends");
	}
}
