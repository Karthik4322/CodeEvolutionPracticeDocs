import {React,Component} from 'react'
import MountingB from './MountingB';
class Mounting extends Component{
    constructor(props){
        super(props);
        this.state={
            name : 'vishwas'
        }
        console.log("Mounting A constructor")
    }
    static getDerivedStateFromProps(props,state){
        console.log("Mounting A getDerivedStateFromProps")
        return null;
    }
    componentDidMount(){
        console.log("Mounting A componentDidMount")
    }
    render(){
        console.log("Mounting A render")
        return(<div>
            <MountingB/>
        </div>)
    }
}
export default Mounting;