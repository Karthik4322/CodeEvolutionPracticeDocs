import {React,useState,useEffect} from 'react'

function EffectCondRendering() {
    const[count,setCount] = useState(0)
    const[name,setName]= useState(' ')

    useEffect(()=>{
        document.title=`click ${count}`
        console.log('updated count');
    },[count])

  return (
    <div>
        <button type="text" onClick={()=>setCount(count+1)}>count {count}</button>
        <input type ="text" value={name} onChange={e=>setName(e.target.value)}/>
        <h2>{name}</h2>
    </div>
  )
}

export default EffectCondRendering