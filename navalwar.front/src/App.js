import React, { Component } from 'react';
import './App.css'
import { Login } from './Login/Login';
import { Game } from './Game/Game';
import { BrowserRouter, Routes, Route } from "react-router-dom";

export default class App extends Component {
    render() { return (
        <BrowserRouter>
                <main>
                    <Routes>
                        <Route>
                            <Route path="*" element={<Login />} />
                            <Route path="/game" element={<Game />} />
                        </Route>
                    </Routes>
                </main>
        </BrowserRouter>
        )
    }
}
