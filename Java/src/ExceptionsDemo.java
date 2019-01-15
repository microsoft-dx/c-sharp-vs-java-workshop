import java.*;


/**
 * Ce sunt exceptiile? Prin exceptii intelegem faptul ca se petrece ceva prost sau nedorit in cadrul programului nostru, de exemplu impartire cu 0 sau
 * accesarea unui element dintr-un array aiurea (arr[-2], arr[arr.length + 69])
 * In Java avem o clasa numita Exception, care este mostenita de toate exceptiile predefinite in Java (FileNotFoundException, IndexOutOfBoundsException etc ca-s multe)
 * -> acestea apar implicit
 * Noi putem sa ne facem exceptii custom, prin extinderea clasei Exception
 */

class MyFirstException extends Exception {
    public MyFirstException() {
        super("My first exception thrown");
    }
}

class MySecondException extends Exception {
    public MySecondException(String name) {
        super("Exception " + name + " is thrown");
    }
}

class SomeStuff {
    private boolean isOk = false;

    public void setOk(boolean bool) {
        isOk = bool;
    }

    // daca in aceasta metoda apare ceva ce nu ne convine sau e prost -> aruncam exceptia
    public void doStuff() throws MyFirstException {
        System.out.println("WORK MAN");
        if (isOk)
            throw new MyFirstException();
    }
}

class Papa {
    static {
        System.out.println("Papa static");
    }

    {
        System.out.println("Papa non - static");
    }
}

class Johnny extends Papa {
    static {
        System.out.println("Johnny static");
    }

    {
        System.out.println("Johnny non - static");
    }
}

/**
 * blocurile de initializare
 * cele statice se executa doar o data, la prima instantiere a clasei, iar cele non - statice ori de cate ori e instantiata clasa respectiva
 *
 * la mostenire, mai intai se executa blocurile statice din clasa parinte, apoi cele statice din clasa copil
 * apoi cele non statice din clasa parinte, apoi cele non statice din clasa copil
 */

public class ExceptionsDemo {
    public static void main (String[] args) {

        Papa papa = new Papa();

        System.out.println("Kid");

        Johnny johnny = new Johnny();

        // incercam sa facem actiuni, in care pot aparea exceptii, in blocul try
        try {
            SomeStuff lab = new SomeStuff();
            lab.doStuff();
            lab.setOk(true);
            lab.doStuff();
        } catch (MyFirstException e) {
            // daca s-a prins exceptia
            e.printStackTrace(); // e obligatoriu sa scrii chestia asta la exceptii (se poate sa nu o scrii, dar e bad practice, caci programul nu se intrerupe, intreruperea fiind dorita)
        } catch (Exception e) {
            e.printStackTrace();
            // putem lua in calcul ca se pot arunca mai multe tipuri de exceptii, asa putem face o constructie ca mai sus, luand exceptiile cele mai de jos ca mostenire primele
            // terminand cu cele mai de sus (vorbind de mostenire)
        } finally {
            // blocurile din finally se executa mereu, indiferent daca s-a aruncat o exceptie sau nu
            System.out.println("Leaving...");
        }

    }
}