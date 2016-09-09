FROM microsoft/dotnet:1.0.0-core

# Set the working directory
WORKDIR /app

# Copy the app
COPY bin/Debug/netcoreapp1.0/publish /app

EXPOSE 5000

# Start the app
ENTRYPOINT dotnet HelloWeb.dll