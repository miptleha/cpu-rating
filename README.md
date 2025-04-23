> [!Note]
> I don't trust AI, let the program collect the data and build a table

```diff
+ Idea: display not all processors, but only those that are on sale
```

parser is .NET Console application, that generates markdown table.  
Open links below, store content of open in parser/Data  
Run app, see bin/Debug/net9.0/output.txt  


Price list 1: https://www.notik.ru/fullprice?cityid=1

Price list 2: https://www.nix.ru/price/price_list.html?section=notebooks_all#c_id=256&fn=256&g_id=10&new_goods=0&page=all&sort=%2Bp8116%2B8120%2B8119%2B330%2B90&spoiler=&store=msk-0_1721_1&thumbnail_view=2

GPU: https://www.notebookcheck.net/Mobile-Graphics-Cards-Benchmark-List.844.0.html?type=&sort=&gpubenchmarks=0&professional=0&dx=0&multiplegpus=1&showClassDescription=1&deskornote=0&series_uid=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&3dmark13_fire_gpu=1&gpu_fullname=1&pixelshaders=1&vertexshaders=1&corespeed=1&boostspeed=1&directx=1&opengl=1&technology=1&daysold=1

CPU: https://www.notebookcheck.net/Mobile-Processors-Benchmark-List.2436.0.html?type=&sort=&deskornote=0&gpubenchmarks=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&geekbench5_1_single=1&geekbench5_1_multi=1&cpu_fullname=1&l2cache=1&l3cache=1&tdp=1&tdp_turbo=1&mhz=1&turbo_mhz=1&cores=1&threads=1&technology=1&daysold=1&gpu_name=1 

Load and parse pages (stored in Data folder, sites blockes HttpClient).  
For all laptops on sale look at the processor rating, find its video core, also look at the video core rating.  
Output a markdown table with ratings, price.

| # | Processor (GPU) | Tdp | Core/Thr | Freq GHz | SCore | MCore | GPU | Total | Price RUB | Value |
|---|-----------------|-----|----------|----------|-------|-------|-----|-------|-----------|-------|
| 1 | Intel Core Ultra 9 285HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,5 | $${\color{green}92}$$ | $${\color{green}209}$$ | 45 | 346 | 536 204 | 0,6 |
| 2 | Intel Core Ultra 9 275HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,4 | $${\color{green}92}$$ | $${\color{green}188}$$ | 45 | 325 | 484 669 | 0,7 |
| 3 | Intel Core Ultra 7 255H (Arc Graphics 140T) | $${\color{green}28}$$-115 | 16/16 | 4,4/5,1 | $${\color{green}87}$$ | $${\color{green}133}$$ | $${\color{green}100}$$ | 320 | 167 274 | 1,9 |
| 4 | Intel Core Ultra 9 285H (Arc Graphics 140T) | $${\color{red}45}$$-115 | 16/16 | 4,5/5,4 | $${\color{green}87}$$ | $${\color{green}122}$$ | $${\color{green}100}$$ | 309 | 118 728 | $${\color{green}2,6}$$ |
| 5 | AMD Ryzen 9 9955HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 5,4 | $${\color{green}100}$$ | $${\color{green}171}$$ | $${\color{red}14}$$ | 285 | 311 888 | 0,9 |
| 6 | AMD Ryzen AI 9 HX 370 (Radeon 890M) | $${\color{green}28}$$-54 | 12/24 | 2,0/5,1 | $${\color{green}87}$$ | $${\color{green}110}$$ | $${\color{green}82}$$ | 279 | 144 064 | 1,9 |
| 7 | Intel Core Ultra 7 255HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 20/20 | 2,3/5,2 | $${\color{green}86}$$ | $${\color{green}137}$$ | 45 | 268 | 258 700 | 1,0 |
| 8 | AMD Ryzen AI 9 365 (Radeon 880M) | $${\color{red}54}$$- | 10/20 | 2,0/5,0 | $${\color{green}85}$$ | $${\color{green}101}$$ | $${\color{green}77}$$ | 263 | 105 990 | $${\color{green}2,5}$$ |
| 9 | Intel Core i9-13980HX (UHD Graphics 770) | $${\color{red}55}$$- | 24/32 | 1,6/5,6 | $${\color{green}87}$$ | $${\color{green}157}$$ | $${\color{red}18}$$ | 262 | 175 495 | 1,5 |
| 10 | Intel Core Ultra 9 185H (Arc 8-Core iGPU) | $${\color{red}45}$$- | 16/22 | 3,8/5,1 | $${\color{green}77}$$ | $${\color{green}105}$$ | $${\color{green}78}$$ | 260 | 99 294 | $${\color{green}2,6}$$ |
| 11 | Intel Core i9-14900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$-157 | 24/32 | 1,6/5,8 | $${\color{green}88}$$ | $${\color{green}155}$$ | $${\color{red}16}$$ | 259 | 176 516 | 1,5 |
| 12 | AMD Ryzen 9 7945HX3D (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 2,3/5,4 | $${\color{green}88}$$ | $${\color{green}154}$$ | $${\color{red}14}$$ | 256 | 408 201 | 0,6 |
| 13 | Intel Core Ultra 7 258V (Arc Graphics 140V) | $${\color{green}17}$$-37 | 8/8 | 2,2/4,8 | $${\color{green}83}$$ | $${\color{green}75}$$ | $${\color{green}98}$$ | 256 | 134 756 | 1,9 |
| 14 | AMD Ryzen 9 9955HX3D (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 5,4 | $${\color{green}88}$$ | $${\color{green}154}$$ | $${\color{red}14}$$ | 256 | 617 990 | 0,4 |
| 15 | Intel Core i9-13900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$- | 24/32 | 1,6/5,4 | $${\color{green}84}$$ | $${\color{green}155}$$ | $${\color{red}16}$$ | 255 | 180 232 | 1,4 |
| 16 | AMD Ryzen 9 7945HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 2,5/5,4 | $${\color{green}87}$$ | $${\color{green}153}$$ | $${\color{red}14}$$ | 254 | 446 981 | 0,6 |
| 17 | Intel Core Ultra 7 256V (Arc Graphics 140V) | $${\color{green}17}$$-37 | 8/8 | 2,2/4,8 | $${\color{green}83}$$ | $${\color{green}72}$$ | $${\color{green}98}$$ | 253 | 151 445 | 1,7 |
| 18 | AMD Ryzen AI 7 350 (Radeon 860M) | $${\color{green}28}$$-54 | 8/16 | 2,0/5,0 | $${\color{green}88}$$ | $${\color{green}92}$$ | $${\color{green}71}$$ | 251 | 132 261 | 1,9 |
| 19 | Intel Core Ultra 5 225H (Arc Graphics 130T) | $${\color{green}28}$$-115 | 16/16 | 4,3/4,9 | $${\color{green}69}$$ | $${\color{green}82}$$ | $${\color{green}98}$$ | 249 | 120 144 | $${\color{green}2,1}$$ |
| 20 | Intel Core Ultra 7 165H (Arc 8-Core iGPU) | $${\color{green}28}$$- | 16/22 | 3,8/5,0 | $${\color{green}74}$$ | $${\color{green}93}$$ | $${\color{green}78}$$ | 245 | 176 007 | 1,4 |
| 21 | Intel Core Ultra 7 155H (Arc 8-Core iGPU) | $${\color{green}28}$$- | 16/22 | 3,8/4,8 | $${\color{green}73}$$ | $${\color{green}94}$$ | $${\color{green}78}$$ | 245 | 81 262 | $${\color{green}3,0}$$ |
| 22 | AMD Ryzen 9 7940HS (Radeon 780M) | $${\color{red}35}$$- | 8/16 | 4,0/5,2 | $${\color{green}82}$$ | $${\color{green}94}$$ | $${\color{green}68}$$ | 244 | 145 715 | 1,7 |
| 23 | AMD Ryzen 9 8945H (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 4,0/5,2 | $${\color{green}82}$$ | $${\color{green}93}$$ | $${\color{green}68}$$ | 243 | 150 751 | 1,6 |
| 24 | AMD Ryzen 7 7840HS (Radeon 780M) | $${\color{red}35}$$- | 8/16 | 3,8/5,1 | $${\color{green}81}$$ | $${\color{green}92}$$ | $${\color{green}68}$$ | 241 | 101 419 | $${\color{green}2,4}$$ |
| 25 | AMD Ryzen 7 8845HS (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 3,8/5,1 | $${\color{green}81}$$ | $${\color{green}92}$$ | $${\color{green}68}$$ | 241 | 81 985 | $${\color{green}2,9}$$ |
| 26 | Intel Core i7-13850HX (UHD Graphics 770) | $${\color{red}55}$$- | 20/28 | 1,5/5,3 | $${\color{green}86}$$ | $${\color{green}137}$$ | $${\color{red}18}$$ | 241 | 669 724 | 0,4 |
| 27 | Intel Core i7-14700HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 20/28 | 3,9/5,5 | $${\color{green}86}$$ | $${\color{green}137}$$ | $${\color{red}18}$$ | 241 | 143 720 | 1,7 |
| 28 | Intel Core i7-14650HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 16/24 | 1,6/5,2 | $${\color{green}80}$$ | $${\color{green}130}$$ | $${\color{red}18}$$ | 228 | 155 818 | 1,5 |
| 29 | Intel Core Ultra 5 226V (Arc Graphics 130V) | $${\color{green}17}$$-37 | 8/8 | 2,1/4,5 | $${\color{green}78}$$ | $${\color{green}69}$$ | $${\color{green}79}$$ | 226 | 96 420 | $${\color{green}2,3}$$ |
| 30 | Intel Core Ultra 5 125H (Arc 7-Core iGPU) | $${\color{green}28}$$- | 14/18 | 3,6/4,5 | $${\color{green}69}$$ | $${\color{green}82}$$ | $${\color{green}74}$$ | 225 | 69 746 | $${\color{green}3,2}$$ |
| 31 | AMD Ryzen 7 8840HS (Radeon 780M) | $${\color{green}28}$$- | 8/16 | 3,3/5,1 | $${\color{green}80}$$ | $${\color{green}77}$$ | $${\color{green}68}$$ | 225 | 97 805 | $${\color{green}2,3}$$ |
| 32 | Intel Core i5-14500HX (Iris Xe G7 96EUs) | $${\color{red}55}$$-157 | 14/20 | 1,8/5,0 | $${\color{green}76}$$ | $${\color{green}106}$$ | 37 | 219 | 165 390 | 1,3 |
| 33 | Intel Core i7-13800H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,8/5,2 | $${\color{green}82}$$ | $${\color{green}100}$$ | 37 | 219 | 247 527 | 0,9 |
| 34 | Intel Core i9-13900H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,9/5,4 | $${\color{green}81}$$ | $${\color{green}100}$$ | 37 | 218 | 91 033 | $${\color{green}2,4}$$ |
| 35 | AMD Ryzen 7 8840U (Radeon 780M) | $${\color{green}28}$$- | 8/16 | 3,3/5,1 | $${\color{green}78}$$ | $${\color{green}72}$$ | $${\color{green}68}$$ | 218 | 106 990 | $${\color{green}2,0}$$ |
| 36 | Intel Core i7-13700HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/5,0 | $${\color{green}77}$$ | $${\color{green}114}$$ | $${\color{red}18}$$ | 209 | 162 474 | 1,3 |
| 37 | AMD Ryzen 5 7640HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | $${\color{green}80}$$ | $${\color{green}72}$$ | $${\color{green}54}$$ | 206 | 58 990 | $${\color{green}3,5}$$ |
| 38 | AMD Ryzen 5 8645HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | $${\color{green}79}$$ | $${\color{green}73}$$ | $${\color{green}54}$$ | 206 | 65 884 | $${\color{green}3,1}$$ |
| 39 | Intel Core i7-13700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,8/5,0 | $${\color{green}76}$$ | $${\color{green}92}$$ | 37 | 205 | 55 681 | $${\color{green}3,7}$$ |
| 40 | Intel Core i7-12700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,7/4,7 | $${\color{green}73}$$ | $${\color{green}94}$$ | 37 | 204 | 65 228 | $${\color{green}3,1}$$ |
| 41 | AMD Ryzen 7 7745HX (Radeon 610M) | $${\color{red}55}$$- | 8/16 | 3,6/5,1 | $${\color{green}85}$$ | $${\color{green}100}$$ | $${\color{red}14}$$ | 199 | 141 073 | 1,4 |
| 42 | AMD Ryzen 7 6800H (Radeon 680M) | $${\color{red}45}$$- | 8/16 | 3,2/4,7 | $${\color{green}64}$$ | $${\color{green}72}$$ | $${\color{green}55}$$ | 191 | 172 190 | 1,1 |
| 43 | AMD Ryzen 7 7735HS (Radeon 680M) | $${\color{red}35}$$- | 8/16 | 3,2/4,8 | $${\color{green}64}$$ | $${\color{green}72}$$ | $${\color{green}55}$$ | 191 | 84 974 | $${\color{green}2,2}$$ |
| 44 | Intel Core i7-13620H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,8/4,9 | $${\color{green}76}$$ | $${\color{green}88}$$ | $${\color{red}26}$$ | 190 | 54 231 | $${\color{green}3,5}$$ |
| 45 | Intel Core i7-13650HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 14/20 | 1,9/4,9 | $${\color{green}76}$$ | $${\color{green}106}$$ | $${\color{red}8}$$ | 190 | 89 497 | $${\color{green}2,1}$$ |
| 46 | Intel Core i7-1360P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,6/5,0 | $${\color{green}75}$$ | $${\color{green}77}$$ | 37 | 189 | 52 547 | $${\color{green}3,6}$$ |
| 47 | Intel Core i7-12850HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/4,8 | $${\color{green}74}$$ | $${\color{green}95}$$ | $${\color{red}18}$$ | 187 | 119 990 | 1,6 |
| 48 | Intel Core i5-13500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,9/4,7 | $${\color{green}72}$$ | $${\color{green}86}$$ | $${\color{red}28}$$ | 186 | 51 989 | $${\color{green}3,6}$$ |
| 49 | Intel Core Ultra 7 165U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,8/4,9 | $${\color{green}72}$$ | $${\color{green}66}$$ | 45 | 183 | 249 900 | 0,7 |
| 50 | Intel Core i7-1365U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,3/5,2 | $${\color{green}78}$$ | $${\color{green}67}$$ | 37 | 182 | 136 588 | 1,3 |
| 51 | Intel Core i7-1260P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,5/4,7 | $${\color{green}71}$$ | $${\color{green}72}$$ | 37 | 180 | 55 025 | $${\color{green}3,3}$$ |
| 52 | Qualcomm Snapdragon X Elite X1E-78-100 (SD X Adreno X1-85 3.8 TFLOPS) | $${\color{red}35}$$-45 | 12/12 | 3,4 | $${\color{green}69}$$ | $${\color{green}70}$$ | 41 | 180 | 111 215 | 1,6 |
| 53 | AMD Ryzen AI 5 340 (Radeon 840M) | $${\color{green}28}$$-54 | 6/12 | 2,0/4,8 | $${\color{green}75}$$ | $${\color{green}66}$$ | 39 | 180 | 76 713 | $${\color{green}2,3}$$ |
| 54 | AMD Ryzen 5 7540U (Radeon 740M) | $${\color{green}28}$$- | 6/12 | 3,2/4,9 | $${\color{green}77}$$ | $${\color{green}64}$$ | 39 | 180 | 163 812 | 1,1 |
| 55 | AMD Ryzen 5 PRO 7540U (Radeon 740M) | $${\color{green}15}$$- | 6/12 | 3,2/4,9 | $${\color{green}77}$$ | $${\color{green}64}$$ | 39 | 180 | 164 890 | 1,1 |
| 56 | Intel Core Ultra 7 155U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,8/4,8 | $${\color{green}70}$$ | $${\color{green}64}$$ | 45 | 179 | 80 970 | $${\color{green}2,2}$$ |
| 57 | Intel Core 7 150U (Iris Xe G7 96EUs) | $${\color{green}15}$$-55 | 10/12 | 1,2/5,4 | $${\color{green}79}$$ | $${\color{green}62}$$ | 37 | 178 | 56 847 | $${\color{green}3,1}$$ |
| 58 | Intel Core i5-1340P (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 12/16 | 1,4/4,6 | $${\color{green}71}$$ | $${\color{green}78}$$ | $${\color{red}28}$$ | 177 | 63 787 | $${\color{green}2,8}$$ |
| 59 | Intel Core i5-12600H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 2,0/4,5 | $${\color{green}68}$$ | $${\color{green}80}$$ | $${\color{red}28}$$ | 176 | 71 520 | $${\color{green}2,5}$$ |
| 60 | Intel Core Ultra 5 135U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,6/4,4 | $${\color{green}65}$$ | $${\color{green}66}$$ | 45 | 176 | 107 398 | 1,6 |
| 61 | Intel Core i5-12500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,8/4,5 | $${\color{green}68}$$ | $${\color{green}80}$$ | $${\color{red}28}$$ | 176 | 55 655 | $${\color{green}3,2}$$ |
| 62 | Intel Core i7-12650H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,7/4,7 | $${\color{green}73}$$ | $${\color{green}76}$$ | $${\color{red}26}$$ | 175 | 58 450 | $${\color{green}3,0}$$ |
| 63 | Intel Core i5-13450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 10/16 | 1,8/4,6 | $${\color{green}73}$$ | $${\color{green}93}$$ | $${\color{red}8}$$ | 174 | 97 957 | 1,8 |
| 64 | AMD Ryzen Z1 (Radeon 740M) | $${\color{red}30}$$- | 6/12 | 3,2/4,9 | $${\color{green}76}$$ | 59 | 39 | 174 | 94 690 | 1,8 |
| 65 | AMD Ryzen 5 7645HX (Radeon 610M) | $${\color{red}55}$$- | 6/12 | 4,0/5,0 | $${\color{green}81}$$ | $${\color{green}79}$$ | $${\color{red}14}$$ | 174 | 154 724 | 1,1 |
| 66 | Intel Core Ultra 5 125U (Graphics 4-Core iGPU) | $${\color{green}15}$$- | 12/14 | 3,6/4,3 | $${\color{green}65}$$ | $${\color{green}64}$$ | 45 | 174 | 57 648 | $${\color{green}3,0}$$ |
| 67 | Intel Core i7-1355U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,2/5,0 | $${\color{green}74}$$ | $${\color{green}62}$$ | 37 | 173 | $${\color{green}48 466}$$ | $${\color{green}3,6}$$ |
| 68 | Intel Core i7-1265U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,3/4,8 | $${\color{green}72}$$ | $${\color{green}63}$$ | 37 | 172 | 209 822 | 0,8 |
| 69 | Intel Core i7-1270P (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 12/16 | 1,6/4,8 | $${\color{green}68}$$ | $${\color{green}67}$$ | 37 | 172 | 164 990 | 1,0 |
| 70 | Intel Core 5 120U (Iris Xe G7 80EUs) | $${\color{green}15}$$-55 | 10/12 | 0,9/5,0 | $${\color{green}77}$$ | $${\color{green}66}$$ | $${\color{red}28}$$ | 171 | $${\color{green}45 915}$$ | $${\color{green}3,7}$$ |
| 71 | Intel Core i7-1255U (Iris Xe G7 96EUs) | $${\color{green}15}$$- | 10/12 | 1,2/4,7 | $${\color{green}69}$$ | $${\color{green}62}$$ | 37 | 168 | $${\color{green}39 428}$$ | $${\color{green}4,3}$$ |
| 72 | Intel Core i5-1245U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 1,2/4,4 | $${\color{green}70}$$ | $${\color{green}67}$$ | $${\color{red}28}$$ | 165 | 183 512 | 0,9 |
| 73 | Intel Core i5-1335U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,6 | $${\color{green}69}$$ | $${\color{green}61}$$ | $${\color{red}28}$$ | 158 | $${\color{green}37 388}$$ | $${\color{green}4,2}$$ |
| 74 | Intel Core i5-1240P (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 12/16 | 1,2/4,4 | $${\color{green}66}$$ | $${\color{green}64}$$ | $${\color{red}28}$$ | 158 | 63 479 | $${\color{green}2,5}$$ |
| 75 | AMD Ryzen 5 6600H (Radeon 660M) | $${\color{red}45}$$- | 6/12 | 3,3/4,5 | $${\color{green}61}$$ | 60 | 36 | 157 | 57 470 | $${\color{green}2,7}$$ |
| 76 | AMD Ryzen 5 7535HS (Radeon 660M) | $${\color{red}35}$$- | 6/12 | 3,3/4,6 | $${\color{green}62}$$ | 58 | 36 | 156 | 65 298 | $${\color{green}2,4}$$ |
| 77 | Intel Core i5-1345U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 1,2/4,7 | $${\color{green}68}$$ | 60 | $${\color{red}28}$$ | 156 | 164 284 | 0,9 |
| 78 | Intel Core i5-13420H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,6 | $${\color{green}69}$$ | $${\color{green}61}$$ | $${\color{red}19}$$ | 149 | $${\color{green}38 409}$$ | $${\color{green}3,9}$$ |
| 79 | Intel Core 5 210H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,6/4,8 | $${\color{green}69}$$ | $${\color{green}61}$$ | $${\color{red}19}$$ | 149 | 103 386 | 1,4 |
| 80 | AMD Ryzen 7 7730U (Vega 8) | $${\color{green}15}$$- | 8/16 | 2,0/4,5 | $${\color{green}61}$$ | 59 | $${\color{red}28}$$ | 148 | $${\color{green}47 664}$$ | $${\color{green}3,1}$$ |
| 81 | AMD Ryzen 5 7535U (Radeon 660M) | $${\color{green}28}$$- | 6/12 | 2,9/4,6 | 60 | 50 | 36 | 146 | 51 672 | $${\color{green}2,8}$$ |
| 82 | AMD Ryzen 7 5825U (Vega 8) | $${\color{green}15}$$- | 8/16 | 2,0/4,5 | $${\color{green}61}$$ | 55 | $${\color{red}28}$$ | 144 | $${\color{green}37 635}$$ | $${\color{green}3,8}$$ |
| 83 | Intel Core i5-12450H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,4 | $${\color{green}68}$$ | 56 | $${\color{red}19}$$ | 143 | $${\color{green}32 286}$$ | $${\color{green}4,4}$$ |
| 84 | Intel Core i7-1185G7 (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 4/8 | 3,0/4,8 | $${\color{green}63}$$ | 43 | 37 | 143 | 120 982 | 1,2 |
| 85 | Intel Core i5-1334U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,6 | $${\color{green}65}$$ | 48 | $${\color{red}28}$$ | 141 | 57 570 | $${\color{green}2,4}$$ |
| 86 | Intel Core i5-1235U (Iris Xe G7 80EUs) | $${\color{green}15}$$- | 10/12 | 0,9/4,4 | $${\color{green}66}$$ | 47 | $${\color{red}28}$$ | 141 | $${\color{green}28 739}$$ | $${\color{green}4,9}$$ |
| 87 | Intel Core 3 100U (UHD Graphics 64EUs) | $${\color{green}15}$$-55 | 6/8 | 0,9/4,7 | $${\color{green}67}$$ | 48 | $${\color{red}26}$$ | 141 | $${\color{green}38 846}$$ | $${\color{green}3,6}$$ |
| 88 | Intel Core i7-1165G7 (Iris Xe G7 96EUs) | $${\color{green}28}$$- | 4/8 | 2,8/4,7 | $${\color{green}63}$$ | 40 | 37 | 140 | 50 985 | $${\color{green}2,7}$$ |
| 89 | Intel Core i5-11320H (Iris Xe G7 96EUs) | $${\color{red}35}$$- | 4/8 | 3,2/4,5 | $${\color{green}62}$$ | 41 | 37 | 140 | 66 395 | $${\color{green}2,1}$$ |
| 90 | AMD Ryzen 7 5800U (Vega 8) | $${\color{green}25}$$- | 8/16 | 1,9/4,4 | 59 | 52 | $${\color{red}28}$$ | 139 | $${\color{green}44 749}$$ | $${\color{green}3,1}$$ |
| 91 | AMD Ryzen 7 4800H (Vega 7) | $${\color{red}45}$$- | 8/16 | 2,9/4,2 | 49 | $${\color{green}62}$$ | $${\color{red}25}$$ | 136 | 51 070 | $${\color{green}2,7}$$ |
| 92 | AMD Ryzen 5 7530U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,0/4,5 | $${\color{green}61}$$ | 49 | $${\color{red}25}$$ | 135 | $${\color{green}46 352}$$ | $${\color{green}2,9}$$ |
| 93 | AMD Ryzen 5 5600H (Vega 7) | $${\color{red}45}$$- | 6/12 | 3,3/4,2 | 59 | 51 | $${\color{red}25}$$ | 135 | $${\color{green}47 990}$$ | $${\color{green}2,8}$$ |
| 94 | Intel Core i5-1155G7 (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 4/8 | 2,5/4,5 | $${\color{green}61}$$ | 45 | $${\color{red}28}$$ | 134 | 55 899 | $${\color{green}2,4}$$ |
| 95 | Intel Core i3-1220P (UHD Graphics 64EUs) | $${\color{green}28}$$- | 10/12 | 1,1/4,4 | 58 | 48 | $${\color{red}26}$$ | 132 | $${\color{green}45 556}$$ | $${\color{green}2,9}$$ |
| 96 | AMD Ryzen 5 7430U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 59 | 47 | $${\color{red}25}$$ | 131 | $${\color{green}40 333}$$ | $${\color{green}3,2}$$ |
| 97 | Intel Core i3-1215U (UHD Graphics 64EUs) | $${\color{green}15}$$- | 6/8 | 0,9/4,4 | $${\color{green}64}$$ | 41 | $${\color{red}26}$$ | 131 | $${\color{green}24 266}$$ | $${\color{green}5,4}$$ |
| 98 | AMD Ryzen 7 7435H () | $${\color{red}45}$$- | 8/16 | 3,1/4,5 | $${\color{green}65}$$ | $${\color{green}66}$$ | $${\color{red}0}$$ | 131 | 72 927 | 1,8 |
| 99 | AMD Ryzen 5 5625U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 59 | 46 | $${\color{red}25}$$ | 130 | $${\color{green}34 698}$$ | $${\color{green}3,7}$$ |
| 100 | Intel Core i3-1315U (UHD Graphics 64EUs) | $${\color{green}15}$$- | 6/8 | 0,9/4,5 | $${\color{green}62}$$ | 41 | $${\color{red}26}$$ | 129 | $${\color{green}32 578}$$ | $${\color{green}4,0}$$ |
| 101 | AMD Ryzen 5 5600U (Vega 7) | $${\color{green}25}$$- | 6/12 | 2,3/4,2 | 58 | 45 | $${\color{red}25}$$ | 128 | $${\color{green}34 983}$$ | $${\color{green}3,7}$$ |
| 102 | AMD Ryzen 7 5700U (Vega 8) | $${\color{green}25}$$- | 8/16 | 1,8/4,3 | 49 | 48 | $${\color{red}28}$$ | 125 | $${\color{green}34 400}$$ | $${\color{green}3,6}$$ |
| 103 | Qualcomm Snapdragon X Plus X1P-42-100 (SD X Adreno X1-45 1.7 TFLOPS) | $${\color{red}30}$$- | 8/8 | 3,4 | $${\color{green}63}$$ | 41 | $${\color{red}21}$$ | 125 | 89 862 | 1,4 |
| 104 | Intel Core i5-11300H (Iris Xe G7 80EUs) | $${\color{red}35}$$- | 4/8 | 3,1/4,4 | 58 | $${\color{red}37}$$ | $${\color{red}28}$$ | 123 | 92 922 | 1,3 |
| 105 | AMD Ryzen 5 PRO 5675U (Vega 7) | $${\color{green}15}$$- | 6/12 | 2,3/4,3 | 56 | 40 | $${\color{red}25}$$ | 121 | $${\color{green}39 570}$$ | $${\color{green}3,1}$$ |
| 106 | Intel Core i5-1135G7 (Iris Xe G7 80EUs) | $${\color{green}28}$$- | 4/8 | 2,4/4,2 | 57 | $${\color{red}36}$$ | $${\color{red}28}$$ | 121 | $${\color{green}28 964}$$ | $${\color{green}4,2}$$ |
| 107 | AMD Ryzen 5 5560U (Vega 6) | $${\color{green}25}$$- | 6/12 | 2,3/4,0 | 54 | 46 | $${\color{red}20}$$ | 120 | $${\color{green}45 551}$$ | $${\color{green}2,6}$$ |
| 108 | AMD Ryzen 7 PRO 4750U (Vega 7) | $${\color{green}15}$$- | 8/16 | 1,7/4,1 | 47 | 48 | $${\color{red}25}$$ | 120 | $${\color{green}42 690}$$ | $${\color{green}2,8}$$ |
| 109 | Intel Core i3-1305U (UHD Graphics 64EUs) | $${\color{green}15}$$- | 5/6 | 1,2/4,5 | 59 | $${\color{red}29}$$ | $${\color{red}26}$$ | 114 | $${\color{green}32 796}$$ | $${\color{green}3,5}$$ |
| 110 | AMD Ryzen 5 5500U (Vega 7) | $${\color{green}25}$$- | 6/12 | 2,1/4,0 | 46 | 42 | $${\color{red}25}$$ | 113 | $${\color{green}36 628}$$ | $${\color{green}3,1}$$ |
| 111 | AMD Ryzen 5 4600H (Vega 6) | $${\color{red}45}$$- | 6/12 | 3,0/4,0 | 46 | 47 | $${\color{red}20}$$ | 113 | $${\color{green}32 828}$$ | $${\color{green}3,4}$$ |
| 112 | AMD Ryzen 5 4600U (Vega 6) | $${\color{green}15}$$- | 6/12 | 2,1/4,0 | 46 | 43 | $${\color{red}20}$$ | 109 | $${\color{green}36 690}$$ | $${\color{green}3,0}$$ |
| 113 | Intel Processor U300 (UHD Graphics Xe G4 48EUs) | $${\color{green}15}$$-55 | 5/6 | 0,9/4,4 | 59 | $${\color{red}29}$$ | $${\color{red}19}$$ | 107 | $${\color{green}46 690}$$ | $${\color{green}2,3}$$ |
| 114 | Intel Core i5-12450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 8/12 | 1,8/4,4 | $${\color{red}39}$$ | 59 | $${\color{red}8}$$ | 106 | 57 808 | 1,8 |
| 115 | AMD Ryzen 3 7335U (Radeon 660M) | $${\color{green}28}$$- | 4/8 | 3,0/4,3 | $${\color{red}36}$$ | $${\color{red}30}$$ | 36 | 102 | $${\color{green}36 513}$$ | $${\color{green}2,8}$$ |
| 116 | AMD Ryzen 5 PRO 4650U (Vega 6) | $${\color{green}15}$$- | 6/12 | 2,1/4,0 | 44 | $${\color{red}36}$$ | $${\color{red}20}$$ | 100 | $${\color{green}36 570}$$ | $${\color{green}2,7}$$ |
| 117 | Intel Core i3-1125G4 (UHD Graphics Xe G4 48EUs) | $${\color{green}28}$$- | 4/8 | 2,0/3,7 | 50 | $${\color{red}29}$$ | $${\color{red}19}$$ | 98 | 79 788 | 1,2 |
| 118 | Intel Core i3-N305 (UHD Graphics Xe 750 32EUs) | $${\color{green}15}$$- | 8/8 | 1,8/3,8 | 44 | $${\color{red}36}$$ | $${\color{red}15}$$ | 95 | $${\color{green}31 121}$$ | $${\color{green}3,1}$$ |
| 119 | AMD Ryzen 3 5300U (Vega 6) | $${\color{green}25}$$- | 4/8 | 2,6/3,8 | 44 | $${\color{red}31}$$ | $${\color{red}20}$$ | 95 | 51 670 | 1,8 |
| 120 | Intel Core i3-1115G4 (UHD Graphics Xe G4 48EUs) | $${\color{green}28}$$- | 2/4 | 3,0/4,1 | 54 | $${\color{red}20}$$ | $${\color{red}19}$$ | 93 | $${\color{green}28 990}$$ | $${\color{green}3,2}$$ |
| 121 | AMD Ryzen 3 5400U (Vega 6) | $${\color{green}25}$$- | 4/8 | 2,6/4,0 | 48 | $${\color{red}24}$$ | $${\color{red}20}$$ | 92 | $${\color{green}34 990}$$ | $${\color{green}2,6}$$ |
| 122 | AMD Ryzen 3 5425U (Vega 6) | $${\color{green}15}$$- | 4/8 | 2,7/4,1 | 48 | $${\color{red}24}$$ | $${\color{red}20}$$ | 92 | $${\color{green}35 085}$$ | $${\color{green}2,6}$$ |
| 123 | AMD Ryzen 3 7330U (Vega 6) | $${\color{green}15}$$- | 4/8 | 2,3/4,3 | 48 | $${\color{red}24}$$ | $${\color{red}20}$$ | 92 | $${\color{green}33 599}$$ | $${\color{green}2,7}$$ |
| 124 | Intel Core i5-1035G1 (UHD Graphics G1) | $${\color{green}15}$$- | 4/8 | 1,0/3,6 | 50 | $${\color{red}30}$$ | $${\color{red}10}$$ | 90 | $${\color{green}29 007}$$ | $${\color{green}3,1}$$ |
| 125 | AMD Ryzen 5 7520U (Radeon 610M) | $${\color{green}15}$$- | 4/8 | 2,8/4,3 | 44 | $${\color{red}30}$$ | $${\color{red}14}$$ | 88 | $${\color{green}27 907}$$ | $${\color{green}3,2}$$ |
| 126 | AMD Ryzen 3 7320U (Radeon 610M) | $${\color{green}15}$$- | 4/8 | 2,4/4,1 | 44 | $${\color{red}30}$$ | $${\color{red}14}$$ | 88 | $${\color{green}28 539}$$ | $${\color{green}3,1}$$ |
| 127 | AMD Ryzen 3 4300U (Vega 5) | $${\color{green}15}$$- | 4/4 | 2,7/3,7 | 43 | $${\color{red}27}$$ | $${\color{red}17}$$ | 87 | $${\color{green}41 770}$$ | $${\color{green}2,1}$$ |
| 128 | Intel Core i5-1030NG7 (Iris Plus Graphics G7) | $${\color{green}10}$$- | 4/8 | 1,1/3,5 | 45 | $${\color{red}21}$$ | $${\color{red}19}$$ | 85 | $${\color{green}32 360}$$ | $${\color{green}2,6}$$ |
| 129 | Intel Core i5-10210U (UHD Graphics 620) | $${\color{green}15}$$- | 4/8 | 1,6/4,2 | 45 | $${\color{red}29}$$ | $${\color{red}9}$$ | 83 | 73 723 | 1,1 |
| 130 | Intel Core i5-8259U (Iris Plus Graphics 655) | $${\color{green}28}$$- | 4/8 | 2,3/3,8 | $${\color{red}39}$$ | $${\color{red}28}$$ | $${\color{red}14}$$ | 81 | $${\color{green}24 779}$$ | $${\color{green}3,3}$$ |
| 131 | Intel Core i5-8265U (UHD Graphics 620) | $${\color{green}15}$$- | 4/8 | 1,6/3,9 | 43 | $${\color{red}28}$$ | $${\color{red}9}$$ | 80 | $${\color{green}30 000}$$ | $${\color{green}2,7}$$ |
| 132 | AMD Ryzen 5 3500U (Vega 8) | $${\color{green}15}$$- | 4/8 | 2,1/3,7 | $${\color{red}37}$$ | $${\color{red}24}$$ | $${\color{red}17}$$ | 78 | $${\color{green}25 072}$$ | $${\color{green}3,1}$$ |
| 133 | Intel Core i3-1005G1 (UHD Graphics G1) | $${\color{green}15}$$- | 2/4 | 1,2/3,4 | 48 | $${\color{red}19}$$ | $${\color{red}10}$$ | 77 | $${\color{green}33 015}$$ | $${\color{green}2,3}$$ |
| 134 | Intel Core i3-1000NG4 (Iris Plus Graphics G4) | $${\color{green}9}$$- | 2/4 | 1,1/3,2 | 45 | $${\color{red}16}$$ | $${\color{red}15}$$ | 76 | $${\color{green}26 494}$$ | $${\color{green}2,9}$$ |
| 135 | Intel Processor N97 (UHD Graphics 24EUs) | $${\color{green}12}$$- | 4/4 | 3,6 | 44 | $${\color{red}21}$$ | $${\color{red}8}$$ | 73 | $${\color{green}30 756}$$ | $${\color{green}2,4}$$ |
| 136 | Intel Core i3-1000G1 (UHD Graphics G1) | $${\color{green}9}$$- | 2/4 | 1,1/3,2 | 45 | $${\color{red}16}$$ | $${\color{red}10}$$ | 71 | $${\color{green}27 491}$$ | $${\color{green}2,6}$$ |
| 137 | Intel Processor N100 (UHD Graphics 24EUs) | $${\color{green}6}$$- | 4/4 | 1,0/3,4 | 41 | $${\color{red}22}$$ | $${\color{red}8}$$ | 71 | $${\color{green}24 142}$$ | $${\color{green}2,9}$$ |
| 138 | Intel Processor N95 (UHD Graphics Xe 16EUs) | $${\color{green}15}$$- | 4/4 | 3,4 | 41 | $${\color{red}20}$$ | $${\color{red}8}$$ | 69 | $${\color{green}23 497}$$ | $${\color{green}2,9}$$ |
| 139 | Intel Core i3-10110U (UHD Graphics 620) | $${\color{green}15}$$- | 2/4 | 2,1/4,1 | 41 | $${\color{red}16}$$ | $${\color{red}9}$$ | 66 | $${\color{green}28 621}$$ | $${\color{green}2,3}$$ |
| 140 | Intel Processor N200 (UHD Graphics Xe 750 32EUs) | $${\color{green}6}$$- | 4/4 | 1,0/3,7 | $${\color{red}38}$$ | $${\color{red}12}$$ | $${\color{red}15}$$ | 65 | $${\color{green}26 275}$$ | $${\color{green}2,5}$$ |
| 141 | Intel Core i3-N300 (UHD Graphics Xe 750 32EUs) | $${\color{green}7}$$- | 8/8 | 3,8 | $${\color{red}26}$$ | $${\color{red}21}$$ | $${\color{red}15}$$ | 62 | $${\color{green}35 721}$$ | 1,7 |
| 142 | AMD Athlon Silver 7120U (Radeon 610M) | $${\color{green}15}$$- | 2/2 | 2,4/3,5 | $${\color{red}31}$$ | $${\color{red}11}$$ | $${\color{red}14}$$ | 56 | $${\color{green}31 110}$$ | 1,8 |
| 143 | AMD Ryzen 3 3250U (Vega 3) | $${\color{green}15}$$- | 2/4 | 2,6/3,5 | $${\color{red}34}$$ | $${\color{red}13}$$ | $${\color{red}9}$$ | 56 | $${\color{green}29 233}$$ | 1,9 |
| 144 | AMD Ryzen 3 3200U (Vega 3) | $${\color{green}15}$$- | 2/4 | 2,6/3,5 | $${\color{red}33}$$ | $${\color{red}13}$$ | $${\color{red}9}$$ | 55 | $${\color{green}24 233}$$ | $${\color{green}2,3}$$ |
| 145 | Intel Pentium Silver N6000 (UHD Graphics) | $${\color{green}6}$$- | 4/4 | 1,1/3,3 | $${\color{red}30}$$ | $${\color{red}15}$$ | $${\color{red}8}$$ | 53 | $${\color{green}33 392}$$ | 1,6 |
| 146 | Intel Core m3-8100Y (UHD Graphics 615) | $${\color{green}5}$$- | 2/4 | 1,1/3,4 | $${\color{red}35}$$ | $${\color{red}11}$$ | $${\color{red}6}$$ | 52 | $${\color{green}29 080}$$ | 1,8 |
| 147 | Qualcomm Snapdragon 8cx (Adreno 680) | $${\color{green}7}$$- | 8/8 | 2,8 | $${\color{red}29}$$ | $${\color{red}21}$$ | $${\color{red}0}$$ | 50 | $${\color{green}22 022}$$ | $${\color{green}2,3}$$ |
| 148 | Intel Celeron N4500 (UHD Graphics) | $${\color{green}6}$$- | 2/2 | 1,1/2,8 | $${\color{red}25}$$ | $${\color{red}8}$$ | $${\color{red}4}$$ | 37 | $${\color{green}22 812}$$ | 1,6 |
| 149 | Qualcomm Snapdragon 850 (Adreno 630) | 0- | 8/8 | 2,8/3,0 | $${\color{red}20}$$ | $${\color{red}15}$$ | $${\color{red}0}$$ | 35 | $${\color{green}36 420}$$ | 1,0 |
| 150 | Intel Celeron N4020 (UHD Graphics 600) | $${\color{green}6}$$-15 | 2/2 | 1,1/2,8 | $${\color{red}19}$$ | $${\color{red}6}$$ | $${\color{red}3}$$ | 28 | $${\color{green}16 107}$$ | 1,7 |
| 151 | Intel Celeron N4000 (UHD Graphics 600) | $${\color{green}6}$$- | 2/2 | 1,1/2,6 | $${\color{red}18}$$ | $${\color{red}6}$$ | $${\color{red}3}$$ | 27 | $${\color{green}17 390}$$ | 1,6 |


[AI Generated rating](./AI.md)


