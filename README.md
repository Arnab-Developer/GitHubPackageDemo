# GitHub package demo

A demo app which uses GitHub package and docker hub for Docker image storage.

Example pattern to create application with .NET and Docker.

https://hub.docker.com/r/45862391/githubpackagedemo

Workflow:

- Pull request to main, build and test the code.
- Push to main or merge a pull request to main, build docker image and push to GitHub package.
- When a release has been created then build docker image and push to dockerhub.
