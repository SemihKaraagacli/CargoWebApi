import { useEffect, useState } from 'react';
import './App.css';

function App() {
  const [data, setData] = useState([]);

  useEffect(() => {
    fetch('http://localhost:5062/Cargo')
      .then((response) => response.json())
      .then((incomingData) => {
        setData(incomingData); // Verileri state'e yerleştir
        console.log(incomingData);
      })
      .catch((error) => {
        console.error('Error fetching cargo data:', error);
      });
  }, []);

  return (
    <div>
      <h1>Cargo List</h1>
      <ul>
        {data.map((cargoItem, index) => (
          <li key={index}>
            {cargoItem.id} --- 
            {cargoItem.consignataryName} --- 
            {cargoItem.consignatarySurname} --- 
            {cargoItem.consignataryAddress} --- 
            {cargoItem.consignataryPhoneNumber} --- 
            {cargoItem.shipperName} --- 
            {cargoItem.shipperSurname} --- 
            {cargoItem.shipperAddress} --- 
            {cargoItem.shipperPhoneNumber} --- 
            {cargoItem.typeId} --- 
          </li> // Örnek olarak, cargoItem'in name özelliğini göster
        ))}
      </ul>
    </div>
  );
}

export default App;
