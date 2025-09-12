:root{
  --bg:#fff; --text:#0f172a; --muted:#475569; --accent:#2563eb; --border:#e5e7eb; --card:#fafafa;
}
*{box-sizing:border-box}
html,body{height:100%}
body{margin:0;color:var(--text);background:var(--bg);font:16px/1.7 system-ui,-apple-system,Segoe UI,Roboto,Ubuntu,Cantarell,Noto Sans,sans-serif}
.container{max-width:960px;margin:40px auto;padding:0 20px}
.site-header{position:sticky;top:0;background:rgba(255,255,255,.9);backdrop-filter:saturate(180%) blur(8px);border-bottom:1px solid var(--border);display:flex;align-items:center;justify-content:space-between;padding:12px 20px}
.brand{font-weight:700;text-decoration:none;color:var(--text)}
.site-nav a{margin-left:14px;text-decoration:none;color:var(--muted)}
.site-nav a:hover{color:var(--accent)}
.site-footer{border-top:1px solid var(--border);margin-top:48px;padding:24px 20px;color:var(--muted)}
h1{font-size:clamp(28px,4vw,40px);line-height:1.2;margin:16px 0}
h2{font-size:clamp(22px,3vw,28px);margin:24px 0 12px}
p.lead{font-size:18px;color:var(--muted)}
section{margin:24px 0}
.btn{display:inline-block;padding:10px 14px;border-radius:10px;border:1px solid var(--border);text-decoration:none}
.btn.primary{border-color:transparent;background:var(--accent);color:#fff}
.grid{display:grid;grid-template-columns:repeat(auto-fit,minmax(260px,1fr));gap:16px}
.card{background:var(--card);border:1px solid var(--border);border-radius:14px;padding:16px}
.card h3{margin:6px 0 8px;font-size:18px}
.badge{display:inline-block;font-size:12px;background:#eef2ff;border:1px solid #e0e7ff;color:#4338ca;border-radius:999px;padding:4px 8px;margin-right:6px}
code, pre{background:#f6f8fa;border-radius:6px;padding:2px 6px}
main img{max-width:100%;border-radius:10px}
