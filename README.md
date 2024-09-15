# C# Prometheus-Grafana Monitoring Example

This repository provides a simple **C# web application** that exposes metrics to **Prometheus**, which can be visualized using **Grafana**. The stack is set up using **Docker Compose** for easy deployment of the C# app, Prometheus, and Grafana in a monitoring environment.

## Overview

This project demonstrates how to set up a basic monitoring stack with:
- **C#**: A simple application that exposes custom metrics via the `/metrics` endpoint using the `prometheus-net` library.
- **Prometheus**: Collects and stores the metrics exposed by the C# application.
- **Grafana**: Visualizes the collected metrics through customizable dashboards.

## Stack Components

- **C# Application**: A simple ASP.NET Core app exposing metrics on `/metrics`.
- **Prometheus**: Collects the application's metrics at regular intervals.
- **Grafana**: Connects to Prometheus and visualizes the metrics in a dashboard.

## How to Run

### Prerequisites

- Docker and Docker Compose installed on your machine.

### Running the Stack

1. Clone the repository:
   ```bash
   git clone https://github.com/zzfernando/csharp-prometheus-grafana-example.git
   cd csharp-prometheus-grafana-example
   ```

2. Start the services:
   ```bash
   docker-compose up --build
   ```

3. Access the services:
   - **Prometheus**: [http://localhost:9090](http://localhost:9090)
   - **Grafana**: [http://localhost:3000](http://localhost:3000) (default login: `admin`, password: `admin`)
   - **C# Application**: [http://localhost:8080/metrics](http://localhost:8080/metrics)

## Project Structure

- `app/Program.cs`: C# application code that exposes metrics using `prometheus-net`.
- `app/Dockerfile`: Dockerfile to build and run the C# application.
- `prometheus.yml`: Configuration file for Prometheus, defining the scraping target.
- `docker-compose.yml`: Docker Compose file to run the C# app, Prometheus, and Grafana services.

## Metrics Visualization

After starting the stack:
1. Go to **Grafana** at [http://localhost:3000](http://localhost:3000).
2. Add **Prometheus** as a data source (`http://prometheus:9090`).
3. Create a new dashboard to visualize the metrics collected from the C# application.

## Customization

Feel free to modify the C# application to expose different custom metrics using the `prometheus-net` library or update the Prometheus configuration to scrape from additional targets.
