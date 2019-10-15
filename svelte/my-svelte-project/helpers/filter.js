
  export function Find(name,people){
    let filtred =  people.find(function(element) {
      return element.nickname == name;
    });

    return filtred;
  }



  export function Sort(parms,people) {
    console.log(parms);
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
      console.log("hobbies selected")
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
        console.log("hobby");
        if (item.hobbies.includes(hobby) && hobbies[hobby] == true) {
          console.log("+1");
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
