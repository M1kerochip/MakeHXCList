@echo off
@CLS
@ECHO
@ECHO HXCSDFE.CFG compilation configurator.
@ECHO
HXCFEMNG.EXE -verbose -disk:I:  -setslots:%1%

@ECHO Drive I: Configured with %1%
PAUSE