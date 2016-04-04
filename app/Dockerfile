# Base of your container
FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr

# If working behind a cntlm proxy, uncomment below
#ENV HTTP_PROXY "http://10.0.2.2:3128"
#ENV HTTPS_PROXY "http://10.0.2.2:3128"
#ENV NO_PROXY "192.168.99.*,*.local.dev"

# Copy the project into folder and then restore packages
COPY src/. /app

WORKDIR /app/WebApplication1/test/ClassLibrary1

RUN ["sh", "-c", "echo ${HTTP_PROXY}"]
RUN ["dnu","restore"]
RUN ["dnx","test"]

WORKDIR /app/WebApplication1/src/WebApplication1
RUN ["dnu","restore"]

# Open this port in the container
EXPOSE 5000
# Start application
ENTRYPOINT ["dnx","-p","project.json", "web"]
