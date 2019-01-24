import java.io.File;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner consoleReader = new Scanner(System.in);
        String command = "";
        boolean isCommandValid;

        do {
            command = consoleReader.nextLine();
            String[] commandArguments = command.split(" \\-");
            isCommandValid = validateInputCommand(commandArguments);

        } while (!isCommandValid);
    }

    private static boolean validateInputCommand(String[] commandArguments) {
        if (commandArguments.length != 4) {
            System.out.println("Wrong command.");
            System.out.println("Usage: conv -[filepath] -[db connection string] -[map file path]");

            return false;
        }

        if (!checkMainCommand(commandArguments[0])) {
            return false;
        }

        boolean doesFileExists = checkIfFileExists(commandArguments[1]);
        boolean doesDBExists = checkIfDBExists(commandArguments[2]);
        boolean doesMapFileExists = checkIfMapFileExists(commandArguments[3]);

        if (!doesFileExists || !doesDBExists || !doesMapFileExists) {
            return false;
        }

        return true;
    }

    private static boolean checkIfMapFileExists(String mapFilePath) {
        File mapFile = new File(mapFilePath);
        if (mapFile.exists()){
            return true;
        }

        System.out.println("The map file does not exists.");

        return false;
    }

    private static boolean checkMainCommand(String command) {
        if (command.equals("conv")) {
            return true;
        }

        System.out.println("Command not found.");
        System.out.println("Usage: conv -[filepath] -[db connection string] -[map file path]");

        return false;
    }

    private static boolean checkIfDBExists(String DBConnectionString) {
        try {
            DriverManager.getConnection(DBConnectionString);

            return true;
        } catch (SQLException e) {
            System.out.println("Cannot establish connection to the database or the database does not exists.");
        }

        return false;
    }

    private static boolean checkIfFileExists(String filePath) {
        File csvFile = new File(filePath);
        if (csvFile.exists()) {
            return true;
        }

        System.out.println("The data file does not exists.");

        return false;
    }
}
