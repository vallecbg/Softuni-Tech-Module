package BookLibrary;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt((scanner.nextLine()));

        Library library = new Library("name");

        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split(" ");

            String title = tokens[0];
            String author = tokens[1];
            String publisher = tokens[2];
            String releaseDate = tokens[3];
            String isbn = tokens[4];
            double price = Double.parseDouble(tokens[5]);

            Book book = new Book(title,author,publisher,releaseDate,isbn,price);
            library.getBooks().add(book);
        }
        Map<String,Double> authorsSum = new LinkedHashMap<>();
        for (Book book : library.getBooks()) {
            if (authorsSum.containsKey(book.getAuthor())){
                double oldValue = authorsSum.get(book.getAuthor());
                authorsSum.put(book.getAuthor(),oldValue+book.getPrice());
            }else {
                authorsSum.put(book.getAuthor(),book.getPrice());
            }
        }
        authorsSum.entrySet().stream().sorted((a1,a2)->{
            int compareResult = Double.compare(a2.getValue(),a1.getValue());
            if (compareResult==0){
                compareResult = a1.getKey().compareTo(a2.getKey());
            }
            return compareResult;
        })
        .forEach(a-> System.out.printf("%s -> %.2f%n", a.getKey(), a.getValue()));
    }
}