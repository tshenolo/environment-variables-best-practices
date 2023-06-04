package main

import (
	"fmt"
	"os"
)

func main() {
	variableName := "YOUR_VARIABLE_NAME" // Replace with your environment variable name

	variableValue, exists := os.LookupEnv(variableName)

	if exists {
		fmt.Printf("Value of %s: %s\n", variableName, variableValue)
	} else {
		fmt.Println("Environment variable not found.")
	}
}
