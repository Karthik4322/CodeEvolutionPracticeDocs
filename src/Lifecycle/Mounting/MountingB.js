import {React,Component} from 'react'
class MountingB extends Component{
    constructor(props){
        super(props)
        this.state={
            name: "Bhalaiya"
        }
        console.log('Mounting B constructor')
    }
    static getDerivedStateFromProps(props,state){
        console.log('Mounting B getDerivedStateFromProps');
    }
    componentDidMount(){
        console.log('Mounting B componentDidMount')
    }
    render(){
        console.log('Mounting B render');
        return(<div>
            
        </div>)
    }
}
export default MountingB;