const variableName = 'YOUR_VARIABLE_NAME'; // Replace with your environment variable name

const variableValue = process.env[variableName];

if (variableValue) {
    console.log(`Value of ${variableName}: ${variableValue}`);
} else {
    console.log('Environment variable not found.');
}
