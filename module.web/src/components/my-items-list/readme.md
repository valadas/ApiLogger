# my-items-list



<!-- Auto Generated Below -->


## Properties

| Property        | Attribute        | Description                                        | Type     | Default |
| --------------- | ---------------- | -------------------------------------------------- | -------- | ------- |
| `pageSize`      | `page-size`      | Defines how many items to fetch per request.       | `number` | `100`   |
| `preloadPixels` | `preload-pixels` | Defines how many pixels under the fold to preload. | `number` | `1000`  |


## Dependencies

### Used by

 - [my-component](../my-component)

### Depends on

- dnn-chevron
- dnn-collapsible
- [my-item-details](../my-item-details)
- dnn-button

### Graph
```mermaid
graph TD;
  my-items-list --> dnn-chevron
  my-items-list --> dnn-collapsible
  my-items-list --> my-item-details
  my-items-list --> dnn-button
  my-item-details --> dnn-button
  my-item-details --> dnn-modal
  my-item-details --> my-edit
  dnn-button --> dnn-modal
  dnn-button --> dnn-button
  my-edit --> dnn-button
  my-component --> my-items-list
  style my-items-list fill:#f9f,stroke:#333,stroke-width:4px
```

----------------------------------------------

*Built with [StencilJS](https://stenciljs.com/)*
