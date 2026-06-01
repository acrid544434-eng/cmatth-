astrophysics-super-blueprint/
├─ README.md
├─ LICENSE
├─ .gitignore
│
├─ docs/
│  ├─ WhiteSheet.md
│  ├─ ArchitectureOverview.md
│  ├─ ModuleIndex.md
│  ├─ TaxonomyGuide.md
│  ├─ ScenarioGuide.md
│  ├─ OrganismGuide.md
│  ├─ ISL_ModuleGuide.md
│
├─ src/
│  ├─ UniverseRun/
│  │  ├─ UniverseRun.cs
│  │  ├─ CosmologicalFrame.cs
│  │  ├─ EvolutionLaws.cs
│  │  ├─ ClockingSystem.cs
│  │  ├─ AuditReplay/
│  │  │  ├─ EventLog.cs
│  │  │  ├─ Checkpoint.cs
│  │  │  ├─ ReplayEngine.cs
│  │  ├─ Interfaces/
│  │  │  ├─ IUniverseModule.cs
│  │  │  ├─ IRunClock.cs
│
│  ├─ GalaxyTaxonomy/
│  │  ├─ GalaxyObject.cs
│  │  ├─ EnvironmentChannel.cs
│  │  ├─ TidalChannel.cs
│  │  ├─ BurstinessChannel.cs
│  │  ├─ FilamentChannel.cs
│  │  ├─ TaxonomyClassifier.cs
│  │  ├─ Interfaces/
│  │  │  ├─ ITaxonomyChannel.cs
│
│  ├─ RebirthEngine/
│  │  ├─ Entities/
│  │  │  ├─ Halo.cs
│  │  │  ├─ Galaxy.cs
│  │  │  ├─ Star.cs
│  │  │  ├─ BlackHole.cs
│  │  │  ├─ FieldEntity.cs
│  │  │  ├─ OrganismEntity.cs
│  │  ├─ Fields/
│  │  │  ├─ GravityField.cs
│  │  │  ├─ PlasmaField.cs
│  │  │  ├─ WarpField.cs
│  │  ├─ Interactions/
│  │  │  ├─ MergerEngine.cs
│  │  │  ├─ CollisionEngine.cs
│  │  │  ├─ AccretionEngine.cs
│  │  │  ├─ JetEngine.cs
│  │  ├─ Dissipation/
│  │  │  ├─ CoolingModel.cs
│  │  │  ├─ TurbulenceModel.cs
│  │  │  ├─ DragModel.cs
│  │  ├─ Relativity/
│  │  │  ├─ CurvatureHooks.cs
│  │  │  ├─ HighVelocityCorrections.cs
│  │  ├─ Interfaces/
│  │  │  ├─ IEntity.cs
│  │  │  ├─ IField.cs
│  │  │  ├─ IInteraction.cs
│
│  ├─ ScenarioBuilder/
│  │  ├─ Scenario.cs
│  │  ├─ ScenarioRunner.cs
│  │  ├─ InitialConditionDSL.cs
│  │  ├─ Scenarios/
│  │  │  ├─ GalaxyMergerScenario.cs
│  │  │  ├─ HaloEvolutionScenario.cs
│  │  │  ├─ StarSystemScenario.cs
│  │  │  ├─ InertialCorridorScenario.cs
│  │  ├─ Interfaces/
│  │  │  ├─ IScenario.cs
│
│  ├─ DSL_Organisms/
│  │  ├─ OrganismBase.cs
│  │  ├─ FieldOrganism.cs
│  │  ├─ WarpOrganism.cs
│  │  ├─ GravityOrganism.cs
│  │  ├─ InertiaOrganism.cs
│  │  ├─ BehaviorChannels/
│  │  │  ├─ Sensing.cs
│  │  │  ├─ Acting.cs
│  │  │  ├─ Modifying.cs
│  │  │  ├─ Spawning.cs
│  │  ├─ Interfaces/
│  │  │  ├─ IOrganism.cs
│
│  ├─ InertialShearLattice/
│  │  ├─ InertialCell.cs
│  │  ├─ ShearLattice.cs
│  │  ├─ InertialDefect.cs
│  │  ├─ ShearEvolution.cs
│  │  ├─ DefectFormation.cs
│  │  ├─ OrganismCoupling.cs
│  │  ├─ Interfaces/
│  │  │  ├─ IInertialCell.cs
│  │  │  ├─ ILattice.cs
│
│  ├─ IdentitySeal/
│  │  ├─ AuthorshipTag.cs
│  │  ├─ WatermarkInjector.cs
│  │  ├─ MetadataBinder.cs
│
│  ├─ EngineCore/
│     ├─ SimulationEngine.cs
│     ├─ EngineConfig.cs
│     ├─ EngineDiagnostics.cs
│     ├─ Interfaces/
│     │  ├─ ISimulationEngine.cs
│
├─ examples/
│  ├─ ExampleUniverseRun.md
│  ├─ ExampleScenario.md
│  ├─ ExampleOrganism.md
│  ├─ ExampleISL_Corridor.md
│
└─ tests/
   ├─ UniverseRunTests.cs
   ├─ TaxonomyTests.cs
   ├─ RebirthEngineTests.cs
   ├─ ScenarioTests.cs
   ├─ OrganismTests.cs
   ├─ ISL_Tests.cs