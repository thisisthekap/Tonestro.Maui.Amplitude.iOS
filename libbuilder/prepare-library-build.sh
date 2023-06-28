#!/bin/bash

amplitudeVersion="8.2.1"

mkdir processing
cd processing

# check out Amplitude.iOS and switch to desired version
git clone https://github.com/amplitude/Amplitude-iOS.git
rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi

cd Amplitude-iOS/
git checkout tags/v${amplitudeVersion}
rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi

cd ..
cp -r ../Amplitude .
cd Amplitude/Amplitude

cp ../../Amplitude-iOS/Sources/Amplitude/* .

cd ..
xed .
cd ..
cp ../Makefile .
