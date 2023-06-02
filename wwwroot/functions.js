function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    ev.target.appendChild(document.getElementById(data));
}

var tokenId = 0;
var tokenURL = "";

function getTokenURL(newTokenURL) {
    tokenURL = newTokenURL;
}

function deleteToken(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    var token = document.getElementById(data);
    token.remove();
}

function createToken() {
    // Cria um token
    const token = document.createElement("img");
    token.id = tokenId;
    token.src = tokenURL;
    token.width = "75";
    token.height = "75";
    token.setAttribute("draggable", "true");
    token.setAttribute("ondragstart", "drag(event)");

    // Da um append em outro elemento
    document.getElementById("createTokenSlot").appendChild(token);
    tokenId = tokenId + 1;
}

function changeBackground(backgroundURL) {
    var table = document.getElementById("gameBoard");
    table.style.backgroundImage = "url(" + backgroundURL + ")";
}

// Alertas ----------------------------------------------------------------------------------------------------------------------------
function alertSaveBackground() {
    alert("A imagem de background foi salva.")
}