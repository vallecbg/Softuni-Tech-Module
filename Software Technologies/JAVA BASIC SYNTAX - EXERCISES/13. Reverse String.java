import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char[] word = scanner.nextLine().toCharArray();
        for (int i = word.length - 1; i >= 0; i--) {
            System.out.printf(word[i] + "");
        }
    }
}

