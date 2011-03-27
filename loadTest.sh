#!/bin/bash
while [ 1 ]
do
  echo `cut -d\  -f1 </proc/loadavg`~ > /dev/ttyUSB0
  sleep 2
done
