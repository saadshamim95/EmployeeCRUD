import React, { Component } from 'react';

export default class SelectType extends Component {
    render() {
        return (

            <div class="form">
                    <select className="select-bar" onChange={this.props.selectUnitType}>
                        <option>Select unit type</option>
                        <option>Length</option>
                        <option>weight</option>
                    </select>
            </div>
        );
    }
}