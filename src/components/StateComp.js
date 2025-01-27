
import {React , Component} from 'react';
class StateComp extends Component{
    constructor(){
        super();
        this.state={
            name : "karthik",
            sal: 50000
        }
    }
changeStateData=()=>{
    this.setState((prevState)=>({name:prevState.name="Sai",sal: prevState.sal+5000})); // we can also add array to change the data's
}


render(){
    return(<div>  
          <p>Name:{this.state.name} salary:{this.state.sal}</p>
        <button type="button" onClick={()=>this.changeStateData()}>Change Data</button>
    </div>)
}

}
export default StateComp;