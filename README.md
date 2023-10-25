# Design-a-workflow-engine-in-CSharp

In this exercise, the task is to design a workflow engine that can take a workflow object and execute it. A workflow is essentially a series of steps or activities. The workflow engine class should have a single method named "Run()" which accepts a workflow as input and then goes through each activity in the workflow, executing them one by one.

What makes this exercise interesting is the requirement for extensibility. The goal is to create new activities without affecting existing ones. To achieve this, we use interfaces to represent the concept of an activity. 

The aim of this exercise is to illustrate how interfaces can be used to design applications that are easily extensible. By creating new classes that adhere to the common interface, you can change the behavior of your application without having to make changes to existing classes. This also demonstrates the concept of polymorphism with interfaces.
