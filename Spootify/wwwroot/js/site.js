// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



document.getElementById("makePlaylistBtn").addEventListener("click", SavePlaylistTitle);

function SavePlaylistTitle() {
    let submittedTitle = document.getElementById("playlistNameId").value;
    document.getElementById("playlistTitle").innerHTML = submittedTitle;
    document.getElementById("makePlaylistBtn").style.transition = "1s";
    document.getElementById("makePlaylistBtn").style.left = "1100px";
    document.getElementById("makePlaylistBtn").style.transitionDelay = "1s";
    document.getElementById("playlistNameId").style.transition = "1s";
    document.getElementById("playlistNameId").style.left = "1100px";
    document.getElementById("playlistNameId").style.transitionDelay = "2s";
    document.getElementById("playlistNameId").value = "";
    setTimeout(ChangeBtnText, 1250);
    setTimeout(ChangeInputText, 2250);
}

function ChangeBtnText() {
    document.getElementById("makePlaylistBtn").innerHTML = "Add Song!";
}


function ChangeInputText() {
    document.getElementById("playlistNameId").placeholder = "Enter Song Name";
}
