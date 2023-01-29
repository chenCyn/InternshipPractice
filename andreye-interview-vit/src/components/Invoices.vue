<template>
  <div class="home">
    <title>MainPage</title>

    <div class="create contact">
      <el-button type="primary" @click="dialogFormVisible = true">
        Create New Contact
      </el-button>

      <el-dialog v-model="dialogFormVisible" title="Create New Contact">
        <el-form :model="form">
          <el-form-item label="lastName" :label-width="formLabelWidth">
            <el-input v-model="form.lastName" autocomplete="off" />
          </el-form-item>
          <el-form-item label="middleName" :label-width="formLabelWidth">
            <el-input v-model="form.middleName" autocomplete="off" />
          </el-form-item>
          <el-form-item label="firstName" :label-width="formLabelWidth">
            <el-input v-model="form.firstName" autocomplete="off" />
          </el-form-item>
          <el-form-item label="email" :label-width="formLabelWidth">
            <el-input v-model="form.email" autocomplete="off" />
          </el-form-item>
          <el-form-item label="phoneNum" :label-width="formLabelWidth">
            <el-input v-model="form.phoneNum" autocomplete="off" />
          </el-form-item>
          <el-form-item label="address" :label-width="formLabelWidth">
            <el-input v-model="form.address" autocomplete="off" />
          </el-form-item>
          <el-form-item label="emerName" :label-width="formLabelWidth">
            <el-input v-model="form.emerName" autocomplete="off" />
          </el-form-item>
          <el-form-item label="emerPhoneNum" :label-width="formLabelWidth">
            <el-input v-model="form.emerPhoneNum" autocomplete="off" />
          </el-form-item>
          <el-form-item label="Date of Birth  *" :label-width="formLabelWidth">
            <el-date-picker v-model="form.dob" type="date" placeholder="Date of Birth" />
          </el-form-item>
          <el-form-item label="legalRep" :label-width="formLabelWidth">
            <el-select v-model="form.legalRep" placeholder="Please select a legalRep">
              <el-option label="Lawyer 1" value="111" />
              <el-option label="Lawyer 2" value="222" />
            </el-select>
          </el-form-item>
          <el-form-item label="additionalNote" :label-width="formLabelWidth">
            <el-input v-model="form.additionalNote" autocomplete="off" />
          </el-form-item>
        </el-form>
        <template #footer>
          <span class="dialog-footer">
            <el-button @click="dialogFormVisible = false">Cancel</el-button>
            <el-button type="primary" @click="createContact(), dialogFormVisible = false">
              Create
            </el-button>
          </span>
        </template>
      </el-dialog>

    </div>

    <div class="create invoice">
      <form @submit.prevent>
        <input type="text" name="invoices" v-model="state.contactId" placeholder="ContactId" />
        <input type="text" name="invoices" v-model="state.description" placeholder="Description" />
        <el-button type="primary" @click="createInvoice">Create A New Invoice</el-button>
      </form>
    </div>

    <hr />

    <div class="contactTable">
      <el-table :data="form.contacts" style="width: 100%" height="250">
        <el-table-column fixed prop="id" label="id" />
        <el-table-column prop="name" label="Name" />
        <el-table-column prop="email" label="email" />
        <el-table-column prop="phoneNum" label="phoneNum" />
        <el-table-column prop="legalRep" label="legalRep" />
        <el-table-column prop="numInvoices" label="numInvoices" />
      </el-table>
    </div>

    <div class="invoiceTable">
      <el-table :data="state.invoices" style="width: 100%" height="250">
        <!-- <el-table-column fixed prop="id" label="id" width="150" /> -->
        <el-table-column label="Id">
          <template v-slot:default="{row}">
            <routerLink :to="'/' + row.id">{{ row.id }}</routerLink>
          </template>
        </el-table-column>
        <el-table-column prop="description" label="description" width="150" />
        <el-table-column prop="totalValue" label="totalValue" width="150" />
        <el-table-column prop="totalBillableValue" label="totalBillableValue" width="150" />
        <el-table-column prop="contactId" label="contactId" width="150" />
      </el-table>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, onMounted, reactive, ref } from 'vue';
import { RouterLink } from 'vue-router';
// @ is an alias to /src

export default defineComponent({
  components: {
    RouterLink
  },
  name: 'Invoices',
  setup() {
    const state = reactive({
      invoices: [],
      contactId: "",
      description: ""
    })
    const form = reactive({
      contacts: [],
      lastName: "",
      middleName: "",
      firstName: "",
      email: "",
      phoneNum: "",
      address: "",
      emerName: "",
      emerPhoneNum: "",
      dob: "",
      legalRep: "",
      additionalNote: ""
    })
    const dialogFormVisible = ref(false)
    const formLabelWidth = '140px'
    function fetchInvoices() {
      fetch("http://localhost:5000/invoices", {
        method: "GET",
        headers: {
          "Content-Type": "application/json"
        },
      }).then((response) => {
        response.json().then(invoices => (state.invoices = invoices.invoices))
      })
    }
    function fetchContacts() {
      fetch("http://localhost:5000/contacts", {
        method: "GET",
        headers: {
          "Content-Type": "application/json"
        },
      }).then((response) => {
        response.json().then(contacts => (form.contacts = contacts.contacts))
      })
    }
    function createInvoice() {
      fetch("http://localhost:5000/invoices", {
        method: "PUT",
        headers: {
          "Content-Type": "application/json"
        },
        body: JSON.stringify({
          contactId: state.contactId,
          description: state.description
        })
      }).then(fetchInvoices).then(fetchContacts)
    }
    function createContact() {
      fetch("http://localhost:5000/contacts", {
        method: "PUT",
        headers: {
          "Content-Type": "application/json"
        },
        body: JSON.stringify({
          lastName: form.lastName,
          middleName: form.middleName,
          firstName: form.firstName,
          email: form.email,
          phoneNum: form.phoneNum,
          address: form.address,
          emerName: form.emerName,
          emerPhoneNum: form.emerPhoneNum,
          dob: form.dob,
          legalRep: form.legalRep,
          additionalNote: form.additionalNote
        })
      }).then(fetchContacts)
    }

    onMounted(() => {
      fetchInvoices()
      fetchContacts()
    })

    return { state, form, dialogFormVisible, formLabelWidth, createInvoice, createContact }
  }
});
</script>
