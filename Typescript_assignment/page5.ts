function Cal(days_count: number,day_start: number){
  console.log("Sun  Mon  Tue   Wed   Thu  Fri  Sat")
  let counter=0  // For Week Count like 7 denotes End of the Week so move to next line
  let day_init=1 // For 30 Days of the Calendar
  let str='' // For concating the actual calendar 
  let flag=true // To see whether our start of the month == current var

  while(day_init<=30){
     if(counter!=day_start && flag==true){
       str+='    ' // For the Starting Row
     }else{
      // From 2nd Row onwards
        flag=false
        // For difference of Spacing between single digits and double digits ( from 10 double digits are started )
        if(day_init<10){
          str+=' '+day_init+'  '
        }else{
          str+=' '+day_init+' '
        }
        // Checking for end of the month
        if(day_init===days_count)
        { 
          console.log(str)
        }
        day_init++
     }
     counter++
     str+=' '
     // Checking for end of week
     if(counter==7){
       console.log(str)
       counter=0
       str=' '
     }
  }
}

Cal(30,4)
