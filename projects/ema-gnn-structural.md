---
layout: default
title: EMA-GNN — Structural GNN for Crystal Stability Prediction
permalink: /projects/ema-gnn-structural/
---

# EMA-GNN — Structural GNN for Crystal Stability Prediction

<div class="media hero" data-alt="EMA-GNN IS2E cohort comparison — F1 and MAE across six direct-prediction models on Matbench Discovery">
  <img src="/assets/img/projects/ema-gnn/hero.png"
       alt="Bar chart comparing F1, MAE and R2 for six IS2E direct-prediction models on Matbench Discovery, with EMA-GNN highlighted">
</div>
<div class="hero-note">F1 and MAE across the six IS2E direct-prediction models on the Matbench Discovery leaderboard. EMA-GNN ranks 3rd by F1 (0.566, within 0.003 of the top two) and 1st by MAE (0.084 eV/atom) and R² (0.387) in this cohort.</div>

<div class="metrics">
  <span class="metric">Matbench Discovery — live leaderboard</span>
  <span class="metric alt">6-seed ensemble · RTX 4070 Ti</span>
  <span class="metric good">3rd/6 IS2E · best MAE & R² in cohort</span>
</div>

<p>
  A message-passing GNN that predicts crystal formation energy per atom directly from an
  unrelaxed input structure, no relaxation step at inference — reimplementing the structural
  GNN from Merchant et al., <em>"Scaling deep learning for materials discovery"</em>
  (Nature 624, 2023, the GNoME paper) at reduced scale. Submitted to the
  <a href="https://matbench-discovery.materialsproject.org/models/ema-gnn" target="_blank" rel="noopener">Matbench Discovery leaderboard</a>
  via <a href="https://github.com/janosh/matbench-discovery/pull/387" target="_blank" rel="noopener">PR #387</a>
  (merged 2026-08-12): F1 0.566, MAE 0.084 eV/atom on the 256,963-structure WBM test set. Among
  the six leaderboard models that share this exact task — <code>IS2E</code>, energy from an
  unrelaxed structure, no relaxation — EMA-GNN ranks 3rd by F1 (within 0.003 of the top two) and
  1st by MAE and R². The published architecture was the starting point, not an assumption: an
  independent hyperparameter search over width, depth, activation and learning rate, run on a
  held-out stratified subset with WBM withheld throughout, converged to the same configuration
  the paper reports, despite training on a different, reduced-scale dataset.
</p>
<p>
  Three scoring bugs surfaced en route to the submitted result, each changing the measured
  number with zero change to the model: a naive stability threshold conflating exothermicity
  with hull stability (F1 ≈0.34, void once corrected to ≈0.56), mean-instead-of-min test-time
  augmentation against methods specifying minimum, and mean-instead-of-median ensemble
  aggregation — median chosen because one out-of-distribution model can poison a mean but not a
  median. The remaining accuracy ceiling was traced to three causes: a systematic bias from
  training on relaxed structures and evaluating on unrelaxed ones, a subset of false positives
  that are confidently wrong rather than marginally wrong, and false-positive rate rising with
  chemical complexity — 24% at 2 elements, 5% at 5+, consistent with thinner Materials Project
  2018 coverage of higher-order compositions. Pre-relaxing WBM inputs with a pretrained
  interatomic potential (MACE-MP-0, CHGNet) isolated the first cause: MAE improved substantially
  (0.084 → 0.079) while F1 stayed flat, confirming the domain gap limits energy accuracy without
  being the binding constraint on stability classification — a retraining problem, not a
  preprocessing one.
</p>

<p><a class="btn" href="https://github.com/submerged-in-matrix/gnome-repro-structural" target="_blank" rel="noopener">GitHub</a></p>

<div class="gallery equal">

  <figure class="figure tilt">
    <a href="#emagnn-fig1">
      <div class="frame">
        <img class="pixel-safe"
             src="/assets/img/projects/ema-gnn/fig1.png"
             alt="Parity plot of predicted vs true formation energy on the WBM test set, colored by stability classification outcome">
      </div>
    </a>
    <figcaption><em>Predicted vs. true formation energy per atom on the WBM test set, colored by TP/FP/TN/FN. Recall (0.818) substantially exceeds precision (0.433) — the model finds most genuinely stable materials but over-predicts stability, the expected signature of a direct energy predictor evaluated on unrelaxed inputs. F1 here is 0.559 (local scoring, vs. 0.566 on the leaderboard — 26 missing predictions counted differently, same model).</em></figcaption>
  </figure>
  <div id="emagnn-fig1" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/ema-gnn/fig1.png" alt=""></div>

  <figure class="figure tilt">
    <a href="#emagnn-fig2">
      <div class="frame">
        <img class="pixel-safe"
             src="/assets/img/projects/ema-gnn/fig2.png"
             alt="False positive rate rising with number of distinct elements in the structure">
      </div>
    </a>
    <figcaption><em>False-positive rate vs. number of elements in the structure. FP rate climbs from binaries to quinaries, consistent with the Materials Project 2018 training set being thinner on higher-order chemical systems — one of three diagnosed causes of the classification ceiling, alongside the relaxed/unrelaxed domain gap and confidently-wrong high-energy false positives.</em></figcaption>
  </figure>
  <div id="emagnn-fig2" class="lb"><a class="x" href="#">×</a><img src="/assets/img/projects/ema-gnn/fig2.png" alt=""></div>

</div>
