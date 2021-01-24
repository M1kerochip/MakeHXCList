@echo off
@CLS
@ECHO
@ECHO HXCSDFE.CFG compilation configurator.
@ECHO
HXCFEMNG.EXE -verbose -disk:F:  -setslots:%1%

@ECHO Drive F: Configured with %1%
PAUSE