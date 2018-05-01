import com.sun.org.apache.xpath.internal.operations.Bool;

import java.awt.*;
import java.math.BigDecimal;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Boolean input = Boolean.parseBoolean(scanner.nextLine());
        if(input == true){
            System.out.println("Yes");
        }
        else{
            System.out.println("No");
        }
    }
}