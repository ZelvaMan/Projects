<script>
  import overview from "./overview.svelte";
  import personDetail from "./personDetail.svelte";
  import Router from 'svelte-spa-router';
  import {link} from 'svelte-spa-router';
  export let name = "honza";
  let  today = new Date();
  
  var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
  
  const routes = {
    '/filter/:filtername/:filtervalue': overview,
    '/': overview,
    '/personDetail/*': personDetail
}
</script>

<nav class="navbar is-dark level">
  <div class="level-left">
    <h1>Hello {name.toUpperCase()}</h1>  
    <a class="button is-dark" href="/" use:link>overview</a> 
  </div>
  <div class="level-right">
    <h2>time : {time}</h2>
  </div>
</nav>
<div class="section">
 <Router {routes}/>
</div>

