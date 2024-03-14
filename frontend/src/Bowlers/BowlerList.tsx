import { useEffect, useState } from 'react';
import { Bowlers } from '../types/Bowlers';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowlers[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:44351/bowler');
      const b = await rsp.json();
      setBowlerData(b);
    };

    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h2 className="text-center">Bowlers</h2>
      </div>
      <br></br>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr>
              <td>{b.bowlerName}</td>
              <td>{b.teamName}</td>
              <td>{b.address}</td>
              <td>{b.phone}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
