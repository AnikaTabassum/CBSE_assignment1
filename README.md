# CBSE_assignment1
This project gives a simple demonstration of component based modeling.


There are two components 
* OrderDetails 
* Orders 
in the system. 

The **OrderDetails** Component Provides interface **getOrderDetails**.

The requires interface of Orders is - 
**getOrderDetails**
which is provided by another independent component **OrderDetails**.

The implementation of **getOrderDetails** does not affect **Orders** component.

The **Orders** Components also provides some interfaces.
* viewOrder
* resolveOrder

For the purpose of reuse there are two systems. 
* KitchenManagementSystem which needs to use viewOrder and resolveOrder interfaces of Orders component.
* Likewise, CustomerManagement also needs to use these two components. 

These two system do not need to have any idea about the implementation details. They can just use the interfaces.

# Execution Details

To execute the kitchenManagementSystem, **Orders** should be added as reference. And then compiler the **ManageKitchen** class.

For reuse purpose, the **customerManagement** system should be executed with the same dependency of **Orders** component.
