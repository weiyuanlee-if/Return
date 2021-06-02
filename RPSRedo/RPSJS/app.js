//let playerName = "";
let playerHand;
let computerHand;

let rounds = 1;
let playerWin = 0;
let playerLose = 0;

let computerWin = 0;
let computerLose = 0;

let playersDraw = 0; 

console.log("Lets play RPS! This is the test code before you implement the DOM stuff");

let playerName = prompt("What is your name?");
console.log(playerName + "? Oh, cool name!");
console.log("Anyway you ready? bc I am.")

while (rounds < 7) {
    console.log("Round: " + rounds);
    playerHand = prompt("what will you choose? Rock, Paper Scissors?");

     
    if (playerHand === "Rock") {
        console.log("Rock");
    }
    else if (playerHand === "Paper") {
        console.log("Paper");
    }
    else if (playerHand === "Scissors"){
        console.log("Scissors");
    }
    else {
        console.log("That's not a move what are you doing?");
    }

    let computerHand = ["Rock", "Paper", "Scissors"]
    let randomIndex = Math.floor(Math.random()* computerHand.length);
    let computerChoice = computerHand[randomIndex];
    console.log(computerChoice);

    if (playerHand === "Paper" && computerChoice === "Paper" || (playerHand === "Rock" && computerChoice === "Rock" || (playerHand === "Scissors" && computerChoice === "Scissors")))
                {
                    console.log("Draw!");
                    rounds += 1;
                    playersDraw += 1;
                  

                }
                if (playerHand === "Paper" && computerChoice === "Rock" || playerHand === "Scissors" && computerChoice === "Paper" || playerHand === "Rock" && computerChoice === "Scissors")
                {
                    console.log("You win!");
                    rounds += 1;
                    playerWin += 1;
                    computerLose -= 1;


                }
                if (computerChoice === "Paper" && playerHand ===  "Rock" || computerChoice === "Scissors" && playerHand === "Paper" || computerChoice === "Rock" && playerHand === "Scissors")
                {
                    console.log("You lose!");
                    rounds += 1;
                    computerWin += 1;
                    playerLose -= 1;
}
while (rounds === 7)
                {
                    console.log("Game over");
                    if(playerWin === 5)
                    {
                        console.log("Cheers, you won!");
                    } else if(playerWin < 5)
                    {
                        console.log("Bummer, you lost");
                    }
                    break;

                }
            }
    


