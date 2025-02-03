import React from 'react'
import { useNavigate } from 'react-router-dom'
function Home() {
    const nav = useNavigate();
    return (
        <div>
           <h2>Home</h2> 
           <button onClick={()=>{nav('/orderpage')}}>place order</button>
          
        </div>
    )
}

export default Home
