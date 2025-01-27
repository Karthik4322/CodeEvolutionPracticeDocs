import React, { Component } from 'react'

export class MultiFnInClassComp extends Component {
    constructor(props) {
      super(props)
    
      this.state = {
        employeeid: 4575
      }
    }

    greeting=()=>{
        window.alert("Welcome to Learning React Module");
    }
    welcome=(name1,name2)=>{
        window.alert(`Welcome to our site ${name1} ${name2}`);
    }

  render() {

    return(
      <div>MultiFnInClassComp<br />
        <button type="button" onClick={()=>{this.welcome("Arun","Sai")}}>Welcome msg</button><br />
        <button type="button" onClick={()=>{this.greeting()}}>Greeting users</button>
      </div>
    )
  }
}

export default MultiFnInClassComp