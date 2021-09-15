# my-edit



<!-- Auto Generated Below -->


## Properties

| Property | Attribute | Description                 | Type             | Default     |
| -------- | --------- | --------------------------- | ---------------- | ----------- |
| `item`   | --        | The item to create or edit. | `IItemViewModel` | `undefined` |


## Events

| Event         | Description                        | Type               |
| ------------- | ---------------------------------- | ------------------ |
| `itemCreated` | Fires up when an item got created. | `CustomEvent<any>` |


## Methods

### `resetForm() => Promise<void>`

Resets the form to insert a new item.

#### Returns

Type: `Promise<void>`



### `setFocus() => Promise<void>`

Sets focus on the first form element

#### Returns

Type: `Promise<void>`




## Dependencies

### Used by

 - [my-create](../my-create)
 - [my-item-details](../my-item-details)

### Depends on

- dnn-button

### Graph
```mermaid
graph TD;
  my-edit --> dnn-button
  dnn-button --> dnn-modal
  dnn-button --> dnn-button
  my-create --> my-edit
  my-item-details --> my-edit
  style my-edit fill:#f9f,stroke:#333,stroke-width:4px
```

----------------------------------------------

*Built with [StencilJS](https://stenciljs.com/)*
