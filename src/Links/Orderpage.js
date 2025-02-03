import React from 'react'
import { useNavigate } from 'react-router-dom'
function Orderpage() {
    const nav = useNavigate();
    return (
        <div>
            <h2>Order page</h2>
            <button onClick={()=>{nav(-1)}}>GoBack</button>
        </div>
    )
}

export default Orderpage
