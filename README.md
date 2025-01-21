# Blazor Puzzle #63

## There Can Only Be One

YouTube Video: https://youtu.be/

Blazor Puzzle Home Page: https://blazorpuzzle.com

### The Challenge:

This app illustrates how there can only be one EventCallback handler of a Cascading component.

The `MyCascadingComponent` cascading parameter is accessed in both *Home.razor* and *Toolbar.razor*.

An EventCallback is created in both places, but there is only one, so the last one to be defined wins. That turns out to be in Home.razor

To test it, comment out the line in `OnInitialized` where `MyEventCallback` is created.

How can we support multiple callbacks?

