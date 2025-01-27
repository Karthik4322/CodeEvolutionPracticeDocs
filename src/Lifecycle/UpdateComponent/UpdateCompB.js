import {React,Component} from 'react'
class UpdateCompB extends Component{
    constructor(props){
        super(props)
        this.state={
            name: "Bhalaiya"
        }
        console.log('UpdateComp B constructor')
    }
    static getDerivedStateFromProps(props,state){
        console.log('UpdateComp B getDerivedStateFromProps');
    }
    componentDidMount(){
        console.log('UpdateComp B componentDidMount')
    }
    shouldComponentUpdate(nextProps,nextState){
        console.log("UpdateComp B shouldComponentUpdate")
        return true;
    }
    getSnapshotBeforeUpdate(prevProps,prevState){
        console.log('UpdateComp B getSnapshotBeforeUpdate')
    }
    componentDidUpdate(){
        console.log('UpdateComp B componentDidUpdate')
    }
    render(){
        console.log('UpdateComp B render');
        return(<div>
            
        </div>)
    }
}
export default UpdateCompB;