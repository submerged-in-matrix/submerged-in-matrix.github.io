---
layout: default
title: 2D Linear Elasticity via PINN
permalink: /projects/pinn-elasticity/
---
# 2D Linear Elasticity via PINN

<div class="media hero" data-alt="Obeyance of Navier-Cauchy equation by the PINN model for the collocation points">
  <img src="/assets/img/projects/pinn-elasticity/hero.png"
       alt="Obeyance of Navier-Cauchy equation by the PINN model for the collocation points">
</div>

<div class="hero-note">Obeyance of Navier-Cauchy equation by the PINN model for the collocation points</div>

<div class="metrics">
  <span class="metric">PINN, TensorFlow</span>
  <span class="metric alt">Hypercube Sampling, 2D linear-elasticity</span>
  <span class="metric good">Lowest loss: 2.22 (6 layers, 15 neurons each)</span>
</div>

<p><span class="label">What:</span> Physics-informed NN for 2D linear elasticity predicting <strong>Ux, Uy, σxx, σyy, σxy</strong>.</p>
<p><span class="label">Why:</span> Reduce reliance on dense FEM labels and deliver <strong>fast, physics-consistent</strong> field predictions for design sweeps.</p>
<p><span class="label">How:</span> TensorFlow PINN with <strong>Navier–Cauchy + Hooke</strong> residuals; Latin-hypercube collocation; Dirichlet/Neumann BCs; <strong>27-config</strong> hyperparameter sweep with validation tracking.</p>
<p><span class="label">Results:</span> Best topology <strong>6×15</strong>, dropout 0.3 (Glorot) reached <strong>val loss 2.22</strong>, producing smooth, physically coherent fields and a clear path to add <strong>R²</strong> vs FEM ground truth.</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/materials-ml-projects-/tree/main/Projects/P_3_PINN_Linear_Elasticity" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">
  <figure class="figure tilt">
    <a href="#fe-fig1">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/pinn-elasticity/fig1.png" alt="Residuals">
      </div>
    </a>
    <figcaption><em>Residuals for the shear-stress components (point-wise) predicted by the PINN.</em></figcaption>
  </figure>
  <div id="fe-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/pinn-elasticity/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#fe-fig2">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/pinn-elasticity/fig2.png" alt="Neumann-BC">
      </div>
    </a>
    <figcaption><em>Residuals for the Neumann-BCs (point-wise) predicted by the PINN</em></figcaption>
  </figure>
  <div id="fe-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/pinn-elasticity/fig2.png" alt=""></div>
</div>

