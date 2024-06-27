#!/bin/bash
./create-xcframework.sh
sharpie bind -framework Amplitude.xcframework/ios-arm64/Amplitude.framework -namespace "Tonestro.Maui.Amplitude.iOS"
