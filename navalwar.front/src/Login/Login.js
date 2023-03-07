import './Login.css';
import { useContext, useState } from 'react';
import { Link } from 'react-router-dom';

export const Login = () => {

    const [pseudo, setpseudo] = useState("");

    let session = undefined;

    const connectPlayer = (e) => {
        e.preventDefault();

        const player = { id: Math.ceil(Math.random() * 10000), name: pseudo };

        const response = fetch('https://localhost:3000/api/User', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(player)
        });

        if (response.ok === true) {
            console.log("player cree");

            session = fetch('https://localhost:3000/api/session/available', {
                headers: {
                    'Accept': 'application/json'
                }
            });

            if (session === null) {
                session = {
                    id: Math.ceil(Math.random() * 10000),
                    player1Id: player.id,
                    player2Id: undefined,
                    winnerPlayerId: undefined,
                    status: 0
                };

                fetch('https://localhost:3000/api/session/available', {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(session)
                });

                console.log("en attente");
            }
            else { 
                session = {
                    id: session.id,
                    player1Id: session.player1Id,
                    player2Id: player.id,
                    winnerPlayerId: undefined,
                    status: 1
                };

                fetch('https://localhost:3000/api/session/available', {
                    method: 'PUT',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(session)
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
                <Link to={(session.player1Id !== undefined && session.player2Id !== undefined) ? '/placement' : '#'} >
                    <input type="submit" value="C'est parti !" required />
                </Link>
            </div>
        </form>
    )
}