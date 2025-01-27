/* eslint-disable no-undef */
import React from 'react';

const Child = ({ name, age, manageState }) => {
  return (
    <div>
      <h2>Child Component</h2>
      <p>
        Name: <strong>{name}</strong> | Age: <strong>{age}</strong>
      </p>
      {/* Invoke the parent's changeAge method */}
      <button type="button" onClick={manageState}>
        Increase Age from Child
      </button>
    </div>
  );
};

export default Child;
