To transition, press spacebar. I had some trouble with making the prefabs render properly from the inside, cuz I was using some random script I found online to invert the mesh, so i had to just have it render the outside of the sphere, imagine you were inside.



This is how i'm thinking of doing transitions; Fading out, then deleting the sphere, then fading back in with a new sphere. Each transition button will have a transitionTo script where you put the sphere it should transition to as one of the "arguments" in the component page, and the current sphere as the other argument, so it knows which sphere to create and which one to delete.