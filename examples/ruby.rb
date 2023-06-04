variable_name = 'YOUR_VARIABLE_NAME' # Replace with your environment variable name

variable_value = ENV[variable_name]

if variable_value
  puts "Value of #{variable_name}: #{variable_value}"
else
  puts 'Environment variable not found.'
end
