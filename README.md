<!-- Sign in -->

POST api/v1/identity/sign-in
body= {
    "userName":string,
    "password":string
}
response:{
    "accessToken":string,
    "refreshToken":string
}

<!-- Sign up -->
POST api/v1/identity/sign-up
body = {
    token: googleToken
}

<!-- Profile info -->
GET api/v1/profile
headers = {
    Authorization: jwtToken
}
