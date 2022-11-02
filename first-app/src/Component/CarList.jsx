import React from 'react'

const CarList = (props) => {
    const {car} = props;
  return (
   <div>
    <tbody>
      {car.map((car) => {
        return(
        <tr>
          <td>{car.model}</td>
          <td>{car.company}</td>
          <td>{car.price}</td>
          <td>{car.configuration.color}</td>
          <td>{car.configuration.fuel}</td>
          <td>{car.configuration.cylinder}</td>
          <td>{car.configuration.fuelTankCapacity}</td>
          <td>{car.configuration.mileage.city}</td>
          <td>{car.configuration.mileage.highway}</td>
        </tr>  
        )
      })}
      </tbody>
    </div>
  )
}

export default CarList
