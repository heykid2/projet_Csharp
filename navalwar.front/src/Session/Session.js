import React, { useState, useEffect } from 'react';

export const Session = () => {

    //get sessions libres
    const [sessions, setSessions] = useState([]);
    useEffect(() => {
        fetch('https://localhost:3000/api/Session/available').then(response => response.json()).then(json => setSessions(json));
    }, []);

    const [selectedSession, setSelectedSession] = useState(null);
    const [newSessionName, setNewSessionName] = useState('');

    let player;

    const handleSessionClick = (session) => {
        session.player2Id = player.id;
        session.status = 1;
        fetch('https://localhost:3000/api/Session', {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(session)
        });

        //redirection placement
    };

    const handleNewSessionChange = (event) => {
        setNewSessionName(event.target.value);
    };

    const handleNewSessionSubmit = (event) => {
        event.preventDefault();
        const newSession = {
            id: sessions.length + 1,
            player1Id: player.Id,
            player2Id: undefined,
            winnerPlayerId: undefined,
            status: 0
        };

        fetch('https://localhost:3000/api/Session', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(newSession)
        });

        console.log("Session créée");

        setSelectedSession(newSession);
        setNewSessionName('');
    };

    return (
        <div>
            <h2>Sessions</h2>
            <ul>
                {sessions.map((session) => (
                    <li
                        key={session.id}
                        onClick={() => handleSessionClick(session)}
                        style={{ fontWeight: selectedSession?.id === session.id ? 'bold' : 'normal' }}
                    >
                        {session.name}
                    </li>
                ))}
            </ul>
            <div>
                <h3>Create new session</h3>
                <form onSubmit={handleNewSessionSubmit}>
                    <label>
                        Name:
                        <input type="text" value={newSessionName} onChange={handleNewSessionChange} />
                    </label>
                    <button type="submit">Create</button>
                </form>
            </div>
            <div>
                {selectedSession ? (
                    <div>
                        <h3>Selected session</h3>
                        <p>{selectedSession.name}</p>
                    </div>
                ) : (
                    <p>No session selected</p>
                )}
            </div>
        </div>
    );
}