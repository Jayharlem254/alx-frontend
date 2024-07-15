/* Custom properties in root elements to use font-family css variables */

html {
  scroll-behavior: smooth;
}

:root {
  --color-primary: #d73953;
  --color-black: #090909;
  --color-white: #ffffff;
  --color-light-grey: #f3f3f3;
  --color-dark-grey: #353535;
  --text-color: var(--color-black);
  --font-family-base: "Helvetica Neue", Helvetica, Arial, sans-serif;
  --font-family-title: "Helvetica Neue", Helvetica, Arial, sans-serif;
}

body {
  color: var(--text-color);
  font-family: var(--font-family-base);
}

h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: var(--font-family-title);
}

a {
  color: var(--text-color);
}

.visually-hidden {
  display: none;
}

.card-category {
  color: var(--color-primary);
}

.section-tagline {
  color: var(--color-primary);
}

