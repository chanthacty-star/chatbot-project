body {
    margin: 0;
    font-family: Arial, sans-serif;
    background: #1e1e2f;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

.chat-container {
    width: 400px;
    height: 600px;
    background: white;
    border-radius: 12px;
    overflow: hidden;
    display: flex;
    flex-direction: column;
    box-shadow: 0 0 15px rgba(0,0,0,0.2);
}

.chat-header {
    background: #4a6cf7;
    color: white;
    padding: 20px;
    font-size: 20px;
    font-weight: bold;
}

.chat-box {
    flex: 1;
    padding: 15px;
    overflow-y: auto;
    background: #f4f4f4;
}

.bot-message,
.user-message {
    margin-bottom: 10px;
    padding: 12px;
    border-radius: 10px;
    max-width: 75%;
}

.bot-message {
    background: #e0e0e0;
}

.user-message {
    background: #4a6cf7;
    color: white;
    margin-left: auto;
}

.input-area {
    display: flex;
    padding: 10px;
    background: white;
}

input {
    flex: 1;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 8px;
}

button {
    margin-left: 10px;
    padding: 10px 15px;
    border: none;
    background: #4a6cf7;
    color: white;
    border-radius: 8px;
    cursor: pointer;
}