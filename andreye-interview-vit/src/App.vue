<script setup lang="ts">
import { defineComponent } from 'vue';
import MainPage from './components/Invoices.vue'
// export default defineComponent{
//   name:'app',
//   components:{
//     MainPage
//   }

  // setup() {
  //   const count = ref(0)
  //   const inc = () => count.value++

  //   return () => {
  //     let render
  //     eval('render =' + hotReloadRender.value.toString())
  //     return render()
  //   }
  // }
// }
</script>

<template>
  <div id="app">
    <!-- <div>
    <a href="https://vitejs.dev" target="_blank">
      <img src="/vite.svg" class="logo" alt="Vite logo" />
    </a>
    <a href="https://vuejs.org/" target="_blank">
      <img src="./assets/vue.svg" class="logo vue" alt="Vue logo" />
    </a>
  </div> -->
    <MainPage msg="Main Page" />
    <!-- <router-view /> -->
  </div>
</template>

<style scoped>
/* .logo {
  height: 6em;
  padding: 1.5em;
  will-change: filter;
}

.logo:hover {
  filter: drop-shadow(0 0 2em #646cffaa);
}

.logo.vue:hover {
  filter: drop-shadow(0 0 2em #42b883aa);
} */
</style>
