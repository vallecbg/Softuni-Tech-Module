import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] array = Arrays .stream(scanner.nextLine().split("\\s+")) .mapToInt(Integer::parseInt).toArray();
        for (int i = 0; i < array.length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;
            for (int j = 0; j < i; j++)
            {
                leftSum += array[j];
            }

            for (int j = i + 1; j < array.length; j++)
            {
                rightSum += array[j];
            }

            if (leftSum == rightSum)
            {
                System.out.println(i);
                return;
            }
        }

        System.out.println("no");
    }
}

