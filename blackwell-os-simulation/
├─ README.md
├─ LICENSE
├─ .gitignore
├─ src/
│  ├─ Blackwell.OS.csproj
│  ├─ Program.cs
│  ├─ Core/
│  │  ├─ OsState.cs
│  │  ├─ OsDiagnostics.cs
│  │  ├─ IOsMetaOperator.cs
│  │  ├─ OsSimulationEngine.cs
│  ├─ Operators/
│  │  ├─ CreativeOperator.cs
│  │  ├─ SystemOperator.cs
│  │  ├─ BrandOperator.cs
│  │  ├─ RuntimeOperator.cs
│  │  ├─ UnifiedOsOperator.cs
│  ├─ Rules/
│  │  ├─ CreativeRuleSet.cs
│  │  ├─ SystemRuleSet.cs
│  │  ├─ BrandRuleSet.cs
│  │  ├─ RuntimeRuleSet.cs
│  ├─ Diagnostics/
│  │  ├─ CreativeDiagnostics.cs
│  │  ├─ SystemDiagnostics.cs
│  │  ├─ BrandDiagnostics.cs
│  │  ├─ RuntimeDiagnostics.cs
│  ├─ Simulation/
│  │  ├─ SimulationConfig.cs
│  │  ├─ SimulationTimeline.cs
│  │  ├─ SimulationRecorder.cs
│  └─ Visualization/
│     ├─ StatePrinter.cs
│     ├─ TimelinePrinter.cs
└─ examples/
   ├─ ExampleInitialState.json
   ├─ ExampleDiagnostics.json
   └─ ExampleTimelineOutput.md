blackwell-os-simulation/
├─ README.md
├─ LICENSE
├─ .gitignore
├─ src/
│  ├─ Blackwell.OS.csproj
│  ├─ Program.cs
│  ├─ Core/
│  │  ├─ OsState.cs
│  │  ├─ OsDiagnostics.cs
│  │  ├─ IOsMetaOperator.cs
│  │  ├─ OsSimulationEngine.cs
│  ├─ Operators/
│  │  ├─ CreativeOperator.cs
│  │  ├─ SystemOperator.cs
│  │  ├─ BrandOperator.cs
│  │  ├─ RuntimeOperator.cs
│  │  ├─ UnifiedOsOperator.cs
│  ├─ Rules/
│  │  ├─ CreativeRuleSet.cs
│  │  ├─ SystemRuleSet.cs
│  │  ├─ BrandRuleSet.cs
│  │  ├─ RuntimeRuleSet.cs
│  ├─ Diagnostics/
│  │  ├─ CreativeDiagnostics.cs
│  │  ├─ SystemDiagnostics.cs
│  │  ├─ BrandDiagnostics.cs
│  │  ├─ RuntimeDiagnostics.cs
│  ├─ Simulation/
│  │  ├─ SimulationConfig.cs
│  │  ├─ SimulationTimeline.cs
│  │  ├─ SimulationRecorder.cs
│  └─ Visualization/
│     ├─ StatePrinter.cs
│     ├─ TimelinePrinter.cs
└─ examples/
   ├─ ExampleInitialState.json
   ├─ ExampleDiagnostics.json
   └─ ExampleTimelineOutput.md