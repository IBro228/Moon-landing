# Moon-landing

Meeting of the spacecraft with the Moon, if not accepted
special measures will lead to its destruction on the surface of the moon itself.

With this program, you can clearly see how different
parameters affect the landing of the device on the lunar surface.

This project uses the formulas of Meshchersky and Tsialkovsky
to calculate the acceleration of the rocket.

From the law of conservation of momentum, one can easily obtain the formula
Meshchersky for acceleration ![image](https://user-images.githubusercontent.com/73960118/148754753-99bc1f03-14a7-45d9-a9c9-3d8ebd619b4f.png),
where![image](https://user-images.githubusercontent.com/73960118/148754850-4513981e-783b-4b6a-b6e9-2af0d7864afa.png) - gas velocity
regarding the rocket,![image](https://user-images.githubusercontent.com/73960118/148754968-1028796c-54b1-40a2-bd18-2c94532db5cd.png) - current weight,
![image](https://user-images.githubusercontent.com/73960118/148755054-efc9b7e0-7058-4a30-a766-07800f1f7c9a.png) - mass flow
fuel. Taking into account the force of gravity, the vertical component
acceleration equals ![image](https://user-images.githubusercontent.com/73960118/148755166-8f74f019-a54f-416c-b465-13a45513d3ae.png) where ![image](https://user-images.githubusercontent.com/73960118/148755271-d2c404ca-67c1-463a-b0c6-38841358fcf6.png) starting mass. In the particular case U- const, const-u, the problem of calculating
speed is easily solved analytically: ![image](https://user-images.githubusercontent.com/73960118/148755457-53e3154e-7254-4035-b759-8de683a1ec0e.png),
![image](https://user-images.githubusercontent.com/73960118/148755498-7f82b214-f673-4d44-9706-db5ae867f061.png),and finally we get the Tsiolkovsky formula:![image](https://user-images.githubusercontent.com/73960118/148755639-f367d19d-5ddc-48a9-ab6a-3c49910d2d30.png)

The computer graphics are implemented in Unity, and the logic is written in C # programming language.
