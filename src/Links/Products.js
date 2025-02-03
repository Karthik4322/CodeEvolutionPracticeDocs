import React from 'react'
import { Link,Outlet } from 'react-router-dom'
import { useNavigate } from 'react-router-dom'

function Products() {

    // const nav = useNavigate();
    return (
        <div>
          Product page
          <nav>
            <Link to="featured">featured</Link>
            <Link to="newproduct">new products</Link>
            {/* <Link to={nav('home')}>Back to home</Link> */}
            <Link to="/home">Back to Home</Link>
          </nav>
          <Outlet/>
        </div>
    )
}

export default Products
