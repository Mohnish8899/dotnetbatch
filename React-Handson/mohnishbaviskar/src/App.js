import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div>
        <AppChild name="Matt" />
    </div>
  );
    }
    function AppChild(props)
    {
      return <span>
          My name is {props.name}
        </span>
    }
    export default App;
