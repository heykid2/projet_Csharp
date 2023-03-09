import React, { useState } from 'react';

export const Session = () => {

    //get sessions libres
    const [sessions, setSessions] = useState([
        { id: 1, name: 'Session 1' },
        { id: 2, name: 'Session 2' },
        { id: 3, name: 'Session 3' },
    ]);
    const [selectedSession, setSelectedSession] = useState(null);
    const [newSessionName, setNewSessionName] = useState('');

    const handleSessionClick = (session) => {
        setSelectedSession(session);
    };

    const handleNewSessionChange = (event) => {
        setNewSessionName(event.target.value);
    };

    const handleNewSessionSubmit = (event) => {
        event.preventDefault();
        const newSession = {
            id: sessions.length + 1,
            name: newSessionName,
        };
        setSessions([...sessions, newSession]);
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