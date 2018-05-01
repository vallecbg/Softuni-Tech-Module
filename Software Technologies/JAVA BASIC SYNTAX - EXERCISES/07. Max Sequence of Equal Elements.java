import java.util.*;


public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] nums = Arrays .stream(scanner.nextLine().split("\\s+")) .mapToInt(Integer::parseInt).toArray();

        int start = 0;
        int beststart = 0;
        int length = 0;
        int bestlength = 0;

        for (int i = 1; i < nums.length; i++)
        {
            if (nums[start] == nums[i])
            {
                length++;
                if (length > bestlength)
                {
                    bestlength = length;
                    beststart = start;
                }
            }
            else
            {
                start++;
                i = start;
                length = 0;
            }
        }
        for (int i = 0; i <= bestlength; i++)
        {
            System.out.printf(nums[beststart + i] + " ");
        }
        System.out.println();

    }
}

