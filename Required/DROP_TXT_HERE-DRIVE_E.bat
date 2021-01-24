@echo off
@CLS
@ECHO
@ECHO HXCSDFE.CFG compilation configurator.
@ECHO
HXCFEMNG.EXE -verbose -disk:E:  -setslots:%1%

@ECHO Drive E: Configured with %1%
PAUSE