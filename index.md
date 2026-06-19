---
layout: default
title: About
---
<img src="/assets/img/copy.png" alt="Md. Saidul Islam" class="profile" />

<h1 class="name-3d">Md. Saidul Islam</h1>

<p class="lead">Materials science × AI — atomistic simulation, ML, and data infrastructure for accelerated materials development.</p>

<div class="section">
<h2>About</h2>

<div class="about-grid">

<div class="card impact">
  <p>
    I am a materials scientist (M.Sc., CAU Kiel) working at the intersection of materials science and AI — building pipelines where first-principles physics and data-driven models reinforce each other at every scale.
  </p>
  <p>
    Starting from interpretable modelling: SINDy recovered governing equations from magnetoelectric sensor signals (R² ≈ 0.99), outperforming ANN benchmarks without sacrificing physical meaning. That principle — models that explain, not just predict — runs            through the work that followed: ensemble regressors, a PINN for elasticity field inference, and a semantic knowledge graph (RDF + SPARQL + LLM) that ingests materials data from heterogeneous sources with full provenance.
  </p>
  <p>
    The simulation side added two first-principles studies — Si nanowire mechanics across 16 MD configurations (LAMMPS) and strain-driven Dirac cone transitions in graphene across 11 strain levels (Quantum ESPRESSO) — before converging in a DFT → ML → FEM pipeline for Fe-Cr alloys: GP and MLP surrogates trained on 17-composition elastic-constant data (C11 R²=0.91) drove CalculiX nanoindentation simulations that recovered Eᵣ within ±12% of the Hill VRH reference.
  </p>
  
  <p>
    Current work targets MLIP: a GNN on Materials Project formation-energy data is at 24.3 meV/atom, with an active learning loop underway — the next step toward a DFT → MLIP → MD pipeline at quantum-mechanical accuracy.
  </p>
</div>

<div class="card toolbox lean-left">
<h3>Toolbox</h3>

<div class="toolbox-grid">

<div class="tool-group">
<div class="group-title">Atomistic &amp; Continuum Simulation</div>
<div class="chiplist">
<span class="chip">LAMMPS</span><span class="chip">Quantum ESPRESSO (DFT)</span>
<span class="chip">COMSOL</span><span class="chip">Ovito</span>
</div>
</div>

<div class="tool-group">
<div class="group-title">Materials Informatics</div>
<div class="chiplist">
<span class="chip">Matminer</span><span class="chip">Pymatgen</span>
<span class="chip alt">RDKit</span><span class="chip">PCA</span>
<span class="chip">Materials Databases</span><span class="chip alt">Semantic Web (RDF; SPARQL)</span>
</div>
</div>

<div class="tool-group">
<div class="group-title">Machine Learning &amp; AI</div>
<div class="chiplist">
<span class="chip">Ensembles</span><span class="chip">PINN</span><span class="chip alt">DNNs | GNNs</span><span class="chip alt">Active learning</span>
<span class="chip">Time-series analysis</span><span class="chip alt">AutoML</span>
<span class="chip">SHAP</span><span class="chip alt">PyTorch</span><span class="chip alt">TensorFlow</span>
</div>
</div>

<div class="tool-group">
<div class="group-title">Programming &amp; Data Analysis</div>
<div class="chiplist">
<span class="chip">Python (preferred)</span><span class="chip">MATLAB</span>
<span class="chip">SQL</span><span class="chip alt">Bash</span>
<span class="chip alt">API Integration</span><span class="chip">Gnuplot</span><span class="chip alt">MS Excel</span>
<span class="chip alt">OriginPro</span>
</div>
</div>

<div class="tool-group char">
<div class="group-title">Experimental Characterization</div>
<div class="chiplist">
<span class="chip">AFM</span><span class="chip">TEM</span>
<span class="chip">SEM</span><span class="chip">XPS</span>
<span class="chip alt">Universal Testing Machine</span>
<span class="chip alt">VSM</span><span class="chip alt">DSC/TGA</span>
</div>
</div>

<div class="tool-group">
<div class="group-title">Data Infrastructure &amp; HT Workflows</div>
<div class="chiplist">
<span class="chip">Flask</span><span class="chip">Jinja</span>
<span class="chip">Docker</span><span class="chip">SQLite</span>
</div>
</div>


</div><!-- /.toolbox-grid -->
</div><!-- /.card.toolbox -->

<div class="card focus lean-right">
<h3>Focus Areas</h3>
<ul class="focus-list">
  <li>Machine Learning for Molecules</li>
  <li>Atomistic simulation — MD &amp; DFT</li>
  <li>High-throughput materials development workflows</li>
  <li>ML interatomic potential</li>
  <li>Smart &amp; functional materials</li>
  <li>High-entropy Alloys &amp; High-strength & Corrosion resistant alloys</li>
</ul>
</div>

</div><!-- /.about-grid -->
</div><!-- /.section -->
