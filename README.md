> [!Note]
> I don't trust AI, let the program collect the data and build a table  
> [AI Generated rating](./AI.md)

```diff
+ Idea: display not all processors, but only those that are on sale
```

parser is .NET Console application, that generates markdown table.  
Open links below, store content of open in parser/Data  
Run app, see bin/Debug/net9.0/output.txt  

Price list 1: https://www.notik.ru/fullprice?cityid=1

Price list 2: https://www.nix.ru/price/price_list.html?section=notebooks_all#c_id=256&fn=256&g_id=10&new_goods=0&page=all&sort=%2Bp8116%2B8120%2B8119%2B330%2B90&spoiler=&store=msk-0_1721_1&thumbnail_view=2

CPU: https://www.notebookcheck.net/Mobile-Processors-Benchmark-List.2436.0.html?type=&sort=&deskornote=0&gpubenchmarks=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&geekbench5_1_single=1&geekbench5_1_multi=1&cpu_fullname=1&codename=1&l2cache=1&l3cache=1&tdp=1&tdp_turbo=1&mhz=1&turbo_mhz=1&cores=1&threads=1&technology=1&daysold=1&gpu_name=1 

GPU: https://www.notebookcheck.net/Mobile-Graphics-Cards-Benchmark-List.844.0.html?type=&sort=&gpubenchmarks=0&professional=0&dx=0&multiplegpus=1&showClassDescription=1&deskornote=0&series_uid=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&3dmark13_time_spy_gpu=1&gpu_fullname=1&pixelshaders=1&vertexshaders=1&corespeed=1&boostspeed=1&directx=1&opengl=1&technology=1&daysold=1

Geekbench 5.5 Single-Core test is used to evaluate single-threaded performance. For multithreaded - Geekbench 5.5 Multi-Core (underestimates the result for a large number of cores, but this test is the most widespread). To evaluate the speed of the GPU, a 3DMark Time Spy test is used.

Load and parse pages (stored in Data folder, sites blockes HttpClient).  
For all laptops on sale look at the processor rating, find its video core, also look at the video core rating.  
Output a markdown table with ratings, price.

[See sortable version (geekbench)](https://miptleha.github.io/cpu-rating/parser/result.html)  
[See sortable version (cinebench)](https://miptleha.github.io/cpu-rating/parser/result2.html)

| # | Processor (GPU) | Tdp | Core/Thr | Freq GHz | SCore | MCore | GPU | Total | Price | Value |
|---|-----------------|-----|----------|----------|-------|-------|-----|-------|-------|-------|
| 1 | AMD Ryzen AI Max+ 395 (8060S) | $${\color{red}55}$$- | 16/32 | 3,0/5,1 | $${\color{green}94}$$ | $${\color{green}170}$$ | $${\color{green}249}$$ | 513 | 256 | $${\color{green}2,0}$$ |
| 2 | Intel Core Ultra 9 285HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,5 | $${\color{green}92}$$ | $${\color{green}209}$$ | 45 | 346 | 383 | 0,9 |
| 3 | Intel Core Ultra 9 275HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,4 | $${\color{green}93}$$ | $${\color{green}183}$$ | 45 | 321 | 239 | 1,3 |
| 4 | Intel Core Ultra 7 255H (Arc Graphics 140T) | $${\color{green}28}$$-115 | 16/16 | 4,4/5,1 | $${\color{green}87}$$ | $${\color{green}124}$$ | $${\color{green}100}$$ | 311 | 125 | $${\color{green}2,5}$$ |
| 5 | Intel Core Ultra 9 285H (Arc Graphics 140T) | $${\color{red}45}$$-115 | 16/16 | 4,5/5,4 | $${\color{green}87}$$ | $${\color{green}122}$$ | $${\color{green}100}$$ | 309 | 99 | $${\color{green}3,1}$$ |
| 6 | AMD Ryzen 9 9955HX3D (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 5,4 | $${\color{green}99}$$ | $${\color{green}182}$$ | $${\color{red}14}$$ | 295 | 471 | 0,6 |
| 7 | AMD Ryzen 9 9955HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 5,4 | $${\color{green}100}$$ | $${\color{green}173}$$ | $${\color{red}14}$$ | 287 | 220 | 1,3 |
| 8 | AMD Ryzen AI 9 HX 370 (Radeon 890M) | $${\color{green}28}$$-54 | 12/24 | 2,0/5,1 | $${\color{green}87}$$ | $${\color{green}111}$$ | $${\color{green}84}$$ | 282 | 117 | $${\color{green}2,4}$$ |
| 9 | Intel Core Ultra 7 255HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 20/20 | 2,3/5,2 | $${\color{green}86}$$ | $${\color{green}137}$$ | 45 | 268 | 191 | 1,4 |
| 10 | AMD Ryzen AI 9 365 (Radeon 880M) | $${\color{red}54}$$- | 10/20 | 2,0/5,0 | $${\color{green}86}$$ | $${\color{green}101}$$ | $${\color{green}78}$$ | 265 | 97 | $${\color{green}2,7}$$ |
| 11 | Intel Core i9-13980HX (UHD Graphics 770) | $${\color{red}55}$$- | 24/32 | 1,6/5,6 | $${\color{green}87}$$ | $${\color{green}157}$$ | $${\color{red}18}$$ | 262 | 173 | 1,5 |
| 12 | Intel Core Ultra 9 185H (Arc 8-Core iGPU) | $${\color{red}45}$$- | 16/22 | 3,8/5,1 | $${\color{green}77}$$ | $${\color{green}105}$$ | $${\color{green}79}$$ | 261 | 86 | $${\color{green}3,0}$$ |
| 13 | Intel Core i9-14900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$-157 | 24/32 | 1,6/5,8 | $${\color{green}88}$$ | $${\color{green}155}$$ | $${\color{red}16}$$ | 259 | 175 | 1,5 |
| 14 | Intel Core Ultra 7 258V (Arc Graphics 140V) | $${\color{green}17}$$-37 | 8/8 | 2,2/4,8 | $${\color{green}83}$$ | $${\color{green}75}$$ | $${\color{green}99}$$ | 257 | 95 | $${\color{green}2,7}$$ |
| 15 | AMD Ryzen 9 7945HX3D (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 2,3/5,4 | $${\color{green}88}$$ | $${\color{green}154}$$ | $${\color{red}14}$$ | 256 | 396 | 0,6 |
| 16 | Intel Core Ultra 7 256V (Arc Graphics 140V) | $${\color{green}17}$$-37 | 8/8 | 2,2/4,8 | $${\color{green}83}$$ | $${\color{green}74}$$ | $${\color{green}99}$$ | 256 | 116 | $${\color{green}2,2}$$ |
| 17 | Intel Core i9-13900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$- | 24/32 | 1,6/5,4 | $${\color{green}84}$$ | $${\color{green}155}$$ | $${\color{red}16}$$ | 255 | 242 | 1,1 |
| 18 | AMD Ryzen 9 7945HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 2,5/5,4 | $${\color{green}87}$$ | $${\color{green}153}$$ | $${\color{red}14}$$ | 254 | 421 | 0,6 |
| 19 | AMD Ryzen AI 7 350 (Radeon 860M) | $${\color{green}28}$$-54 | 8/16 | 2,0/5,0 | $${\color{green}88}$$ | $${\color{green}94}$$ | $${\color{green}69}$$ | 251 | 106 | $${\color{green}2,4}$$ |
| 20 | Intel Core Ultra 5 225H (Arc Graphics 130T) | $${\color{green}28}$$-115 | 16/16 | 4,3/4,9 | $${\color{green}69}$$ | $${\color{green}82}$$ | $${\color{green}99}$$ | 250 | 90 | $${\color{green}2,8}$$ |
| 21 | Intel Core Ultra 7 165H (Arc 8-Core iGPU) | $${\color{green}28}$$- | 16/22 | 3,8/5,0 | $${\color{green}74}$$ | $${\color{green}93}$$ | $${\color{green}79}$$ | 246 | 204 | 1,2 |
| 22 | Intel Core Ultra 7 155H (Arc 8-Core iGPU) | $${\color{green}28}$$- | 16/22 | 3,8/4,8 | $${\color{green}73}$$ | $${\color{green}94}$$ | $${\color{green}79}$$ | 246 | 69 | $${\color{green}3,6}$$ |
| 23 | AMD Ryzen 9 8945H (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 4,0/5,2 | $${\color{green}83}$$ | $${\color{green}93}$$ | $${\color{green}68}$$ | 244 | 178 | 1,4 |
| 24 | Intel Core i7-14700HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 20/28 | 3,9/5,5 | $${\color{green}86}$$ | $${\color{green}137}$$ | $${\color{red}18}$$ | 241 | 124 | 1,9 |
| 25 | Intel Core i7-13850HX (UHD Graphics 770) | $${\color{red}55}$$- | 20/28 | 1,5/5,3 | $${\color{green}86}$$ | $${\color{green}137}$$ | $${\color{red}18}$$ | 241 | 341 | 0,7 |
| 26 | AMD Ryzen 7 8845HS (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 3,8/5,1 | $${\color{green}81}$$ | $${\color{green}92}$$ | $${\color{green}68}$$ | 241 | 75 | $${\color{green}3,2}$$ |
| 27 | Intel Core i7-14650HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 16/24 | 1,6/5,2 | $${\color{green}80}$$ | $${\color{green}130}$$ | $${\color{red}18}$$ | 228 | 133 | 1,7 |
| 28 | Intel Core Ultra 5 226V (Arc Graphics 130V) | $${\color{green}17}$$-37 | 8/8 | 2,1/4,5 | $${\color{green}78}$$ | $${\color{green}69}$$ | $${\color{green}81}$$ | 228 | 79 | $${\color{green}2,9}$$ |
| 29 | Intel Core Ultra 5 228V (Arc Graphics 130V) | $${\color{green}17}$$-37 | 8/8 | 2,1/4,5 | $${\color{green}77}$$ | $${\color{green}70}$$ | $${\color{green}81}$$ | 228 | 93 | $${\color{green}2,5}$$ |
| 30 | Intel Core Ultra 5 125H (Arc 7-Core iGPU) | $${\color{green}28}$$- | 14/18 | 3,6/4,5 | $${\color{green}69}$$ | $${\color{green}82}$$ | $${\color{green}75}$$ | 226 | 63 | $${\color{green}3,6}$$ |
| 31 | AMD Ryzen 7 260 (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 3,8/5,1 | $${\color{green}81}$$ | $${\color{green}76}$$ | $${\color{green}68}$$ | 225 | 72 | $${\color{green}3,1}$$ |
| 32 | AMD Ryzen 7 8840HS (Radeon 780M) | $${\color{green}28}$$- | 8/16 | 3,3/5,1 | $${\color{green}80}$$ | $${\color{green}77}$$ | $${\color{green}68}$$ | 225 | 79 | $${\color{green}2,8}$$ |
| 33 | AMD Ryzen 7 8745H (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 3,8/4,9 | $${\color{green}80}$$ | $${\color{green}77}$$ | $${\color{green}68}$$ | 225 | 69 | $${\color{green}3,3}$$ |
| 34 | Intel Core i7-13800H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,8/5,2 | $${\color{green}82}$$ | $${\color{green}100}$$ | 38 | 220 | 204 | 1,1 |
| 35 | Intel Core i5-14500HX (Iris Xe G7 96EUs) | $${\color{red}55}$$-157 | 14/20 | 1,8/5,0 | $${\color{green}76}$$ | $${\color{green}106}$$ | 38 | 220 | 127 | 1,7 |
| 36 | Intel Core i9-13900H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,9/5,4 | $${\color{green}81}$$ | $${\color{green}100}$$ | 38 | 219 | 82 | $${\color{green}2,7}$$ |
| 37 | AMD Ryzen 7 8840U (Radeon 780M) | $${\color{green}28}$$- | 8/16 | 3,3/5,1 | $${\color{green}78}$$ | $${\color{green}72}$$ | $${\color{green}68}$$ | 218 | 93 | $${\color{green}2,3}$$ |
| 38 | AMD Ryzen Z2 (Radeon 780M) | $${\color{green}28}$$- | 8/16 | 3,3/5,1 | $${\color{green}78}$$ | $${\color{green}72}$$ | $${\color{green}68}$$ | 218 | 84 | $${\color{green}2,6}$$ |
| 39 | Intel Core i7-13700HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/5,0 | $${\color{green}77}$$ | $${\color{green}114}$$ | $${\color{red}18}$$ | 209 | 119 | 1,8 |
| 40 | AMD Ryzen 5 7640HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | $${\color{green}80}$$ | $${\color{green}72}$$ | $${\color{green}55}$$ | 207 | 55 | $${\color{green}3,8}$$ |
| 41 | AMD Ryzen 5 8645HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | $${\color{green}79}$$ | $${\color{green}73}$$ | $${\color{green}55}$$ | 207 | 60 | $${\color{green}3,5}$$ |
| 42 | Intel Core i7-13700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,8/5,0 | $${\color{green}76}$$ | $${\color{green}92}$$ | 38 | 206 | 51 | $${\color{green}4,0}$$ |
| 43 | Intel Core i7-12700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,7/4,7 | $${\color{green}73}$$ | $${\color{green}94}$$ | 38 | 205 | 61 | $${\color{green}3,4}$$ |
| 44 | AMD Ryzen 5 8640HS (Radeon 760M) | $${\color{green}28}$$- | 6/12 | 3,5/4,9 | $${\color{green}78}$$ | $${\color{green}70}$$ | $${\color{green}55}$$ | 203 | 81 | $${\color{green}2,5}$$ |
| 45 | AMD Ryzen 7 7745HX (Radeon 610M) | $${\color{red}55}$$- | 8/16 | 3,6/5,1 | $${\color{green}85}$$ | $${\color{green}100}$$ | $${\color{red}14}$$ | 199 | 137 | 1,5 |
| 46 | AMD Ryzen AI 5 340 (Radeon 840M) | $${\color{green}28}$$-54 | 6/12 | 2,0/4,8 | $${\color{green}84}$$ | $${\color{green}68}$$ | 41 | 193 | 59 | $${\color{green}3,3}$$ |
| 47 | AMD Ryzen 7 7735HS (Radeon 680M) | $${\color{red}35}$$- | 8/16 | 3,2/4,8 | $${\color{green}65}$$ | $${\color{green}72}$$ | $${\color{green}56}$$ | 193 | 72 | $${\color{green}2,7}$$ |
| 48 | AMD Ryzen 7 6800H (Radeon 680M) | $${\color{red}45}$$- | 8/16 | 3,2/4,7 | $${\color{green}64}$$ | $${\color{green}72}$$ | $${\color{green}56}$$ | 192 | 169 | 1,1 |
| 49 | Intel Core i7-13620H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,8/4,9 | $${\color{green}76}$$ | $${\color{green}88}$$ | 27 | 191 | 51 | $${\color{green}3,7}$$ |
| 50 | Intel Core i7-1360P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,6/5,0 | $${\color{green}76}$$ | $${\color{green}77}$$ | 38 | 191 | $${\color{green}47}$$ | $${\color{green}4,1}$$ |
| 51 | Intel Core i7-13650HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 14/20 | 1,9/4,9 | $${\color{green}76}$$ | $${\color{green}106}$$ | $${\color{red}8}$$ | 190 | 74 | $${\color{green}2,6}$$ |
| 52 | Intel Core i7-12850HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/4,8 | $${\color{green}74}$$ | $${\color{green}95}$$ | $${\color{red}18}$$ | 187 | 114 | 1,6 |
| 53 | Intel Core i5-13500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,9/4,7 | $${\color{green}72}$$ | $${\color{green}86}$$ | 29 | 187 | $${\color{green}45}$$ | $${\color{green}4,2}$$ |
| 54 | Intel Core i7-1365U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,3/5,2 | $${\color{green}78}$$ | $${\color{green}67}$$ | 38 | 183 | 128 | 1,4 |
| 55 | Intel Core Ultra 7 165U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,8/4,9 | $${\color{green}72}$$ | $${\color{green}66}$$ | 45 | 183 | 190 | 1,0 |
| 56 | AMD Ryzen 7 7735U (Radeon 680M) | $${\color{green}28}$$- | 8/16 | 2,7/4,8 | $${\color{green}63}$$ | $${\color{green}63}$$ | $${\color{green}56}$$ | 182 | 67 | $${\color{green}2,7}$$ |
| 57 | Intel Core i7-1260P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,5/4,7 | $${\color{green}71}$$ | $${\color{green}72}$$ | 38 | 181 | 93 | 1,9 |
| 58 | AMD Ryzen 5 7540U (Radeon 740M) | $${\color{green}28}$$- | 6/12 | 3,2/4,9 | $${\color{green}77}$$ | $${\color{green}64}$$ | 39 | 180 | 88 | $${\color{green}2,0}$$ |
| 59 | AMD Ryzen 5 PRO 7540U (Radeon 740M) | $${\color{green}15}$$- | 6/12 | 3,2/4,9 | $${\color{green}77}$$ | $${\color{green}64}$$ | 39 | 180 | 155 | 1,2 |
| 60 | Qualcomm Snapdragon X Elite X1E-78-100 (SD X Adreno X1-85 3.8 TFLOPS) | $${\color{red}35}$$-45 | 12/12 | 3,4 | $${\color{green}69}$$ | $${\color{green}70}$$ | 41 | 180 | 102 | 1,8 |
| 61 | Intel Core 7 150U (Iris Xe G7 96EUs) | $${\color{green}15}$$-55 | 10/12 | 1,2/5,4 | $${\color{green}79}$$ | $${\color{green}62}$$ | 38 | 179 | $${\color{green}49}$$ | $${\color{green}3,7}$$ |
| 62 | Intel Core Ultra 7 155U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,8/4,8 | $${\color{green}70}$$ | $${\color{green}64}$$ | 45 | 179 | 71 | $${\color{green}2,5}$$ |
| 63 | Intel Core i5-1340P (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 12/16 | 1,4/4,6 | $${\color{green}71}$$ | $${\color{green}78}$$ | 29 | 178 | 72 | $${\color{green}2,5}$$ |
| 64 | Intel Core i5-12600H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 2,0/4,5 | $${\color{green}68}$$ | $${\color{green}80}$$ | 29 | 177 | 84 | $${\color{green}2,1}$$ |
| 65 | Intel Core i5-12500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,8/4,5 | $${\color{green}68}$$ | $${\color{green}80}$$ | 29 | 177 | 53 | $${\color{green}3,3}$$ |
| 66 | Intel Core i7-12650H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,7/4,7 | $${\color{green}73}$$ | $${\color{green}76}$$ | 27 | 176 | 52 | $${\color{green}3,4}$$ |
| 67 | Intel Core Ultra 5 135U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,6/4,4 | $${\color{green}65}$$ | $${\color{green}66}$$ | 45 | 176 | 98 | 1,8 |
| 68 | AMD Ryzen 5 7645HX (Radeon 610M) | $${\color{red}55}$$- | 6/12 | 4,0/5,0 | $${\color{green}82}$$ | $${\color{green}79}$$ | $${\color{red}14}$$ | 175 | 150 | 1,2 |
| 69 | AMD Ryzen Z1 (Radeon 740M) | $${\color{red}30}$$- | 6/12 | 3,2/4,9 | $${\color{green}76}$$ | 59 | 39 | 174 | 107 | 1,6 |
| 70 | Intel Core i7-1355U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,2/5,0 | $${\color{green}74}$$ | $${\color{green}62}$$ | 38 | 174 | $${\color{green}44}$$ | $${\color{green}4,0}$$ |
| 71 | Intel Core i5-13450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 10/16 | 1,8/4,6 | $${\color{green}73}$$ | $${\color{green}93}$$ | $${\color{red}8}$$ | 174 | 90 | 1,9 |
| 72 | Intel Core Ultra 5 125U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,6/4,3 | $${\color{green}65}$$ | $${\color{green}64}$$ | 45 | 174 | 55 | $${\color{green}3,2}$$ |
| 73 | Intel Core i7-1265U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,3/4,8 | $${\color{green}72}$$ | $${\color{green}63}$$ | 38 | 173 | 227 | 0,8 |
| 74 | Intel Core i7-1270P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,6/4,8 | $${\color{green}68}$$ | $${\color{green}67}$$ | 38 | 173 | 156 | 1,1 |
| 75 | Intel Core 5 120U (Iris Xe G7 80EUs) | $${\color{green}15}$$-55 | 10/12 | 0,9/5,0 | $${\color{green}77}$$ | $${\color{green}66}$$ | 29 | 172 | $${\color{green}39}$$ | $${\color{green}4,4}$$ |
| 76 | AMD Ryzen 5 8540U (Radeon 740M) | $${\color{green}28}$$- | 6/12 | 3,2/4,9 | $${\color{green}76}$$ | 56 | 39 | 171 | 54 | $${\color{green}3,2}$$ |
| 77 | Intel Core i7-1255U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,2/4,7 | $${\color{green}69}$$ | $${\color{green}62}$$ | 38 | 169 | $${\color{green}37}$$ | $${\color{green}4,6}$$ |
| 78 | Intel Core i5-1335U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,6 | $${\color{green}69}$$ | $${\color{green}61}$$ | 29 | 159 | $${\color{green}39}$$ | $${\color{green}4,1}$$ |
| 79 | AMD Ryzen 5 6600H (Radeon 660M) | $${\color{red}45}$$- | 6/12 | 3,3/4,5 | $${\color{green}61}$$ | 60 | 37 | 158 | $${\color{green}41}$$ | $${\color{green}3,9}$$ |
| 80 | Intel Core i5-1345U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 1,2/4,7 | $${\color{green}68}$$ | 60 | 29 | 157 | 149 | 1,1 |
| 81 | AMD Ryzen 5 7535HS (Radeon 660M) | $${\color{red}35}$$- | 6/12 | 3,3/4,6 | $${\color{green}62}$$ | 58 | 37 | 157 | 60 | $${\color{green}2,6}$$ |
| 82 | Intel Core 5 210H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,6/4,8 | $${\color{green}69}$$ | $${\color{green}61}$$ | $${\color{red}19}$$ | 149 | 82 | 1,8 |
| 83 | Intel Core i5-13420H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,6 | $${\color{green}69}$$ | $${\color{green}61}$$ | $${\color{red}19}$$ | 149 | $${\color{green}40}$$ | $${\color{green}3,7}$$ |
| 84 | AMD Ryzen 7 7730U (Vega 8) | $${\color{green}15}$$- | 8/16 | 2,0/4,5 | $${\color{green}61}$$ | 59 | 28 | 148 | $${\color{green}40}$$ | $${\color{green}3,7}$$ |
| 85 | AMD Ryzen 5 7535U (Radeon 660M) | $${\color{green}28}$$- | 6/12 | 2,9/4,6 | 60 | 50 | 37 | 147 | $${\color{green}49}$$ | $${\color{green}3,0}$$ |
| 86 | AMD Ryzen 7 5825U (Vega 8) | $${\color{green}15}$$- | 8/16 | 2,0/4,5 | $${\color{green}61}$$ | 55 | 28 | 144 | $${\color{green}28}$$ | $${\color{green}5,1}$$ |
| 87 | Intel Core i5-12450H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,4 | $${\color{green}68}$$ | 56 | $${\color{red}19}$$ | 143 | $${\color{green}34}$$ | $${\color{green}4,2}$$ |
| 88 | Intel Core 3 100U (UHD Graphics 64EUs) | $${\color{green}15}$$-55 | 6/8 | 0,9/4,7 | $${\color{green}67}$$ | 48 | 27 | 142 | $${\color{green}33}$$ | $${\color{green}4,3}$$ |
| 89 | Intel Core i5-1235U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,4 | $${\color{green}66}$$ | 47 | 29 | 142 | $${\color{green}35}$$ | $${\color{green}4,1}$$ |
| 90 | Intel Core i5-1334U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,6 | $${\color{green}65}$$ | 48 | 29 | 142 | 51 | $${\color{green}2,8}$$ |
| 91 | Intel Core i7-1165G7 (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 4/8 | 2,8/4,7 | $${\color{green}63}$$ | 40 | 38 | 141 | $${\color{green}45}$$ | $${\color{green}3,1}$$ |
| 92 | Intel Core i5-11320H (Iris Xe G7 96EUs) | $${\color{red}35}$$- | 4/8 | 3,2/4,5 | $${\color{green}62}$$ | 41 | 38 | 141 | 63 | $${\color{green}2,2}$$ |
| 93 | AMD Ryzen 7 5800U (Vega 8) | $${\color{green}25}$$- | 8/16 | 1,9/4,4 | 59 | 52 | 28 | 139 | $${\color{green}43}$$ | $${\color{green}3,2}$$ |
| 94 | AMD Ryzen 7 4800H (Vega 7) | $${\color{red}45}$$- | 8/16 | 2,9/4,2 | 49 | $${\color{green}62}$$ | 25 | 136 | 52 | $${\color{green}2,6}$$ |
| 95 | AMD Ryzen 5 7530U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,0/4,5 | $${\color{green}61}$$ | 49 | 25 | 135 | $${\color{green}41}$$ | $${\color{green}3,3}$$ |
| 96 | Intel Core i3-1220P (UHD Graphics 64EUs) | $${\color{green}28}$$- | 10/12 | 1,1/4,4 | 58 | 48 | 27 | 133 | $${\color{green}45}$$ | $${\color{green}3,0}$$ |
| 97 | Intel Core i3-1215U (UHD Graphics 64EUs) | $${\color{green}15}$$- | 6/8 | 0,9/4,4 | $${\color{green}64}$$ | 41 | 27 | 132 | $${\color{green}32}$$ | $${\color{green}4,1}$$ |
| 98 | AMD Ryzen 7 7435H () | $${\color{red}45}$$- | 8/16 | 3,1/4,5 | $${\color{green}65}$$ | $${\color{green}66}$$ | $${\color{red}0}$$ | 131 | 59 | $${\color{green}2,2}$$ |
| 99 | AMD Ryzen 5 7430U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 59 | 47 | 25 | 131 | $${\color{green}38}$$ | $${\color{green}3,4}$$ |
| 100 | Intel Core i3-1315U (UHD Graphics 64EUs) | $${\color{green}15}$$- | 6/8 | 0,9/4,5 | $${\color{green}62}$$ | 41 | 27 | 130 | $${\color{green}41}$$ | $${\color{green}3,2}$$ |
| 101 | AMD Ryzen 5 5625U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 59 | 46 | 25 | 130 | $${\color{green}32}$$ | $${\color{green}4,1}$$ |
| 102 | Qualcomm Snapdragon X Plus X1P-42-100 (SD X Adreno X1-45 1.7 TFLOPS) | $${\color{red}30}$$- | 8/8 | 3,4 | $${\color{green}63}$$ | 41 | $${\color{red}21}$$ | 125 | 79 | 1,6 |
| 103 | AMD Ryzen 7 5700U (Vega 8) | $${\color{green}25}$$- | 8/16 | 1,8/4,3 | 49 | 48 | 28 | 125 | $${\color{green}37}$$ | $${\color{green}3,4}$$ |
| 104 | Intel Core i5-1135G7 (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 4/8 | 2,4/4,2 | 57 | $${\color{red}36}$$ | 29 | 122 | $${\color{green}49}$$ | $${\color{green}2,5}$$ |
| 105 | AMD Ryzen 5 5560U (Vega 6) | $${\color{green}25}$$- | 6/12 | 2,3/4,0 | 55 | 46 | $${\color{red}21}$$ | 122 | $${\color{green}44}$$ | $${\color{green}2,8}$$ |
| 106 | AMD Ryzen 5 PRO 5675U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 56 | 40 | 25 | 121 | $${\color{green}39}$$ | $${\color{green}3,1}$$ |
| 107 | AMD Ryzen 7 PRO 4750U (Vega 7) | $${\color{green}15}$$- | 8/16 | 1,7/4,1 | 48 | 48 | 25 | 121 | $${\color{green}42}$$ | $${\color{green}2,9}$$ |
| 108 | AMD Ryzen 5 4600H (Vega 6) | $${\color{red}45}$$- | 6/12 | 3,0/4,0 | 46 | 47 | $${\color{red}21}$$ | 114 | $${\color{green}37}$$ | $${\color{green}3,1}$$ |
| 109 | AMD Ryzen 5 5500U (Vega 7) | $${\color{green}25}$$- | 6/12 | 2,1/4,0 | 46 | 42 | 25 | 113 | $${\color{green}35}$$ | $${\color{green}3,2}$$ |
| 110 | Intel Core i5-12450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 8/12 | 1,8/4,4 | $${\color{red}39}$$ | 59 | $${\color{red}8}$$ | 106 | 51 | $${\color{green}2,1}$$ |
| 111 | AMD Ryzen 3 7335U (Radeon 660M) | $${\color{green}28}$$- | 4/8 | 3,0/4,3 | $${\color{red}36}$$ | $${\color{red}30}$$ | 37 | 103 | $${\color{green}36}$$ | $${\color{green}2,9}$$ |
| 112 | Intel Core 3 N355 (UHD Graphics Xe 750 32EUs) | $${\color{green}15}$$- | 8/8 | 3,0/3,9 | 45 | $${\color{red}38}$$ | $${\color{red}15}$$ | 98 | $${\color{green}36}$$ | $${\color{green}2,7}$$ |
| 113 | Intel Core i3-N305 (UHD Graphics Xe 750 32EUs) | $${\color{green}15}$$- | 8/8 | 1,8/3,8 | 44 | $${\color{red}36}$$ | $${\color{red}15}$$ | 95 | $${\color{green}29}$$ | $${\color{green}3,3}$$ |
| 114 | AMD Ryzen 3 5400U (Vega 6) | $${\color{green}25}$$- | 4/8 | 2,6/4,0 | 48 | $${\color{red}24}$$ | $${\color{red}21}$$ | 93 | $${\color{green}35}$$ | $${\color{green}2,7}$$ |
| 115 | Intel Core i5-1035G1 (UHD Graphics G1) | $${\color{green}15}$$- | 4/8 | 1,0/3,6 | 50 | $${\color{red}30}$$ | $${\color{red}10}$$ | 90 | $${\color{green}26}$$ | $${\color{green}3,5}$$ |
| 116 | AMD Ryzen 5 7520U (Radeon 610M) | $${\color{green}15}$$- | 4/8 | 2,8/4,3 | 44 | $${\color{red}30}$$ | $${\color{red}14}$$ | 88 | $${\color{green}35}$$ | $${\color{green}2,5}$$ |
| 117 | AMD Ryzen 3 7320U (Radeon 610M) | $${\color{green}15}$$- | 4/8 | 2,4/4,1 | 44 | $${\color{red}30}$$ | $${\color{red}14}$$ | 88 | $${\color{green}31}$$ | $${\color{green}2,8}$$ |
| 118 | AMD Ryzen 3 4300U (Vega 5) | $${\color{green}15}$$- | 4/4 | 2,7/3,7 | 43 | $${\color{red}27}$$ | $${\color{red}18}$$ | 88 | $${\color{green}34}$$ | $${\color{green}2,6}$$ |
| 119 | Intel Core i5-1030NG7 (Iris Plus Graphics G7) | $${\color{green}10}$$- | 4/8 | 1,1/3,5 | 45 | $${\color{red}21}$$ | $${\color{red}19}$$ | 85 | $${\color{green}27}$$ | $${\color{green}3,1}$$ |
| 120 | Intel Core i5-10210U (UHD Graphics 620) | $${\color{green}15}$$- | 4/8 | 1,6/4,2 | 45 | $${\color{red}29}$$ | $${\color{red}9}$$ | 83 | $${\color{green}35}$$ | $${\color{green}2,4}$$ |
| 121 | Intel Core i5-8265U (UHD Graphics 620) | $${\color{green}15}$$- | 4/8 | 1,6/3,9 | 43 | $${\color{red}28}$$ | $${\color{red}9}$$ | 80 | $${\color{green}30}$$ | $${\color{green}2,7}$$ |
| 122 | Intel Core i3-1005G1 (UHD Graphics G1) | $${\color{green}15}$$- | 2/4 | 1,2/3,4 | 48 | $${\color{red}19}$$ | $${\color{red}10}$$ | 77 | $${\color{green}30}$$ | $${\color{green}2,6}$$ |
| 123 | Intel Core i3-1000NG4 (Iris Plus Graphics G4) | $${\color{green}9}$$- | 2/4 | 1,1/3,2 | 45 | $${\color{red}16}$$ | $${\color{red}16}$$ | 77 | $${\color{green}24}$$ | $${\color{green}3,2}$$ |
| 124 | Intel Processor N100 (UHD Graphics 24EUs) | $${\color{green}6}$$- | 4/4 | 1,0/3,4 | 41 | $${\color{red}22}$$ | $${\color{red}8}$$ | 71 | $${\color{green}21}$$ | $${\color{green}3,4}$$ |
| 125 | Intel Core i3-10110U (UHD Graphics 620) | $${\color{green}15}$$- | 2/4 | 2,1/4,1 | 41 | $${\color{red}16}$$ | $${\color{red}9}$$ | 66 | $${\color{green}31}$$ | $${\color{green}2,1}$$ |
| 126 | Intel Processor N200 (UHD Graphics Xe 750 32EUs) | $${\color{green}6}$$- | 4/4 | 1,0/3,7 | $${\color{red}38}$$ | $${\color{red}12}$$ | $${\color{red}15}$$ | 65 | $${\color{green}33}$$ | 2,0 |
| 127 | AMD Ryzen 3 3200U (Vega 3) | $${\color{green}15}$$- | 2/4 | 2,6/3,5 | $${\color{red}33}$$ | $${\color{red}13}$$ | $${\color{red}10}$$ | 56 | $${\color{green}25}$$ | $${\color{green}2,2}$$ |
| 128 | Intel Core m3-8100Y (UHD Graphics 615) | $${\color{green}5}$$- | 2/4 | 1,1/3,4 | $${\color{red}35}$$ | $${\color{red}11}$$ | $${\color{red}6}$$ | 52 | $${\color{green}26}$$ | 2,0 |
| 129 | Intel Celeron N4020 (UHD Graphics 600) | $${\color{green}6}$$-15 | 2/2 | 1,1/2,8 | $${\color{red}19}$$ | $${\color{red}6}$$ | $${\color{red}3}$$ | 28 | $${\color{green}17}$$ | 1,6 |
| 130 | Intel Celeron N4000 (UHD Graphics 600) | $${\color{green}6}$$- | 2/2 | 1,1/2,6 | $${\color{red}18}$$ | $${\color{red}6}$$ | $${\color{red}3}$$ | 27 | $${\color{green}17}$$ | 1,6 |

[AI Generated rating](AI.md)

[List of notebooks](notebooks.md)

