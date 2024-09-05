import React, { useEffect, useState } from 'react';

function Products() {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        fetch('https://localhost:44322/api/products') // Ensure this matches your API URL
            .then(response => response.json())
            .then(data => setProducts(data))
            .catch(error => console.error('Error fetching products:', error));
    }, []);

    return (
        <div>
            <h2>Products</h2>
            <div style={{ margin: "10px 0" }}>
                {products.map(product => (
                    <div key={product.id} style={{ border: "1px solid gray", padding: "10px", marginBottom: "10px" }}>
                        <h3>{product.name}</h3>
                        <p>{product.description}</p>
                        <p>Price: ${product.price}</p>
                    </div>
                ))}
            </div>
        </div>
    );
}

export default Products;
