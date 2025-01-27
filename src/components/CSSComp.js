import React from 'react'

const CSSComp = () => {
    let circle ={

        width: "100px",
        height: "100px",
        borderRadius: "50%",
        border: "5px solid green",
        color: "red",
        margin: "auto"
    }

    let square={
    height: "150px",
    width: "150px",
    margin: "auto",
    border: "5px solid red",
    align: "center"
    }
  return(
    <div><p style={circle}>CSSComp</p>
    {/* This is internal css instead style tag , we are creating object and applying the style to the tag p */}
    <h5 style={square}>shapes using identifier,This is internal css,because we are giving css code inside component file</h5>
    <h3 style ={{color:"aqua"}}>Inline css using double curly braces</h3>
    {/* The inline css is enclosed within {{double curly braces}} */}
    </div>
  )
}
export default CSSComp