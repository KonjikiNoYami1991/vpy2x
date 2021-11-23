# vpy2x
Simple alternative to VSEdit Job Server Watcher. 

![vpy2x](https://repository-images.githubusercontent.com/426181208/045dbbe5-126b-4ffb-aef4-b5193656a587)
## Short description
Totally rewritten frontend for vspipe.exe.
The goal is to replace VSEdit Job Server Watcher, with more functions not available in VSEdit JSW.
Though it's not stable yet, it provides:
 - drag&drop for one or more VPY files
 - JSON file for every saved preset
 - XML file for saved settings
 - a dedicated form for presets management 
 - saving on closing and reloading on opening of all jobs in queue, automatically
 - shutdown, stand-by and reboot commands after all jobs are done

## Usage
If you have already used VSEdit Job Server Watcher, usage is the same. Exception is made for placeholder {ss}, witch now will be replaced with full subsampling string (ex. yuv420p, instead of 420).
In case not, usage is:

 - create a new job by clicking on "New" button
 - drag&drop or choose one VPY file
 - create and/or choose a preset to use
 - click on "Done" button to add the job to queue
 - repeat the operation until all jobs are added
 - click on "Start" and wait

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[GPLv3](https://choosealicense.com/licenses/gpl-3.0/)
