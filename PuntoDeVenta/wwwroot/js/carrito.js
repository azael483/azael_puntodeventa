function obtenerCarrito() {
  return JSON.parse(localStorage.getItem('carrito')) || [];
}

function guardarCarrito(carrito) {
  localStorage.setItem('carrito', JSON.stringify(carrito));
}

function agregarAlCarrito(producto) {
  let carrito = JSON.parse(localStorage.getItem('carrito')) || [];
  
  // Verificar si el carrito está vacío
  if (carrito.length === 0) {
    console.log('El carrito está vacío');
  } else {
      console.log('El carrito contiene productos:', carrito);
  }

  // Verificar que el producto tenga un Id
  if (!producto.Id) {
    console.error('El producto no tiene un ID válido:', producto);
    return;
  }

  const productoEnCarrito = carrito.find(p => p.Id === producto.Id);

  // Si el producto ya está en el carrito, aumentar la cantidad
  if (productoEnCarrito) {
      productoEnCarrito.cantidad++;
  } else {
      // Si no está, agregarlo con cantidad 1
      carrito.push({ ...producto, cantidad: 1 });
  }

  // Guardar el carrito actualizado en localStorage
  localStorage.setItem('carrito', JSON.stringify(carrito));
  
  // Verificar el contenido de localStorage
  console.log(localStorage.getItem('carrito'));
  
  // Verificar el carrito actualizado
  console.log('Carrito actualizado:', carrito); 

  // Llamar a renderCarrito para actualizar la interfaz
  renderCarrito();

  // Mostrar un mensaje de éxito (esto dependerá de cómo hayas implementado el toast)
  mostrarToast("Producto añadido al carrito");
}



function eliminarDelCarrito(productId) {
  let carrito = obtenerCarrito();
  const nuevoCarrito = carrito.filter(p => p.Id !== productId);

  guardarCarrito(nuevoCarrito);
  renderCarrito();
}

function mostrarToast(mensaje) {
  const toast = $('#toast');
  toast.text(mensaje).fadeIn(400).delay(2000).fadeOut(400);
}
