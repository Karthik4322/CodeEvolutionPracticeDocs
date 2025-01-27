import React,{Component} from 'react';
class ClassComp extends Component{
    render(){
        return(<div><h2>This is Class comp in {this.props.country}</h2></div>)
    }
}
export default ClassComp;