`parser` is .NET Console application that makes a list of processors for laptops.  
Open links below, store content of open in parser/Data  
Run app, see bin/Debug/net9.0/output.txt  

Price list 1: https://www.notik.ru/fullprice?cityid=1

Price list 2: https://www.nix.ru/price/price_list.html?section=notebooks_all#c_id=256&fn=256&g_id=10&new_goods=0&page=all&sort=%2Bp8116%2B8120%2B8119%2B330%2B90&spoiler=&store=msk-0_1721_1&thumbnail_view=2

CPU: https://www.notebookcheck.net/Mobile-Processors-Benchmark-List.2436.0.html?type=&sort=&deskornote=0&gpubenchmarks=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&geekbench5_1_single=1&geekbench5_1_multi=1&cpu_fullname=1&codename=1&l2cache=1&l3cache=1&tdp=1&tdp_turbo=1&mhz=1&turbo_mhz=1&cores=1&threads=1&technology=1&daysold=1&gpu_name=1 

GPU: https://www.notebookcheck.net/Mobile-Graphics-Cards-Benchmark-List.844.0.html?type=&sort=&gpubenchmarks=0&professional=0&dx=0&multiplegpus=1&showClassDescription=1&deskornote=0&series_uid=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&3dmark13_time_spy_gpu=1&gpu_fullname=1&pixelshaders=1&vertexshaders=1&corespeed=1&boostspeed=1&directx=1&opengl=1&technology=1&daysold=1

Geekbench 5.5 / Cinebench R23 Single-Core test is used to evaluate single-threaded performance. For multithreaded - Geekbench 5.5 / Cinebench R23 Multi-Core. To evaluate the speed of the GPU, a 3DMark Time Spy test is used.

Load and parse pages (stored in Data folder, sites blockes using `HttpClient`).  
For all laptops on sale look at the processor rating, find its video core, also look at the video core rating.  

[See sortable version (geekbench)](https://miptleha.github.io/cpu-rating/parser/result.html)  
[See sortable version (cinebench)](https://miptleha.github.io/cpu-rating/parser/result2.html)

[List of notebooks](notebooks.md)

