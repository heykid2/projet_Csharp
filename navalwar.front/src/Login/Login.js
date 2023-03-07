import './Login.css';
import { useContext, useState } from 'react';

export const Login = () => {

    const [pseudo, setpseudo] = useState("");

    const connectPlayer = (e) => {
        e.preventDefault();

        const response = fetch('https://localhost:3000/api/User', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ name: pseudo })
        });

        if (response.ok === true) {
            console.log("player cree");

            const session = fetch('https://localhost:3000/api/session/available', {
                headers: {
                    'Accept': 'application/json'
                }
            });

            if (session === null) {
                fetch('https://localhost:3000/api/session/available', {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        id: Math.ceil(Math.random() * 10000),
                        player1Id: 1,
                        player2Id: 2,
                        winnerId: -1
                    })
                });
            }
            else { 
                fetch('https://localhost:3000/api/session/available', {
                    method: 'PUT',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify()
                });
            }
        }
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
}