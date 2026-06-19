---
layout: default
title: Selected Projects
---

# Selected Projects
<p class="muted">Seven projects across atomistic simulation, ML for materials, and data infrastructure — click a title for What · Why · How · Results. GitHub links in each card.</p>

<!-- ── SECTION 1 ─────────────────────────────────────────── -->
<h2 class="proj-section-header">Atomistic Simulation</h2>

<div class="proj-grid">

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/fe-cr-nanoindentation/' | relative_url }}">Fe–Cr Elastic Constants — DFT → ML → FEM</a></h3>
    <p>Strain–stress DFT across 17 Fe-Cr compositions, GP/MLP surrogate training, and CalculiX axisymmetric nanoindentation. K-saturation failure mode caught and corrected; Eᵣ tracks Hill VRH within ±12%.</p>
    <p class="chips">
      <span class="badge">Quantum ESPRESSO</span><span class="badge alt">GP + MLP</span>
      <span class="badge alt">CalculiX CCX</span><span class="badge alt">Eᵣ: 197→274 GPa</span>
    </p>
  </div>
  
  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/silicon-mechanical-response/' | relative_url }}">Si Nanowire Mechanical Response — Parametric MD</a></h3>
    <p>Uniaxial tensile deformation of [001] Si nanowires across 16 (diameter × strain-rate) combinations using the Tersoff potential. Surface-to-volume ratio, not strain rate, controls stiffness.</p>
    <p class="chips">
      <span class="badge">LAMMPS</span><span class="badge alt">Tersoff</span>
      <span class="badge alt">E: 34→44 GPa</span><span class="badge alt">16-run sweep</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/graphene-strain-qe-dft/' | relative_url }}">Graphene Dirac Cone under Uniaxial Strain — DFT</a></h3>
    <p>First-principles PBE study (Quantum ESPRESSO) of Dirac cone robustness under 0–20% zigzag strain. 2D k-scans reveal the 1D band-path overestimates the gap 23× at 4% — the cone survives until ~10%.</p>
    <p class="chips">
      <span class="badge">Quantum ESPRESSO</span><span class="badge alt">PBE/PAW</span>
      <span class="badge alt">11 strain levels</span><span class="badge alt">2D k-scan</span>
    </p>
  </div>

</div>

<!-- ── SECTION 2 ─────────────────────────────────────────── -->
<h2 class="proj-section-header">ML for Materials</h2>

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
      <span class="badge">R² ≈ 0.83</span><span class="badge alt">~3.041k samples</span>
      <span class="badge alt">2-level ensemble</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/oxidation-states/' | relative_url }}">Oxidation-State Assignment</a></h3>
    <p>Soft-voting ensemble on lean OQMD/ICSD data — competitive quality on ~15× less data than typical literature sets.</p>
    <p class="chips">
      <span class="badge">Proxy R² ≈ 0.91</span><span class="badge alt">~7k OQMD</span>
      <span class="badge alt">Weighted soft voting</span>
    </p>
  </div>

</div>

<!-- ── SECTION 3 ─────────────────────────────────────────── -->
<h2 class="proj-section-header">Data & Informatics Infrastructure</h2>

<div class="proj-grid">

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/patterns-matter/' | relative_url }}">Materials Database App</a></h3>
    <p>Auto-ETL + Flask UI tracking datasets → features → results with FAIR-aligned provenance and secure file delivery.</p>
    <p class="chips">
      <span class="badge">Auto-ETL</span><span class="badge alt">Flask + SQLite</span>
      <span class="badge alt">FAIR / provenance</span>
    </p>
  </div>

  <div class="proj-card compact">
    <h3><a class="proj-link" href="{{ '/projects/semantic-models/' | relative_url }}">Semantic Band-Gap (LLM + KG)</a></h3>
    <p>RDF/SPARQL schema with local LLM (llama3.2) for explainable, natural-language materials lookups.</p>
    <p class="chips">
      <span class="badge">RDF/SPARQL</span><span class="badge alt">LLM</span>
      <span class="badge alt">Explainable</span>
    </p>
  </div>

</div>
