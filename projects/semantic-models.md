---
layout: default
title: Semantic Band-Gap (LLM + KG)
permalink: /projects/semantic-models/
---
# Semantic Band-Gap (LLM + KG)

<div class="media hero" data-alt="NL query to the Knowledge graph">
  <img src="/assets/img/projects/bandgap-kg/hero.png"
       alt="NL query to the Knowledge graph">
</div>

<div class="hero-note">NL query to the Knowledge graph.</div>

<div class="metrics">
  <span class="metric">RDF / SPARQL · 1.36M triples</span>
  <span class="metric alt">NL→SPARQL via fine-tuned Llama 3.2 3B</span>
  <span class="metric good">150,987 materials · symmetry-aware screening</span>
</div>

<p>A neuro-symbolic pipeline for symmetry-aware materials screening.
Multi-constraint questions in materials science are rarely blocked by a
single missing number — they are blocked by constraints living in
different formats. Finding a candidate for ultraviolet frequency
doubling, for instance, requires a non-centrosymmetric crystal (even-order
nonlinear response vanishes identically under inversion symmetry — a
selection rule, not a tendency) <em>and</em> a wide band gap. Symmetry
comes from the crystal structure, the gap from an electronic-structure
calculation, composition from a formula string. Here that is one
question: <em>"non-centrosymmetric materials with band gap above
2.5 eV"</em> returns 9,429 candidates from 150,987, provenance attached.
Two LoRA adapters fine-tuned on Llama 3.2 (3B) drive it — one generating
SPARQL from natural language, one extracting deduplicated triples from
unstructured text. A deterministic sanitizer sits between model and
graph, repairing and schema-enforcing every generated query, turning
understood failure modes into corrected output. The RDF schema covers
composition, crystal system, centrosymmetry, band gap, and provenance
across 1.36M triples. Node identity is the Materials Project
<code>material_id</code>, not chemical formula: one composition
crystallises into structurally distinct phases, and 91.6% of multi-entry
compositions were confirmed to hold genuinely different structures via
<code>pymatgen</code> StructureMatcher.</p>

<p><a class="btn" href="https://huggingface.co/spaces/brainteaser/semantic-bg-query-semiconductor" target="_blank" rel="noopener">Live Demo</a>
<a class="btn" href="https://github.com/submerged-in-matrix/KG_BG_Semiconductors" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">
  <figure class="figure tilt">
    <a href="#fe-fig1">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/bandgap-kg/fig1.png" alt="Ontology">
      </div>
    </a>
    <figcaption><em>Ontology used in the mini MSE KG—Material with five literal properties.</em></figcaption>
  </figure>
  <div id="fe-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/bandgap-kg/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#fe-fig2">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/bandgap-kg/fig2.png" alt="Pipeline">
      </div>
    </a>
    <figcaption><em>Guardrailed NL→SPARQL + typed row normalization</em></figcaption>
  </figure>
  <div id="fe-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/bandgap-kg/fig2.png" alt=""></div>
</div>

