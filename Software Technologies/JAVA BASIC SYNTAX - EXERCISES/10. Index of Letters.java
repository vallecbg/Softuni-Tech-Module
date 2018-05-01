import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] first = scanner
                .nextLine()
                .toCharArray();
        int temp_integer = 97;
        for (char character : first) {
            int temp = (int)character;
            System.out.println(character + " -> " + (temp-temp_integer));
        }
    }
}

