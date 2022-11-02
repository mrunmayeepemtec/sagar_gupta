import React from 'react'


const Car = () => {
    const car = {
        model: 'i20',
        company: 'Hyundai',
        price: 20,
        configuration: {
            color: 'gray',
            fuel: 'petrol',
            cylinder: 4,
            fuelTankCapacity: 37,
            mileage: {
                city: 14,
                highway: 20,
            },
        },
        features: ['touch screen', 'bluetooth', 'alloy wheels', 'power steering'],
    }

    return (
        <div>
            <ul>
                <li>Model:{car.model}</li>
                <li>Company{car.company}</li>
                <li>Price:{car.price}</li>
                <li>Configuration:{car.configuration.color}</li>
                <li>Fuel:{car.configuration.fuel}</li>
                <li>Cylinder{car.configuration.cylinder}</li>
                <li>Capacity:{car.configuration.fuelTankCapacity}</li>
                <li>MileageCity:{car.configuration.mileage.city}</li>
                <li>Mileage{car.configuration.mileage.highway}</li>
            </ul>
        </div>
    )
}

export default Car