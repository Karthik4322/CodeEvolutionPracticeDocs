import {React,useState} from 'react'

function StateWithObject() {
    const[name,setName]= useState({firstName: ' ',lastName:' '})
  return (
    <div>
        <div>
            <form>
                <label>Enter your firstName :</label>
                <input type="text" value={name.firstName} onChange={e=>setName({...name,firstName:e.target.value})}/>
                <h2>firstname:{name.firstName}</h2>

                <label>Enter your lastName :</label>
                <input type="text" value={name.lastName} onChange={e=>setName({...name,lastName:e.target.value})}/>
                <h2>lastName:{name.lastName}</h2>
                <h2>{JSON.stringify(name)}</h2>
            </form>
        </div>
    </div>
  )
}

export default StateWithObject