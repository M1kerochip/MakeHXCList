@echo off
@CLS
@ECHO
@ECHO HXCSDFE.CFG compilation configurator.
@ECHO
HXCFEMNG.EXE -verbose -disk:G:  -setslots:%1%

@ECHO Drive G: Configured with %1%
PAUSE