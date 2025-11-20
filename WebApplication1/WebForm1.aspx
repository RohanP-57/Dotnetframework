<%@ Page Language="C#" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>Login - Calculator</title>
    <script>
        // Static credentials (for demo only)
        function doLogin(evt) {
            evt.preventDefault();
            var user = document.getElementById('username').value.trim();
            var pass = document.getElementById('password').value;
            var msg = document.getElementById('message');

            if (user === 'admin' && pass === 'password') {
                // Redirect to the calculator page on successful login
                window.location.href = 'Calculator.aspx';
                return true;
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