<?php
$variableName = "YOUR_VARIABLE_NAME"; // Replace with your environment variable name

$variableValue = getenv($variableName);

if ($variableValue !== false) {
    echo "Value of $variableName: $variableValue";
} else {
    echo "Environment variable not found.";
}
?>
