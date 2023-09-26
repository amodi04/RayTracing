# RayTracing
A realtime ray tracer built in the Unity game engine.
The ray tracer includes various methods to produce photorealistic results.

Currently the ray tracer implements the following features:
  1. Plane intersection
  2. Sphere intersection
  3. Triangle intersection
  4. Mesh intersection (not optimised)
  5. Anti-aliasing
  6. Reflection
  7. Directional Light and Shadows
  8. Skybox rendering
  9. Lambert diffuse
  10. Phong specular highlighting
  11. Importance sampling
  12. Emission

This particular ray tracer makes use of compute shaders in order to take advantage of parallel processing on the GPU to speed up compuation.

## Next Stages
Currently working on increasing efficiency when rendering 3d models in the scene. Currently able to render spheres, planes, triangles and low-poly models. Higher poly counts slow the tracer to an unusable speed at this stage due to the number of iterations over each poly.

## Screenshots
![Screenshot-1695729156](https://github.com/amodi04/RayTracing/assets/33089242/60077e76-9e1a-4186-adf2-267553ae7b82)
*Noise in screenshot here shows the ray tracer mid way through rendering. The longer the ray tracer is given, the more accurate the results*

![Screenshot-1695729249](https://github.com/amodi04/RayTracing/assets/33089242/47ffbcfb-1c44-44a6-951a-37999f382f68)
![Screenshot-1695729335](https://github.com/amodi04/RayTracing/assets/33089242/e2ecc5ec-406e-4323-90ad-f7dc6ea7977d)

![Screenshot-1695730053](https://github.com/amodi04/RayTracing/assets/33089242/6f24d422-b64c-48d7-944c-f6bcb69ca9b1)
![Screenshot-1695729979](https://github.com/amodi04/RayTracing/assets/33089242/e556f7c1-e44c-4d1b-9c9b-d0f5db62ec2d)
*5000 spheres*
