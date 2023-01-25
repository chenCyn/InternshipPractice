<!-- <script setup lang="ts">
import { ref } from 'vue'

defineProps<{ msg: string }>()

const count = ref(0)
</script>

<template>
  <h1>{{ msg }}</h1>

  <div class="card">
    <button type="button" @click="count++">count is {{ count }}</button>
    <p>
      Edit
      <code>components/HelloWorld.vue</code> to test HMR
    </p>
  </div>

  <p>
    Check out
    <a href="https://vuejs.org/guide/quick-start.html#local" target="_blank"
      >create-vue</a
    >, the official Vue + Vite starter
  </p>
  <p>
    Install
    <a href="https://github.com/johnsoncodehk/volar" target="_blank">Volar</a>
    in your IDE for a better DX
  </p>
  <p class="read-the-docs">Click on the Vite and Vue logos to learn more</p>
</template>

<style scoped>
.read-the-docs {
  color: #888;
}
</style> -->
<template>
  <div class="home">
    <form @submit.prevent>
      <label for="invoices">Create a new invoice</label>
      <input type="text" name="invoices" v-model="state.description" placeholder="Description" />
      <button @click="createInvoice">Create Invoice</button>
    </form>

    <hr />

    <table>
      <thead>
        <th>ID</th>
        <th>Description</th>
        <th>Invoice Link</th>
        <th>Total value</th>
        <th>Total Billed Amount</th>
      </thead>
      <tbody>
        <tr v-for="invoice in state.invoices" :key="invoice.id">
          <td>{{ state.id }}</td>
          <td>{{ state.description }}</td>
          <td>
            <router-link :to="{ name: 'Invoice', params: { id: state.id } }">
              Open
            </router-link>
          </td>
          <td>{{ state.totalValue }}</td>
          <td>{{ state.totalBillableValue }}</td>

        </tr>
      </tbody>
    </table>
  </div>
</template>


<style scoped>
.read-the-docs {
  color: #888;
}
</style>


<script lang="ts">
import { defineComponent, onMounted, reactive } from 'vue';
// @ is an alias to /src

export default defineComponent({
  name: 'Invoices',
  setup() {
    const state = reactive({
      invoices: [],
      id: 0,
      contactId: 0,
      description: "",
      totalValue: 0,
      totalBillableValue: 0,
      totalNumberLineItems: 0
    })

    function fetchInvoices() {
      fetch("http://localhost:5000/invoices")
        .then(response => {
          if (!response.ok) {
            throw new Error(response.statusText);
          }
          return response.json();
        })
        .then(({ invoices }) => {
          state.invoices = invoices;
          let id = 0;
          let contactId = 0;
          let description = "";
          let totalValue = 0;
          let totalBillableValue = 0;
          let totalNumberLineItems = 0;
          invoices.forEach(({ id: idval, contactId: contId, description: string, totalValue: value, totalBillableValue: billable, totalNumberLineItems: lineItems }: any) => {
            id += idval;
            contactId += contId;
            description = string;
            totalValue += value;
            totalBillableValue += billable;
            totalNumberLineItems += lineItems;
          });
          state.id = id;
          state.contactId = contactId;
          state.description = description;
          state.totalValue = totalValue;
          state.totalBillableValue = totalBillableValue;
          state.totalNumberLineItems = totalNumberLineItems;
        })
        .catch(error => console.error(error));
      // fetch("http://localhost:5000/invoices", {
      //   method: "GET",
      //   headers: {
      //     "Content-Type": "application/json"
      //   },
      // }).then((response) => {
      //   response.json().then(invoices => {
      //     state.invoices = invoices.invoices;
      //     state.id = invoices.id;
      //     state.contactId = invoices.contactId;
      //     state.description = invoices.description;
      //     state.totalValue = invoices.totalValue;
      //     state.totalBillableValue = invoices.totalBillableValue;
      //     state.totalNumberLineItems = invoices.totalNumberLineItems

      //   })
      // })
    }

    function createInvoice() {
      fetch("http://localhost:5000/invoices", {
        method: "PUT",
        headers: {
          "Content-Type": "application/json"
        },
        body: JSON.stringify({
          description: state.description
        })
      }).then(fetchInvoices)
    }

    onMounted(fetchInvoices)

    return { state, createInvoice }
  }
});
</script>



