<template>

  <main class="container">
    <a href="#" title="Вернуться к началу" class="top-button">Наверх</a>
    <div class="centered">
      <h1>
        Авторизация
      </h1>
      <img :src="require('@/assets/img/auth_logo.svg')" alt="Иконка авторизации" class="auth-logo">
    </div>
    <div class="form">
      <div class="form-wrapper">
        <form action="">
          <label for="login">Логин</label>
          <input type="text" id="login" v-model="login">
          <label for="password">Пароль</label>
          <input type="password" id="password" v-model="password">
          <button type="button"  v-on:click="onClick">Войти</button>
        </form>
      </div>
    </div>
  </main>
  <div class="separator"></div>
</template>

<script>
import axios from 'axios';

export default {
  name: "Auth",
  data: function() {
    return {
      login: "",
      password: "",
    }
  },
  methods: {
    onClick() {
      axios.post("http://localhost:8080/User/Login", {
        email: this.login,
        password: this.password,
      }).then((response) => {
        sessionStorage.setItem("accessToken", response.data.accessToken);
        sessionStorage.setItem("email", response.data.email);
        sessionStorage.setItem("userId", response.data.userId);
        this.$router.push({name: "Home"});
      })
    }
  }
}
</script>

<style scoped>

.auth-logo {
  margin: 0 0 10px 5px;
  height: 50px;
}

.centered {
  display: flex;
  border-bottom: 1px solid #8698A9;
  width: 70%;
  margin: 60px auto 0;
  align-items: baseline;
}

.form {
  background-color: #D0E7FD;
  width: 70%;
  margin: 50px auto 0;
  border-radius: 50px;
}

.form-wrapper {
  margin: 0 auto;
  width: 70%;
  padding: 15px 0 25px;
}

input, textarea {
  display: block;
  margin: 12px 0;
  width: 100%;
  height: 30px;
  background-color: #E5F0FA;
  border: none;
  border-radius: 10px;
  padding: 10px;
  font-family: 'Montserrat', sans-serif;
  font-size: 16px;
}

textarea {
  resize: none;
  height: 200px;
}

button {
  background-color: #E5F0FA;
  border: none;
  border-radius: 10px;
  width: 180px;
  height: 30px;
  font-family: 'Montserrat', sans-serif;
  font-size: 16px;
  font-weight: 600;
  color: #3A5B7A;
}
</style>