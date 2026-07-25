---
layout: default
title: Semantic Band-Gap (LLM + KG)
permalink: /projects/semantic-models/
---
# Semantic Band-Gap (LLM + KG)

<div class="media hero" data-alt="NL→KG with normalization; metada for provenance.">
  <img src="/assets/img/projects/bandgap-kg/hero.png"
       alt="NL→KG with normalization; metada for provenance.">
</div>

<div class="hero-note">NL→KG with normalization; metada for provenance.</div>

<div class="metrics">
  <span class="metric">RDF/SPARQL</span>
  <span class="metric alt">LLM-assisted retrieval/query</span>
  <span class="metric good">llama3.2:3b local</span>
</div>

<p> Fine-tuned two LoRA adapters on Llama 3.2 (3B) for a neuro-symbolic
knowledge graph pipeline over semiconductor band-gap data (~150k materials,
~999k RDF triples, sourced from Materials Project, featurized via matminer).
One adapter generates SPARQL from natural-language questions (eval loss
0.0004, 13/13 held-out queries parse-valid); the other extracts deduplicated
triples from unstructured text and URLs (eval loss 0.0002, 21/21 valid JSON,
11/11 rejection cases correct). A deterministic sanitizer sits between the
LLM and the graph — validates, repairs, and enforces schema constraints on
every generated query, turning understood model failure modes into corrected
output. RDF schema covers composition, crystal system, centrosymmetricity,
band gap, and provenance. The graph serves as a single provenance-tracked
source for band-gap screening, replacing manual cross-referencing of
disconnected CSV, API, and literature sources. Query interface served as
an API with interactive docs, available on request via email.</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/Semantic_models_for-MSE" target="_blank" rel="noopener">GitHub</a></p>

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

