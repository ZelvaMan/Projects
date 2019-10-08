<script>
  import Card from "./Card.svelte";
  import SortForm from "./SortForm.svelte";
  import people from "data/people.js"
  export let name = "hroch";
  let currentTime = new Date();

  let sortedPersons = people;

  function Sort(event) {
    let parms = event.detail;
    //parametry funguji
    let sorted = people;
    if (parms.name) {
      sorted = sorted.filter(SortByName(parms.name));
      console.log(
        "name filtred name : " + parms.name + "length:" + sorted.length
      );
    }

    if (parms.state !== "Select state") {
      sorted = sorted.filter(SortByState(parms.state));
      console.log(
        "state filtred state: " + parms.state + "    length:" + sorted.length
      );
    }

    if (parms.city) {
      sorted = sorted.filter(SortByCity(parms.city));
      console.log(
        "city filtred city: " + parms.city + "    length:" + sorted.length
      );
    }

    if (HobbiesSelected(parms.hobbies)) {
      sorted = sorted.filter(SortByHobbies(parms.hobbies));
      console.log("hobbies filtred length: " + sorted.length);
    }
    sortedPersons = sorted;
    console.log(sorted.length + "end");
  }
  function SortByName(name) {
    return function(item) {
      return item.nickname.includes(name);
    };
  }

  function SortByState(state) {
    return function(item) {
      return item.state === state;
    };
  }

  function SortByCity(city) {
    return function(item) {
      return item.city === city;
    };
  }

  function SortByHobbies(hobbies) {
    return function(item) {
      for (var hobby in hobbies) {
        //console.log(hobby + " - item: " + item.hobbies[hobby] + " hobbies: " + hobbies[hobby] );
        if (item.hobbies[hobby] == true && hobbies[hobby] == true) {
          return true;
        }
      }
      return false;
    };
  }

  function HobbiesSelected(hobbies) {
    console.log("start");
    for (var hobby in hobbies) {
      if (hobbies[hobby]) {
        console.log(hobbies[hobby]);
        return true;
      }
      console.log(hobbies[hobby]);
    }
    console.log("end ");
    return false;
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
    <SortForm on:parmChanged={Sort} />
  </div>
  <br class="margin" />
  <div class="container">
    <div class="columns is-centered is-multiline" style="padding: 2rem">
      {#each SortedPersons as person, i}
        <div class="column is-2">
          <Card bind:userInfo={person} />
        </div>
      {/each}
    </div>
  </div>
</div>
