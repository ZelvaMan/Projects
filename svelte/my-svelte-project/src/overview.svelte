 <script>
  import SortForm from "./SortForm.svelte";
  import { Sort } from "../helpers/filter.js";
  import Card from "./Card.svelte";

  
  export let params = {};
  let parameters = null;
  const BaseAPiUrl = "https://localhost:44360/api/Users/GetUsers";
  let filteredPeople;
  

  $: filteredPeople = LoadFromApi(parameters);

  async function LoadFromApi(parms) {
    let url = null;
    console.log("fetch URL:" + url);
    const response = await fetch(BaseAPiUrl);
    filteredPeople = await response.json();
    console.log(filteredPeople);
  }

  function ChangeParms(event) {
    if (event) parameters = event.detail;
  }

  function LogProperties() {
    console.log("filteredPeople:");
    console.log(filteredPeople);

    console.log("----------------------------------------");
    console.log("params:");
    console.log(parameters);
  }
</script>

<style>  
.margin {
    margin-bottom: 200px;
  }

</style>

<div class="section">
  <button on:click = {LogProperties}>LOG</button>
  <div class="container">
    <SortForm
      on:parmChanged={ChangeParms}
      filterName={params.filtername}
      filterValue={params.filtervalue} />
  <div class="container">      
    <SortForm on:parmChanged={ChangeParms} filterName={params.filtername} filterValue={params.filtervalue} />
  </div>
  <br class="margin" />
  <div class="container">
    <div class="columns is-centered is-multiline" style="padding: 2rem">
      {#if filteredPeople == null || filteredPeople == undefined}
        <h1>LOADING FROM DATABASE</h1>
      {:else}
      
        else
        {#each filteredPeople as person}
        
          <div class="column is-2">
            <Card bind:userInfo={person} />
          </div>
        {/each}
      {/if}
      {#each filteredPeople as person, i}
        <div class="column is-2">
          <Card bind:userInfo={person} />
        </div>
      {/each} 
    </div>
  </div>
