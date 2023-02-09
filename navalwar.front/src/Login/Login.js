import './Login.css';
import { useContext, useState } from 'react';

export const Login = () => {

    const [pseudo, setpseudo] = useState("");

    const connectPlayer = (e) => {
        e.preventDefault();

        postData('http://cabe0232.odns.fr/webdev-api/order', {
            id: Math.floor(Math.random() * 10000000000),
            description: getDetail(foods, menus),
            price: Math.round((sum(foods) + sum(menus)) * 100) / 100,
            date: new Date(),
            client: firstname + " " + lastname + " (" + tel + ")"
        })
            .then((data) => {
                console.log(data); // JSON data parsed by `data.json()` call
            });
    }

    return (
        <form action="" method="post" onSubmit={(e) => connectPlayer(e)}>
            <label><strong>Commencer une partie</strong></label>
            <div>
                <label>Pseudo : </label>
                <input type="text" name="name" id="name" placeholder="Tabouret" required onChange={(e) => setpseudo(e.target.value)} />
            </div>
            <div>
                <input type="submit" value="C'est parti !" required />
            </div>
        </form>
    )

    async function postData(url = '', data = {}) {
        // Default options are marked with *
        const response = await fetch(url, {
            method: 'POST', // *GET, POST, PUT, DELETE, etc.
            mode: 'cors', // no-cors, *cors, same-origin
            headers: {
                'Content-Type': 'application/json'
                // 'Content-Type': 'application/x-www-form-urlencoded',
            },
            body: JSON.stringify(data) // body data type must match "Content-Type" header
        });

        if (response.status < 300) {
            console.log("commande enregistrée");
        }

        return response.text(); // parses JSON response into native JavaScript objects
    }
}