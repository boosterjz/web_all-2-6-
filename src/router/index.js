import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Auth from "@/views/Auth";
import Registration from "@/views/Registration";

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/auth',
    name: 'Auth',
    component: Auth
  },
  {
    path: '/registration',
    name: 'Registration',
    component: Registration
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
