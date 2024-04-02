import BowlerList from './BowlerLeague/BowlerList';
import logo from './stephaniebowling.png';
function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo-small" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title} </h1>
        <h6 className="text-white">
          {' '}
          Contact dictionary for the Marlin and Sharks bowling teams
        </h6>
      </div>
    </header>
  );
}

export default Header;
