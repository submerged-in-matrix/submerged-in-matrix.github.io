---
layout: default
title: Materials Database App
permalink: /projects/patterns-matter/
---
# Materials Database App

<div class="media hero" data-alt="Results with provenance & one-click View/Download">
  <img src="/assets/img/projects/db-app/hero.png"
       alt="Results with provenance & one-click View/Download">
</div>

<div class="hero-note">Results with provenance & one-click View/Download</div>

<div class="metrics">
  <span class="metric">Auto-ETL</span>
  <span class="metric alt">Flask + SQLite</span>
  <span class="metric alt">Google-drive API-integration</span>
  <span class="metric good">Pipeline: Raw data → Featurization → Results</span>
</div>

<p><span class="label">What:</span> Built a proof-of-concept <strong>Flask/Jinja</strong> app with <strong>SQLite+Google-drive</strong> backend; admin CRUD, role-based access, secure file delivery (via drive API), metadata tracking, and keyword search.</p>
<p><span class="label">Why:</span> Provide <strong>governed, reproducible</strong> management of research files and tabular datasets for collaborative work & a practice-project of RDBMS</p>
<p><span class="label">How:</span> Automated ETL (CSV/NPY → pandas → SQL), type validation, normalized schemas, <strong>idempotent imports</strong>, and Google Drive API integration for ingestion, preview, and download.</p>
<p><span class="label">Results:</span> <strong>Provenance & timestamps</strong> on every dataset, cleaner imports, and faster find-and-reuse—creating a dependable data hub for the team.</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/Patterns-Matter" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">
  <figure class="figure tilt">
    <a href="#fe-fig1">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/db-app/fig1.png" alt="Schema">
      </div>
    </a>
    <figcaption><em>Normalized schema for datasets → features → results.</em></figcaption>
  </figure>
  <div id="fe-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/db-app/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#fe-fig2">
      <div class="frame">
        <img class="pixel-safe" src="/assets/img/projects/db-app/fig2.png" alt="ETL">
      </div>
    </a>
    <figcaption><em>Idempotent ETL with type validation & Drive-backed delivery</em></figcaption>
  </figure>
  <div id="fe-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/db-app/fig2.png" alt=""></div>
</div>
