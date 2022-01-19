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

.top-button {
  width:40px;
  border:1px solid #8698A9;
  background:#D0E7FD;
  text-align:center;
  padding:10px;
  position:fixed;
  bottom: 20px;
  right:30px;
  cursor: pointer;
  color:#3A5B7B;
  font-size:10px;
  border-radius: 8px;
  -moz-border-radius: 8px;
  -webkit-border-radius: 8px;
  -khtml-border-radius: 8px;
  z-index: 1;
}

.separator{
  border-top: 1px solid #8698A9 ;
  border-bottom: 1px solid #8698A9 ;
  height: 50px;
  position: absolute;
  left: -70px;
  right: 0;
  margin-top: 50px;
  background-color: #D1E8FD;
}
</style>
<script>
import Header from "@/components/Header";

export default {
  components: { Header }
}
</script>