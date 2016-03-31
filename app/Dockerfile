# Base of your container
FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr

# Copy the project into folder and then restore packages
COPY src/. /app
WORKDIR /app
RUN ["dnu","restore"]

# Open this port in the container
EXPOSE 5004
# Start application
ENTRYPOINT ["dnx","-p","project.json", "web"]
