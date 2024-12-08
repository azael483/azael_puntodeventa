function renderCarrito() {
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    $(document).ready(function() {
        // Función para actualizar el carrito
        function actualizarCarrito() {
            $.ajax({
                url: '/Carrito/ObtenerProductosCarrito', // Ruta a tu controlador
                success: function(data) {
                    var listaProductos = $('#carrito');
                    listaProductos.empty();
                    var total = 0;

                    $.each(data, function(index, producto) {
                        listaProductos.append(`
                            <li class="list-group-item">
                                <span>${producto.Id}</span> - ${producto.Nombre} x ${producto.Cantidad} - $${producto.Precio}
                                <button class="btn btn-danger btn-sm eliminar" data-id="${producto.Id}">Eliminar</button>
                            </li>
                        `);
                        total += producto.Precio * producto.Cantidad;
                    });

                    $('#total').text(total.toFixed(2));
                }
            });
        }

        // Inicializar el carrito
        actualizarCarrito();

        // Eliminar un producto del carrito
        $(document).on('click', '.eliminar', function() {
            var productId = $(this).data('id');
            $.ajax({
                url: '/Carrito/EliminarProducto',
                data: { id: productId },
                success: function() {
                    actualizarCarrito();
                }
            });
        });
    });
  }
  
  function agregarAlCarrito(producto) {
    const productoEnCarrito = carrito.find(p => p.Id === producto.Id);
  
    if (productoEnCarrito) {
      productoEnCarrito.cantidad++;
    } else {
      carrito.push({ ...producto, cantidad: 1 });
    }
  
    localStorage.setItem('carrito', JSON.stringify(carrito));
    renderCarrito();
  }
  
  function eliminarDelCarrito(productId) {
    carrito = carrito.filter(p => p.Id !== productId);
    localStorage.setItem('carrito', JSON.stringify(carrito));
    renderCarrito();
  }
  
  window.addEventListener('load', () => {
    carrito = JSON.parse(localStorage.getItem('carrito')) || [];
    renderCarrito();
  });
  
  window.addEventListener('beforeunload', () => {
    localStorage.setItem('carrito', JSON.stringify(carrito));
  });