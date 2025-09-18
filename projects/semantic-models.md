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

<p><span class="label">What:</span> Built a <strong>semantic knowledge graph (KG)</strong> for custom-featurized semiconductor band-gap data using RDF triples.</p>
<p><span class="label">Why:</span> Enable <strong>structured, explainable retrieval</strong> and easy integration of heterogeneous materials datasets.</p>
<p><span class="label">How:</span> Designed an RDF schema (materials, composition, structure-features, measurements); ingested sources, provenence metadata to RDF; used <strong>a light-weight local Ollama</strong> model to translate natural language: into executable <strong>SPARQL</strong> queries (secondary purpose) or into deduped + sanitized ingestible triples to the KG , supporting url, pdf, raw/fabricated texts [<strong>PRIMARY TASK</strong> ].</p>
<p><span class="label">Results:</span> A <strong>queryable single source of truth</strong> that improves accessibility, automation, and reproducibility for band-gap analysis.</p>

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

