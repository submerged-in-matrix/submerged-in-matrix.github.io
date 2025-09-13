---
layout: default
title: 2D Linear Elasticity via PINN
---
# 2D Linear Elasticity via PINN
<div class="media">
  <img src="/assets/img/projects/pinn-elasticity/hero.png" alt="PINN elasticity demo"/>
</div>
<div class="metrics">
  <span class="metric">PINN</span>
  <span class="metric alt">BCs: Dirichlet/Neumann</span>
  <span class="metric good">Matches FEM baseline</span>
</div>
**What:** Solve plane-stress elasticity with a physics-informed NN.  
**Why:** Continuous fields, fewer meshing headaches; differentiable BCs.  
**How:** PDE loss + BC penalty; cosine annealing; Xavier init.  
**Results:** Strain/stress fields match FEM within ±ε; smooth gradients.

**Links:** <a class="btn" href="YOUR_REPO_URL" target="_blank" rel="noopener">GitHub</a>

<div class="gallery">
  <figure class="figure"><a href="#pe1"><img src="/assets/img/projects/pinn-elasticity/fig1.png" alt=""></a><figcaption>Domain & BCs.</figcaption></figure>
  <div id="pe1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/pinn-elasticity/fig1.png" alt=""></div>

  <figure class="figure"><a href="#pe2"><img src="/assets/img/projects/pinn-elasticity/fig2.png" alt=""></a><figcaption>PINN vs FEM parity.</figcaption></figure>
  <div id="pe2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/pinn-elasticity/fig2.png" alt=""></div>
</div>
