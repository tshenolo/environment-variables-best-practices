public class Main {
    public static void main(String[] args) {
        String variableName = "YOUR_VARIABLE_NAME"; // Replace with your environment variable name

        String variableValue = System.getenv(variableName);

        if (variableValue != null) {
            System.out.println("Value of " + variableName + ": " + variableValue);
        } else {
            System.out.println("Environment variable not found.");
        }
    }
}
