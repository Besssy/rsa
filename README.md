# RSA

The RSA cryptosystem is the most widely-used public key cryptography algorithm in the world. This is the original algorithm:

- Generate two large random primes, p and q, of approximately equal size such that their product n = pq is of the required bit length, e.g. 1024 bits.
- Compute n = pq and (φ) φ = (p-1)(q-1).
- Choose an integer e, 1 < e < φ, such that gcd(e, φ) = 1.
- Compute the secret exponent d, 1 < d < phi, such that ed ≡ 1 (mod phi).
- The public key is (n, e) and the private key (d, p, q). Keep all the values d, p, q and phi secret. [We prefer sometimes to write the private key as (n, d) because you need the value of n when using d. Other times we might write the key pair as ((N, e), d).]

About the variables:

- *p,q* are the most common variables for prime numbers.
- *n* is known as the modulus.
- *e* is known as the public exponent or encryption exponent or just the exponent.
- *d* is known as the secret exponent or decryption exponent.

Instead of *φ* Euler function you can use *λ=lcm(p−1,q−1)* Carmichael function.
