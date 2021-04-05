# GitHub package demo

A demo app which uses GitHub package and docker hub for Docker image storage.

Example pattern to create application with .NET and Docker.

https://hub.docker.com/r/45862391/githubpackagedemo

Workflow:

- When pull request to main then build and test the code.
- When push to main or merge a pull request to main then build docker image and push to GitHub package.
- When a release has been created then build docker image and push to dockerhub.
