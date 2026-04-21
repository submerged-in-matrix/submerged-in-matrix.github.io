---
layout: default
title: Masters Thesis
---
# SINDy + ANN for Magnetoelectric Sensors

<div class="media">
  <video src="/assets/video/masters/hero.mp4" autoplay muted loop playsinline></video>
</div>

<div class="metrics">
  <span class="metric">Thesis</span>
  <span class="metric alt">SINDy + ANN</span>
  <span class="metric good">Magnetoelectric sensors (Duffing Oscillator)</span>
  <span class="metric">R² SINDy: 0.986 (deriv)</span>
  <span class="metric">R² SINDy: 0.991 (signal)</span>
  <span class="metric good">DNNS: 99.85–100%</span>
</div>


<p> Designed the excitation and acquisition pipeline (MATLAB + audio interface) for a prototype implantable magnetoelectric sensor, setting excitation frequency and boundary conditions to respect brain-field safety constraints. Applied SINDy to discover the governing equations directly from acquired signals — recovering Duffing-type dynamics with R² ≈ 0.99, yielding a model that predicts both the signal and its derivatives. ANN models (LSTM, MLP) were built in parallel as accuracy benchmarks; SINDy matched or exceeded them while remaining fully interpretable. Validated via energy consistency, stiffness (force-deflection), and damping (phase portrait) analyses.</p>

<p>
  <!-- Add your repo when ready -->
  <a class="btn" href="https://github.com/submerged-in-matrix/Masterarbeit" target="_blank" rel="noopener">GitHub</a> 
  
</p>

<div class="gallery stack">
  <figure class="figure tilt">
    <a href="#mfig1"><img src="/assets/img/masters/fig1.png" alt="Stiffness force"></a>
    <figcaption><strong>SINDy</strong> capturing the EM-sensor’s stiffness force, i.e., non-dimensional force-deflection characteristics.</figcaption>
  </figure>
  <div id="mfig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/masters/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#mfig2"><img src="/assets/img/masters/fig2.png" alt="Damping force"></a>
    <figcaption><strong>SINDy</strong> capturing the EM-sensor’s damping behavior (phase portraits, i.e., non-dimensional deflection (y1, U) vs. its derivative (y2, Udot)).</figcaption>
  </figure>
  <div id="mfig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/masters/fig2.png" alt=""></div>
</div>





