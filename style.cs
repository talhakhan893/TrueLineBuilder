body {
    margin: 0;
    font-family: Arial, sans-serif;
    background-color: #1a1a1a;
    color: #fff;
}

header {
    position: relative;
    text-align: center;
    color: white;
}

.header-image {
    width: 100%;
    height: 400px;
    object-fit: cover;
}

.overlay {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    text-align: center;
}

.logo {
    width: 150px;
    margin-bottom: 10px;
}

nav {
    background-color: #222;
    padding: 10px 0;
    text-align: center;
}

nav ul {
    list-style: none;
    padding: 0;
}

nav ul li {
    display: inline;
    margin: 0 15px;
}

nav ul li a {
    color: white;
    text-decoration: none;
    font-size: 18px;
}

section {
    padding: 50px;
    text-align: center;
}

.service, .project-gallery img {
    width: 250px;
    margin: 20px;
    border-radius: 10px;
}

.project-gallery {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
}

footer {
    background-color: #111;
    text-align: center;
    padding: 20px;
}

footer p {
    margin: 10px 0;
}

footer i {
    margin-right: 10px;
}
