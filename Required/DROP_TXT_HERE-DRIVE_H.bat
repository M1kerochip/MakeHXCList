@echo off
@CLS
@ECHO
@ECHO HXCSDFE.CFG compilation configurator.
@ECHO
HXCFEMNG.EXE -verbose -disk:H:  -setslots:%1%

@ECHO Drive H: Configured with %1%
PAUSE