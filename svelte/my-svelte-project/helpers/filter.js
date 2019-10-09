

  export function Sort(parms,people) {
    console.log("Sorting started");
    //parametry funguji
    let sorted = people;
    if(!parms)
      return people;
    if (parms.name) {
      sorted = sorted.filter(SortByName(parms.name));
    }

    if (parms.state !== "Select state") {
      sorted = sorted.filter(SortByState(parms.state));
    }

    if (parms.city) {
      sorted = sorted.filter(SortByCity(parms.city));
    }

    if (HobbiesSelected(parms.hobbies)) {
      sorted = sorted.filter(SortByHobbies(parms.hobbies));
    }
    return sorted;
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
