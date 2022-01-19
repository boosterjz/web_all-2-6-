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
