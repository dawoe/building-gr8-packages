---?color=#ffc927

@title[Migrations]

@snap[midpoint]

@css[text-25](Migrations)

@snapend

---

@title[What are migrations]

@snap[north text-center span-100]

### What are migrations

@snapend

@snap[midpoint text-center span-100]

Migrations are used when you want to run setup code during startup

@ul
- Create or modify database table
- Migrate data
- Run on each environment when needed
@ulend

@snapend

---

@title[Differences]

@snap[midpoint span-100 text-center]

### C&num; - What changed

<table class="text-09">
  <tr>
    <th>V7</th>
    <th>V8</th>
  </tr>
  <tr>
    <td>Version based</td>
    <td>State based</td>
  </tr>    
</table>

@snapend

---

@title[Migration]

@snap[north span-100 text-center]

### Migration

@snapend


@snap[midpoint span-100]

```csharp
   public class CreateRelationTableMigration : MigrationBase
    {
        public CreateRelationTableMigration(IMigrationContext context)
            : base(context)
        {
        }

        public override void Migrate()
        {
            this.Create.Table("MyTable")
                .WithColumn("Id").AsGuid().PrimaryKey("PK_Id").NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .Do();
        }
    }
```
@[1](Inherit from migration base)
@[8-15](Add your migration code)

---

@title[Migration plan]

@snap[north span-100 text-center]

### Migration plan

@snapend


@snap[midpoint span-100]

```csharp
   public class NexuMigrationPlan : MigrationPlan
    {
        public NexuMigrationPlan()
            : base("Our.Umbraco.Nexu")
        {
            this.From(this.InitialState)
			.To<CreateRelationTableMigration>("2.0.0-Initial");
        }

        public override string InitialState => string.Empty;

    }
```
@[1](Inherit from migration plan)
@[6-7](Run your migrations depending on state)

---

@title[Migration component]

@snap[north span-100 text-center]

### Migration component

@snapend


@snap[midpoint span-100]

```csharp
   public class MigrationComponent : IComponent
    {
        private readonly IScopeProvider scopeProvider;
        private readonly IMigrationBuilder migrationBuilder;
        private readonly IKeyValueService keyValueService;
        private readonly ILogger logger;

        public MigrationComponent(IScopeProvider scopeProvider, IMigrationBuilder migrationBuilder, IKeyValueService keyValueService, ILogger logger)
        {
            // set dependencies
        }

        public void Initialize()
        {
            var upgrader = new Upgrader(new NexuMigrationPlan());

            upgrader.Execute(this.scopeProvider, this.migrationBuilder, this.keyValueService, this.logger);
        }
    }
```

---

@title[Migrations explained]

@snap[north span-100 text-center]

### Migration explained

@snapend

@snap[midpoint span-100 text-center]

@ul[](false)

- [V7 Migrations by Sebastian](https://cultiv.nl/blog/using-umbraco-migrations-to-deploy-changes/)
- [V8 Migrations by Stephane](https://www.zpqrtbnk.net/posts/migrations-in-v8/)


  @ulend

@snapend



