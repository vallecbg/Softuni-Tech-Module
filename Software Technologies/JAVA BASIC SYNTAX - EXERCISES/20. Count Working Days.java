import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String start = scan.nextLine();
        String end = scan.nextLine();

        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");

        LocalDate startDate = LocalDate.parse(start, formatter);
        LocalDate endDate = LocalDate.parse(end, formatter);

        long days = ChronoUnit.DAYS.between(startDate, endDate);
        int workingDays = 0;

        for (int i = 0; i <= days; i++) {
            boolean workday = checkIfHoliday(startDate);

            if (!workday) {
                workingDays++;
            }
            startDate = startDate.plusDays(1);
        }
        System.out.println(workingDays);
    }

    private static boolean checkIfHoliday(LocalDate date) {
        if ((date.getDayOfMonth() == 1 && date.getMonth().getValue() == 1) ||
                (date.getDayOfMonth() == 3 && date.getMonth().getValue() == 3) ||
                (date.getDayOfMonth() == 1 && date.getMonth().getValue() == 5) ||
                (date.getDayOfMonth() == 6 && date.getMonth().getValue() == 5) ||
                (date.getDayOfMonth() == 24 && date.getMonth().getValue() == 5) ||
                (date.getDayOfMonth() == 6 && date.getMonth().getValue() == 9) ||
                (date.getDayOfMonth() == 22 && date.getMonth().getValue() == 9) ||
                (date.getDayOfMonth() == 1 && date.getMonth().getValue() == 11) ||
                (date.getDayOfMonth() == 24 && date.getMonth().getValue() == 12) ||
                (date.getDayOfMonth() == 25 && date.getMonth().getValue() == 12) ||
                (date.getDayOfMonth() == 26 && date.getMonth().getValue() == 12)) {
            return true;
        } else if ((date.getDayOfWeek().getValue() == 6) || (date.getDayOfWeek().getValue() == 7)) {
            return true;
        } else {
            return false;
        }
    }
}