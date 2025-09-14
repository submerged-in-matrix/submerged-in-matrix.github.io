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
  <span class="metric good">Magnetoelectric sensors</span>
</div>

**What:** Designed the excitation & acquisition pipeline to probe sensor dynamics (MATLAB + audio interface).  
**Why:** Needed a compact, explainable model for nonlinear source behavior in EM sensors.  
**How:** Discovered governing equations with SINDy and used a small neural residual to capture remaining nonlinearity.  
**Results:** Validated via energy consistency, stiffness (oscillator-type), and damping (phase portraits); delivered an **interpretable model** that predicts the signal and its **derivatives**.

<p>
  <!-- Add your repo when ready -->
  <!-- <a class="btn" href="YOUR_GITHUB_URL" target="_blank" rel="noopener">GitHub</a> -->
  <a class="btn" href="/poster-publication">Poster/Publication</a>
</p>

<div class="gallery">
  <figure class="figure">
    <a href="#mfig1"><img src="/assets/img/masters/fig1.png" alt="Stiffness force"></a>
    <figcaption>SINDy capturing the EM-sensor’s <strong>stiffness force</strong> (oscillator-type).</figcaption>
  </figure>
  <div id="mfig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/masters/fig1.png" alt=""></div>

  <figure class="figure">
    <a href="#mfig2"><img src="/assets/img/masters/fig2.png" alt="Damping force"></a>
    <figcaption>SINDy capturing the EM-sensor’s <strong>damping behavior</strong> (phase portraits).</figcaption>
  </figure>
  <div id="mfig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/masters/fig2.png" alt=""></div>
</div>

