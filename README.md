# TestDataGenerator
Simple program which generates test sets for the another project. Format of the generated file is as follows:

```
<tasks count>
<processors count>
<task id> <processor 1 time> <processor 2 time> ... <processor p time>
<task id> <processor 1 time> <processor 2 time> ... <processor p time>
...
```

## Example usage
List all available arguments: `TestDataGenerator`

Generate sets: `TestDataGenerator -count 50 -min-cpu 10 -max-cpu 20`

## Available arguments:
```
--output       (Default: ./) Set directory where the output files will be saved.
--count        (Default: 10) Set number of the sets which will be generated.
--min-tasks    (Default: 1) Set number of the minimum tasks in the set.
--max-tasks    (Default: 10) Set number of the maximum tasks in the set.
--min-cpu      (Default: 1) Set number of the minimum processors in the set.
--max-cpu      (Default: 4) Set number of the maximum processors in the set.
--min-time     (Default: 1) Set minimum time which will be assigned to the task.
--max-time     (Default: 100) Set maximum time which will be assigned to the task.
--help         Display this help screen.
--version      Display version information.
```