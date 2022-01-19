<template>
  <div class="covid_19">
    <article id="cov19">
      <h2>
        Covid-19
      </h2>
    </article>

  </div>

  <section class="covid_help">
    <img :src="require('@/assets/img/covidInfo.png')" alt="Справка по covid19" class="covid19_info">
    <img :src="require('@/assets/img/covid19_doctor.svg')" alt="Доктор covid_19" class="covid_doctor">
  </section>
</template>

<script>
export default {
  name: "Covid19"
}
</script>

<style scoped>

.covid_19 {
  margin-bottom: 60px;
}

.covid_help {
  display: flex;

}

.covid19_info {
  height: 500px;
  width: 800px;
  margin-right: 20px;
}

.covid_doctor {
  height: 400px;
  width: 300px;
  margin-top: 50px;
}
</style>