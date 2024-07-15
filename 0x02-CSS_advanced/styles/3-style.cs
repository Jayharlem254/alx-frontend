/* Custom properties in root elements to use css variables */

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
}

body {
  color: var(--text-color);
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
