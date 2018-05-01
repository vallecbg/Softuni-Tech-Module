import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine();

        LinkedHashMap<String, String> phonebook =  new LinkedHashMap<>();

        while (!text.equals("END")){
            String[] array = text.split(" ");
            String command = array[0];
            String name = array[1];

            if (command.equals("A")){
                String number = array[2];
                if (!phonebook.containsKey(name)){
                    phonebook.put(name,number);
                }
                phonebook.put(name,number);
            }
            else if (command.equals("S")){
                if (!phonebook.containsKey(name)){
                     System.out.printf("Contact %s does not exist.",name);
                      System.out.println();
                }
                else {
                     System.out.println(name+" -> "+phonebook.get(name));
                }
            }
            text = scan.nextLine();
        }
    }
}