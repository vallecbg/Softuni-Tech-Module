import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();

        if (input.contains("://")){
            String[] prot = input.split("://");
             System.out.println("[protocol] = "+"\""+prot[0]+"\"");
             if (!prot[1].equals("")){
                 String[] serv = prot[1].split("/+?");
                  System.out.println("[server] = "+"\""+serv[0]+"\"");
                  if (serv.length!=1){
                      String[] res = prot[1].split("^([^\\/]+)\\/");
                       System.out.println("[resource] = "+"\""+res[1]+"\"");
                  }
                  else {
                       System.out.println("[resource] = \"\"");
                  }
             }
        }
        else {
             System.out.println("[protocol] = \"\"");
            if (input.contains("/")){
                String[] serv = input.split("/+?");
                System.out.println("[server] = "+"\""+serv[0]+"\"");
                if (serv.length!=1){
                    String[] res = input.split("^([^\\/]+)\\/");
                    System.out.println("[resource] = "+"\""+res[1]+"\"");
                }
            }
            else {
                 System.out.println("[server] = "+"\""+input+"\"");
                  System.out.println("[resource] = \"\"");
            }
        }

    }
}