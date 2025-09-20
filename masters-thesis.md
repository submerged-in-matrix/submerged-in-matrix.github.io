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


<p><span class="label">What:</span> Designed the excitation & acquisition pipeline (MATLAB + audio interface) **and** built an ML stack (SINDy + small ANN residual) to learn nonlinear EM-sensor dynamics.</p>
<p><span class="label">Why:</span> Prototype toward an implantable magnetoelectric sensor; set excitation frequency and boundary conditions to respect brain-field constraints and safety.</p>
<p><span class="label">How:</span> Discovered governing equations with SINDy; ANN residual captured leftover nonlinearity.</p>
<p><span class="label">Results:</span> Validated via energy consistency, stiffness (oscillator-type), and damping (phase portraits); interpretable model predicts the signal **and its derivatives**.</p>


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
    <figcaption><strong>SINDy</strong> capturing the EM-sensor’s damping behavior (phase portraits).</figcaption>
  </figure>
  <div id="mfig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/masters/fig2.png" alt=""></div>
</div>





