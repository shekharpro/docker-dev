# docker-dev
Docker Compose Environment

## Getting Started

### Dependencies

- https://www.virtualbox.org/
- https://www.docker.com/products/docker-toolbox

### Quick Start

Make sure the dependencies have been installed then...

```
# Create a VM to run docker
docker-machine create --driver virtualbox default

# Connect docker machine to the VM
docker-machine env default
# (follow instructions)

# Start the dev environment
cd ./docker-dev
docker-compose up
# (internet happens)

# done!
```

To connect to a container directly:
```
docker exec -it "id of running container" bash
```
