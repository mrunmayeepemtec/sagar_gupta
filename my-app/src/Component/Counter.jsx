import { useState } from "react";
import React from 'react'
import './Styls/Counter.css'

const Counter = () => {

    const [sum, setsum] = useState(0);

    const add = () =>{
        setsum(sum+1);
    }
    const subtract = () =>{
        if(sum>0)
        {
        setsum(sum-1);
        }
        else
        {
        setsum(0);
        }
    }

  return (
    <>
     <div className='main_div'>
        <div className='center_div'>
            <h1>{sum}</h1>
            <div className="btn_div">
                <button onClick={add}>+</button>
                <button onClick={subtract}>-</button>
            </div>
        </div>
     </div>
    </>
  )
}

export default Counter
