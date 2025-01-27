import React from 'react';
function FuncComp({name,team}){
    return(<div><h2>This is functional component by {name} and {team}</h2></div>)
}
export default FuncComp;

// props is nothing but parameter passing. you can use alternative way to give this. In return section, {props.name} and in parameter{props}.