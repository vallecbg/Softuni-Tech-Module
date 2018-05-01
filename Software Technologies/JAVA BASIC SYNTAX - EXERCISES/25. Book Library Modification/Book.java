package BookLibrary;

import java.util.Date;

class Books {
    private String title;
    private String name;
    private double price;
    private Date releaseDate;


    public Books(String title, String name, double price, Date releaseDate) {
        this.name = name;
        this.title = title;
        this.price = price;
        this.releaseDate = releaseDate;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getTitle() {
        return title;
    }

    public void getTitle(String title) {
        this.title = title;
    }

    public double getPrice() {
        return price;
    }

    public void getPrice(double price) {
        this.price = price;
    }

    public Date getReleaseDate() {
        return releaseDate;
    }

    public void getReleaseDate(Date releaseDate) {
        this.releaseDate = releaseDate;
    }
}