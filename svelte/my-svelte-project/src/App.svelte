<script>
  import Card from "./Card.svelte";
  import SortForm from "./SortForm.svelte";

  export let name = "hroch";
  let currentTime = new Date();

  let persons = [
		{ imageLink: "https://i.pravatar.cc/400?img=1", nickname: "Nick" , 
		state:"Offline", city:"Ostrava"},
		{ imageLink: "https://i.pravatar.cc/400?img=2", nickname: "Nick2", 
		state:"Offline", city:"Ostrava"},
		{ imageLink: "https://i.pravatar.cc/400?img=3", nickname: "Nick3",
		state:"Offline", city:"Ostrava"},
		{ imageLink: "https://i.pravatar.cc/400?img=4", nickname: "Nick4",
		state:"Offline", city:"Ostrava"},
		{ imageLink: "https://i.pravatar.cc/400?img=5", nickname: "Nick5", 
		state:"Offline", city:"Ostrava"},
		{ imageLink: "https://i.pravatar.cc/400?img=6", nickname: "Nick6", 
		state:"Offline", city:"Ostrava"}
	];
	
	let SortedPersons = persons;

  function Sort(event) {
		let parms = event.detail;
		alert(parms.name);
		let sorted = persons
		sorted = sorted.includes(SortByName(parms.name));
		
		sorted = sorted.includes(SortByState(parms.state));
		sorted = sorted.includes(SortByCity(parms.city));
	SortedPersons = sorted;
  }

  function SortByName(item , name) {
      return item.nickname.includes(name);
  }

  function SortByState(item , state) {
    return item.state == state;
  }

  function SortByCity(item, city) {
    return item.city == city;
	}
	
	function SortByHobbies(item, hobbies) {

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
    <div class="columns is-centered" style="padding: 2rem">
      {#each SortedPersons as person, i}
        <div class="columns">
          <Card bind:userInfo={person} />
        </div>
      {/each}
    </div>
  </div>
</div>
