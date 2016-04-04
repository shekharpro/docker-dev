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

### app Dockerfile and proxies
If you are developing behind a proxy (using ./cntlm-start.sh) you will, for now,
need to uncomment the following lines in app/Dockerfile before running
docker-compose up:

```
# If working behind a cntlm proxy, uncomment below
#ENV HTTP_PROXY "http://10.0.2.2:3128"
#ENV HTTPS_PROXY "http://10.0.2.2:3128"
#ENV NO_PROXY "192.168.99.*,*.local.dev"
```
