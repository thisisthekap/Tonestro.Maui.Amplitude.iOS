#!/bin/bash

cd processing

make

cp libAmplitude.a ../../Tonestro.Maui.Amplitude.iOS/nativelib/libAmplitude.a

# cleanup
cd ..
rm -rf processing
