# my-create



<!-- Auto Generated Below -->


## Dependencies

### Used by

 - [my-component](../my-component)

### Depends on

- dnn-button
- dnn-modal
- [my-edit](../my-edit)

### Graph
```mermaid
graph TD;
  my-create --> dnn-button
  my-create --> dnn-modal
  my-create --> my-edit
  dnn-button --> dnn-modal
  dnn-button --> dnn-button
  my-edit --> dnn-button
  my-component --> my-create
  style my-create fill:#f9f,stroke:#333,stroke-width:4px
```

----------------------------------------------

*Built with [StencilJS](https://stenciljs.com/)*
