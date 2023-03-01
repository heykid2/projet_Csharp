import './Game.css';
import React, { useState } from 'react';

export const Game = () => {
    const [grid, setGrid] = useState([
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
        ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O']
    ]);

    //toucher/couler
    const handleClick = (rowIndex, colIndex) => {
        const newGrid = [...grid];
        //appel api avec coordonnees click -> retour bool
        let hit = false;
        if (hit === true) {
            newGrid[rowIndex][colIndex] = 'X';
        }
        else {
            newGrid[rowIndex][colIndex] = 'S';
        }
        setGrid(newGrid);
    };

    return (
        <div className="board-container">
            <div>
                {grid.map((row, rowIndex) => (
                    <div key={rowIndex} style={{ display: 'flex' }}>
                        {row.map((cell, colIndex) => (
                            <div
                                key={colIndex}
                                style={{
                                    width: '50px',
                                    height: '50px',
                                    border: '1px solid black',
                                    textAlign: 'center',
                                    lineHeight: '50px',
                                    cursor: 'pointer',
                                    backgroundColor: cell === 'O' ? 'white' : cell === 'X' ? 'red' : 'gray'
                                }}
                                onClick={() => handleClick(rowIndex, colIndex)}
                            >
                                {cell === 'S' ? 'O' : cell}
                            </div>
                        ))}
                    </div>
                ))}
            </div>
        </div>
    );
};