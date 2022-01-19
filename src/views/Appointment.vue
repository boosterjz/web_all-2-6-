<template><main class="container">
  <a href="#" title="Вернуться к началу" class="top-button">Наверх</a>
  <div class="centered">
    <h1>
      Записаться на приём
    </h1>
    <img :src="require('@/assets/img/Doctor_logo.svg')" alt="Красивый доктор" class="doctor-logo">
  </div>
  <div class="form">
    <div class="form-wrapper">
      <form action="">
        <label for="name">Ваши фамилия, имя, отчество</label>
        <input type="text" id="name" v-model="name">
        <label for="contact">Ваш E-mail или номер телефона</label>
        <input type="text" id="contact" v-model="contact">
        <label for="message">Ваше сообщение</label>
        <textarea id="message" v-model="message"></textarea>
        <button type="button" v-on:click="onClick">Отправить</button>
      </form>
    </div>
  </div>
</main>
  <div class="separator"></div>
</template>

<script>
import axios from 'axios';

export default {
  name: "Appointment",
  data: function() {
    return {
      name: "",
      contact: "",
      message: ""
    }
  },
  methods: {
    onClick() {
      axios.post("http://localhost:8080/api/Appointment", {
        name: this.name,
        contact: this.contact,
        message: this.message
      }).then((response) => {
        console.log(response);
        this.$router.push({name: "Home"});
      })
    }
  }
}
</script>

<style scoped>

main {
  display: flex;
  flex-flow: column;
}

.centered {
  display: flex;
  border-bottom: 1px solid #8698A9;
  width: 70%;
  margin: 60px auto 0;
  align-items: baseline;
}

.doctor-logo {
  margin: 0 0 10px 5px;
  height: 50px;
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
h1 {
  font-weight: 400;
  margin-bottom: 0;
}
</style>