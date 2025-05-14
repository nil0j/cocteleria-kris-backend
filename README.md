## Drinks

- api/drinks with optional query parameters \[alcoholic: bool\] \[type: string\] \[flavour: string\]
```bash
# all
curlie :5013/api/drinks

# one
curlie :5013/api/drinks/{id}

# filters
curlie :5013/api/drinks?alcoholic=false
curlie :5013/api/drinks?type=Classy
curlie :5013/api/drinks?flavour=Sour
curlie :5013/api/drinks/?name=Gut

# order # false for reverse order
curlie :5013/api/drinks?orderByPrice=true
```

You can now create/modify/delete drinks
following the model and adding an image
as multipart/formdata and using JWT.
The link is /api/drinks.



## JWT and user management

Authentication now works with FormData,
and user creation requires an image called imageFile aswell.
The following are outdated:

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


# Hosting
This is currently being hosted at [155.138.229.44](http://155.138.229.44)
