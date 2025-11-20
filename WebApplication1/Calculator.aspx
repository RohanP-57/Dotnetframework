<%@ Page Language="C#" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>Calculator</title>
    <script>
        function calculate(evt) {
            evt.preventDefault();
            var a = parseFloat(document.getElementById('num1').value);
            var b = parseFloat(document.getElementById('num2').value);
            var op = document.getElementById('operation').value;
            var resEl = document.getElementById('result');

            if (isNaN(a) || isNaN(b)) {
                resEl.style.color = 'red';
                resEl.textContent = 'Please enter valid numbers.';
                return false;
            }

            var r = 0;
            switch (op) {
                case 'add': r = a + b; break;
                case 'sub': r = a - b; break;
                case 'mul': r = a * b; break;
                case 'div':
                    if (b === 0) {
                        resEl.style.color = 'red';
                        resEl.textContent = 'Cannot divide by zero!';
                        return false;
                    }
                    r = a / b;
                    break;
            }

            resEl.style.color = 'black';
            resEl.textContent = 'Result: ' + r;
            return false;
        }
    </script>
</head>
<body>
    <div class="card">
        <h1>Welcome to Calculator</h1>
        <form onsubmit="return calculate(event);">
            <div class="field">
                <label for="num1">Number 1</label>
                <input id="num1" type="number" step="any" />
            </div>
            <div class="field">
                <label for="num2">Number 2</label>
                <input id="num2" type="number" step="any" />
            </div>
            <div class="field">
                <label for="operation">Operation</label>
                <select id="operation">
                    <option value="add">Add</option>
                    <option value="sub">Subtract</option>
                    <option value="mul">Multiply</option>
                    <option value="div">Divide</option>
                </select>
            </div>
            <button type="submit">Calculate</button>
            <div id="result" aria-live="polite"></div>
        </form>
    </div>
</body>
</html>