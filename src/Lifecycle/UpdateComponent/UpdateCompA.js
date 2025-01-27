import {React,Component} from 'react'
import UpdateCompB from './UpdateCompB';
class UpdateCompA extends Component{
    constructor(props){
        super(props);
        this.state={
            name : 'vishwas'
        }
        console.log("UpdateComp A constructor")
    }
    static getDerivedStateFromProps(props,state){
        console.log("UpdateComp A getDerivedStateFromProps")
        return null;
    }
    componentDidMount(){
        console.log("UpdateComp A componentDidMount")
    }
    shouldComponentUpdate(nextProps,nextState){
        console.log("UpdateComp A shouldComponentUpdate")
        return true;
    }
    getSnapshotBeforeUpdate(prevProps,prevState){
        console.log('UpdateComp A getSnapshotBeforeUpdate')
        return true;
    }
    componentDidUpdate(){
        console.log('UpdateComp A componentDidUpdate')
    }
   changename=()=>{
        this.setState({name:"codevolution"})
        
    }

    render(){
        console.log("UpdateComp A render")
        return(<div>
            <UpdateCompB/>
            <button type ="button" onClick ={()=>{this.changename()}}>ChangeName</button>
            <div><p>{this.state.name}</p></div>
        </div>)
    }
}
export default UpdateCompA;