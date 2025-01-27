import React, { Component } from 'react'

class EventH1 extends Component {
    constructor(props) {
      super(props)
    
      this.state = {
        message: "hi"
      }
      this.changeMsg= this.changeMsg.bind(this)
    }
   changeMsg(){
    this.setState({message:"good bye"});
   }   

render() {

 return (
      <div>EventH1
        <p>{this.state.message}</p>
        <button type="button" onClick={this.changeMsg}>Change Message</button>
      </div>
    )
  }
}

export default EventH1