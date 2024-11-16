2. Assumptions that I had made:
We are checking OTP for one email. As is, it is impossible to check an OTP for different emails without further implementations.
That send_email will throw exceptions if the email did not exist or otherwise failed to send email body to that email. 
The OTP entered by the user is always 6 digits
I would be able to put iostream readOTP in Task.Run without side effects or bugs, as the current implementation needs to run asynchronously with the stopwatch timer.
4. How I would test my module:
Test generate_OTP_email first, as without it, check_OTP would not be able to be tested.
Give generate_OTP_email a correct email address, then address with wrong domain, address with shorter character length than the allowed domain, and then an empty string.
Then check the OTP generated that it is actually 6 digits
After we are done with generate_OTP_email, we can then use generate_OTP_email as scaffolding to test check_OTP. First wait a full minute without typing anything to test for timeout, then type something and then wait for timeout, then do a couple of otp failed attempts and then wait for timeout. After which, we generate 10 wrong OTPs to check for fails. Finally we enter a correct OTP to check for correct answer.
