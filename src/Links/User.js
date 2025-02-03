import React from 'react'
import { Outlet, useSearchParams } from 'react-router-dom'
const User = () => {
    const[searchParams,setSearchParams]= useSearchParams();
    const showActiveUsers =searchParams.get('filter')=='active'
    return (
        <div>
        <div>
            User details 1
            User details 2
            User details 3
            <Outlet/>
        </div>
        <button onClick={()=> setSearchParams({ filter: 'active'})}>Active Users</button>
        <button onClick={()=> setSearchParams({})}>Reset filter</button>

       {showActiveUsers ? (<h2>Showing active users</h2>):(<h2>Showing all users</h2>)}
       </div>
       
    )
}

export default User
