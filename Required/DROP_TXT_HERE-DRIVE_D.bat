@echo off
@CLS
@ECHO
@ECHO HXCSDFE.CFG compilation configurator.
@ECHO
HXCFEMNG.EXE -verbose -disk:D:  -setslots:%1%

@ECHO Drive D: Configured with %1%
PAUSE