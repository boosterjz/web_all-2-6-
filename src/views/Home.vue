<template>
  <main class="container_wrapper">
    <a href="#" title="Вернуться к началу" class="top-button">Наверх</a>
    <SiteMenu/>
    <HospitalDescription/>
    <div class="separator" />
    <Services/>
    <div class="separator" />
    <WorkTime/>
    <div class="separator" />
    <PaidServices/>
    <div class="separator" />
    <Covid19/>
    <div class="separator" />
    <ContactInfo/>
    <div class="separator" />
    <HospitalStory/>
    <div class="separator" />
  </main>
</template>

<script>
import SiteMenu from "@/components/SiteMenu";
import HospitalDescription from "@/components/HospitalDescription";
import Services from "@/components/Services";
import WorkTime from "@/components/WorkTime";
import PaidServices from "@/components/PaidServices";
import Covid19 from "@/components/Covid19";
import ContactInfo from "@/components/ContactInfo";
import HospitalStory from "@/components/HospitalStory";
export default {
  name: 'Home',
  components: {HospitalStory, ContactInfo, Covid19, PaidServices, WorkTime, Services, SiteMenu, HospitalDescription}

}
</script>

<style>
</style>
