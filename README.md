> [!Note]
> I don't trust AI, let the program collect the data and build a table  
> [AI Generated rating](./AI.md)

```diff
+ Idea: display not all processors, but only those that are on sale
```

parser is .NET Console application, that generates markdown table.  
Open links below, store content of open in parser/Data  
Run app, see bin/Debug/net9.0/output.txt  

[List of notebooks](notebooks.md)

Price list 1: https://www.notik.ru/fullprice?cityid=1

Price list 2: https://www.nix.ru/price/price_list.html?section=notebooks_all#c_id=256&fn=256&g_id=10&new_goods=0&page=all&sort=%2Bp8116%2B8120%2B8119%2B330%2B90&spoiler=&store=msk-0_1721_1&thumbnail_view=2

CPU: https://www.notebookcheck.net/Mobile-Processors-Benchmark-List.2436.0.html?type=&sort=&deskornote=0&gpubenchmarks=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&geekbench5_1_single=1&geekbench5_1_multi=1&cpu_fullname=1&codename=1&l2cache=1&l3cache=1&tdp=1&tdp_turbo=1&mhz=1&turbo_mhz=1&cores=1&threads=1&technology=1&daysold=1&gpu_name=1 

GPU: https://www.notebookcheck.net/Mobile-Graphics-Cards-Benchmark-List.844.0.html?type=&sort=&gpubenchmarks=0&professional=0&dx=0&multiplegpus=1&showClassDescription=1&deskornote=0&series_uid=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&3dmark13_time_spy_gpu=1&gpu_fullname=1&pixelshaders=1&vertexshaders=1&corespeed=1&boostspeed=1&directx=1&opengl=1&technology=1&daysold=1

Geekbench 5.5 Single-Core test is used to evaluate single-threaded performance. For multithreaded - Geekbench 5.5 Multi-Core (underestimates the result for a large number of cores, but this test is the most widespread). To evaluate the speed of the GPU, a 3DMark Time Spy test is used.

Load and parse pages (stored in Data folder, sites blockes HttpClient).  
For all laptops on sale look at the processor rating, find its video core, also look at the video core rating.  
Output a markdown table with ratings, price.

[See sortable version](https://miptleha.github.io/cpu-rating/parser/result.html)

| # | Processor (GPU) | Tdp | Core/Thr | Freq GHz | SCore | MCore | GPU | Total | Price | Value |
|---|-----------------|-----|----------|----------|-------|-------|-----|-------|-------|-------|
| 1 | Intel Core Ultra 9 285HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,5 | $${\color{green}92}$$ | $${\color{green}209}$$ | 44 | 345 | 535 | 0,6 |
| 2 | Intel Core Ultra 7 255H (Arc Graphics 140T) | $${\color{green}28}$$-115 | 16/16 | 4,4/5,1 | $${\color{green}87}$$ | $${\color{green}133}$$ | $${\color{green}100}$$ | 320 | 143 | $${\color{green}2,2}$$ |
| 3 | Intel Core Ultra 9 275HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,4 | $${\color{green}91}$$ | $${\color{green}178}$$ | 44 | 313 | 319 | 1,0 |
| 4 | Intel Core Ultra 9 285H (Arc Graphics 140T) | $${\color{red}45}$$-115 | 16/16 | 4,5/5,4 | $${\color{green}87}$$ | $${\color{green}122}$$ | $${\color{green}100}$$ | 309 | 116 | $${\color{green}2,7}$$ |
| 5 | AMD Ryzen 9 9955HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 5,4 | $${\color{green}100}$$ | $${\color{green}173}$$ | $${\color{red}14}$$ | 287 | 341 | 0,8 |
| 6 | AMD Ryzen AI 9 HX 370 (Radeon 890M) | $${\color{green}28}$$-54 | 12/24 | 2,0/5,1 | $${\color{green}87}$$ | $${\color{green}110}$$ | $${\color{green}82}$$ | 279 | 141 | 2,0 |
| 7 | Intel Core Ultra 7 255HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 20/20 | 2,3/5,2 | $${\color{green}86}$$ | $${\color{green}137}$$ | 44 | 267 | 267 | 1,0 |
| 8 | AMD Ryzen AI 9 365 (Radeon 880M) | $${\color{red}54}$$- | 10/20 | 2,0/5,0 | $${\color{green}86}$$ | $${\color{green}101}$$ | $${\color{green}77}$$ | 264 | 105 | $${\color{green}2,5}$$ |
| 9 | Intel Core i9-13980HX (UHD Graphics 770) | $${\color{red}55}$$- | 24/32 | 1,6/5,6 | $${\color{green}87}$$ | $${\color{green}157}$$ | $${\color{red}18}$$ | 262 | 171 | 1,5 |
| 10 | Intel Core Ultra 9 185H (Arc 8-Core iGPU) | $${\color{red}45}$$- | 16/22 | 3,8/5,1 | $${\color{green}77}$$ | $${\color{green}105}$$ | $${\color{green}78}$$ | 260 | 104 | $${\color{green}2,5}$$ |
| 11 | Intel Core i9-14900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$-157 | 24/32 | 1,6/5,8 | $${\color{green}88}$$ | $${\color{green}155}$$ | $${\color{red}16}$$ | 259 | 171 | 1,5 |
| 12 | Intel Core Ultra 7 258V (Arc Graphics 140V) | $${\color{green}17}$$-37 | 8/8 | 2,2/4,8 | $${\color{green}83}$$ | $${\color{green}75}$$ | $${\color{green}98}$$ | 256 | 108 | $${\color{green}2,4}$$ |
| 13 | AMD Ryzen 9 9955HX3D (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 5,4 | $${\color{green}88}$$ | $${\color{green}154}$$ | $${\color{red}14}$$ | 256 | 617 | 0,4 |
| 14 | Intel Core i9-13900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$- | 24/32 | 1,6/5,4 | $${\color{green}84}$$ | $${\color{green}155}$$ | $${\color{red}16}$$ | 255 | 131 | 1,9 |
| 15 | Intel Core Ultra 7 256V (Arc Graphics 140V) | $${\color{green}17}$$-37 | 8/8 | 2,2/4,8 | $${\color{green}83}$$ | $${\color{green}73}$$ | $${\color{green}98}$$ | 254 | 128 | 2,0 |
| 16 | AMD Ryzen 9 7945HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 2,5/5,4 | $${\color{green}87}$$ | $${\color{green}153}$$ | $${\color{red}14}$$ | 254 | 443 | 0,6 |
| 17 | Intel Core Ultra 5 225H (Arc Graphics 130T) | $${\color{green}28}$$-115 | 16/16 | 4,3/4,9 | $${\color{green}69}$$ | $${\color{green}82}$$ | $${\color{green}98}$$ | 249 | 104 | $${\color{green}2,4}$$ |
| 18 | AMD Ryzen AI 7 350 (Radeon 860M) | $${\color{green}28}$$-54 | 8/16 | 2,0/5,0 | $${\color{green}88}$$ | $${\color{green}92}$$ | $${\color{green}67}$$ | 247 | 119 | $${\color{green}2,1}$$ |
| 19 | Intel Core Ultra 7 165H (Arc 8-Core iGPU) | $${\color{green}28}$$- | 16/22 | 3,8/5,0 | $${\color{green}74}$$ | $${\color{green}93}$$ | $${\color{green}78}$$ | 245 | 171 | 1,4 |
| 20 | Intel Core Ultra 7 155H (Arc 8-Core iGPU) | $${\color{green}28}$$- | 16/22 | 3,8/4,8 | $${\color{green}73}$$ | $${\color{green}94}$$ | $${\color{green}78}$$ | 245 | 75 | $${\color{green}3,3}$$ |
| 21 | AMD Ryzen 9 8945H (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 4,0/5,2 | $${\color{green}83}$$ | $${\color{green}93}$$ | $${\color{green}68}$$ | 244 | 160 | 1,5 |
| 22 | AMD Ryzen 9 7940HS (Radeon 780M) | $${\color{red}35}$$- | 8/16 | 4,0/5,2 | $${\color{green}82}$$ | $${\color{green}94}$$ | $${\color{green}68}$$ | 244 | 146 | 1,7 |
| 23 | AMD Ryzen 7 7840HS (Radeon 780M) | $${\color{red}35}$$- | 8/16 | 3,8/5,1 | $${\color{green}81}$$ | $${\color{green}92}$$ | $${\color{green}68}$$ | 241 | 115 | $${\color{green}2,1}$$ |
| 24 | AMD Ryzen 7 8845HS (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 3,8/5,1 | $${\color{green}81}$$ | $${\color{green}92}$$ | $${\color{green}68}$$ | 241 | 81 | $${\color{green}3,0}$$ |
| 25 | Intel Core i7-14700HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 20/28 | 3,9/5,5 | $${\color{green}86}$$ | $${\color{green}137}$$ | $${\color{red}18}$$ | 241 | 149 | 1,6 |
| 26 | Intel Core i7-13850HX (UHD Graphics 770) | $${\color{red}55}$$- | 20/28 | 1,5/5,3 | $${\color{green}86}$$ | $${\color{green}137}$$ | $${\color{red}18}$$ | 241 | 652 | 0,4 |
| 27 | Intel Core i7-14650HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 16/24 | 1,6/5,2 | $${\color{green}80}$$ | $${\color{green}130}$$ | $${\color{red}18}$$ | 228 | 155 | 1,5 |
| 28 | Intel Core Ultra 5 226V (Arc Graphics 130V) | $${\color{green}17}$$-37 | 8/8 | 2,1/4,5 | $${\color{green}78}$$ | $${\color{green}69}$$ | $${\color{green}79}$$ | 226 | 93 | $${\color{green}2,4}$$ |
| 29 | Intel Core Ultra 5 125H (Arc 7-Core iGPU) | $${\color{green}28}$$- | 14/18 | 3,6/4,5 | $${\color{green}69}$$ | $${\color{green}82}$$ | $${\color{green}74}$$ | 225 | 70 | $${\color{green}3,2}$$ |
| 30 | AMD Ryzen 7 8840HS (Radeon 780M) | $${\color{green}28}$$- | 8/16 | 3,3/5,1 | $${\color{green}80}$$ | $${\color{green}77}$$ | $${\color{green}68}$$ | 225 | 93 | $${\color{green}2,4}$$ |
| 31 | AMD Ryzen 7 260 (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 3,8/5,1 | $${\color{green}81}$$ | $${\color{green}76}$$ | $${\color{green}68}$$ | 225 | 91 | $${\color{green}2,5}$$ |
| 32 | Intel Core i5-14500HX (Iris Xe G7 96EUs) | $${\color{red}55}$$-157 | 14/20 | 1,8/5,0 | $${\color{green}76}$$ | $${\color{green}106}$$ | 37 | 219 | 159 | 1,4 |
| 33 | AMD Ryzen 7 8840U (Radeon 780M) | $${\color{green}28}$$- | 8/16 | 3,3/5,1 | $${\color{green}78}$$ | $${\color{green}72}$$ | $${\color{green}68}$$ | 218 | 104 | $${\color{green}2,1}$$ |
| 34 | Intel Core i9-13900H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,9/5,4 | $${\color{green}81}$$ | $${\color{green}100}$$ | 37 | 218 | 89 | $${\color{green}2,4}$$ |
| 35 | Intel Core i7-13700HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/5,0 | $${\color{green}77}$$ | $${\color{green}114}$$ | $${\color{red}18}$$ | 209 | 154 | 1,4 |
| 36 | AMD Ryzen 5 7640HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | $${\color{green}80}$$ | $${\color{green}72}$$ | $${\color{green}54}$$ | 206 | 60 | $${\color{green}3,4}$$ |
| 37 | AMD Ryzen 5 8645HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | $${\color{green}79}$$ | $${\color{green}73}$$ | $${\color{green}54}$$ | 206 | 60 | $${\color{green}3,4}$$ |
| 38 | Intel Core i7-13700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,8/5,0 | $${\color{green}76}$$ | $${\color{green}92}$$ | 37 | 205 | 66 | $${\color{green}3,1}$$ |
| 39 | Intel Core i7-12700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,7/4,7 | $${\color{green}73}$$ | $${\color{green}94}$$ | 37 | 204 | 69 | $${\color{green}3,0}$$ |
| 40 | AMD Ryzen 5 8640HS (Radeon 760M) | $${\color{green}28}$$- | 6/12 | 3,5/4,9 | $${\color{green}78}$$ | $${\color{green}70}$$ | $${\color{green}54}$$ | 202 | 84 | $${\color{green}2,4}$$ |
| 41 | AMD Ryzen 7 7745HX (Radeon 610M) | $${\color{red}55}$$- | 8/16 | 3,6/5,1 | $${\color{green}85}$$ | $${\color{green}100}$$ | $${\color{red}14}$$ | 199 | 152 | 1,3 |
| 42 | AMD Ryzen AI 5 340 (Radeon 840M) | $${\color{green}28}$$-54 | 6/12 | 2,0/4,8 | $${\color{green}84}$$ | $${\color{green}68}$$ | 41 | 193 | 72 | $${\color{green}2,7}$$ |
| 43 | AMD Ryzen 7 7735HS (Radeon 680M) | $${\color{red}35}$$- | 8/16 | 3,2/4,8 | $${\color{green}65}$$ | $${\color{green}72}$$ | $${\color{green}55}$$ | 192 | 84 | $${\color{green}2,3}$$ |
| 44 | AMD Ryzen 7 6800H (Radeon 680M) | $${\color{red}45}$$- | 8/16 | 3,2/4,7 | $${\color{green}64}$$ | $${\color{green}72}$$ | $${\color{green}55}$$ | 191 | 169 | 1,1 |
| 45 | Intel Core i7-13650HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 14/20 | 1,9/4,9 | $${\color{green}76}$$ | $${\color{green}106}$$ | $${\color{red}8}$$ | 190 | 90 | $${\color{green}2,1}$$ |
| 46 | Intel Core i7-1360P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,6/5,0 | $${\color{green}76}$$ | $${\color{green}77}$$ | 37 | 190 | 114 | 1,7 |
| 47 | Intel Core i7-13620H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,8/4,9 | $${\color{green}76}$$ | $${\color{green}88}$$ | 26 | 190 | 54 | $${\color{green}3,5}$$ |
| 48 | Intel Core i7-12850HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/4,8 | $${\color{green}74}$$ | $${\color{green}95}$$ | $${\color{red}18}$$ | 187 | 116 | 1,6 |
| 49 | Intel Core i5-13500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,9/4,7 | $${\color{green}72}$$ | $${\color{green}86}$$ | 28 | 186 | 50 | $${\color{green}3,7}$$ |
| 50 | AMD Ryzen 7 7735H (Radeon 680M) | $${\color{red}35}$$- | 8/16 | 3,2/4,8 | $${\color{green}65}$$ | $${\color{green}66}$$ | $${\color{green}55}$$ | 186 | 186 | 1,0 |
| 51 | Intel Core i7-1365U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,3/5,2 | $${\color{green}78}$$ | $${\color{green}67}$$ | 37 | 182 | 135 | 1,3 |
| 52 | Intel Core Ultra 7 165U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,8/4,9 | $${\color{green}72}$$ | $${\color{green}66}$$ | 44 | 182 | 238 | 0,8 |
| 53 | AMD Ryzen 7 7735U (Radeon 680M) | $${\color{green}28}$$- | 8/16 | 2,7/4,8 | $${\color{green}63}$$ | $${\color{green}63}$$ | $${\color{green}55}$$ | 181 | 71 | $${\color{green}2,5}$$ |
| 54 | Intel Core i7-1260P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,5/4,7 | $${\color{green}71}$$ | $${\color{green}72}$$ | 37 | 180 | 92 | 2,0 |
| 55 | Qualcomm Snapdragon X Elite X1E-78-100 (SD X Adreno X1-85 3.8 TFLOPS) | $${\color{red}35}$$-45 | 12/12 | 3,4 | $${\color{green}69}$$ | $${\color{green}70}$$ | 41 | 180 | 110 | 1,6 |
| 56 | AMD Ryzen 5 PRO 7540U (Radeon 740M) | $${\color{green}15}$$- | 6/12 | 3,2/4,9 | $${\color{green}77}$$ | $${\color{green}64}$$ | 38 | 179 | 155 | 1,2 |
| 57 | AMD Ryzen 5 7540U (Radeon 740M) | $${\color{green}28}$$- | 6/12 | 3,2/4,9 | $${\color{green}77}$$ | $${\color{green}64}$$ | 38 | 179 | 159 | 1,1 |
| 58 | Intel Core Ultra 7 155U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,8/4,8 | $${\color{green}70}$$ | $${\color{green}64}$$ | 44 | 178 | 78 | $${\color{green}2,3}$$ |
| 59 | Intel Core 7 150U (Iris Xe G7 96EUs) | $${\color{green}15}$$-55 | 10/12 | 1,2/5,4 | $${\color{green}79}$$ | $${\color{green}62}$$ | 37 | 178 | 55 | $${\color{green}3,2}$$ |
| 60 | Intel Core i5-1340P (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 12/16 | 1,4/4,6 | $${\color{green}71}$$ | $${\color{green}78}$$ | 28 | 177 | 69 | $${\color{green}2,6}$$ |
| 61 | Intel Core i5-12500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,8/4,5 | $${\color{green}68}$$ | $${\color{green}80}$$ | 28 | 176 | 64 | $${\color{green}2,8}$$ |
| 62 | Intel Core i5-12600H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 2,0/4,5 | $${\color{green}68}$$ | $${\color{green}80}$$ | 28 | 176 | 85 | $${\color{green}2,1}$$ |
| 63 | AMD Ryzen 5 7645HX (Radeon 610M) | $${\color{red}55}$$- | 6/12 | 4,0/5,0 | $${\color{green}82}$$ | $${\color{green}79}$$ | $${\color{red}14}$$ | 175 | 142 | 1,2 |
| 64 | Intel Core Ultra 5 135U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,6/4,4 | $${\color{green}65}$$ | $${\color{green}66}$$ | 44 | 175 | 111 | 1,6 |
| 65 | Intel Core i7-12650H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,7/4,7 | $${\color{green}73}$$ | $${\color{green}76}$$ | 26 | 175 | 59 | $${\color{green}3,0}$$ |
| 66 | Intel Core i5-13450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 10/16 | 1,8/4,6 | $${\color{green}73}$$ | $${\color{green}93}$$ | $${\color{red}8}$$ | 174 | 95 | 1,8 |
| 67 | Intel Core i7-1355U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,2/5,0 | $${\color{green}74}$$ | $${\color{green}62}$$ | 37 | 173 | $${\color{green}45}$$ | $${\color{green}3,8}$$ |
| 68 | AMD Ryzen Z1 (Radeon 740M) | $${\color{red}30}$$- | 6/12 | 3,2/4,9 | $${\color{green}76}$$ | 59 | 38 | 173 | 86 | $${\color{green}2,0}$$ |
| 69 | Intel Core Ultra 5 125U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,6/4,3 | $${\color{green}65}$$ | $${\color{green}64}$$ | 44 | 173 | 59 | $${\color{green}2,9}$$ |
| 70 | Intel Core i7-1265U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,3/4,8 | $${\color{green}72}$$ | $${\color{green}63}$$ | 37 | 172 | 239 | 0,7 |
| 71 | Intel Core i7-1270P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,6/4,8 | $${\color{green}68}$$ | $${\color{green}67}$$ | 37 | 172 | 164 | 1,0 |
| 72 | Intel Core 5 120U (Iris Xe G7 80EUs) | $${\color{green}15}$$-55 | 10/12 | 0,9/5,0 | $${\color{green}77}$$ | $${\color{green}66}$$ | 28 | 171 | $${\color{green}46}$$ | $${\color{green}3,7}$$ |
| 73 | Intel Core i7-1255U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,2/4,7 | $${\color{green}69}$$ | $${\color{green}62}$$ | 37 | 168 | $${\color{green}40}$$ | $${\color{green}4,2}$$ |
| 74 | Intel Core i5-1335U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,6 | $${\color{green}69}$$ | $${\color{green}61}$$ | 28 | 158 | $${\color{green}41}$$ | $${\color{green}3,9}$$ |
| 75 | AMD Ryzen 5 6600H (Radeon 660M) | $${\color{red}45}$$- | 6/12 | 3,3/4,5 | $${\color{green}61}$$ | 60 | 36 | 157 | 59 | $${\color{green}2,7}$$ |
| 76 | Intel Core i5-1345U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 1,2/4,7 | $${\color{green}68}$$ | 60 | 28 | 156 | 155 | 1,0 |
| 77 | AMD Ryzen 5 7535HS (Radeon 660M) | $${\color{red}35}$$- | 6/12 | 3,3/4,6 | $${\color{green}62}$$ | 58 | 36 | 156 | 69 | $${\color{green}2,3}$$ |
| 78 | Intel Core i5-13420H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,6 | $${\color{green}69}$$ | $${\color{green}61}$$ | $${\color{red}19}$$ | 149 | 52 | $${\color{green}2,9}$$ |
| 79 | Intel Core 5 210H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,6/4,8 | $${\color{green}69}$$ | $${\color{green}61}$$ | $${\color{red}19}$$ | 149 | 94 | 1,6 |
| 80 | AMD Ryzen 7 7730U (Vega 8) | $${\color{green}15}$$- | 8/16 | 2,0/4,5 | $${\color{green}61}$$ | 59 | 28 | 148 | $${\color{green}47}$$ | $${\color{green}3,1}$$ |
| 81 | AMD Ryzen 5 7535U (Radeon 660M) | $${\color{green}28}$$- | 6/12 | 2,9/4,6 | 60 | 50 | 36 | 146 | 73 | 2,0 |
| 82 | AMD Ryzen 7 5825U (Vega 8) | $${\color{green}15}$$- | 8/16 | 2,0/4,5 | $${\color{green}61}$$ | 55 | 28 | 144 | $${\color{green}32}$$ | $${\color{green}4,5}$$ |
| 83 | Intel Core i5-12450H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,4 | $${\color{green}68}$$ | 56 | $${\color{red}19}$$ | 143 | $${\color{green}39}$$ | $${\color{green}3,7}$$ |
| 84 | Intel Core 3 100U (UHD Graphics 64EUs) | $${\color{green}15}$$-55 | 6/8 | 0,9/4,7 | $${\color{green}67}$$ | 48 | 26 | 141 | $${\color{green}43}$$ | $${\color{green}3,3}$$ |
| 85 | Intel Core i5-1334U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,6 | $${\color{green}65}$$ | 48 | 28 | 141 | 54 | $${\color{green}2,6}$$ |
| 86 | Intel Core i5-1235U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,4 | $${\color{green}66}$$ | 47 | 28 | 141 | $${\color{green}37}$$ | $${\color{green}3,8}$$ |
| 87 | Intel Core i5-11320H (Iris Xe G7 96EUs) | $${\color{red}35}$$- | 4/8 | 3,2/4,5 | $${\color{green}62}$$ | 41 | 37 | 140 | 64 | $${\color{green}2,2}$$ |
| 88 | Intel Core i7-1165G7 (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 4/8 | 2,8/4,7 | $${\color{green}63}$$ | 40 | 37 | 140 | $${\color{green}47}$$ | $${\color{green}3,0}$$ |
| 89 | AMD Ryzen 7 5800U (Vega 8) | $${\color{green}25}$$- | 8/16 | 1,9/4,4 | 59 | 52 | 28 | 139 | $${\color{green}42}$$ | $${\color{green}3,3}$$ |
| 90 | AMD Ryzen 7 4800H (Vega 7) | $${\color{red}45}$$- | 8/16 | 2,9/4,2 | 49 | $${\color{green}62}$$ | 25 | 136 | 52 | $${\color{green}2,6}$$ |
| 91 | AMD Ryzen 5 7530U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,0/4,5 | $${\color{green}61}$$ | 49 | 25 | 135 | $${\color{green}45}$$ | $${\color{green}3,0}$$ |
| 92 | Intel Core i3-1220P (UHD Graphics 64EUs) | $${\color{green}28}$$- | 10/12 | 1,1/4,4 | 58 | 48 | 26 | 132 | $${\color{green}46}$$ | $${\color{green}2,9}$$ |
| 93 | AMD Ryzen 5 7430U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 59 | 47 | 25 | 131 | $${\color{green}41}$$ | $${\color{green}3,2}$$ |
| 94 | Intel Core i3-1215U (UHD Graphics 64EUs) | $${\color{green}15}$$- | 6/8 | 0,9/4,4 | $${\color{green}64}$$ | 41 | 26 | 131 | $${\color{green}32}$$ | $${\color{green}4,1}$$ |
| 95 | AMD Ryzen 7 7435H () | $${\color{red}45}$$- | 8/16 | 3,1/4,5 | $${\color{green}65}$$ | $${\color{green}66}$$ | $${\color{red}0}$$ | 131 | 70 | 1,9 |
| 96 | AMD Ryzen 5 5625U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 59 | 46 | 25 | 130 | $${\color{green}35}$$ | $${\color{green}3,7}$$ |
| 97 | Intel Core i3-1315U (UHD Graphics 64EUs) | $${\color{green}15}$$- | 6/8 | 0,9/4,5 | $${\color{green}62}$$ | 41 | 26 | 129 | $${\color{green}44}$$ | $${\color{green}2,9}$$ |
| 98 | AMD Ryzen 7 5700U (Vega 8) | $${\color{green}25}$$- | 8/16 | 1,8/4,3 | 49 | 48 | 28 | 125 | $${\color{green}39}$$ | $${\color{green}3,2}$$ |
| 99 | Qualcomm Snapdragon X Plus X1P-42-100 (SD X Adreno X1-45 1.7 TFLOPS) | $${\color{red}30}$$- | 8/8 | 3,4 | $${\color{green}63}$$ | 41 | $${\color{red}21}$$ | 125 | 87 | 1,4 |
| 100 | AMD Ryzen 5 5560U (Vega 6) | $${\color{green}25}$$- | 6/12 | 2,3/4,0 | 55 | 46 | $${\color{red}20}$$ | 121 | $${\color{green}44}$$ | $${\color{green}2,8}$$ |
| 101 | Intel Core i5-1135G7 (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 4/8 | 2,4/4,2 | 57 | $${\color{red}36}$$ | 28 | 121 | 68 | 1,8 |
| 102 | AMD Ryzen 5 PRO 5675U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 56 | 40 | 25 | 121 | $${\color{green}39}$$ | $${\color{green}3,1}$$ |
| 103 | AMD Ryzen 7 PRO 4750U (Vega 7) | $${\color{green}15}$$- | 8/16 | 1,7/4,1 | 48 | 48 | 25 | 121 | $${\color{green}42}$$ | $${\color{green}2,9}$$ |
| 104 | AMD Ryzen 5 4600H (Vega 6) | $${\color{red}45}$$- | 6/12 | 3,0/4,0 | 46 | 47 | $${\color{red}20}$$ | 113 | $${\color{green}32}$$ | $${\color{green}3,5}$$ |
| 105 | AMD Ryzen 5 5500U (Vega 7) | $${\color{green}25}$$- | 6/12 | 2,1/4,0 | 46 | 42 | 25 | 113 | $${\color{green}43}$$ | $${\color{green}2,6}$$ |
| 106 | AMD Ryzen 5 4600U (Vega 6) | $${\color{green}15}$$- | 6/12 | 2,1/4,0 | 46 | 43 | $${\color{red}20}$$ | 109 | $${\color{green}36}$$ | $${\color{green}3,0}$$ |
| 107 | Intel Core i5-12450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 8/12 | 1,8/4,4 | $${\color{red}39}$$ | 59 | $${\color{red}8}$$ | 106 | 51 | $${\color{green}2,1}$$ |
| 108 | AMD Ryzen 3 7335U (Radeon 660M) | $${\color{green}28}$$- | 4/8 | 3,0/4,3 | $${\color{red}36}$$ | $${\color{red}30}$$ | 36 | 102 | $${\color{green}43}$$ | $${\color{green}2,4}$$ |
| 109 | Intel Core i3-N305 (UHD Graphics Xe 750 32EUs) | $${\color{green}15}$$- | 8/8 | 1,8/3,8 | 44 | $${\color{red}36}$$ | $${\color{red}15}$$ | 95 | $${\color{green}31}$$ | $${\color{green}3,1}$$ |
| 110 | Intel Core i3-1115G4 (UHD Graphics Xe G4 48EUs) | $${\color{green}28}$$- | 2/4 | 3,0/4,1 | 54 | $${\color{red}20}$$ | $${\color{red}19}$$ | 93 | $${\color{green}31}$$ | $${\color{green}3,0}$$ |
| 111 | AMD Ryzen 3 5400U (Vega 6) | $${\color{green}25}$$- | 4/8 | 2,6/4,0 | 48 | $${\color{red}24}$$ | $${\color{red}20}$$ | 92 | $${\color{green}36}$$ | $${\color{green}2,6}$$ |
| 112 | Intel Core i5-1035G1 (UHD Graphics G1) | $${\color{green}15}$$- | 4/8 | 1,0/3,6 | 50 | $${\color{red}30}$$ | $${\color{red}10}$$ | 90 | $${\color{green}28}$$ | $${\color{green}3,2}$$ |
| 113 | AMD Ryzen 3 7320U (Radeon 610M) | $${\color{green}15}$$- | 4/8 | 2,4/4,1 | 44 | $${\color{red}30}$$ | $${\color{red}14}$$ | 88 | $${\color{green}35}$$ | $${\color{green}2,5}$$ |
| 114 | AMD Ryzen 5 7520U (Radeon 610M) | $${\color{green}15}$$- | 4/8 | 2,8/4,3 | 44 | $${\color{red}30}$$ | $${\color{red}14}$$ | 88 | $${\color{green}37}$$ | $${\color{green}2,4}$$ |
| 115 | Intel Core i5-1030NG7 (Iris Plus Graphics G7) | $${\color{green}10}$$- | 4/8 | 1,1/3,5 | 45 | $${\color{red}21}$$ | $${\color{red}19}$$ | 85 | $${\color{green}29}$$ | $${\color{green}2,9}$$ |
| 116 | Intel Core i5-8265U (UHD Graphics 620) | $${\color{green}15}$$- | 4/8 | 1,6/3,9 | 43 | $${\color{red}28}$$ | $${\color{red}9}$$ | 80 | $${\color{green}30}$$ | $${\color{green}2,7}$$ |
| 117 | Intel Core i3-1005G1 (UHD Graphics G1) | $${\color{green}15}$$- | 2/4 | 1,2/3,4 | 48 | $${\color{red}19}$$ | $${\color{red}10}$$ | 77 | $${\color{green}32}$$ | $${\color{green}2,4}$$ |
| 118 | Intel Core i3-1000NG4 (Iris Plus Graphics G4) | $${\color{green}9}$$- | 2/4 | 1,1/3,2 | 45 | $${\color{red}16}$$ | $${\color{red}15}$$ | 76 | $${\color{green}25}$$ | $${\color{green}3,0}$$ |
| 119 | Intel Processor N97 (UHD Graphics 24EUs) | $${\color{green}12}$$- | 4/4 | 3,6 | 44 | $${\color{red}21}$$ | $${\color{red}8}$$ | 73 | $${\color{green}24}$$ | $${\color{green}3,0}$$ |
| 120 | Intel Processor N100 (UHD Graphics 24EUs) | $${\color{green}6}$$- | 4/4 | 1,0/3,4 | 41 | $${\color{red}22}$$ | $${\color{red}8}$$ | 71 | $${\color{green}23}$$ | $${\color{green}3,1}$$ |
| 121 | Intel Core i3-10110U (UHD Graphics 620) | $${\color{green}15}$$- | 2/4 | 2,1/4,1 | 41 | $${\color{red}16}$$ | $${\color{red}9}$$ | 66 | $${\color{green}28}$$ | $${\color{green}2,4}$$ |
| 122 | Intel Processor N200 (UHD Graphics Xe 750 32EUs) | $${\color{green}6}$$- | 4/4 | 1,0/3,7 | $${\color{red}38}$$ | $${\color{red}12}$$ | $${\color{red}15}$$ | 65 | $${\color{green}38}$$ | 1,7 |
| 123 | AMD Ryzen 3 3200U (Vega 3) | $${\color{green}15}$$- | 2/4 | 2,6/3,5 | $${\color{red}33}$$ | $${\color{red}13}$$ | $${\color{red}9}$$ | 55 | $${\color{green}26}$$ | $${\color{green}2,1}$$ |
| 124 | Intel Processor N50 (UHD Graphics Xe 16EUs) | $${\color{green}6}$$- | 2/2 | 1,0/3,4 | $${\color{red}37}$$ | $${\color{red}10}$$ | $${\color{red}8}$$ | 55 | $${\color{green}24}$$ | $${\color{green}2,3}$$ |
| 125 | Intel Core m3-8100Y (UHD Graphics 615) | $${\color{green}5}$$- | 2/4 | 1,1/3,4 | $${\color{red}35}$$ | $${\color{red}11}$$ | $${\color{red}6}$$ | 52 | $${\color{green}28}$$ | 1,9 |
| 126 | Qualcomm Snapdragon 8cx (Adreno 680) | $${\color{green}7}$$- | 8/8 | 2,8 | $${\color{red}29}$$ | $${\color{red}21}$$ | $${\color{red}0}$$ | 50 | $${\color{green}21}$$ | $${\color{green}2,4}$$ |
| 127 | Intel Celeron N4020 (UHD Graphics 600) | $${\color{green}6}$$-15 | 2/2 | 1,1/2,8 | $${\color{red}19}$$ | $${\color{red}6}$$ | $${\color{red}3}$$ | 28 | $${\color{green}17}$$ | 1,6 |
| 128 | Intel Celeron N4000 (UHD Graphics 600) | $${\color{green}6}$$- | 2/2 | 1,1/2,6 | $${\color{red}18}$$ | $${\color{red}6}$$ | $${\color{red}3}$$ | 27 | $${\color{green}17}$$ | 1,6 |

[AI Generated rating](./AI.md)


