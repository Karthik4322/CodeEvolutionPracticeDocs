import React from 'react'
import { NavLink } from 'react-router-dom';
import {useAuth} from './auth'
function NavbarComp() {
    const auth = useAuth()
    return (
        <nav>
            <NavLink to="/home" >Home</NavLink>{"    "}
            <NavLink to="/about" >About us</NavLink>{"    "}
            <NavLink to="products">Products</NavLink>{"     "}
            <NavLink to="profile">Profile</NavLink>{"     "}
            {!auth.user && (<NavLink to ='/login'>Login</NavLink>)}

        </nav>
    )
}

export default NavbarComp;
