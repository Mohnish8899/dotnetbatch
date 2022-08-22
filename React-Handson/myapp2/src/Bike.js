import React,{Component} from 'react';

class Bike extends Component {
  constructor(props) {
    super(props);

    this.state = { brand: 'Honda', model: 'CB 200X' };
  }

  render() {
    return (
      <div>
        <h1>
          My bikes brand is {this.state.brand} and the model is{' '}
          {this.state.model}{' '}
        </h1>
      </div>
    );
  }
}
export default Bike;
