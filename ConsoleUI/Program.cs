using ConsoleUI; 
StandardMessages.WelcomeMessage();
var user = PersonDataCapture.Capture();
var IsValid = PersonValidator.Validate(user);
if (!IsValid)
{
    StandardMessages.EndApplication();
    return;
}
AccountGenerator.CreateAccount(user);
StandardMessages.EndApplication();