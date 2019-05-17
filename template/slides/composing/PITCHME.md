---?color=#FFC927

@title[Extending Umbraco]

@snap[midpoint]

@css[text-25](Extending Umbraco)

@snapend

---

@title[V7 - ApplicationEventHandler]

@snap[north span-100 text-center]

### V7 - ApplicationEventHandler

@snapend

@snap[midpoint span-100 text-center]
Subscribing Umbraco events or extending Umbraco is done in a [ApplicationEventHandler](https://our.umbraco.com/Documentation/Reference/Events/Application-Startup-v7) by overriding one or all of these methods : <br>
@ul

- ApplicationInitialized
- ApplicationStarting
- ApplicationStarted
  @ulend

@snapend

---

@title[V7 - ApplicationEventHandler]

@snap[north span-100 text-center]

### ApplicationEventHandler issues

@snapend

@snap[midpoint span-100 text-center]

@ul

- Using wrong event
- No "real" control over execution order
  @ulend

@snapend

---

@title[V8 - Composing]

@snap[north span-100 text-center]

### V8 - composing

@snapend

@snap[west span-100 text-center]

@snap[west span-30 tex-center]

@box[bg-yellow fragment](Core#Composition)

@snapend

@snap[midpoint span-30 tex-center]

@box[bg-green fragment](User#Composer)

@snapend

@snap[east span-30 tex-center]

@box[bg-pink fragment](User#Components)

@snapend

@snapend

---

@title[Composing benefits]

@snap[north span-100 text-center]

### Composing benefits

@snapend

@snap[midpoint span-100 text-center]

@ul

- Control execution moment
- Control execution order
- Easier replacement or enabling/disabling of functionality
- More predictable, less black magic

  @ulend

@snapend

---

@title[Composing documentation]

@snap[north span-100 text-center]

### Composing documentation

@snapend

@snap[midpoint span-100 text-center]

@ul[](false)

- [Composing documentation](https://our.umbraco.com/documentation/implementation/composing/)
- [Composing Umbraco V8](https://www.zpqrtbnk.net/posts/composing-umbraco-v8/)
- [Composing Umbraco V8 collections](https://www.zpqrtbnk.net/posts/composing-umbraco-v8-collections/)
- [Composing Umbraco V8 Components](https://www.zpqrtbnk.net/posts/composing-umbraco-v8-components/)

  @ulend

@snapend
