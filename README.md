# UnityPrototypePlayground
This repository is a heavily-documented set of basic prototypes that can be used as examples to understand unity mechanics or to build off of

## Repo Structure
The general idea behind this repo as a whole is to keep and maintain a collection of completely disjoint set of prototype mini-projects. Separated in sub-folders of different mechanics, each collection should have a parent folder and reference nothing outside it's parent folder. This will make it perfectly clear what is needed in order for a certain mechanic to work and nothing more complex than that.

## Prototype List
- **Position Translations**: How to translate objects in a scene from one position to another in its simplist form.

## Prototype Requests
- **Player Movement Control**: How to use a ```CharacterController``` to control a player object with the keyboard.
- **Player First Person Control**: How to setup a player with first person perspective that can look around with mouse movements.
- **Animations**: How to work with ```AnimationControllers``` and ```Animations``` to animate an entity.
- **Control Animations**: How to invoke attack animations with different key presses
- **AI Agent**: How to create an entity that can path itself from one place to another, avoiding obstacles on its way
- **AI Walk Locations**: How to create an AI that will make rounds stopping at a list of dynamic locations in repeat order.

## To Create a New Prototype
1. Open Unity and create a new project with the Project Name you'd like to name the parent folder at the location in the project you want it to go
2. After implementing, add comments over everything unique to your project's concept. Make it as clear as possible why every line is there.
3. Add a README.md file and format it with markdown, describing the elements of the scene and how you got things to work in particular.
4. Add a reference to the primary README.md file at the repo root mentioning your project name and a quick blurb about it to make it easy to find.
