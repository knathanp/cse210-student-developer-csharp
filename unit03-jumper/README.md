Structure:
    Program.cs:
    Director.cs:
        Responsabilities:
         -keep track og the functions and objects
         -make the gameplay
        Behaviours:
         -Make a guess
         -make Terminal Service, Jumper, and Word objects
        States:
         -Still playing
         
    TerminalService.cs:
        Responsabilities: 
         -Draw the jumper and the correct guessed words.
         -Read the letter typed
        Behaviours: 
         -Display the Jumper and its parachute
         -Display the guessed letters
        States: None
    Jumper.cs:
        Responsabilities: 
         -Keep track of the parachute

        Behaviours: 
         -remove part of the parachute if they guessed wrong.

        states: Full parachute, Intermidiate Parachute, and Dead

    Word.cs:
        Responsabilities:
         -Choose a random word from a list of words.
         -Keep track of the guessed letter.
        Behaviours:
         -Return a word at the begining 
         -Return true or false according to the guess
        States:
         -random word
         -right or not guess