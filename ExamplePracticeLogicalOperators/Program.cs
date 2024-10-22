// See https://aka.ms/new-console-template for more information

// First Example

int age = 20;
bool hasLicense = true;
bool consumedAlcohol = false;

bool canDrive = age > 18 && hasLicense && !consumedAlcohol;

Console.WriteLine(canDrive);

// Second Example

bool isCardValid = true;
bool isCardExpired = false;
double transactionAmount = 150;
double transactionLimit = 2000;

bool isPaymentSuccessful = isCardValid && !isCardExpired && (transactionAmount <= transactionLimit);

Console.WriteLine(isPaymentSuccessful);


// Third Example

bool hasFreeTimeToPlay = false;
bool hasOtherPets = true;
bool hasBackyard = true;
bool hasPetAlegies = false;

bool canAdoptPet = (!hasFreeTimeToPlay || hasOtherPets) && hasBackyard && !hasPetAlegies;
    
Console.WriteLine(canAdoptPet);