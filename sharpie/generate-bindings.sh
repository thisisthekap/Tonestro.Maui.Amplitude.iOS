#!/bin/bash
sudo gem uninstall cocoapods && sudo gem install cocoapods -v 1.5.0

sharpie pod init ios Amplitude
sharpie pod bind -namespace "Tonestro.Maui.Amplitude.iOS"

mv Binding/Amplitude_ApiDefinitions.cs ApiDefinitions.cs
rm -rf Binding
rm -rf build
rm Podfile
rm Podfile.lock
rm -rf Pods
