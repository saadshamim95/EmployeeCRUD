import React, { Component } from "react";

export default class InputRight extends Component {
    render() {
        return (
            <div className="input-div-right">
                <input type="text" className="input-field" onChange={this.props.inputTypeRight} value={this.props.inputRightValue}/>
                <select className="value-type" onChange={this.props.selectMeasurementTypeRight}>
                    <option>Select measurement type</option>
                {
                    this.props.showType?
                    <>
                    <option name="Length">Inch</option>
                    <option name="Length">Feet</option>
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
