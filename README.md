# Latent Motion

An exploration into poses and animations generated from a variational autoencoder trained on motion capture data

![gif](https://i.imgur.com/QtOzHjU.gif)


This project is synthesis of multiple projects:

- **Animation Autoencoder** - a neural network is trained on motion capture data. The latent space can be randomly sampled to create new poses for a humanoid character

- **Smrvfx** is a Unity sample project that shows how to use an animated [skinned
mesh] as a particle source in a [visual effect graph].

- **WASAPI** - Audio reactive visual effects are created using Windows Audio and Sound API

[skinned mesh]: https://docs.unity3d.com/Manual/class-SkinnedMeshRenderer.html
[visual effect graph]: https://unity.com/visual-effect-graph

Created with Unity 2019.3. Please note that it's not
compatible with the previous versions of Unity.
