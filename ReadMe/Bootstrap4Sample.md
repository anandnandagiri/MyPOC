  Hide Column 3 & 4 On a Large Screen
  ```
  <div class="container">
    <div class="row">
       <!-- we use div instead of div -->
      <div class="col-6">1<button class="btn btn-primary d-block">adfadf</button></div> 
      <div class="col-md-6">2</div>
      <!-- will be hidden on large screens -->
      <div class="col-md-6 d-block d-lg-none">3</div> 
      <div class="col-md-6 d-block d-lg-none">4</div>
    </div>
  </div>
  ```
