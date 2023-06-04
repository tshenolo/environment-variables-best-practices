use std::env;

fn main() {
    let variable_name = "YOUR_VARIABLE_NAME"; // Replace with your environment variable name

    match env::var(variable_name) {
        Ok(variable_value) => println!("Value of {}: {}", variable_name, variable_value),
        Err(_) => println!("Environment variable not found."),
    }
}
