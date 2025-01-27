import React, { Component, Fragment} from "react";
import ChildComp from "./ChildComp";
// import MyPureComp from "./MyPureComp";
// import MyMemo from "./MyMemoComp";

class ParentComp extends Component{
    
    constructor(props){
        super(props);
        this.state={
            empName:"Arjun",
            empSal : 20000
        } 
    }
    changeStateData = () =>{
        this.setState((prevState)=>({empName:"Karthik S",empSal:prevState.empSal+5000}))
    } 
    render()
    {
            const{empName,empSal} = this.state; // destructuring state
            const{gender,contact}= this.props;  // destructuring props
        // if i have not used destructing concept i have to fetch data like {this.state.propertyname}
        // if i have not used destructing concept i have to fetch data like {this.props.propertyname}

            console.log("parent-comp render");
        return(
            <Fragment>
                <h2>This is Parent Component</h2>
                {/* <p>EmployeeName:{this.state.empName} EmployeeSalary:{this.state.empSal}</p> */}
                <p>Name:<strong>{empName}</strong>, Salary:<strong>{empSal}</strong></p>
                {/* <p>Gender:{this.props.gender} EmployeeSalary:{this.props.contact}</p> */}
                <p>Gender:<strong>{gender}</strong>, Contact:<strong>{contact}</strong></p>

                <button type="button" onClick={()=>this.changeStateData()}>Change State Data</button> <hr></hr>

                <ChildComp name={empName} sal={empSal} manageState={this.changeStateData}/> <hr></hr>

                {/* 
                <MyPureComp empName={empName}  />

                <MyMemo empName={empName} />
                 */}
            </Fragment>
        )
    }
}

export default ParentComp;