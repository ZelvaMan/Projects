 <script>
 import SortForm from "./SortForm.svelte";
  import people from "../data/people.js";
  import {Sort} from "../helpers/filter.js";
  import Card from "./Card.svelte";
    export let params = {};
  console.log(people);

  let parameters;
  
  $: filteredPeople = Sort(parameters,people);


  function ChangeParms(event){
    console.log("event handled");
    console.log("event details:" + event.detail);
    if(event)
      parameters = event.detail;
  }
</script>

<style>
  .margin {
    margin-bottom: 200px;
  }

</style>

<div class="section">
  <div class="container">
    <SortForm on:parmChanged={ChangeParms} filteredHobbies={params.filtervalue}/>
  </div>
  <br class="margin" />
  <div class="container">
    <div class="columns is-centered is-multiline" style="padding: 2rem">
      {#each filteredPeople as person, i}
        <div class="column is-2">
          <Card bind:userInfo={person} />
        </div>
      {/each} 
    </div>
  </div>
</div>
