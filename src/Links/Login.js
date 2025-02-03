import {useState} from 'react'
import { useNavigate,useLocation } from 'react-router-dom'
import {useAuth} from './auth'

export const Login =()=>{
    const[user,setUser] = useState('')
    const auth = useAuth()
    const location = useLocation()

    const navigate = useNavigate()
    const handleLogin =()=>{
        auth.login(user)
        navigate('/profile',{replace:"true"})
    }
    return (<div>
        <label>Username: {''}
        <input type = 'text' onChange={(e)=>setUser(e.target.value)}/>
        </label>
        <button onClick={handleLogin}>Login</button>
    </div>)
}