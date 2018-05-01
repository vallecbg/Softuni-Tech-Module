import com.sun.org.apache.xpath.internal.operations.Bool;

import java.awt.*;
import java.math.BigDecimal;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int input = Integer.parseInt(scanner.nextLine());
        System.out.println(Integer.toString(input, 16).toUpperCase());
        System.out.println(Integer.toString(input, 2));
    }
}

