<template>
  <Header/>
  <router-view/>
</template>

<style>
body {
  margin: 0;
  font-family: 'Montserrat', sans-serif;
  font-weight: 400;
  color: #3A5B7B;
  font-size: 15px;
}

#app {
  width: 100%;
  height: 100%;
}

.container {
  max-width: 1100px;
  margin: auto;
}

.container_wrapper {
  max-width: 1100px;
  margin: auto;
}

h1 {
  font-size: 30px;
}

h2 {
  font-size: 25px;
  margin-top: 150px;
  border-bottom: 1px solid #8698A9;
  font-weight: 400;
  margin-bottom: 60px;
}

h3 {
  font-weight: 700;
  font-size: 15px;
  padding-right: 20px;
  margin: 15px;
}
</style>
<script>
import Header from "@/components/Header";

export default {
  components: { Header }
}
</script>