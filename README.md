## JWT and user management

Currently available endpoints (they use json):

- api/auth/login
```bash
curlie :5013/api/auth/login username=user password=pass
```

- api/auth/register
```bash
curlie :5013/api/auth/register username=user password=pass
```

- home/boniato
```bash
curlie :5013/home/boniato Authorization:"Bearer token"
```
