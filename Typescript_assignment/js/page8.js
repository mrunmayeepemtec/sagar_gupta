"use strict";
function check_pangram(str) {
    let alphabet = "abcdefghijklmnopqrstuvwxyz";
    //Checking for all the alphabets
    let s = str; //Demo String
    let regex = /\s/g;
    // Checking for the white spaces in our sentence to be checked
    let lowercase = s.toLowerCase().replace(regex, "");
    // Removing all the whitespaces from the input string
    // console.log(lowercase)
    for (let i = 0; i < alphabet.length; i++) {
        if (lowercase.indexOf(alphabet[i]) === -1) {
            return 'Not a Pangram';
        }
    }
    return 'Pangram';
}
console.log(check_pangram('The quick brown fox jumps over the lazy dog'));
