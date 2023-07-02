document
  .getElementById("profesor-form")
  .addEventListener("submit", function (event) {
    event.preventDefault();

    // Obtiene el valor del campo DNI
    let dni = document.getElementById("dni").value;

    // Realiza la lógica para obtener los datos del profesor y los horarios
    let nombre = "Juan Perez";
    let edad = 35;
    let email = "juan@example.com";
    let horarios = [
      { curso: "Matemáticas", dia: "Lunes", inicio: "08:00", fin: "10:00" },
      { curso: "Historia", dia: "Miércoles", inicio: "10:00", fin: "12:00" },
      { curso: "Ciencias", dia: "Viernes", inicio: "14:00", fin: "16:00" },
    ];

    // Muestra los datos del profesor
    document.getElementById("nombre").value = nombre;
    document.getElementById("edad").value = edad;
    document.getElementById("email").value = email;

    // Muestra los horarios en la tabla
    var horariosTable = document.getElementById("horarios-body");
    horariosTable.innerHTML = "";
    horarios.forEach(function (horario) {
      var row = document.createElement("tr");
      row.innerHTML =
        "<td>" +
        horario.curso +
        "</td><td>" +
        horario.dia +
        "</td><td>" +
        horario.inicio +
        "</td><td>" +
        horario.fin +
        "</td>";
      horariosTable.appendChild(row);
    });

    // Muestra el div de resultados
    document.getElementById("resultado").style.display = "block";
  });




