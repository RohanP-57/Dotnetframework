<%@ Page Language="C#" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>Login - Calculator</title>
    <style>
        body { font-family: Arial, Helvetica, sans-serif; display:flex; align-items:center; justify-content:center; height:100vh; margin:0; background:#f5f7fa; }
        .card { background:#fff; padding:24px; border-radius:8px; box-shadow:0 2px 8px rgba(0,0,0,0.08); width:320px; }
        .card h1 { margin:0 0 12px; font-size:20px; }
        .field { margin-bottom:12px; display:flex; flex-direction:column; }
        label { margin-bottom:6px; font-size:13px; color:#333; }
        input[type="text"], input[type="password"] { padding:8px; border:1px solid #ccc; border-radius:4px; font-size:14px; }
        button { width:100%; padding:10px; background:#0078d4; color:white; border:none; border-radius:4px; font-size:15px; cursor:pointer; }
        #message { margin-top:12px; font-size:14px; }
    </style>
    <script>
        // Static credentials (for demo only)
        function doLogin(evt) {
            evt.preventDefault();
            var user = document.getElementById('username').value.trim();
            var pass = document.getElementById('password').value;
            var msg = document.getElementById('message');

            if (user === 'admin' && pass === 'password') {
                msg.style.color = 'green';
                msg.textContent = 'Login successful. Welcome, ' + user + '!';
                // Optionally redirect:
                // window.location.href = 'Home.html';
            } else {
                msg.style.color = 'red';
                msg.textContent = 'Invalid username or password.';
            }
            return false;
        }
    </script>
</head>
<body>
    <div class="card">
        <h1>Welcome to Calculator - Login</h1>
        <form id="loginForm" onsubmit="return doLogin(event);">
            <div class="field">
                <label for="username">Username</label>
                <input id="username" type="text" autocomplete="username" />
            </div>
            <div class="field">
                <label for="password">Password</label>
                <input id="password" type="password" autocomplete="current-password" />
            </div>
            <button type="submit">Sign In</button>
            <div id="message" role="status" aria-live="polite"></div>
        </form>
        <small>Demo credentials: <strong>admin</strong> / <strong>password</strong></small>
    </div>
</body>
</html>