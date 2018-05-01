import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String emailInput = scanner.nextLine();
        String word = scanner.nextLine();
        String emailPattern = "([a-zA-Z0-9_.-]+)@([a-zA-Z0-9_\\-]+\\.[a-zA-Z0-9_\\-]+)";
        Pattern r = Pattern.compile(emailPattern);
        Matcher m = r.matcher(emailInput);

        if(m.find()){
            String allChar = m.group(0);
            String name = m.group(1);
            String email = m.group(2);
            String censored = word.replaceAll(allChar, new String(new char[allChar.length() - email.length() - 1]).replace("\0", "*") + "@" + email);
            System.out.println(censored);

        }


    }
}

