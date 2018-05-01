package BookLibrary;
import java.awt.print.Book;
import java.text.DateFormat;
import java.text.MessageFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int bookNumber = scan.nextInt();
        scan.nextLine();
        Books[] result = new Books[bookNumber];
        DateFormat df = new SimpleDateFormat("dd.MM.yyyy");
        for (int i = 0; i < bookNumber; i++) {
            String[] inputBooks = scan.nextLine().split(" ");
            String name = inputBooks[1];
            String title = inputBooks[0];
            double price = Double.parseDouble(inputBooks[5]);
            String date = inputBooks[3];
            Date date1 = null;
            try {
                date1 = df.parse(date);
            } catch (ParseException e) {
                e.printStackTrace();
            }
            Books student = new Books(title, name, price,date1);
            result[i]=student;
        }
        String inputDate = scan.nextLine();
        Date date2 = null;
        try {
            date2 = df.parse(inputDate);
        } catch (ParseException e) {
            e.printStackTrace();
        }
        List<Library> output = new ArrayList<>();
        for (int i = 0; i < result.length; i++) {
            String title = result[i].getTitle();
            Date date = result[i].getReleaseDate();
            Library lib = new Library(title,date);
            output.add(lib);
        }

        Collections.sort(output, new ObjectComparator());

        for (Library entry : output) {
            int sComp = entry.getDate().compareTo(date2);
            if (sComp > 0) {
                System.out.println(MessageFormat.format("{0} -> {1}", entry.getTitle(), df.format(entry.getDate())));
            }
        }
    }

}
class ObjectComparator implements Comparator {

    public int compare(Object obj1, Object obj2) {
        Date x3 = ((Library) obj1).getDate();
        Date x4 = ((Library) obj2).getDate();
        int sComp = x3.compareTo(x4);
        if (sComp != 0) {
            return sComp;
        } else {
            String x1 = ((Library) obj1).getTitle();
            String x2 = ((Library) obj2).getTitle();
            return  x1.compareTo(x2);
        }
    }
}