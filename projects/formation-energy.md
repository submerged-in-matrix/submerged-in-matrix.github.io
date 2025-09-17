---
layout: default
title: Formation-Energy Prediction
permalink: /projects/formation-energy/
---
# Formation-Energy Prediction  

<div class="media hero" data-alt="Performance summary of the best models">
  <img src="/assets/img/projects/formation-energy/hero.png" alt="Performance summary of the best models" />
</div>

<div class="hero-note">Performance summary of the best models</div>

<div class="metrics">
  <span class="metric">PyCaret</span>
  <span class="metric alt">Auto features+model selection</span>
  <span class="metric good">Selection Metrics: R2 & Mean Absolute Error (MAE)</span>
  <span class="metric good">Practical targets</span>
  <span class="metric alt">Best Models (CatBoost, ExtraTrees)</span>
</div>

<p><span class="label">What:</span> Built a strong AutoML baseline for formation energy using <strong>PyCaret</strong> to auto-select algorithms and features.</p>
<p><span class="label">Why:</span> Stress-tested AutoML on a thermodynamic target with weak direct descriptors (formation energy) to gauge when AutoML is truly viable.</p>
<p><span class="label">How:</span> Featurized <strong>chemical formulas</strong> and <strong>Pymatgen structures</strong> via Matminer; tuned PyCaret setup; compared model/feature sets by CV <strong>MAE</strong> and <strong>R²</strong>, prioritizing MAE for selection.</p>
<p><span class="label">Results:</span> <strong>MAE-first selection</strong> beat R²-first on out-of-sample performance, yielding a compact model with lower error and clearer trade-offs.</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/materials-ml-projects-/tree/main/Projects/P_2_Formation_Energy_Prediction" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">
  <figure class="figure tilt">
    <a href="#fe-fig1">
      <div class="frame">
        <img class="pixel-safe wide" src="/assets/img/projects/formation-energy/fig1.png" alt="Prediction vs. ground truth">
      </div>
    </a>
    <figcaption><em>Prediction vs. ground truth of the best models (for both metrics)</em></figcaption>
  </figure>
  <div id="fe-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/formation-energy/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#fe-fig2">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/formation-energy/fig2.png" alt="Learning curve (MAE sorted)">
      </div>
    </a>
    <figcaption><em>Learning curve for ExtraTrees Regressor (MAE sorted)</em></figcaption>
  </figure>
  <div id="fe-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/formation-energy/fig2.png" alt=""></div>
</div>
