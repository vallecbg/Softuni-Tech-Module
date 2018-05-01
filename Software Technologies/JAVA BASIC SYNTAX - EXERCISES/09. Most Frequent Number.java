import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays
                .stream(scanner.nextLine().split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();
        int maxNumber = nums[0];

        int maxCounter = 0;

        for (int i = 0; i < nums.length; i++) {
            int tempCounter = 1;
            for (int j = i; j < nums.length; j++) {
                if (nums[i] == nums[j]){
                    tempCounter++;
                }
            }

            if(tempCounter > maxCounter){
                maxCounter = tempCounter;
                maxNumber = nums[i];
            }
        }
        System.out.println(maxNumber);
    }
}

