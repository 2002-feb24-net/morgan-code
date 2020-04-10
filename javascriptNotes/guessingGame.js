const guesses = document.querySelector('.guesses');
const lastResult = document.querySelector('.lastResult');
const lowOrHi = document.querySelector('.lowOrHi');
const guessSubmit = document.querySelector('.guessSubmit');
const guessField = document.querySelector('.guessField');

// add an event listener that will get called when the user "clicks" the 
guessSubmit.addEventListener('click', checkGuess);

let guessCount = 1;


let randomNumber = (Math.floor(Math.random()*100) ) + 1;

function checkGuess(){
    let userGuess = Number(guessField.value)
    // console.log('here in checkGuess:');

    if (guessCount === 1){
        guesses.textContent = 'Previous Guesses: ';
    }

    guesses.textContent += ' ' + userGuess;

    if (userGuess === randomNumber)
    {
        lastResult.textContent = 'Congratulations! You got the guess right';
        lastResult.style.backgroundColor = 'green';
        lastResult.style.color = 'black';

        lowOrHi = '';
    } else if(guessCount === 10){
        lastResult.textContent = 'Game over';
    } else
    {
        lastResult.textContent = 'Wrong number';

        if (userGuess < randomNumber)
        {
            lowOrHi.textContent = 'Your guess was too low';

        }else if (userGuess > randomNumber){
            lowOrHi.textContent = 'That guess was too high.'
        }

    }
    guessCount++; // increment the turns taken
    guessField.value = '';
    
}