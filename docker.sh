docker-machine create --driver virtualbox --engine-env HTTP_PROXY=http://10.0.2.2:3128 --engine-env HTTPS_PROXY=http://10.0.2 .2:3128 default

eval $(docker-machine env default)

docker-compose up