<h1>Hex Encryptor</h1>
This <b>Hexadecimal</b>(just "Hex") <b>Encryptor</b> encrypts 
your string into hex hash.
<h2>How it works?</h2>

- At first, 
You give the <b>word</b>,
<b>letter and word separator.</b>

- Then, every letter from word have been translated into it's alphabetic position,
ex: `a - 1, b - 2, z - 26`

- Those letter positions will be converted into <b>HEX</b> value, <br>
ex: `1 = 0001, 2 = 0002, 26 = 001A`

- After this, converted values will be appended to result with separators.<br>
ex: `aa bb = 0001[letter separator]0001[word separator]0002[letter separator]0002`

<h2>Getting Started</h2>
Just open ```HexEncrypt.exe```
<a href="https://github.com/edoxa1/HexEncryptor/tree/master/HexEncrypt/bin/Debug">there</a>