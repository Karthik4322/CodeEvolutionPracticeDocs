import React from 'react'
import { BrowserRouter } from 'react-router-dom'
// import Aboutus from './Aboutus'
import Home from './Home'
import NavbarComp from './NavbarComp'
import { Route,Routes } from 'react-router-dom'
import Orderpage from './Orderpage'
import PageNotFound from './PageNotFound'
import Products from './Products'
import Featured from './Featured'
import Newproducts from './Newproducts'
import UserDetails from './UserDetails'
import User from './User'
import AuthProvider from './auth'
import { Login } from './Login'
import { Profile } from './Profile'
import { RequireAuth } from './RequireAuth'
const LazyAbout = React.lazy(()=> import('./Aboutus'))

function RoutingCE() {
    return (
        <AuthProvider>
        <>
    
        <NavbarComp/>
        <Routes>
        <Route path='home' element={<Home/>}></Route>

        <Route path='products' element={<Products/>}>
        <Route index element={<Featured/>}/>
        <Route path='products/featured' element={<Featured/>}></Route>
        <Route path='newproduct' element={<Newproducts/>}></Route>
        </Route>

        
        <Route path='/orderpage' element={<Orderpage/>}></Route>

        <Route path='/user' element={<User/>}>
        <Route path='/user/:userId' element={<UserDetails/>}></Route>
        </Route>
        {/* <Route path='/user/about' element={<Aboutus/>}></Route> */}

        <Route path='about' element={<React.Suspense fallback="loading.."><LazyAbout/></React.Suspense>}></Route>
        <Route path ='login' element={<Login></Login>}/>
        <Route path ='profile' element={
        <RequireAuth><Profile/></RequireAuth>}/>

        <Route path='*' element={<PageNotFound/>}></Route>
        </Routes>
     
        </>
        </AuthProvider>
        
    )
} 

export default RoutingCE

