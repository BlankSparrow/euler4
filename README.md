# Euler Project Problem 4 - Largest Palindrome Product
https://projecteuler.net/problem=4

**Challenge**
---
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.

**Brute Force Approach**
---
![image](https://user-images.githubusercontent.com/6037005/187058001-f39277c2-4d37-4671-8e6d-6e41ae9c6670.png)

No attempt was made to be efficent, but instead was to validate what the true answer is. 

**After Optimisations**
---
![image](https://user-images.githubusercontent.com/6037005/187058305-30dcafc3-8f3f-44f7-8961-1b98ca04e870.png)

In this approach, I decided to count backwards as there is no point going though all the small pointless numbers.
Next, I started using a traveling minimum for the for loops as going below the minimum number is always going to be a smaller end result.
The traveling maximum is not needed as the inner for loop only needs to start at where the outer for loop is currently.
