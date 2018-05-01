import com.sun.org.apache.xpath.internal.operations.Bool;

import java.awt.*;
import java.math.BigDecimal;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        if(input.equals("0") || input.equals("1") || input.equals("2") || input.equals("3") ||
                input.equals("4") || input.equals("5") || input.equals("6") || input.equals("7") || input.equals("8") ||
                input.equals("9")){
            System.out.println("digit");
        }
        else if(input.equals("a") || input.equals("e") || input.equals("i") || input.equals("o") || input.equals("u")){
            System.out.println("vowel");
        }
        else{
            System.out.println("other");
        }
    }
}

