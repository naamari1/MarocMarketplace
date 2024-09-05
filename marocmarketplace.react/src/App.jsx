import React from 'react';
import './App.css';
import { Routes, Route, Link } from 'react-router-dom';
import Products from './Products';  // Import the Products component

function App() {
    return (
        <div className="App">
            <nav>
                <ul>
                    <li>
                        <Link to="/">Home</Link>  // Link to the homepage
                    </li>
                    <li>
                        <Link to="/products">Products</Link>  // Link to the Products page
                    </li>
                </ul>
            </nav>
            <Routes>
                <Route path="/" element={<Home />} />  // Route for the homepage
                <Route path="/products" element={<Products />} />  // Route for the Products page
            </Routes>
        </div>
    );
}

function Home() {
    return <h1>Welcome to the Homepage</h1>;  // Content for the homepage
}

export default App;
