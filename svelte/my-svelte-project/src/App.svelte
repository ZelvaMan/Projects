<script >
  import SortForm from "./SortForm.svelte";
  import people from "../data/people.js";
  import {Sort} from "../helpers/filter.js";
  import Card from "./Card.svelte";
  export let name = "honza";
  console.log(people);
  let currentTime = new Date();
  let parameters;
  
  $: filteredPeople = Sort(parameters,people);


  function ChangeParms(event){
    console.log("event handled")
    if(event)
      parameters = event.detail;
  }
</script>

<style>
  .margin {
    margin-bottom: 200px;
  }

</style>

<nav class="navbar is-dark level">
  <div class="level-left">
    <h1>Hello {name.toUpperCase()}</h1>
  </div>
  <div class="level-right">
    <h2>time : {currentTime}</h2>
  </div>
</nav>
<div class="section">
  <div class="container">
    <SortForm on:parmChanged={ChangeParms} />
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
