<template>
  <header>
    <div class="upper_header_wrapper">
      <div class="container header upper_header">
        <img :src="require('@/assets/img/phone_logo.svg')" height="40" alt="Иконка номера телефона" class="header_icon_phone">
        <span class="contact_info">
          Единая справочная<br>
          +7 (4722) 50-48-48
        </span>
        <a href="#" v-if="isAuthorized()" class="auth">{{ email }}</a>
        <a href="" v-if="isAuthorized()" v-on:click="logOut" class="auth">Выйти</a>
        <div v-else>
          <router-link :to="{ name: 'Auth' }" class="auth">Вход</router-link>
          <router-link :to="{ name: 'Registration' }" class="auth">Регистрация</router-link>
        </div>
        <img :src="require('@/assets/img/geolocation_logo.svg')" alt="Иконка адреса" class="header_icon_geo">
        Адрес:<br>
        улица Некрасова, дом 8/9, Белгород, 308007
      </div>
    </div>
    <div class="lower_header_wrapper">
      <div class="container header lower_header">
        <img :src="require('@/assets/img/hospital_logo.svg')" alt="Логотип больницы" class="hospital_logo">
        <span class="hospital_name">
              ОГБУЗ «Белгородская областная<br>
              клиническая больница Святителя Иоасафа»
        </span>
        <div class="site_navigation">
          <ul class="site_navigation_list">
            <li class="site_navigation_item"><router-link class="site_navigation_link" :to="{ name: 'Home' }">Главная</router-link></li>
            <li class="site_navigation_item"><router-link class="site_navigation_link" :to="{ name: 'Home', hash: '#hospital_inf' }">О больнице</router-link></li>
            <li class="site_navigation_item"><router-link class="site_navigation_link" :to="{ name: 'Home', hash: '#contacts' }">Контакты</router-link></li>
          </ul>
        </div>
      </div>
    </div>
  </header>
</template>

<script>
export default {
  name: "Header",
  data: function() {
    return {
      email: ""
    }
  },
  methods: {
    isAuthorized() {
      return sessionStorage.getItem("accessToken") !== null;
    },
    logOut() {
      sessionStorage.removeItem("accessToken");
      sessionStorage.removeItem("email");
      sessionStorage.removeItem("userId");
      this.$router.push({ name: "Home" });
    }
  },
  mounted() {
    this.email = sessionStorage.getItem("email");
  }
}
</script>

<style scoped>
.auth {
  flex: 1;
  text-decoration: none;
  color: #3A5B7B;
  font-size: 18px;
}

.contact_info {
  flex: 4;
}

.header {
  display: flex;
  align-items: center;
  margin: auto;
  justify-content: space-between;
}

.upper_header {
  height: 50px;
}

.lower_header {
  justify-content: flex-start;
  height: 210px;
}

.upper_header_wrapper {
  background-color: #D0E7FD;
  border-bottom: 1px solid #8698A9;
}

.lower_header_wrapper {
  background-color: #E5F0FA;
  border-bottom: 1px solid #8698A9;
}

.header_icon_phone {
  margin-right: 20px;
}

.header_icon_geo {
  flex: 2;
  max-height: 40px;
  margin-right: 20px;
  max-width: 40px;
}

.hospital_logo {
  max-width: 70px;
  margin-right: 30px;
}

.hospital_name {
  color: #3A5B7B;
  font-size: 22px;
  flex-grow: 4;
  font-weight: 500;
}

.site_navigation_list {
  list-style-type: none;
  display: flex;
  justify-content: center;
  padding: 0;
}

.site_navigation_item {
  display: inline;
  margin-right: 30px;
  font-weight: 400;
}

.site_navigation_item:last-child {
  margin-right: 0;
}

.site_navigation {
  justify-self: flex-end;
  align-self: flex-end;
}

.site_navigation_link {
  text-decoration: none;
  color: inherit;
  font-size: 20px;
}

</style>