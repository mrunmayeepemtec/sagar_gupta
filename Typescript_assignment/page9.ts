function vowelsAndConsonants(s:string) {
    // let vowels = [];
    // let consonas = [];
    let result_str=''
    for(var i=0; i<s.length ; i++) {
        if((s[i]=='a')||(s[i]=='e')||(s[i]=='i')||(s[i]=='o')||(s[i]=='u')||(s[i]==' ')){
            result_str+=s[i]
        } else {
            result_str+=s[i]+'o'+s[i]
        }
    }
    
    console.log(result_str)
}

vowelsAndConsonants('this is fun')