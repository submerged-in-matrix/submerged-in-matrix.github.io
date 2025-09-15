---
layout: default
title: Selected Projects
---
# Selected Projects
<p class="muted">Six quick cards—click a title to see the full page with What · Why · How · Results.</p>

<div class="proj-grid">

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/pinn-elasticity/' | relative_url }}">2D Linear Elasticity via PINN</a></h3>
    <p>Physics-informed NN for fast, physics-consistent field predictions.</p>
    <p class="chips">
      <span class="badge">PINN</span><span class="badge alt">FEM</span>
      <span class="badge alt">val loss 2.22</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/mp-ensemble/' | relative_url }}">Melting-Point Prediction (2-Level Ensemble)</a></h3>
    <p>Stacked RF/XGB/LGBM/MLP with SHAP-guided features.</p>
    <p class="chips">
      <span class="badge">R² ≈ 0.83</span><span class="badge alt">~20k samples</span>
      <span class="badge alt">2 level Ensemble</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/oxidation-states/' | relative_url }}">Oxidation-State Assignment</a></h3>
    <p>Soft-voting ensemble on lean OQMD/ICSD data.</p>
    <p class="chips">
      <span class="badge">Proxy R² ≈ 0.91</span><span class="badge alt">~7k OQMD</span>
      <span class="badge alt">Weighted soft voting</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/semantic-models/' | relative_url }}">Semantic Band-Gap (LLM + KG)</a></h3>
    <p>RDF/SPARQL schema with LLM-assisted, explainable queries.</p>
    <p class="chips">
      <span class="badge">RDF/SPARQL</span><span class="badge alt">LLM</span>
      <span class="badge alt">Explainable</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/patterns-matter/' | relative_url }}">Materials Database App</a></h3>
    <p>Auto-ETL + Flask UI to track datasets → features → results.</p>
    <p class="chips">
      <span class="badge">Auto-ETL</span><span class="badge alt">Flask + SQLite</span>
      <span class="badge alt">CRUD</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/formation-energy/' | relative_url }}">Formation-Energy Prediction</a></h3>
    <p>AutoML baseline with Matminer features and MAE-first selection.</p>
    <p class="chips">
      <span class="badge">R² 0.971–0.998</span><span class="badge alt">Matminer</span>
      <span class="badge alt">PyCaret</span>
    </p>
  </div>

</div>
