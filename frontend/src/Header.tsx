import logo from './spencerout.png';

function Header() {
  return (
    <header className="row navbar-dark bg-dark main">
      <div className="col-4 titlelogo">
        <img src={logo} className="logo" alt="logo" height="150px" />
      </div>
      <div className="maintitle">
        <h1 id="title" className="col subtitle">
          Bowling League Info Page
        </h1>
      </div>
    </header>
  );
}

export default Header;
