import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] n = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int[] m = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int number = m[0];
        int power = m[1];

        for (int i = 0; i < n.length; i++) {
            if (n[i] == number) {
                n[i] = 0;
                for (int j = 1; j <= power; j++) {
                    if (i + j >= n.length) {
                        break;
                    } else {
                        n[i + j] = 0;
                        ;
                    }
                }

                for (int k = 1; k <= power; k++) {
                    if (i - k < 0) {
                        break;
                    } else {
                        n[i - k] = 0;
                    }
                }
            }
        }
        int result = 0;
        for (int i = 0; i < n.length; i++) {
            result += n[i];
        }
        System.out.println(result);
    }
}

