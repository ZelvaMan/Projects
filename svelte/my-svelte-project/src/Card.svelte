<script>
  import {link} from 'svelte-spa-router';
  export let userInfo;
  let url = "/personDetail/" + userInfo.nickname;
</script>
<style>
.n,.n:hover{
  text-decoration: none;
  color: black;
}
</style>
<div class="card is-marginless">
  <a href={url} use:link class="n">
    <div class="card-image">
      <figure class="image is-4by4">
        <img src={userInfo.imageLink} alt="Placeholder image" />
      </figure>
    </div>
    <div class="card-content">
      <div class="content ">
        <p class="has-text-centered is-size-6 ">{userInfo.nickname}</p>
      </div>
    </div>
  </a>
</div>
