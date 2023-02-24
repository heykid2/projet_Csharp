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

    //TODO: get les bateaux avec l'api
    const [ships] = useState([
        { id: 1, name: 'Carrier', size: 5, orientation: 'horizontal', row: -1, col: -1, cells: [] },
        { id: 2, name: 'Battleship', size: 4, orientation: 'vertical', row: -1, col: -1, cells: [] },
        { id: 3, name: 'Destroyer', size: 3, orientation: 'horizontal', row: -1, col: -1, cells: [] },
        { id: 4, name: 'Submarine', size: 3, orientation: 'vertical', row: -1, col: -1, cells: [] },
        { id: 5, name: 'Patrol Boat', size: 2, orientation: 'horizontal', row: -1, col: -1, cells: [] }
    ]);

    let currentShipId = -1;
    const [shipToPlace, setShipToPlace] = useState([]);

    //toucher/couler
    /*const handleClick = (rowIndex, colIndex) => {
        const newGrid = [...grid];
        const shipIndex = findShipIndex(rowIndex, colIndex);
        if (shipIndex >= 0) {
            const { size, orientation, row, col } = ships[shipIndex];
            const newShip = { name: ships[shipIndex].name, size, orientation, row, col };
            const isShipVertical = orientation === 'vertical';
            const newShipCells = [];
            for (let i = 0; i < size; i++) {
                const newRowIndex = isShipVertical ? row + i : row;
                const newColIndex = isShipVertical ? col : col + i;
                newShipCells.push([newRowIndex, newColIndex]);
                newGrid[newRowIndex][newColIndex] = 'S';
            }
            const newShips = [...ships];
            newShips[shipIndex] = { ...newShip, cells: newShipCells };
            setShips(newShips);
        } else {
            newGrid[rowIndex][colIndex] = 'X';
        }
        setGrid(newGrid);
    };

    const findShipIndex = (rowIndex, colIndex) => {
        return ships.findIndex(ship =>
            ship.cells && ship.cells.some(([row, col]) => row === rowIndex && col === colIndex)
        );
    };*/

    //placer navire
    const handlePlaceShip = (rowIndex, colIndex) => {
        if (currentShipId !== -1) {
            const ship = ships.find(s => s.id === currentShipId);
            const isShipVertical = ship.orientation === 'vertical';
            for (let i = 0; i < ship.size; i++) {
                const newRowIndex = isShipVertical ? rowIndex + i : rowIndex;
                const newColIndex = isShipVertical ? colIndex : colIndex + i;
                if (newRowIndex >= grid.length || newColIndex >= grid[0].length) {
                    alert('Cannot place ship outside the grid!');
                    return;
                }
                if (grid[newRowIndex][newColIndex] === 'S') {
                    alert('Cannot place ship on top of another ship!');
                    return;
                }
                ship.cells.push([newRowIndex, newColIndex]);
            }
            for (let i = 0; i < ship.size; i++) {
                const newRowIndex = isShipVertical ? rowIndex + i : rowIndex;
                const newColIndex = isShipVertical ? colIndex : colIndex + i;
                const newGrid = [...grid];
                newGrid[newRowIndex][newColIndex] = 'S';
                setGrid(newGrid);
            }
        }
    };

    const shipBtns = ships.map(ship => {
        return (
            <button key={ship.id} onClick={() => currentShipId = ship.id}> {ship.name} </button>
        );
    });

    return (
        <>
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
                                onClick={() => handlePlaceShip(rowIndex, colIndex)}
                            >
                                {cell === 'S' ? 'O' : cell}
                            </div>
                        ))}
                    </div>
                ))}
            </div>
            <div>
                { shipBtns }
            </div>
        </>
    );
};