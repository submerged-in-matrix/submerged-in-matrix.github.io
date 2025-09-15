---
layout: default
title: Melting-Point Prediction (2-Level Decorrelated Ensemble)
---
# Melting-Point Prediction (Multi-level ML)

<div class="media">
  <img src="/assets/img/projects/mp-ensemble/hero.png" alt="effect of Stacking order on Ensemble performance" />
</div>

<div class="metrics">
  <span class="metric">R² ≈ 0.83</span>
  <span class="metric alt">~20k samples (Citrination)</span>
  <span class="metric good">Custom decorrelated (1st) & stacking (2nd) layer</span>
</div>

<p><span class="label">What:</span> Predict melting points of organic compounds with a <strong>two-level stacking ensemble</strong> (RF/XGB/LGBM/MLP).</p>
<p><span class="label">Why:</span> Reproduced and <strong>extended</strong> a published approach (<a href="https://link.springer.com/article/10.1134/S1995080223010341" target="_blank" rel="noopener">DOI</a>) to validate best practices on a larger, custom set.</p>
<p><span class="label">How:</span> Built a ~20k dataset; featurized <strong>SMILES</strong> with RDKit + custom bond-count features; Custom-stacked tuned Ensemble.</p>
<p><span class="label">Results:</span> <strong>R² ≈ 0.83</strong>; custom stacking order improved baseline by ~<strong>4%</strong> out-of-sample.</p>


<p><a class="btn" href="https://github.com/submerged-in-matrix/materials-ml-projects-/tree/main/Projects/P_4_MP_Pred_2_Lvl_Ensemble" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery stack">
  <figure class="figure tilt">
    <a href="#mp-fig1"><img src="/assets/img/projects/mp-ensemble/fig1.png" alt=""></a>
    <figcaption><em>Heatmap (pair-wise correlations) on prediction accuracy for validation data.</em></figcaption>
  </figure>
  <div id="mp-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/mp-ensemble/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#mp-fig2"><img src="/assets/img/projects/mp-ensemble/fig2.png" alt=""></a>
    <figcaption><em>Top 20 SHAP features</em></figcaption>
  </figure>
  <div id="mp-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/mp-ensemble/fig2.png" alt=""></div>
</div>

