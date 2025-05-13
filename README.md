## Drinks

- api/drinks with optional query parameters \[alcoholic: bool\] \[type: string\] \[flavour: string\]
```bash
curlie :5013/api/drinks
curlie :5013/api/drinks?alcoholic=false
curlie :5013/api/drinks?type=Classy
curlie :5013/api/drinks?flavour=Sour
```


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

