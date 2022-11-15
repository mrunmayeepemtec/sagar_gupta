import React from 'react'

const CarList = (props) => {
    const cars = props;
  return (
   <div>
    
      {cars.map((s) => {
        return(
          <div>
        <ul>
          <li>{s.model}</li>
          <li>{s.company}</li>
          <li>{s.price}</li>
          <li>{s.configuration.color}</li>
          <li>{s.configuration.fuel}</li>
          <li>{s.configuration.cylinder}</li>
          <li>{s.configuration.fuelTankCapacity}</li>
          <li>{s.configuration.mileage.city}</li>
          <li>{s.configuration.mileage.highway}</li>
        </ul>  
        </div>
        )
      })}
      
    </div>
  )
}

export default CarList
