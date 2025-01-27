// Changing the color using state property this.state, this.setState
import React, { Component } from 'react';
import "./ColorChange.css";
import fullscreen from "./bgcolor.module.css"

class ColorChange extends Component {

constructor() {
  super()
  this.state = {
     colorName: "red",
  }
}

changeColor=()=>{
    this.setState({colorName:"blue"})
}

render() {
    let circle ={

        width: "200px",
        height: "200px",
        borderRadius: "50%",
        margin: "auto",
        border: "3px solid black",
        color: "blue"
        
    }
return (

    <div><h1 style={{color:this.state.colorName}}>ColorChange</h1>
    <button type ="button" style={circle} onClick={()=>this.changeColor()}>Change Color</button>
    <p className="pstyle">I am using external style in paragraph tag</p>
    <h6 className={fullscreen.fontsize}>Hello</h6>
    </div>

    )
  }
}

export default ColorChange