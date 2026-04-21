---
layout: default
title: Graphene Dirac Cone under Uniaxial Strain — DFT
permalink: /projects/graphene-strain-qe-dft/
---
# Graphene Dirac Cone under Uniaxial Strain — DFT

<div class="media hero" data-alt="Band structure evolution from 0% to 20% uniaxial strain">
  <img src="/assets/img/projects/graphene-dft/bands_comparison.png"
       alt="Band structure evolution from 0% to 20% uniaxial strain">
</div>
<div class="hero-note">π and π* band evolution along Γ → M → K → Γ across 11 strain levels (0–20%)</div>

<div class="metrics">
  <span class="metric">Gap: 0 → 2.85 eV</span>
  <span class="metric alt">11 strain levels</span>
  <span class="metric good">QE · PBE/PAW · 2D k-scan</span>
</div>

<p>
  First-principles PBE study (Quantum ESPRESSO) of how the Dirac cone in graphene responds to
  uniaxial tensile strain along the zigzag direction, from 0% to 20% in 2% steps.
  The key methodological contribution: a <strong>2D k-scan around the K point</strong> at selected
  strain levels revealed that the standard 1D band path <strong>overestimates the gap by 23× at 4%
  strain</strong> — the apparent 479 meV gap reduces to 21 meV once the actual (shifted) Dirac
  point is located. This makes the Fermi velocity asymmetry a practical diagnostic: the ratio of
  M→K to K→Γ band slopes tracks whether a gap is a geometric path artifact or a true topological
  transition. Three regimes emerge cleanly — <strong>cone survives (0–4%)</strong>,
  <strong>cone deforming (6–10%)</strong>, <strong>cone destroyed (&gt;10%)</strong> — with the
  critical strain appearing lower than simple tight-binding predictions (~10% vs ~20%), attributed
  to DFT capturing bond-weakening and orbital rehybridization absent from the tight-binding model.
  Structural relaxation under each strained cell (BFGS, fixed cell) confirmed that sublattice
  shifts grow from ~0.001 to ~0.016 crystal units at 20%, making internal relaxation non-negligible
  at large deformation.
</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/graphene-strain-qe-dft" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">

  <figure class="figure tilt">
    <a href="#gr-fig1">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/graphene-dft/gap_vs_strain.png"
             alt="Band gap at K and Fermi velocity vs. strain">
      </div>
    </a>
    <figcaption><em>Top: gap at K grows approximately linearly with strain. Bottom: Fermi velocity from M→K and K→Γ directions. Velocity divergence above ~6% marks the transition from shifted Dirac cone to true gap opening.</em></figcaption>
  </figure>
  <div id="gr-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/graphene-dft/gap_vs_strain.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#gr-fig2">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/graphene-dft/2d_kscan_gap_map.png"
             alt="2D k-scan gap map around K at 4% and 10% strain">
      </div>
    </a>
    <figcaption><em>Band gap mapped on a 21×21 k-grid around K. At 4% (left), the Dirac point has shifted off the nominal K with a true gap of only 21 meV. At 10% (right), the 71 meV minimum gap and elongated gap valley confirm the cone is on the verge of destruction — a result invisible on the standard 1D path.</em></figcaption>
  </figure>
  <div id="gr-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/graphene-dft/2d_kscan_gap_map.png" alt=""></div>

</div>
