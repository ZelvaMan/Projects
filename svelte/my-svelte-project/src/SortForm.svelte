<script>
  import { createEventDispatcher } from "svelte";
  const dispatch = createEventDispatcher();

  export let filterName = undefined;
  export let filterValue = undefined;

  export let filteredHobbies = undefined;

  let Name = "",
    State = "",
    City = "";
  let Hobbies = false;
  let allFalse = {
    football: false,
    reading: false,
    running: false,
    skating: false,
    fishing: false,
    drawing: false
  };

  function ChangeHobbies(filterName, filterValue) {
    Hobbies = allFalse;
    Name = "";
    City = "";
    State = "Select state";
    if (filterName && filterValue) {
      switch (filterName.toLowerCase()) {
        case "hobby":
          for (let hobby in Hobbies) {
            if (filterValue == hobby) {
              Hobbies[hobby] = true;
            }
          }
          break;
          case"name":
            Name = filterValue;
          break;
          case"city":
            City = filterValue;
          break;
          case"state":
    
          break
      }
    }
  }

  function ParmChanged() {

    let data = {
      name: Name,
      state: State,
      city: City,
      hobbies: Hobbies
    };

    dispatch("parmChanged", data);
    console.log("dispatched");
  }

  $: {ChangeHobbies(filterName, filterValue); ParmChanged();};

  $: {
    let x = Name;
    let y = City;

    ParmChanged();
  }
</script>

<form id="SortForm">
  <div class="box">
    <h1>
      <strong>Search by</strong>
    </h1>
    <div class="columns">
      <div class="column">

        <input
          class="input"
          type="text"
          placeholder="Name"
          bind:value={Name}
          on:change={ParmChanged} />
        <br />
        <div class="control">
          <div class="select">
            <select bind:value={State} on:change={ParmChanged}>
              <option selected>Select state</option>
              <option>Online</option>
              <option>Away</option>
              <option>Offline</option>
            </select>
          </div>
        </div>
      </div>
      <div class="column">
        <input
          class="input"
          type="text"
          placeholder="City"
          bind:value={City}
          on:change={ParmChanged} />
        <div class="box">
          <h1>Hobbies</h1>
          <div class="columns">
            <div class="column">
              <label class="checkbox">
                <input
                  type="checkbox"
                  bind:checked={Hobbies.football}
                  on:change={ParmChanged} />
                football
              </label>
              <label class="checkbox">
                <input
                  type="checkbox"
                  bind:checked={Hobbies.reading}
                  on:change={ParmChanged} />
                reading
              </label>
              <label class="checkbox">
                <input
                  type="checkbox"
                  bind:checked={Hobbies.running}
                  on:change={ParmChanged} />
                running
              </label>
            </div>
            <div class="column">
              <label class="checkbox">
                <input
                  type="checkbox"
                  bind:checked={Hobbies.skating}
                  on:change={ParmChanged} />
                skating
              </label>
              <label class="checkbox">
                <input
                  type="checkbox"
                  bind:checked={Hobbies.fishing}
                  on:change={ParmChanged} />
                fishing
              </label>
              <label class="checkbox">
                <input
                  type="checkbox"
                  bind:checked={Hobbies.drawing}
                  on:change={ParmChanged} />
                drawing
              </label>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</form>
