<template><section>
  <div class="hospital_services_text">
    <article id="services"><h2>Услуги</h2></article>

    <ul class="main_services">
      <h3> Консультация специалиста терапевтического профиля
        <ul class="consultation_therap_profile">
          <li class="consultation_therap_profile_item">врача ревматолога;</li>
          <li class="consultation_therap_profile_item">врача пульмонолога;</li>
          <li class="consultation_therap_profile_item">врача гастроэнтеролога;</li>
          <li class="consultation_therap_profile_item">врача гематолога;</li>
          <li class="consultation_therap_profile_item">врача нефролога;</li>
          <li class="consultation_therap_profile_item">врача терапевта;</li>
          <li class="consultation_therap_profile_item">врача кардиолога;</li>
          <li class="consultation_therap_profile_item">врача невролога;</li>
          <li class="consultation_therap_profile_item">врача эндокринолога;</li>
          <li class="consultation_therap_profile_item">врача пропатолога;</li>
          <li class="consultation_therap_profile_item">врача логопеда;</li>
          <li class="consultation_therap_profile_item">врача диабетолога;</li>
          <li class="consultation_therap_profile_item">врача мануальной терапии;</li>
          <li class="consultation_therap_profile_item">врача психотерапевта;</li>
          <li class="consultation_therap_profile_item">врача аллеролога;</li>
          <li class="consultation_therap_profile_item">врача дерматвенолога;</li>
          <li class="consultation_therap_profile_item">врача косметолога;</li>
        </ul>
      </h3>
      <h3> Консультация специалиста хирургического профиля
        <ul class="consultation_surgical_specialist">
          <li class="consultation_surgical_specialist_item">врача оториноларинголога;</li>
          <li class="consultation_surgical_specialist_item">врача кардиохирурга;</li>
          <li class="consultation_surgical_specialist_item">врача хирурга;</li>
          <li class="consultation_surgical_specialist_item">врача торакального хирурга;</li>
          <li class="consultation_surgical_specialist_item">врача челюстно-лицевого хирурга;</li>
          <li class="consultation_surgical_specialist_item">врача уролога;</li>
          <li class="consultation_surgical_specialist_item">врача офтальмолога;</li>
          <li class="consultation_surgical_specialist_item">врача сосудистого хирурга;</li>
          <li class="consultation_surgical_specialist_item">врача травматолога-ортопеда;</li>
          <li class="consultation_surgical_specialist_item">врача нейрохирурга;</li>
          <li class="consultation_surgical_specialist_item">врача колопроктолога;</li>
          <li class="consultation_surgical_specialist_item">врача акушера-гинеколога;</li>
          <li class="consultation_surgical_specialist_item">врача сурдолога;</li>
          <li class="consultation_surgical_specialist_item">врача сексолог;</li>
        </ul>
      </h3>
      <h3> Манипуляции

        Клинико-диагностические исследования

        <ul class="clinical_and_diagnostic_exam">
          <li class="clinical_and_diagnostic_exam_item">Гематологические исследования</li>
          <li class="clinical_and_diagnostic_exam_item">Общеклинические исследования</li>
          <li class="clinical_and_diagnostic_exam_item">Биохимические исследования</li>
          <li class="clinical_and_diagnostic_exam_item">Иммунологические исследования методом ИФА</li>
        </ul>
      </h3>
    </ul>

  </div>
</section>
</template>

<script>
export default {
  name: "Services"
}
</script>

<style scoped>
.hospital_services_text{
  font-size: 18px;
}
.main_services {
  list-style-type: none;
  display: flex;
  justify-content: left;
  padding-left: 0;
}

.consultation_therap_profile {
  font-weight: 400;
  font-size: 15px;
  margin-top: 40px;
}

.consultation_surgical_specialist {
  font-size: 15px;
  font-weight: normal;
  margin-top: 40px;
}

.clinical_and_diagnostic_exam {
  font-weight: normal;
  font-size: 15px;
  margin-top: 40px;
}
</style>