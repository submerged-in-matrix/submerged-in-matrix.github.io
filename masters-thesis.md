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

**What:** Designed the excitation & acquisition pipeline (MATLAB + audio interface) **and** built ML-pipelines (SINDy,  ANN: MLP & LSTM ) to learn nonlinear EM-sensor dynamics  
**Why:** Prototype toward an implantable magnetoelectric sensor; set excitation frequency and boundary conditions to respect brain's magnetic-field constraints and safety. 
**How:** Discovered governing differential equations via tuning the developed SINDy model which best portrays the dynamics of the system.
**Results:** Validated via energy consistency, stiffness (oscillator-type), and damping (phase portraits); delivered an **interpretable model** that predicts the signal and its **derivatives**.

<p>
  <!-- Add your repo when ready -->
  <a class="btn" href="https://github.com/submerged-in-matrix/Masterarbeit" target="_blank" rel="noopener">GitHub</a> 
  
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

