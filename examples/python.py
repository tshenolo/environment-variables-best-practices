import os

variable_name = 'YOUR_VARIABLE_NAME'  # Replace with your environment variable name

variable_value = os.getenv(variable_name)

if variable_value:
    print(f'Value of {variable_name}: {variable_value}')
else:
    print('Environment variable not found.')
