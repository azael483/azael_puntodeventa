function renderCarrito() {
    const carrito = obtenerCarrito(); // Obtener el carrito desde localStorage
    console.log('Renderizando carrito:', carrito); // Verificar datos del carrito

    const listaProductos = $('#carrito'); // Seleccionar la lista
    listaProductos.empty(); // Limpiar la lista

    let total = 0; // Inicializar el total

    // Recorrer los productos en el carrito
    carrito.forEach(function (producto) {
        console.log('Producto en carrito:', producto); // Verificar cada producto

        // Crear el elemento de la lista
        listaProductos.append(`
            <li class="list-group-item d-flex justify-content-between align-items-center">
                ${producto.Nombre} x ${producto.cantidad} - $${formatearPrecio(producto.Precio * producto.cantidad)}
                <button class="btn btn-danger btn-sm eliminar" data-id="${producto.Id}">Eliminar</button>
            </li>
        `);

        // Sumar al total
        total += producto.Precio * producto.cantidad;
    });

    // Actualizar el total en la interfaz
    $('#total').text(formatearPrecio(total));

    // Asociar el evento de eliminar
    $(document).off('click', '.eliminar').on('click', '.eliminar', function () {
        const productId = $(this).data('id'); // Obtener el ID del producto
        console.log('Eliminando producto con ID:', productId); // Confirmar acción
        eliminarDelCarrito(productId); // Llamar a la función para eliminar
    });
}

// Formatear precios a dos decimales
function formatearPrecio(precio) {
    return precio.toFixed(2);
}
