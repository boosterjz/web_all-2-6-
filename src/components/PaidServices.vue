<template>
  <section>
    <article id="paid_s">
      <h2>
        Платные услуги
      </h2>
    </article>
  </section>
  <img :src="require('@/assets/img/paid_services.png')" alt="Платные услуги" class="paid_services_img">
</template>

<script>
export default {
  name: "PaidServices"
}
</script>

<style scoped>
.paid_services_img {
  height: 600px;
  width: 1000px;
  margin-left: 50px;
  display: flex;
  justify-content: center;
}
</style>