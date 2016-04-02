# docker-dev
Docker Compose Environment

## Getting Started

### Dependencies

Install Docker Toolbox which can be found here:
- https://www.docker.com/products/docker-toolbox

### Quick Start
from the project directory, run:
```
chmod +x start.sh
./start.sh
```

You can now run:
```
docker-compose up
```
To bring up all the containers.

## Proxies
By default the start.sh script will pickup HTTP_PROXY, HTTPS_PROXY and NO_PROXY
environment variables from the host machine. If you are using cntlm, this is
suboptimal.

The start.sh script allows you to specify some extra environment variables:
- DOCKER_HTTP_PROXY
- DOCKER_HTTPS_PROXY
- DOCKER_NO_PROXY

To save time, there is a script cntlm-start.sh which sets these variables
appropriately and runs the start.sh script.
