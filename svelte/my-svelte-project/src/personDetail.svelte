<script>
  import people from "../data/people.js";
  import { Find } from "../helpers/filter.js";
  import { link } from "svelte-spa-router";
  export let params = {};
  let nick = params.wild;
  let person = Find(nick, people);

  function CreateUrl(filterName, filterValue) {
    return `/filter/${filterName}/${filterValue}`;
  }
</script>

<style>
  .red {
    color: red;
  }
  .big {
    font-size: xx-large;
  }
  a {
    text-decoration: none;
    color: black;
  }
  a:hover {
    text-decoration: none;
    color: blue;
  }
</style>

{#if person == null || person == undefined}
  <b class="red">ERROR PERSON NOT FOUND</b>
{:else}
  <div class="columns">
    <div class="column">
      <img src={person.imageLink} alt="Placeholder image" />
    </div>
    <div class="column">
      <h1 class="big">
        Nickname:
        <b>{person.nickname}</b>
      </h1>
      <h2>
        state:
        <b>{person.state}</b>
      </h2>
      <br />
      <h1>
        city:
        <b>{person.city}</b>
      </h1>
      <h1>
        hobbies:
        <b>
          {#each person.hobbies as hobby}
            {#if hobby}
              <a href={CreateUrl('hobby', hobby)} use:link>{hobby}</a>
              ,
            {/if}
          {/each}
        </b>
      </h1>
    </div>
  </div>
{/if}
