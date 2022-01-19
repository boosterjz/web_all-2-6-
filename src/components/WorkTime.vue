<template>
  <section>
    <article id="operation_m">
      <h2>
        Режим работы
      </h2>
    </article>

    <div class="work_time_text">
      <p>
        <b>Поликлиника:</b> с 08:00 до 15:30 (выходные: суббота, воскресенье).<br>
      </p>
      <p>
        <b>Дневной стационар:</b> с 09:00 до 18:00, без выходных.<br>
      </p>
      <p>
        <b>Стационар:</b> круглосуточно.<br>
      </p>
      <p>
        <b>Консультативно-диагностическое отделение перинатального центра:</b> с 08:00 до 18:00 (выходные: суббота, воскресенье).<br>
      </p>
      <p>
        <b>Центр медицинской реабилитации:</b> с 08:00 до 20:00 (выходные: суббота, воскресенье).
      </p>
    </div>
    <img :src="require('@/assets/img/timer_img.svg')" alt="Логотип-таймер" class="timer_logo">
  </section>
</template>

<script>
export default {
  name: "WorkTime"
}
</script>

<style scoped>

.work_time_text {
  font-size: 17px;
  width: 600px;
  height: 400px;
  margin-top: 0;
  display: inline;
  flex-direction: column;
  align-items: flex-start;
}

.timer_logo {
  width: 316px;
  height: 440px;
  margin-left: 420px;
  margin-right: 0;
  justify-content: flex-end;
}
</style>