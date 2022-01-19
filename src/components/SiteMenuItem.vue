<template>
  <li class="menu_navigation_item"><router-link :to="to" class="menu_navigation_link">{{ linkText }}</router-link></li>
</template>

<script>
export default {
  name: "SiteMenuItem",
  props: ["linkText", "to"]
}
</script>

<style scoped>
.menu_navigation_item {
  display: inline-block;
  margin-right: auto;
  background-color: #D1E8FD;
  padding: 3px 27px 3px 27px;
  text-align: center;
  font-size: 15px;
  border-radius: 10px;
  max-height: inherit;
}
.menu_navigation_item:last-child {
  margin-right: 0;
}

.menu_navigation_link {
  text-decoration: none;
  color: inherit;
  text-align: center;
}
</style>