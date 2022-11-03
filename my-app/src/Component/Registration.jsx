import React, { useState } from 'react'

const Registration = () => {
    const [name, setName] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [address, setAddress] = useState("");
   
    const [AllEntry, setAllEntry] = useState([]);
    const submitForm = (e) => {
        e.preventDefault();
        const newEntry = { name, email, password, address};
        setAllEntry([...AllEntry, newEntry]);
        console.log(AllEntry);
    }
    return (
        <>
            <div>
                <h1>This is the Registration form</h1>
                <form onClick={submitForm} >
                    <div>
                        <label htmlFor='Name'>Name:</label>
                        <input type="text"
                            name='name'
                            id='text'
                            autoComplete='off'
                            value={name}
                            onChange={(e) => setName(e.target.value)}
                        />
                    </div>
                    <div>
                        <label htmlFor='email'>Email:</label>
                        <input type="text"
                            name='email'
                            id='text'
                            autoComplete='off'
                            value={email}
                            onChange={(e) => setEmail(e.target.value)}
                        />
                    </div>
                    <div>
                        <label htmlFor='Password'>Password</label>
                        <input type="password"
                            name='password'
                            id='password'
                            autoComplete='off'
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
                        />
                    </div>
                    <div>
                        <label htmlFor='address'>Address</label>
                        <input type="text"
                            name='address'
                            id='text'
                            autoComplete='off'
                            value={address}
                            onChange={(e) => setAddress(e.target.value)}
                        />
                    </div>
                </form>
            </div>
            <button type='submit'>Submit</button>
        </>
    )
}

export default Registration
