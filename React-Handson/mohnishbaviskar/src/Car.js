import React from "react";
class Car extends React.Component{
    constructor(props)
    {
        super(props);

        this.state = {brand: "Kia",model: "seltos"};

    }

    render()
    {
        return(
            <div>
                <h1>My Car {this.state.brand} and model {this.state.model} </h1>
            </div>
        );
    }
}export default Car;