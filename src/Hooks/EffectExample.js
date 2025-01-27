import {React,useState,useEffect} from 'react'

function EffectExample() {
    const[count,setCount] = useState(0)

    useEffect(()=>{
        document.title=`click ${count}`
    })

  return (
    <div>
        <button type="text" onClick={()=>setCount(count+1)}>count {count}</button>
    </div>
  )
}

export default EffectExample