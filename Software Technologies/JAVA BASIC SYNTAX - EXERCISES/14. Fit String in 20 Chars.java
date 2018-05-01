import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String word = scanner.nextLine();
        if(word.length() < 20) {
            String asterics = new String(new char[20 - word.length()]).replace("\0", "*");
            System.out.println(word + asterics);
        }
        else{
            String newWord = word.substring(0, 20);
            System.out.println(newWord);
        }

    }
}

