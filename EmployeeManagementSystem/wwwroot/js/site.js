"use strict";
const logoutBtnTarget = document.querySelector(".profile-picture-wrapper");
const logoutBtn = document.querySelector(".logout-btn");
const hamburgerTarget = document.getElementById("hamburger-target");
const myFirstChild = document.querySelector(".my-dashboard-first-child");
const myLastChild = document.querySelector(".my-dashboard-last-child");


logoutBtnTarget.addEventListener("click", function(){
    logoutBtn.classList.toggle("logout-add-me");
});

hamburgerTarget.addEventListener("click", function(){
    myFirstChild.classList.toggle("dashboard-first-child-add");
    myLastChild.classList.toggle("dashboard-last-child-add");
});
