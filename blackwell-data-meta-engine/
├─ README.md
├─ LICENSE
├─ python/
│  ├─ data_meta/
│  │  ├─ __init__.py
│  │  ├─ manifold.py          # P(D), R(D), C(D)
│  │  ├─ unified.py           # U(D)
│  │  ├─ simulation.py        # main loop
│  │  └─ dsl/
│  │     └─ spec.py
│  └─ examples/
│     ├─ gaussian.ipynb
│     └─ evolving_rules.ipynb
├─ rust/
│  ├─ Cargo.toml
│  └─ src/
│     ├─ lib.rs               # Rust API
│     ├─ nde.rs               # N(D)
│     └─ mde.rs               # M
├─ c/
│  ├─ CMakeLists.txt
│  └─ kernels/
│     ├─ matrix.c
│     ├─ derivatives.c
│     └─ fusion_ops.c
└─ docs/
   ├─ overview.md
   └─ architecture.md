blackwell-data-meta-engine/
├─ README.md
├─ LICENSE
├─ python/
│  ├─ data_meta/
│  │  ├─ __init__.py
│  │  ├─ manifold.py          # P(D), R(D), C(D)
│  │  ├─ unified.py           # U(D)
│  │  ├─ simulation.py        # main loop
│  │  └─ dsl/
│  │     └─ spec.py
│  └─ examples/
│     ├─ gaussian.ipynb
│     └─ evolving_rules.ipynb
├─ rust/
│  ├─ Cargo.toml
│  └─ src/
│     ├─ lib.rs               # Rust API
│     ├─ nde.rs               # N(D)
│     └─ mde.rs               # M
├─ c/
│  ├─ CMakeLists.txt
│  └─ kernels/
│     ├─ matrix.c
│     ├─ derivatives.c
│     └─ fusion_ops.c
└─ docs/
   ├─ overview.md
   └─ architecture.md