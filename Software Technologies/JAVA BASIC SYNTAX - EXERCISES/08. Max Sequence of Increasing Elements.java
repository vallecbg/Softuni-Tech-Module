import java.util.*;


public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] numbers = Arrays .stream(scanner.nextLine().split("\\s+")) .mapToInt(Integer::parseInt).toArray();
        int length = numbers.length;
        int cntCurrSeq = 0;
        int startCurrSeq = 0;
        int cntMaxSeq = 0;
        int startMaxSeq = 0;

        for (int i = 1; i < length; i++)
        {
            if (numbers[i] - numbers[i - 1] >= 1)
            {
                cntCurrSeq++;
                startCurrSeq = i - cntCurrSeq;

                if (cntCurrSeq > cntMaxSeq)
                {
                    cntMaxSeq = cntCurrSeq;
                    startMaxSeq = startCurrSeq;
                }
            }
            else
            {
                cntCurrSeq = 0;
            }
        }
        for (int iWrite = startMaxSeq; iWrite <= (startMaxSeq + cntMaxSeq); iWrite++)
        {
            System.out.printf(numbers[iWrite] + " ");
        }
        System.out.println();
    }
}

