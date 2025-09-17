---
layout: default
title: Oxidation-State Assignment
permalink: /projects/oxidation-states/
---
# Oxidation-State Assignment

<div class="media">
  <img src="/assets/img/projects/oxi-ensemble/hero.png" alt="Choosing optimized weights for the base models" />
</div>
<div class="media hero" data-alt="Choosing optimized weights for the base models">
  <img src="/assets/img/projects/oxi-ensemble/hero.png"
       alt="Choosing optimized weights for the base models">
</div>

<div class="hero-note">Choosing optimized weights for the base models</div>

<div class="metrics">
  <span class="metric">Proxy R² ≈ 0.91</span>
  <span class="metric alt">~7k OQMD </span>
  <span class="metric good">Ensemble (soft voting)</span>
</div>

<p><span class="label">What:</span> Assign oxidation states in MOFs with a <strong>soft-voting ensemble</strong> of four diverse base learners.</p>
<p><span class="label">Why:</span> Reproduced and <strong>extended</strong> a published approach (<a href="https://www.nature.com/articles/s41557-021-00717-y" target="_blank" rel="noopener">DOI</a>) to validate best practices on a custom OQMD/ICSD subset.</p>
<p><span class="label">How:</span> Curated ~7k ICSD-tagged MOF entries from OQMD; manual target assignment; tuned four base models via mixed strategies (random search, simulated annealing, TPE) and applied <strong>weighted voting</strong>.</p>
<p><span class="label">Results:</span> <strong>Proxy R² ≈ 0.91</strong> on ~7k samples; custom weighting improved the ensemble by ~<strong>3%</strong> vs. uniform voting.</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/materials-ml-projects-/tree/main/Projects/P_5_Oxidation_State_Assignment" target="_blank" rel="noopener">GitHub</a></p>


<div class="gallery equal">
  <figure class="figure tilt">
    <a href="#fe-fig1">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/oxi-ensemble/fig1.png" alt="Choosing optimum feature-matrix size from SHAP-ranked features (all)">
      </div>
    </a>
    <figcaption><em>Choosing optimum feature-matrix size from SHAP-ranked features (all)</em></figcaption>
  </figure>
  <div id="fe-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/oxi-ensemble/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#fe-fig2">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/oxi-ensemble/fig2.png" alt="Deciding on Iteration No. for tuning the hyperparameters of the base learners using Hyperopt.">
      </div>
    </a>
    <figcaption><em>Deciding on Iteration No. for tuning the hyperparameters of the base learners using Hyperopt.</em></figcaption>
  </figure>
  <div id="fe-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/oxi-ensemble/fig2.png" alt=""></div>
</div>

