#!/bin/bash


paste -d '' <(sed 's/^[^0-9]*\([0-9]\).*$/\1/' input.txt)  <(sed 's/^.*\([0-9]\).*$/\1/' input.txt) | awk  '{sum += $1}; END {print sum}'

