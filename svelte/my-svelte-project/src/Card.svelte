<script>
export let userInfo;
</script>
<div class="card is-marginless">
  <div class="card-image">
    <figure class="image is-4by4">
       <img src={userInfo.imageLink} alt="Placeholder image">
    </figure>
  </div>
  <div class="card-content">
    <div class="content ">
      <p class="has-text-centered	is-size-6">
        {userInfo.nickname}
      </p>
    </div>
  </div>
</div>