#!/bin/bash

# ตั้งค่าตัวแปรเวอร์ชัน
VERSION=0.0.2
IMAGE_NAME=tcirswebservice
REGISTRY=devbastion.sense.ocp.local:8443/tcir/repo/tcir/tcirswebservice

# Build Docker Image & tag & push
docker build --no-cache -t ${IMAGE_NAME}:${VERSION} .
docker tag ${IMAGE_NAME}:${VERSION} ${REGISTRY}:${VERSION}
docker push ${REGISTRY}:${VERSION}