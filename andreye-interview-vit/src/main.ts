import { createApp } from 'vue'
import { createRouter, createWebHistory } from 'vue-router'
import './style.css'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import Invoices from './components/Invoices.vue'
import Invoice from './components/Invoice.vue'
// import router from './router'

const router = createRouter({
    // history: createWebHistory(process.env.BASE_URL),
    history: createWebHistory(),
    routes: [
        { path: '/', name: 'MainPage', component: Invoices },
        { path: '/:id', name: 'Invoice', component: Invoice, props: true }
    ]
})

createApp(App)
    .use(router)
    .use(ElementPlus)
    .mount('#app')
