import './Placement.css';
import React, { useState } from 'react';
import { Link } from 'react-router-dom';

export const Placement = () => {
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

    //TODO: trouver un moyen de mettre le player + de le passer dans l'api
    const [ships, setShips] = useState([]);

    useEffect(() => {
        fetch('https://localhost:3000/api/{player.Id}/ships').then(response => response.json()).then(json => setShips(json));
    }, []);


    //    useState([
    //    { id: 1, name: 'Carrier', size: 5, orientation: 'horizontal', row: -1, col: -1, cells: [] },
    //    { id: 2, name: 'Battleship', size: 4, orientation: 'vertical', row: -1, col: -1, cells: [] },
    //    { id: 3, name: 'Destroyer', size: 3, orientation: 'horizontal', row: -1, col: -1, cells: [] },
    //    { id: 4, name: 'Submarine', size: 3, orientation: 'vertical', row: -1, col: -1, cells: [] },
    //    { id: 5, name: 'Patrol Boat', size: 2, orientation: 'horizontal', row: -1, col: -1, cells: [] }
    //]);



    const [placedShips, setPlacedShips] = useState([]);

    const [currentShipId, setCurrentShipId] = useState([]);

    const handlePlaceShip = (rowIndex, colIndex) => {
        if (currentShipId !== -1) {
            const ship = ships[currentShipId - 1];
            if (ship !== undefined) {
                placeShip(rowIndex, colIndex, ship);
            }
        }
    }

    //placer navire
    const placeShip = (rowIndex, colIndex, ship) => {
        ship.X = rowIndex;
        ship.Y = colIndex;
        const isShipVertical = ship.isVertical;
        for (let i = 0; i < ship.size; i++) {
            const newRowIndex = isShipVertical ? rowIndex + i : rowIndex;
            const newColIndex = isShipVertical ? colIndex : colIndex + i;
            if (newRowIndex >= grid.length || newColIndex >= grid[0].length) {
                alert('Cannot place ship outside the grid!');
                return false;
            }
            if (grid[newRowIndex][newColIndex] === 'S') {
                alert('Cannot place ship on top of another ship!');
                return false;
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

        if (ships[currentShipId - 1] !== undefined) {
            placedShips[currentShipId - 1] = ship;
            delete ships[currentShipId - 1];
        }

        return true;
    };

    const handleRotateShip = () => {
        const ship = placedShips[currentShipId - 1];
        ship.isShipVertical = !ship.isVertical;

        if (placeShip(ship.X, ship.Y, ship) === true) {
            for (let i = 0; i < ship.cells.length; i++) {
                const row = ship.cells[i][0];
                const col = ship.cells[i][1];
                const newGrid = [...grid];
                newGrid[row][col] = 'O';
                setGrid(newGrid);
            }
        }
    };

    const handleRemoveShip = () => {
        const ship = placedShips[currentShipId - 1];

        if (ship !== undefined) {
            for (let i = 0; i < ship.cells.length; i++) {
                const row = ship.cells[i][0];
                const col = ship.cells[i][1];
                const newGrid = [...grid];
                newGrid[row][col] = 'O';
                setGrid(newGrid);
            }

            ships[currentShipId - 1] = ship;
            delete placedShips[currentShipId - 1];
        }
    };

    const shipsBtns = ships.map(ship => {
        return (
            <button id="button" key={ship.id} onClick={() => setCurrentShipId(ship.id)}> {ship.name} </button>
        );
    });

    const placedShipsBtns = placedShips.map(ship => {
        return (
            <button id="button" key={ship.id} onClick={() => setCurrentShipId(ship.id)}> {ship.name} </button>
        );
    });

    const saveBoats = () => {
        if (allShipsPlaced(ships) === true) {
            for (let i = 0; i < ships.length; ++i) {
                let ship = ships[i];
                fetch('https://localhost:3000/api/{player.id}/ship/{ships[i].id}', {
                    method: 'PUT',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        id: ship.id,
                        pv: ship.pv,
                        x: ship.x,
                        y: ship.y,
                        size: ship.size,
                        isVertical: ship.isVertical,
                        name: ship.name
                    })
                });
            }
        }
    };

    return (
        <div className="game-container">
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
            <div className="buttons">
                <h2>A placer</h2>
                { shipsBtns }
                <h2>Sur le plateau</h2>
                {placedShipsBtns}
                <div className="remove-rotate">
                    <button id="button" onClick={() => handleRotateShip()}>Rotate Ship</button>
                    <button id="button" onClick={() => handleRemoveShip()}>Remove Ship</button>
                    <Link to={allShipsPlaced(ships) ? '/game' : '#'} >
                        <button id="button" enabled={allShipsPlaced(ships)} onClick={() => saveBoats() }>C'est parti !</button>
                    </Link>
                </div>
            </div>
        </div>
    );
};

function allShipsPlaced(ships) {
    for (let i = 0; i < ships.length; ++i) {
        if (ships[i] !== undefined) {
            return false;
        }
    }
    return true;
}