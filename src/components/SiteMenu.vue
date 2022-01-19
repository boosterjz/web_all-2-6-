<template>
  <nav class="site_menu">
    <ul class="site_menu_list">
      <SiteMenuItem v-for="(menuItem, i) in menuItems" :key="i" :to="menuItem.to" :linkText="menuItem.text" />
    </ul>
  </nav>
</template>

<script>
import SiteMenuItem from "@/components/SiteMenuItem";

export default {
  name: "SiteMenu",
  components: {SiteMenuItem},
  data: function() {
    return {
      menuItems: [
        {
          to: { name: 'Home', hash: '#services'},
          text: 'Список услуг'
        },
        {
          to: { name: 'Home', hash: '#operation_m'},
          text: 'Режим работы'
        },
        {
          to: { name: 'Home', hash: '#paid_s'},
          text: 'Платные услуги'
        },
        {
          to: { name: 'Appointment' },
          text: 'Записаться на прием'
        },
        {
          to: { name: 'Home', hash: '#cov19'},
          text: 'Covid-19'
        },
      ]
    }
  }
}
</script>

<style scoped>
.site_menu {
  font-weight: 700;
}

.site_menu_list {
  list-style-type: none;
  display: flex;
  justify-content: center;
  padding: 0;
}
</style>