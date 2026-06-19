---
layout: default
title: Elastic Constants of Fe–Cr Alloys — DFT → ML → FEM
permalink: /projects/fe-cr-nanoindentation/
---

# Elastic Constants of Fe–Cr Alloys — DFT → ML → FEM

<div class="media hero" data-alt="Nanoindentation von Mises stress field at peak load — Fe16Cr0 three-panel composite">
  <img src="/assets/img/projects/Fe_Cr_Nind/fe16cr00_Mises_peak.png"
       alt="Three-panel von Mises stress composite for Fe16Cr0 at peak indentation load: overview, near-field contact patch, and close-up contact zone">
</div>
<div class="hero-note">Von Mises stress at peak load (h = 0.404 µm) — Fe16Cr0 reference case. Three-panel composite: overview ∣ near-field (full contact patch, a = 1.128 µm) ∣ close-up (sub-contact detail). Colorbar capped at 20,000 MPa (~1.9× mean contact pressure) to suppress penalty contact edge singularities and reveal the physical stress bulb.</div>

<div class="metrics">
  <span class="metric">4 compositions · 0–100% Cr</span>
  <span class="metric alt">DFT → ML → FEM pipeline</span>
  <span class="metric good">Eᵣ within ±12% of Hill VRH</span>
</div>

<p>
  A three-stage first-principles-to-FEM pipeline for Fe-Cr binary alloys, targeting the
  composition-dependent reduced indentation modulus <em>E</em>ᵣ across the full BCC solid-solution
  range. Stage 1 computes C11, C12, and C44 for 17 compositions using the strain–stress method
  in Quantum ESPRESSO on a GPU-accelerated cloud node. Stage 2 trains Gaussian-Process and MLP
  surrogates to interpolate the elastic tensor across composition space, generating FEM-ready
  material cards. Stage 3 runs axisymmetric conical-indentation simulations in CalculiX and
  extracts <em>E</em>ᵣ via the Oliver–Pharr method.
</p>
<p>
  The central methodological challenge was penalty-contact validity. An earlier model generation
  used a fixed penalty stiffness that silently saturated — producing a spurious flat <em>E</em>ᵣ
  ≈ 40 GPa across all compositions with no solver warnings. The validated model sets
  <strong>K = 5 × C11 per composition</strong>, confirmed by checking observed contact pressure
  against the K × h<sub>element</sub> ceiling. The resulting <em>E</em>ᵣ values track the
  analytical Hill VRH reference within −12% to +7%, consistent with the elastic-only constitutive
  model, idealised conical geometry, and lower-bound penalty stiffness.
</p>
<p>
  Post-processing is staged across all three pipeline steps. DFT output undergoes a five-tier
  convergence audit that assigns quality weights carried into ML training. The ML stage selects
  models per elastic constant via leave-one-out cross-validation and an fe02cr14 ablation study.
  FEM output is corrected for the CAX 2° wedge (×180 force scaling) and zero-contact unloading
  points before Oliver–Pharr fitting. Field visualisation in ParaView 6.1.1 uses per-composition
  colorbar caps derived from the mean contact pressure to suppress penalty singularity nodes
  and reveal the physical stress and strain fields.
</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/fe-cr_cu-ni_DFT" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">

  <figure class="figure tilt">
    <a href="#fecr-fig1">
      <div class="frame">
        <img class="pixel-safe"
             src="/assets/img/projects/Fe_Cr_Nind/dft_ml_fem_pipeline.svg"
             alt="Pipeline schematic: Stage 1 DFT → Stage 2 ML → Stage 3 FEM, each with a post-processing step below">
      </div>
    </a>
    <figcaption><em>Three-stage pipeline with explicit post-processing at each step. Stage 1 produces a five-tier elastic-constant dataset. Stage 2 selects the best GP/MLP surrogate per constant and emits CalculiX and ABAQUS material cards. Stage 3 corrects for wedge scaling and zero-contact exclusion before Oliver–Pharr fitting and ParaView field visualisation.</em></figcaption>
  </figure>
  <div id="fecr-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/fe-cr-nanoindentation/pipeline_schematic.svg" alt=""></div>

  <figure class="figure tilt">
    <a href="#fecr-fig2">
      <div class="frame">
        <img class="pixel-safe"
             src="/assets/img/projects/Fe_Cr_Nind/fecr_Er_K_dependency.png"
             alt="Er vs Cr% plot showing K-saturated v16 flat at ~40 GPa versus validated v19 tracking Hill VRH within ±12%">
      </div>
    </a>
    <figcaption><em>K-dependency diagnostic: the v16 model (fixed K = 10,000 MPa/µm) produces a spurious flat <em>E</em>ᵣ ≈ 40 GPa regardless of composition — the substrate elastic constants never enter the force response. The v19 model (K = 5 × C11) tracks the analytical Hill VRH curve within −12% to +7%. Both models converged cleanly; the saturation is detectable only by checking contact pressure against the K × h<sub>element</sub> ceiling.</em></figcaption>
  </figure>
  <div id="fecr-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/fe-cr-nanoindentation/fecr_Er_K_dependency.png" alt=""></div>

</div>

<div class="media" data-alt="Von Mises stress animations — all four Fe-Cr compositions at peak load">
  <table>
    <tr>
      <td style="text-align:center">
        <img src="/assets/img/projects/Fe_Cr_Nind/fe16cr00_Mises.gif"
             alt="Fe16Cr0 von Mises stress animation — full load-unload cycle">
        <div class="hero-note">Fe16Cr0 — 0% Cr &nbsp;·&nbsp; <em>E</em>ᵣ = 196.9 GPa (−12.4% vs VRH)</div>
      </td>
      <td style="text-align:center">
        <img src="/assets/img/projects/Fe_Cr_Nind/fe08cr08_Mises.gif"
             alt="Fe8Cr8 von Mises stress animation — full load-unload cycle">
        <div class="hero-note">Fe8Cr8 — 50% Cr &nbsp;·&nbsp; <em>E</em>ᵣ = 220.5 GPa (−1.1% vs VRH)</div>
      </td>
    </tr>
    <tr>
      <td style="text-align:center">
        <img src="/assets/img/projects/Fe_Cr_Nind/fe04cr12_Mises.gif"
             alt="Fe4Cr12 von Mises stress animation — full load-unload cycle">
        <div class="hero-note">Fe4Cr12 — 75% Cr &nbsp;·&nbsp; <em>E</em>ᵣ = 247.7 GPa (−3.7% vs VRH)</div>
      </td>
      <td style="text-align:center">
        <img src="/assets/img/projects/Fe_Cr_Nind/fe00cr16_Mises.gif"
             alt="Fe0Cr16 von Mises stress animation — full load-unload cycle">
        <div class="hero-note">Fe0Cr16 — 100% Cr &nbsp;·&nbsp; <em>E</em>ᵣ = 274.0 GPa (+6.8% vs VRH) ⚠️ AFM</div>
      </td>
    </tr>
  </table>
</div>
<div class="hero-note">Von Mises stress — full load–unload cycle for all four compositions. Three-panel composite: overview (indenter motion) ∣ near-field (contact patch decay) ∣ close-up (sub-contact detail). Fe0Cr16 shows a distinctly broader stress field driven by its anomalously low C12 (66 GPa, AFM ground state) and low Poisson ratio (ν ≈ 0.22).</div>
