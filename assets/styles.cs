:root{
--good:#10b981; /* green */
--bad:#ef4444; /* red */
--border:#1f2937; /* dark border */
}
*{box-sizing:border-box}
html,body{height:100%}
body{margin:0;background:radial-gradient(1200px 600px at 10% -10%, #1e293b 0%, transparent 60%),
radial-gradient(1200px 600px at 110% 10%, #0ea5e9 0%, transparent 35%),
var(--bg);
color:var(--text);font:16px/1.75 "Inter", system-ui, -apple-system, "Segoe UI", Roboto, Ubuntu, Cantarell, Noto Sans, sans-serif}
.wrap{max-width:1000px;margin:0 auto;padding:0 20px}


/* Header */
.site-header{position:sticky;top:0;z-index:50;background:linear-gradient(90deg, rgba(56,189,248,.12), rgba(167,139,250,.12));
backdrop-filter:saturate(180%) blur(10px);border-bottom:1px solid rgba(148,163,184,.2)}
.brand{display:inline-block;padding:14px 0;font-weight:800;text-decoration:none;color:#fff}
.nav{display:flex;flex-wrap:wrap;gap:10px;align-items:center;justify-content:flex-end}
.nav-link{display:inline-block;padding:8px 12px;border-radius:999px;text-decoration:none;color:var(--text);border:1px solid transparent}
.nav-link:hover{background:rgba(56,189,248,.15);border-color:rgba(56,189,248,.3)}
.nav-link.active{background:linear-gradient(90deg, var(--brandA), var(--brandB)); color:#0b1220; font-weight:700}


/* Typography */
h1{font-size:clamp(28px,4vw,44px);line-height:1.2;margin:22px 0 10px}
h2{font-size:clamp(22px,3vw,32px);margin:24px 0 10px}
p.lead{font-size:18px;color:var(--text);opacity:.92}
.muted{color:var(--muted)}


/* Layout */
main.wrap{padding:24px 20px}
.section{margin:28px 0}


/* Buttons */
.btn{display:inline-block;padding:10px 14px;border-radius:12px;text-decoration:none;border:1px solid rgba(148,163,184,.35);color:var(--text)}
.btn:hover{background:rgba(148,163,184,.15)}
.btn.primary{border-color:transparent;background:linear-gradient(90deg, var(--brandA), var(--brandB)); color:#0b1220;font-weight:700}


/* Cards & grid */
.grid{display:grid;grid-template-columns:repeat(auto-fit, minmax(250px, 1fr));gap:16px}
.card{background:linear-gradient(180deg, rgba(255,255,255,.06), rgba(255,255,255,.03));border:1px solid rgba(148,163,184,.18);border-radius:16px;padding:16px}
.card h3{margin:4px 0 8px}
.badge{display:inline-block;font-size:12px;padding:4px 8px;border-radius:999px;margin-right:6px;color:#0b1220;background:var(--brandC)}
.badge.alt{background:var(--brandB)}


/* Tabs (Projects page) */
.tabs{display:flex;flex-wrap:wrap;gap:10px;margin:16px 0}
.tab{display:inline-block;padding:10px 14px;border-radius:14px;background:rgba(56,189,248,.12);border:1px solid rgba(56,189,248,.3);text-decoration:none;color:var(--text)}
.tab:hover{background:rgba(56,189,248,.2)}


/* Lists */
ul {margin:10px 0 10px 20px}
code, pre{background:#0b1220;border:1px solid rgba(148,163,184,.25);border-radius:8px;padding:2px 6px}


/* Footer */
.site-footer{border-top:1px solid rgba(148,163,184,.2);margin-top:40px;padding:20px 0;color:var(--muted)}

/* Chips/badges */
.chips { display:flex; flex-wrap:wrap; gap:8px; }
.chips .badge { margin:0; }   /* cancel the old margin-right */

/* Tighter hero */
h1 + .lead { margin-top:6px; }

/* Use this only where you want exactly 3 cards */
.grid-3 { display:grid; grid-template-columns:repeat(3,1fr); gap:18px; }
@media (max-width:960px){ .grid-3 { grid-template-columns:1fr; } }
