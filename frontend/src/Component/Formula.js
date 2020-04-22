
import React, { Component } from 'react';

export default class Formula extends Component {
    render() {
        return (
            <div className="label">
                <label className='formula-label' onChange={this.props.selectMeasurementTypeLeft}>Formula</label>
                {
                    (this.props.measurementTypeLeft === "Feet" && this.props.measurementTypeRight === "Inch") ?
                        <p className="p-label">multiply the length value by 12</p> :
                        (this.props.measurementTypeLeft === "Inch" && this.props.measurementTypeRight === "Feet") ?
                            <p className="p-label">divide the length value by 12</p> :
                            (this.props.measurementTypeLeft === "Meter" && this.props.measurementTypeRight === "Centimeter") ?
                                <p className="p-label">multiply the length value by 100</p> :
                                (this.props.measurementTypeLeft === "Centimeter" && this.props.measurementTypeRight === "Meter") ?
                                    <p className="p-label">divide the length value by 100</p> :
                                    (this.props.measurementTypeLeft === "Kilogram" && this.props.measurementTypeRight === "Gram") ?
                                        <p className="p-label">multiply the mass value by 1000</p> :
                                        (this.props.measurementTypeLeft === "Gram" && this.props.measurementTypeRight === "Kilogram") ?
                                            <p className="p-label">divide the mass value by 1000</p> : null
                }
            </div>
        )
    }
}