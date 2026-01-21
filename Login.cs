#Include<Main.au3>
Func Login($username, $password)
    ; Wait for the login window to appear
    WinWaitActive("Login Window Title")

    ; Set the username
    ControlSetText("Login Window Title", "", "Edit1", $username)

    ; Set the password
    ControlSetText("Login Window Title", "", "Edit2", $password)

    ; Click the login button
    ControlClick("Login Window Title", "", "Button1")

    ; Optionally, wait for the main application window to appear
    WinWaitActive("Main Application Window Title")