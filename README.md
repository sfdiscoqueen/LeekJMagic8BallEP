# LeekJMagic8BallEP
// Jasmine Leek
// 27oct2022
// Magic 8 Ball - Endpoints
// this is a web api that generates a fortune message for the user at random
// peer review: By Kenneth Fujimura -- Eveyrthing works well! The RNG to determine the output works properly and cycles through all possible responses. The little emoji flourish for the text output is really cute. The program is set up to take ana input for the question but doesn't do anything with it (not that it actually needs to) but if you were looking to simplify code, you could just remove that part. Other than that, it's really good! Kudos Jasmine!

User Testing Instructions:

1) Open VS Code, click "Clone Git Repository", then type this link into the toolbar: https://github.com/sfdiscoqueen/LeekJMagic8Ball.git
2) Click F5 to run and debug the program. A local host will be generated through the web browser. Take note of the 4 digit host # needed for step 3.
3) Open Postman, create a new "get" request, then type this link into the toolbar: https://localhost:####/Magic/fortune/{question}. Replace "####" with the 4 digit host.
4) Replace {question} with your special question, then click send to reveal your fortune.
5) Have fun testing with new questions!
