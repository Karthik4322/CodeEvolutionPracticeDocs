/* eslint-disable no-undef */
import React, { Component } from 'react';
import Child from './Child';

class Parent extends Component {
  constructor(props) {
    super(props);

    this.state = {
      name: 'Aaradhya',
      age: 1,
      color: 'white',
    };
  }

  changeAge = () => {
    this.setState((prevState) => ({ age: prevState.age + 1 }));
  };

  render() {
    const { name, age } = this.state;

    return (
      <div>
        <h1>Parent</h1>
        <button type="button" onClick={this.changeAge}>
          Increase Age
        </button>
        <p>
          Name: <strong>{name}</strong> | Age: <strong>{age}</strong> | Gender:{' '}
          <strong>{this.props.gender}</strong>
        </p>
        <Child name={name} age={age} manageState={this.changeAge} />
      </div>
    );
  }
}

export default Parent;
