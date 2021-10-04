1. Correct Architecture:
Application
2. So logging between different output options at runtime is one of the loggers requirements?
The requirements are - log to a selected option or log to all options. If further requirements are required, they can be achieved using either of these options.
3. How about logging to 2 targets at once?
Implemented.
4. Will it never happen or is there a way to extend in the future and do it?
Implemented new function to allow logging to all functions.
5. Is it open for extension?
Yes, remade to non static.
6. In order to extend should i clone and recompile, or can i just reference it and write my own implementations? What's the process?
The program was changed to non static to allow referencing it, yet it is open enough to allow cloning and recompiling just as well.
