unified-crypto-engine/
├── README.md
├── META_EQUATION.md
├── LICENSE
├── kernel/
│   ├── unified-crypto-kernel.yaml
│   ├── modes/
│   │   ├── aes256.yaml
│   │   ├── ecc.yaml
│   │   └── rsa.yaml
│   ├── equations/
│   │   ├── unified_equation.yaml
│   │   ├── composite_chain.yaml
│   │   └── composite_parallel.yaml
│   └── invariants/
│       ├── identity_invariants.yaml
│       └── math_invariants.yaml
├── src/
│   ├── core/
│   │   ├── engine_init.rs
│   │   ├── state.rs
│   │   ├── keys.rs
│   │   └── params.rs
│   ├── modes/
│   │   ├── aes256.rs
│   │   ├── ecc.rs
│   │   └── rsa.rs
│   ├── composite/
│   │   ├── chain.rs
│   │   └── parallel.rs
│   └── io/
│       ├── input.rs
│       └── output.rs
├── tests/
│   ├── test_aes256.rs
│   ├── test_ecc.rs
│   ├── test_rsa.rs
│   ├── test_chain.rs
│   └── test_parallel.rs
├── docs/
│   ├── architecture.md
│   ├── state_space.md
│   ├── key_space.md
│   ├── params_space.md
│   ├── mode_selector.md
│   ├── invariants.md
│   └── simulation_flow.md
└── examples/
    ├── encrypt_message.rs
    ├── decrypt_message.rs
    ├── chain_three_modes.rs
    └── parallel_three_modes.rs