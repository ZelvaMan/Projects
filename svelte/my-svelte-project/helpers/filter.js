import { null_to_empty } from "svelte/internal";

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
    console.log("filtering started with " + sorted.length);
    if(!parms){
      console.log("no parms, returning all people");
      return people;
    }

    if (parms.name) {
      sorted = sorted.filter(SortByName(parms.name));
    }
    console.log("after name filter " + sorted.length);
    if (parms.state !== "Select state" && parms.state != undefined && parms.state != null && parms.state != "") {
      sorted = sorted.filter(SortByState(parms.state));
    }
    console.log("after state filter " + sorted.length);
    if (parms.city) {
      sorted = sorted.filter(SortByCity(parms.city));
    }
    console.log("after city filter " + sorted.length);
    if (HobbiesSelected(parms.hobbies)) {
      console.log("hobbies selected")
      sorted = sorted.filter(SortByHobbies(parms.hobbies));
    }
    console.log("filtering finished : " + sorted.length);
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
        if (item.hobbies.includes(hobby) && hobbies[hobby] == true) {
          return true;
        }
      }
      return false;
    };
  }

  function HobbiesSelected(hobbies) {
    for (var hobby in hobbies) {
      if (hobbies[hobby]) {
        return true;
      }
    }
    console.log("no hobbies selected");
    return false;
  }
