// This simple application simulates a 50/50 coin flip.


// Initialize a random variable
var coin = new Random();


// Randomize an integer value between 1 and 100 (upper limit is uninclusive)
int flip = coin.Next(1,101);

// Create string variables to be used in output
string heads = "heads";
string tails = "tails";


// If the random integer value is Even, return heads. If odd, return tails
Console.WriteLine($"Flip result: {(flip % 2 == 0 ? heads : tails)}");