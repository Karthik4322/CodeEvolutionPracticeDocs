import React, { Component } from 'react'

export class SideEffect extends Component {

    
    constructor(props) {
      super(props)
    
      this.state = {
         count : 0
      }
    }
   
    componentDidMount(){
        document.title=`click ${this.state.count}`
    }
    componentDidUpdate(props,state){
        document.title=`click ${this.state.count}`
    }
  changevalue=()=>{
    this.setState((prevState)=>({count:prevState.count+1}))
  }
   
  render() {

    return (
      <div>SideEffect
      <button type="button" onClick={this.changevalue}>increase value{this.state.count}</button>
      </div>
    )
  }
}

export default SideEffect