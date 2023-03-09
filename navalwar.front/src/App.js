import React, { Component } from 'react';
import './App.css'
import { Login } from './Login/Login';
import { Placement } from './Placement/Placement';
import { Game } from './Game/Game';
import { Session } from './Session/Session';
import { BrowserRouter, Routes, Route } from "react-router-dom";

export default class App extends Component {
    render() { return (
        <BrowserRouter>
                <main>
                    <Routes>
                        <Route>
                            <Route path="*" element={<Login />} />
                            <Route path="/placement" element={<Placement />} />
                            <Route path="/game" element={<Game />} />
                            <Route path="/sessions" element={<Session />} />
                        </Route>
                    </Routes>
                </main>
        </BrowserRouter>
        )
    }
}
