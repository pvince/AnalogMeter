#!/bin/bash
while [ 1 ]
do
  #echo `cut -d\  -f1 </proc/loadavg`~ > /dev/ttyUSB0
  echo `ps aux | awk '{sum +=$3}; END {print sum}'`~ > /dev/ttyUSB0
  #sleep 1 
  perl -e 'select(undef,undef,undef,.5)'
done
