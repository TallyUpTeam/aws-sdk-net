#!/bin/bash

mkdir -p AWSSDK

# This script assumes Cygwin64 and that Unity is installed in default location
mono=/cygdrive/c/Program\ Files/Unity/Editor/Data/MonoBleedingEdge/bin/mono.exe
pdb2mdb='C:\Program Files\Unity\Editor\Data\MonoBleedingEdge\lib\mono\4.5\pdb2mdb.exe'

copy() {
    service=$(basename $1)
    dll="$1/bin/Release/unity/AWSSDK.$service.dll"
    if [[ -f "$dll" ]]; then
        echo $dll...
        # Copy the DLL
        cp $dll AWSSDK
        # Copy the XML
        xml="$1/bin/Release/unity/AWSSDK.$service.xml"
        cp $xml AWSSDK
        # Convert .pdb to .mdb (in place)
        "$mono" "$pdb2mdb" $dll
        # Copy the MDB
        cp $dll.mdb AWSSDK
    fi
}

copy sdk/src/Core
for dir in sdk/src/Services/*; do
    copy $dir
done
