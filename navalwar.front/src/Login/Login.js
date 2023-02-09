import './Login.css';
import { useContext, useState } from 'react';

export const Login = () => {

    const [pseudo, setpseudo] = useState("");

    return (
        <form action="" method="post" onSubmit={(e) => mySubmit(e)}>
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