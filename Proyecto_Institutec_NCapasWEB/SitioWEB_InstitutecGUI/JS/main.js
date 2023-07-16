function validarNumeros(input) {
    var regex = /^\d+$/;
    var valor = input.value;
    if (!regex.test(valor)) {
        input.value = valor.replace(/\D/g, ''); // Eliminar caracteres no numéricos
    }
}
