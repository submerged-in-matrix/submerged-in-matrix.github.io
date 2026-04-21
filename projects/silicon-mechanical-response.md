---
layout: default
title: Si Nanowire Mechanical Response — Parametric MD
permalink: /projects/silicon-mechanical-response/
---
# Si Nanowire Mechanical Response — Parametric MD

<div class="media hero" data-alt="Parametric sweep: size effect and rate effect on Young's modulus">
  <img src="/assets/img/projects/si-nanowire/parametric_sweep.png"
       alt="Parametric sweep: size effect and rate effect on Young's modulus">
</div>
<div class="hero-note">Young's modulus vs. diameter and strain rate — 16-run parametric sweep</div>

<div class="metrics">
  <span class="metric">E: 34 → 44 GPa</span>
  <span class="metric alt">16 runs (4 × 4)</span>
  <span class="metric good">LAMMPS · Tersoff</span>
</div>

<p>
  Parametric MD study of uniaxial tensile deformation in [001] diamond-cubic silicon nanowires,
  sweeping wire diameter (33–109 Å) and strain rate (10⁸–5×10⁹ s⁻¹) across
  <strong>16 independent LAMMPS runs</strong>. The central finding: Young's modulus is governed
  by the <strong>surface-to-volume ratio</strong>, not strain rate. E rises from 34 to 44 GPa as
  diameter increases — under-coordinated surface atoms in the diamond cubic lattice reduce local
  stiffness, and their fractional contribution shrinks as the wire thickens. Strain rate changes E
  by less than 5% at any diameter, confirming rate-independence in this regime. Extrapolation toward
  bulk [100] Si (E ≈ 130 GPa) is consistent with a surface-fraction-dependent stiffness model,
  with the remaining gap attributed to a known Tersoff potential limitation in reproducing
  anisotropic elastic constants C₁₁ and C₁₂.
</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/silicon-mechanical-response" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">

  <figure class="figure tilt">
    <a href="#si-fig1">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/si-nanowire/si_stress_strain.png"
             alt="Stress-strain curves across all 16 runs">
      </div>
    </a>
    <figcaption><em>Smoothed stress-strain curves across all 16 (diameter × strain-rate) combinations. Linear elastic regime used for best-fit E extraction with R² quality control.</em></figcaption>
  </figure>
  <div id="si-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/si-nanowire/si_stress_strain.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#si-fig2">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/si-nanowire/bulk_extrapolation.png"
             alt="Extrapolation of Young's modulus toward bulk Si limit">
      </div>
    </a>
    <figcaption><em>Extrapolation of E toward the bulk Si [100] limit using surface-fraction and 1/d models. Both models converge to ~47 GPa at zero surface fraction; the remaining gap to 130 GPa isolates the Tersoff potential error.</em></figcaption>
  </figure>
  <div id="si-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/si-nanowire/bulk_extrapolation.png" alt=""></div>

</div>
