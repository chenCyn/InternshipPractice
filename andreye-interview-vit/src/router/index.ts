import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router'

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'MainPage',
    component: () => import('../components/Invoices.vue')
  },
  {
    path: '/:id',
    name: 'InvoiceLineItems',
    component: () => import('../components/Invoice.vue'),
    props: true
  }
]

const router = createRouter({
  // history: createWebHistory(process.env.BASE_URL),
  history: createWebHistory(),
  routes
})

export default router
