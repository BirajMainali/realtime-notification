"use strict";
const connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub").build();
connection.start();

connection.on("onUserPresent", (message) => {
    toastr.success(message, {timeOut: 5000})
});
