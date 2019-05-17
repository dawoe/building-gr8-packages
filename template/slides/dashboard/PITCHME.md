---?color=#F5D9FF

@title[Dashboards]

@snap[midpoint]

@css[text-25](Dashboards)

@snapend

---

@title[V7 - ApplicationEventHandler]

@snap[north span-100 text-center]

### V7 - Registration in config

Register by adding entry in [/config/dashboard.config](https://our.umbraco.com/Documentation/Extending/Dashboards/index-v7#configuration-example)

@snapend


@snap[midpoint span-100]

```xml
  <section alias="Our.Umbraco.Nexu">
    <areas>
      <area>developer</area>
    </areas>
    <tab caption="Nexu">
      <control>/App_Plugins/Nexu/views/dashboard.html</control>
    </tab>
  </section>
```

---

@title[V8 - Package manifest]

@snap[north span-100 text-center]

### V8 - Package manifest

Register by using the [package manifest](https://our.umbraco.com/documentation/Extending/Dashboards/#registering-with-packagemanifest)

@snapend


@snap[midpoint span-100]

```json
  {
    "dashboards":  [
        {
            "alias": "myCustomDashboard2",
            "view":  "/App_Plugins/myCustom/dashboard.html",
            "sections": [ "content", "settings" ],
            "weight": -10,
            "access": [
                { "deny": "translator" },
                { "grant": "admin" }
            ]
        }
    ]
}
```
---

@title[V8 - C# type]

@snap[north span-100 text-center]

### V8 - C&num; type

Register by using the [ C&num; type](https://our.umbraco.com/documentation/Extending/Dashboards/#registering-with-c-type)

@snapend


@snap[midpoint span-100]

```csharp
  [Weight(-10)]
    public class MyDashboard : IDashboard
    {
        public string Alias => "myCustomDashboard";

        public string[] Sections => new[] { "content", "settings" };

        public string View => "/App_Plugins/myCustom/dashboard.html";

        public IAccessRule[] AccessRules => Array.Empty<IAccessRule>();
    }
```

---

@title[V8 - Removing dashboard]

@snap[north span-100 text-center]

### V8 - Removing dashboard

[Removing](https://our.umbraco.com/documentation/Extending/Dashboards/#remove-an-umbraco-dashboard) is only possible using C&num;

@snapend


@snap[midpoint span-100]

```csharp
 [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class RemoveDashboard : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Dashboards().Remove<ContentDashboard>();
        }
    }
```