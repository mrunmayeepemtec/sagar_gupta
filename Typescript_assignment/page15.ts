function titleCase(string:string) {
    var sentence = string.toLowerCase().split(" ");
    for(var i = 0; i< sentence.length; i++){
       sentence[i] = sentence[i][0].toUpperCase() + sentence[i].slice(1);
    }
    console.log(sentence.join(" "));
 }
 
 const OK:any = prompt("Enter Str")
 titleCase(OK);