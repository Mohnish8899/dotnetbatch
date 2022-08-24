import React,{Component} from 'react';

class School1 extends Component {
  constructor(props) {
    super(props);

    this.state = { University: 'MSBTE', Collage: 'RCPP' };
  }

  render() {
    return (
      <div>
        <h1>
          I have completed my diploma from {this.state.University} University and Collage name is {' '}
          {this.state.Collage}{' '}
        </h1>
      </div>
    );
  }
}
export default School1;