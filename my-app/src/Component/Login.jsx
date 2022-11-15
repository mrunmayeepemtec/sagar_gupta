import React, { useState } from 'react'

const Login = () => {
    const[email, setEmail] = useState("");
    const[password, setPassword] = useState("");
    const[Allentry, setAllEntry] = useState([]);     

    const submitForm = (e) => {
        e.preventDefault();
        const newEntry = {email: email, password: password};
        // console.log(newEntry);
        setAllEntry([...Allentry, newEntry]);
        console.log(Allentry);
    };

    return (
        <>
            <form action='' onSubmit={submitForm}>
                <div>
                    <label htmlFor='email'>Email</label>
                    <input
                        type="email"
                        name="email"
                        id="email"
                        autocomplete="off"
                        value={email}
                        onChange={(e)=>setEmail(e.target.value)}
                    />
                </div>
                <div>
                    <label htmlFor='password'>Password</label>
                    <input
                        type="password"
                        name="password"
                        id="password"
                        autocomplete="off"
                        value={password}
                        onChange={(e)=>setPassword(e.target.value)}
                    />
                </div>
                <button type='Submit'>Submit</button>
            </form>
        </>
    )
}

export default Login
