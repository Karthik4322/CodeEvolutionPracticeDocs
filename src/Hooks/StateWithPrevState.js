import React, { useState } from 'react'

function StateWithPrevState() {
    const initialvalue =0;
    const[count,setCount] = useState(initialvalue)

    const incrementBy1=()=>{
        setCount(prevCount=>prevCount+1)
    }
    const decrementBy1=()=>{
        setCount(prevCount=>prevCount+1)
    }
    const incrementBy5=()=>{
        setCount(prevCount=>prevCount+5)
    }

  return (
    <div>
        <div>Value {count}</div>
        <button type ="button" onClick={()=>incrementBy1()}>Increment</button>
        <button type ="button" onClick={()=>decrementBy1()}>Decrement</button>
        <button type ="button" onClick={()=>incrementBy5()}>IncrementBy5</button>
        
    </div>
  )
}

export default StateWithPrevState