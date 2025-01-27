import React, { Component } from 'react';

class ConditionalRenComp extends Component {
  constructor() {
    super();
    this.state = {
      isCond: true,
    };
  }

  changeStateData = () => {
    this.setState((prevState) => ({
      isCond: !prevState.isCond, // Toggle the state
    }));
  };

  render() {
    let msg = "";

    if (!this.state.isCond) {  // checking the condition is false = admin, true = user
      msg = "Admin Login Successfully";
       return <h2>Admin Login Successfully</h2>

    } 
    else {
     msg = "User Login";
     // return <h2>User Login Successfully</h2>

    }

    return (
      <div>
        <p>Change input value: {this.state.isCond.toString()}</p>
        <button type="button" onClick={this.changeStateData}>Change Default Value</button>
        <h2>{msg}</h2>
        {/* <h2>{msg}</h2> variable as a element. In JSX allowed only  */}
      </div>
    );
  }
}

export default ConditionalRenComp;
