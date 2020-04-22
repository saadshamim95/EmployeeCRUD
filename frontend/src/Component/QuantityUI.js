import React, { Component } from 'react';
import SelectType from './SelectType';
import InputLeft from './InputLeft';
import InputRight from './InputRight'
//import { FaEquals } from 'react-icons/fa';
import {FaEquals}  from 'react-icons/fa'
import Formula from './Formula';
import {feetToInch, inchToFeet, meterToCentimeter, centimeterToMeter, kgToGm, gmToKg} from '../Services/Service';

export default class QuantityUI extends Component {
    state = {
        showType: false,
        measurementTypeLeft:"",
        measurementTypeRight:"",
        inputTypeLeft:"",
        inputTypeRight:""
    }

    unitTypeHandler = async (event)=>{
        const type = event.target.value;
        console.log(type);
        if(type == "Length")
        {
            await this.setState({
                showType : true
            })
        }
        else if(type == "Weight")
        {
            await this.setState({
                showType : false
            })
        }
    }

    measumentTypeLeftHandler = async (event)=>{
        const lefttype = event.target.value;
        await this.setState({
            measurementTypeLeft : lefttype
        })
        console.log(this.state.measurementTypeLeft);
    }

    measumentTypeRightHandler = async (event)=>{
        const righttype = event.target.value;
        await this.setState({
            measurementTypeRight : righttype
        })
        console.log(this.state.measurementTypeRight);
    }

    inputTypeRightHandler = async (event) => {
        const inputTypeRight = event.target.value;
        await this.setState({
            inputTypeRight: inputTypeRight
        })
    }
    inputTypeLeftHandler =  async (event) => {
        const inputTypeLeft = event.target.value;
       await this.setState({
            inputTypeLeft: inputTypeLeft
        })
        console.log(this.state.inputTypeLeft);
        const input = this.state.inputTypeLeft;
        
        if((this.state.measurementTypeLeft==="Feet") && (this.state.measurementTypeRight==="Inch")){
            const data = {
                Feet: input
            }

            const response =  feetToInch(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.measurementTypeLeft==="Inch") && (this.state.measurementTypeRight==="Feet")){
            const data = {
                Inch: input
            }
            const response =  inchToFeet(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.measurementTypeLeft==="Meter") && (this.state.measurementTypeRight==="Centimeter")){
            const data = {
                Meter: input
            }
            const response =  meterToCentimeter(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.measurementtTypeLeft==="Centimeter") && (this.state.measurementTypeRight==="Meter")){
            const data = {
                Centimeter: input
            }
            const response =  centimeterToMeter(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.measurementTypeLeft==="Kilogram") && (this.state.measurementTypeRight==="Gram")){
            const data = {
                Kilogram: input
            }
            const response =  kgToGm(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.measurementTypeLeft==="Gram") && (this.state.measurementTypeRight==="Kilogram")){
            const data = {
                Gram: input
            }
            const response =  gmToKg(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }
    }

    render() {
        return (
            <div className="main-div">
                <SelectType selectUnitType = {this.unitTypeHandler}/>
                <InputLeft  inputTypeLeft={this.inputTypeLeftHandler} selectMeasurementTypeLeft={this.measumentTypeLeftHandler} showType={this.state.showType} />
                <div className="equals-div"> <i className="equals-icon"><FaEquals /> </i></div>
                <InputRight inputRightValue={this.state.inputTypeRight} inputTypeRight={this.inputTypeRightHandler} selectMeasurementTypeRight={this.measumentTypeRightHandler} showType={this.state.showType} />
                <Formula measurementTypeLeft={this.state.measurementTypeLeft} measurementTypeRight={this.state.measurementTypeRight}/>
            </div>
        );
    }
}