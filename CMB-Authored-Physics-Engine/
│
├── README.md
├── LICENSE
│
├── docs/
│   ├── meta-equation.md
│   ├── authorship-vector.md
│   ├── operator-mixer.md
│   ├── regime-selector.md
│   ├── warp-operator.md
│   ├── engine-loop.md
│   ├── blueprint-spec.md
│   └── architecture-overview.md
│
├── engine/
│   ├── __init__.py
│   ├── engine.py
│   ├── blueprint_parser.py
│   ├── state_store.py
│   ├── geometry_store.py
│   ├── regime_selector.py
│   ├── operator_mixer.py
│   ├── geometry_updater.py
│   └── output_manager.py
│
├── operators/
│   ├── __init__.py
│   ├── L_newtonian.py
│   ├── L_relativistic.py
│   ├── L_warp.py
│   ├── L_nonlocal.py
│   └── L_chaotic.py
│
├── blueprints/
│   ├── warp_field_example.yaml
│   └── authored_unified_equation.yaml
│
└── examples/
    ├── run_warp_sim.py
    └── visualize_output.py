CMB-Authored-Physics-Engine/
│
├── README.md
├── LICENSE
│
├── docs/
│   ├── meta-equation.md
│   ├── authorship-vector.md
│   ├── operator-mixer.md
│   ├── regime-selector.md
│   ├── warp-operator.md
│   ├── engine-loop.md
│   ├── blueprint-spec.md
│   └── architecture-overview.md
│
├── engine/
│   ├── __init__.py
│   ├── engine.py
│   ├── blueprint_parser.py
│   ├── state_store.py
│   ├── geometry_store.py
│   ├── regime_selector.py
│   ├── operator_mixer.py
│   ├── geometry_updater.py
│   └── output_manager.py
│
├── operators/
│   ├── __init__.py
│   ├── L_newtonian.py
│   ├── L_relativistic.py
│   ├── L_warp.py
│   ├── L_nonlocal.py
│   └── L_chaotic.py
│
├── blueprints/
│   ├── warp_field_example.yaml
│   └── authored_unified_equation.yaml
│
└── examples/
    ├── run_warp_sim.py
    └── visualize_output.py