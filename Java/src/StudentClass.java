import java.util.*;
import java.util.stream.Collectors;

public class StudentClass implements Comparable<StudentClass> {
    private String name, surname;
    private HashMap<String, Double> grades;

    public StudentClass (String name, String surname) {
        this.name = name;
        this.surname = surname;
    }

    public double calculateAverageGrade() {
        double sum = 0;
        int count = 0;
        for (Map.Entry<String, Double> entry: grades.entrySet()) {
            ++count;
            sum += entry.getValue();
        }
        return sum / (double) count;
    }

    // se returneaza un dictionar cu materiile unde avem note peste 9
    public Map<String, Double> subjectOver9 () {
        return grades.entrySet().stream().filter(x -> Double.compare(x.getValue(), 9) >= 0)
                .collect(Collectors.toMap(x -> x.getKey(), x -> x.getValue()));
    }

    public void addSubjectAndGrade (String subject, double grade) {
        grades.put(subject, grade);
    }

    @Override
    public int compareTo(StudentClass o) {
        if (o.name.equals(name)) {
            return o.surname.compareTo(surname);
        }
        return Double.compare(calculateAverageGrade(), o.calculateAverageGrade());
    }
}
