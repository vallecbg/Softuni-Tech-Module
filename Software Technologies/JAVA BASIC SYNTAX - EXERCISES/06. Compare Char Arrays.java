import com.sun.org.apache.xpath.internal.operations.Bool;

import java.awt.*;
import java.math.BigDecimal;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char[] first = scanner
                .nextLine()
                .toCharArray();
        char[] second = scanner
                .nextLine()
                .toCharArray();
        int endIndex = Math.min(first.length, second.length);
        for (int i = 0; i < endIndex; i++) {
            if(first[i] == ' '){
                continue;
            }
            if (first[i] > second[i]){
                printCharArray(second);
                printCharArray(first);
                break;
            }
            else if(second[i] > first[i]){
                printCharArray(first);
                printCharArray(second);
                break;
            }
            else if (i == endIndex - 1){
                if (first.length>second.length){
                    printCharArray(second);
                    printCharArray(first);
                    break;
                }
                else{
                    printCharArray(first);
                    printCharArray(second);
                    break;
                }
            }
        }
    }

    private static void printCharArray(char[] arr) {
        for (char ch : arr) {
            if (ch != ' ') {
                System.out.printf("%c", ch);
            }
        }
        System.out.println();
    }
}

