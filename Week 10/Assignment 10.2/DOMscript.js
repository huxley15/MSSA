document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('btnAddHobby').addEventListener('click', addHobby);
});

function addHobby() {
    //get all hobbies input text boxes
    const inputList = document.querySelectorAll('.hobbyInput');
    //check if hobbies are less than 5
    if (inputList.length < 5) {
        const hobbyList = document.getElementById('hobbyList');
        const newlineelement = CreateNode('br'), //create br
            inputElement = CreateNode('input'); //create input
        inputElement.setAttribute("class", "hobbyInput");
        append(hobbyList, newlineelement); //add br into div
        append(hobbyList, inputElement); //add input text box into div
    }
    else {
        document.getElementById('btnAddHobby').removeEventListener('click', addHobby);
    }
}

function CreateNode(element) {
    return document.createElement(element);
}

function append(parent, el) {
    return parent.appendChild(el);
}