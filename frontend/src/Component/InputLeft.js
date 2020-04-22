import React, { Component } from "react";

export default class InputLeft extends Component{
    render(){
        return(
          <div className="input-div-left">
                <input type="text" className="input-field" onChange={this.props.inputTypeLeft}/>
                <select className="value-type" onChange={this.props.selectMeasurementTypeLeft}>
                <option>Select measurement type</option>
                {
                    this.props.showType?
                    <>
                    <option name="Length">Feet</option>
                    <option name="Length">Inch</option>
                    <option name="Length">Meter</option>
                    <option name="Length">Centimeter</option></> : <>
                    <option name="Weight">Gram</option>
                    <option name="Weight">Kilogram</option>
                </>
                }
                    </select>
              </div>  
        );
    }
}
