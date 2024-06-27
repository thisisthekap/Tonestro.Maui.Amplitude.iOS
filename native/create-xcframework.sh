#!/bin/bash
rm -rf Amplitude.xcframework
carthage update --use-xcframeworks --platform iOS
mv Carthage/Build/Amplitude.xcframework .
rm -rf Cartfile.resolved Carthage
