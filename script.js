function sendMessage() {

    const input = document.getElementById("user-input");
    const chatBox = document.getElementById("chat-box");

    const message = input.value.trim();

    if(message === "") {
        return;
    }

    const userMessage = document.createElement("div");
    userMessage.classList.add("user-message");
    userMessage.textContent = message;

    chatBox.appendChild(userMessage);

    input.value = "";

    setTimeout(() => {

        const botMessage = document.createElement("div");
        botMessage.classList.add("bot-message");

        botMessage.textContent = getBotReply(message);

        chatBox.appendChild(botMessage);

        chatBox.scrollTop = chatBox.scrollHeight;

    }, 500);
}

function getBotReply(message) {

    message = message.toLowerCase();

    if(message.includes("hello")) {
        return "Hello! Nice to meet you.";
    }

    if(message.includes("how are you")) {
        return "I'm doing great. Thanks for asking!";
    }

    if(message.includes("bye")) {
        return "Goodbye! Have a nice day.";
    }

    return "I'm still learning. Please teach me more!";
}