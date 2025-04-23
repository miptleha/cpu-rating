> [!Note]
> I don't trust AI, let the program collect the data and build a table

Price list: https://www.nix.ru/price/price_list.html?section=notebooks_all#c_id=256&fn=256&g_id=10&new_goods=0&page=all&sort=%2Bp8116%2B8120%2B8119%2B330%2B90&spoiler=&store=msk-0_1721_1&thumbnail_view=2

GPU: https://www.notebookcheck.net/Mobile-Graphics-Cards-Benchmark-List.844.0.html?type=&sort=&gpubenchmarks=0&professional=0&dx=0&multiplegpus=1&showClassDescription=1&deskornote=0&series_uid=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&3dmark13_fire_gpu=1&gpu_fullname=1&pixelshaders=1&vertexshaders=1&corespeed=1&boostspeed=1&directx=1&opengl=1&technology=1&daysold=1

CPU: https://www.notebookcheck.net/Mobile-Processors-Benchmark-List.2436.0.html?type=&sort=&deskornote=0&gpubenchmarks=0&archive=0&condensed=0&id=0&perfrating=1&or=0&condensed=0&showCount=0&showBars=0&showPercent=0&geekbench5_1_single=1&geekbench5_1_multi=1&cpu_fullname=1&l2cache=1&l3cache=1&tdp=1&tdp_turbo=1&mhz=1&turbo_mhz=1&cores=1&threads=1&technology=1&daysold=1&gpu_name=1 

Load and parse 3 pages.  
For all laptops on sale look at the processor rating, find its video core, also look at the video core rating.  
Output a markdown table with ratings, price.

| # | Processor (GPU) | Tdp | Core/Thr | Freq GHz | SCore | MCore | GPU | Total | Price RUB | Value |
|---|-----------------|-----|----------|----------|-------|-------|-----|-------|-----------|-------|
| 1 | Intel Core Ultra 9 285HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,5 | 92 | 209 | 53 | 354 | 536 204 | 0,7 |
| 2 | Intel Core Ultra 9 275HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 24/24 | 2,1/5,4 | 92 | 188 | 53 | 333 | 484 669 | 0,7 |
| 3 | Intel Core Ultra 7 255H (Arc Graphics 140T) | 28-115 | 16/16 | 4,4/5,1 | 87 | 133 | 95 | 315 | 167 274 | 1,9 |
| 4 | Intel Core Ultra 9 285H (Arc Graphics 140T) | $${\color{red}45}$$-115 | 16/16 | 4,5/5,4 | 87 | 122 | 95 | 304 | 118 728 | 2,6 |
| 5 | AMD Ryzen 9 9955HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 5,4 | 100 | 171 | $${\color{red}22}$$ | 293 | 311 888 | 0,9 |
| 6 | AMD Ryzen AI 9 HX 370 (Radeon 890M) | 28-54 | 12/24 | 2,0/5,1 | 87 | 110 | 93 | 290 | 144 064 | 2,0 |
| 7 | AMD Ryzen AI 9 365 (Radeon 880M) | $${\color{red}54}$$- | 10/20 | 2,0/5,0 | 85 | 101 | 95 | 281 | 110 467 | 2,5 |
| 8 | Intel Core Ultra 7 255HX (Graphics 4-Core iGPU) | $${\color{red}55}$$-160 | 20/20 | 2,3/5,2 | 86 | 137 | 53 | 276 | 258 700 | 1,1 |
| 9 | Intel Core i9-13980HX (UHD Graphics 770) | $${\color{red}55}$$- | 24/32 | 1,6/5,6 | 87 | 157 | $${\color{red}27}$$ | 271 | 175 495 | 1,5 |
| 10 | Intel Core Ultra 9 185H (Arc 8-Core iGPU) | $${\color{red}45}$$- | 16/22 | 3,8/5,1 | 77 | 105 | 87 | 269 | 99 294 | 2,7 |
| 11 | Intel Core i9-14900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$-157 | 24/32 | 1,6/5,8 | 88 | 155 | $${\color{red}25}$$ | 268 | 176 516 | 1,5 |
| 12 | AMD Ryzen 9 7945HX3D (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 2,3/5,4 | 88 | 154 | $${\color{red}22}$$ | 264 | 408 201 | 0,6 |
| 13 | Intel Core i9-13900HX (UHD Graphics Xe 32EUs) | $${\color{red}55}$$- | 24/32 | 1,6/5,4 | 84 | 155 | $${\color{red}25}$$ | 264 | 180 232 | 1,5 |
| 14 | AMD Ryzen 9 7945HX (Radeon 610M) | $${\color{red}55}$$- | 16/32 | 2,5/5,4 | 87 | 153 | $${\color{red}22}$$ | 262 | 446 981 | 0,6 |
| 15 | AMD Ryzen AI 7 350 (Radeon 860M) | 28-54 | 8/16 | 2,0/5,0 | 88 | 92 | 81 | 261 | 132 261 | 2,0 |
| 16 | Intel Core Ultra 7 258V (Arc Graphics 140V) | 17-37 | 8/8 | 2,2/4,8 | 83 | 75 | 100 | 258 | 134 756 | 1,9 |
| 17 | AMD Ryzen 9 8945H (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 4,0/5,2 | 82 | 93 | 81 | 256 | 150 751 | 1,7 |
| 18 | Intel Core Ultra 7 256V (Arc Graphics 140V) | 17-37 | 8/8 | 2,2/4,8 | 83 | 72 | 100 | 255 | 151 445 | 1,7 |
| 19 | Intel Core Ultra 7 155H (Arc 8-Core iGPU) | 28- | 16/22 | 3,8/4,8 | 73 | 94 | 87 | 254 | 81 262 | 3,1 |
| 20 | AMD Ryzen 7 7840HS (Radeon 780M) | $${\color{red}35}$$- | 8/16 | 3,8/5,1 | 81 | 92 | 81 | 254 | 101 419 | 2,5 |
| 21 | Intel Core Ultra 7 165H (Arc 8-Core iGPU) | 28- | 16/22 | 3,8/5,0 | 74 | 93 | 87 | 254 | 176 007 | 1,4 |
| 22 | AMD Ryzen 7 8845HS (Radeon 780M) | $${\color{red}45}$$- | 8/16 | 3,8/5,1 | 81 | 92 | 81 | 254 | 81 985 | 3,1 |
| 23 | Intel Core Ultra 5 225H (Arc Graphics 130T) | 28-115 | 16/16 | 4,3/4,9 | 69 | 82 | 100 | 251 | 120 144 | 2,1 |
| 24 | Intel Core i7-13850HX (UHD Graphics 770) | $${\color{red}55}$$- | 20/28 | 1,5/5,3 | 86 | 137 | $${\color{red}27}$$ | 250 | 669 724 | 0,4 |
| 25 | Intel Core i7-14700HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 20/28 | 3,9/5,5 | 86 | 137 | $${\color{red}27}$$ | 250 | 143 720 | 1,7 |
| 26 | AMD Ryzen 7 8840HS (Radeon 780M) | 28- | 8/16 | 3,3/5,1 | 80 | 77 | 81 | 238 | 97 805 | 2,4 |
| 27 | Intel Core i7-14650HX (UHD Graphics 770) | $${\color{red}55}$$-157 | 16/24 | 1,6/5,2 | 80 | 130 | $${\color{red}27}$$ | 237 | 155 818 | 1,5 |
| 28 | Intel Core i7-13800H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,8/5,2 | 82 | 100 | 52 | 234 | 247 527 | 0,9 |
| 29 | Intel Core Ultra 5 125H (Arc 7-Core iGPU) | 28- | 14/18 | 3,6/4,5 | 69 | 82 | 83 | 234 | 69 746 | 3,4 |
| 30 | Intel Core i9-13900H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,9/5,4 | 81 | 100 | 52 | 233 | 91 033 | 2,6 |
| 31 | AMD Ryzen 7 8840U (Radeon 780M) | 28- | 8/16 | 3,3/5,1 | 78 | 72 | 81 | 231 | 120 252 | 1,9 |
| 32 | Intel Core i7-13700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,8/5,0 | 76 | 92 | 52 | 220 | 55 681 | 4,0 |
| 33 | Intel Core i7-12700H (Iris Xe G7 96EUs) | $${\color{red}45}$$- | 14/20 | 1,7/4,7 | 73 | 94 | 52 | 219 | 65 228 | 3,4 |
| 34 | Intel Core i7-13700HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/5,0 | 77 | 114 | $${\color{red}27}$$ | 218 | 162 474 | 1,3 |
| 35 | AMD Ryzen 5 8645HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | 79 | 73 | 65 | 217 | 65 884 | 3,3 |
| 36 | AMD Ryzen 5 7640HS (Radeon 760M) | $${\color{red}45}$$- | 6/12 | 4,3/5,0 | 80 | 72 | 65 | 217 | 131 632 | 1,6 |
| 37 | AMD Ryzen 7 7745HX (Radeon 610M) | $${\color{red}55}$$- | 8/16 | 3,6/5,1 | 85 | 100 | $${\color{red}22}$$ | 207 | 141 073 | 1,5 |
| 38 | AMD Ryzen 7 7735HS (Radeon 680M) | $${\color{red}35}$$- | 8/16 | 3,2/4,8 | 64 | 72 | 70 | 206 | 84 974 | 2,4 |
| 39 | Intel Core i7-13620H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,8/4,9 | 76 | 88 | 40 | 204 | 54 231 | 3,8 |
| 40 | Intel Core i7-1360P (Iris Xe G7 96EUs) | 28- | 12/16 | 1,6/5,0 | 75 | 77 | 52 | 204 | 52 547 | 3,9 |
| 41 | Qualcomm Snapdragon X Elite X1E-78-100 (SD X Adreno X1-85 3.8 TFLOPS) | $${\color{red}35}$$-45 | 12/12 | 3,4 | 69 | 70 | 64 | 203 | 111 215 | 1,8 |
| 42 | Intel Core i5-13500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,9/4,7 | 72 | 86 | 41 | 199 | 51 989 | 3,8 |
| 43 | Intel Core i7-1365U (Iris Xe G7 96EUs) | 15- | 10/12 | 1,3/5,2 | 78 | 67 | 52 | 197 | 136 588 | 1,4 |
| 44 | Intel Core i7-12850HX (UHD Graphics 770) | $${\color{red}55}$$- | 16/24 | 1,5/4,8 | 74 | 95 | $${\color{red}27}$$ | 196 | 231 477 | 0,8 |
| 45 | Intel Core i7-1260P (Iris Xe G7 96EUs) | 28- | 12/16 | 1,5/4,7 | 71 | 72 | 52 | 195 | 55 025 | 3,5 |
| 46 | Intel Core i7-13650HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 14/20 | 1,9/4,9 | 76 | 106 | $${\color{red}12}$$ | 194 | 89 497 | 2,2 |
| 47 | Intel Core 7 150U (Iris Xe G7 96EUs) | 15-55 | 10/12 | 1,2/5,4 | 79 | 62 | 52 | 193 | 56 847 | 3,4 |
| 48 | AMD Ryzen 5 7540U (Radeon 740M) | 28- | 6/12 | 3,2/4,9 | 77 | 64 | 51 | 192 | 163 812 | 1,2 |
| 49 | AMD Ryzen AI 5 340 (Radeon 840M) | 28-54 | 6/12 | 2,0/4,8 | 75 | 66 | 51 | 192 | 76 713 | 2,5 |
| 50 | Intel Core i5-1340P (Iris Xe G7 80EUs) | 28- | 12/16 | 1,4/4,6 | 71 | 78 | 41 | 190 | 63 787 | 3,0 |
| 51 | Intel Core i5-12500H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 1,8/4,5 | 68 | 80 | 41 | 189 | 55 655 | 3,4 |
| 52 | Intel Core i7-12650H (UHD Graphics 64EUs) | $${\color{red}45}$$- | 10/16 | 1,7/4,7 | 73 | 76 | 40 | 189 | 58 450 | 3,2 |
| 53 | Intel Core i5-12600H (Iris Xe G7 80EUs) | $${\color{red}45}$$- | 12/16 | 2,0/4,5 | 68 | 80 | 41 | 189 | 71 520 | 2,6 |
| 54 | Intel Core i7-1355U (Iris Xe G7 96EUs) | 15- | 10/12 | 1,2/5,0 | 74 | 62 | 52 | 188 | 48 466 | 3,9 |
| 55 | Intel Core Ultra 7 155U (Graphics 4-Core iGPU) | 15- | 12/14 | 3,8/4,8 | 70 | 64 | 53 | 187 | 81 917 | 2,3 |
| 56 | Intel Core i7-1265U (Iris Xe G7 96EUs) | 15- | 10/12 | 1,3/4,8 | 72 | 63 | 52 | 187 | 209 822 | 0,9 |
| 57 | AMD Ryzen Z1 (Radeon 740M) | $${\color{red}30}$$- | 6/12 | 3,2/4,9 | 76 | 59 | 51 | 186 | 97 563 | 1,9 |
| 58 | Intel Core Ultra 5 135U (Graphics 4-Core iGPU) | 15- | 12/14 | 3,6/4,4 | 65 | 66 | 53 | 184 | 107 398 | 1,7 |
| 59 | Intel Core 5 120U (Iris Xe G7 80EUs) | 15-55 | 10/12 | 0,9/5,0 | 77 | 66 | 41 | 184 | 45 915 | 4,0 |
| 60 | Intel Core i7-1255U (Iris Xe G7 96EUs) | 15- | 10/12 | 1,2/4,7 | 69 | 62 | 52 | 183 | 39 428 | 4,6 |
| 61 | AMD Ryzen 5 7645HX (Radeon 610M) | $${\color{red}55}$$- | 6/12 | 4,0/5,0 | 81 | 79 | $${\color{red}22}$$ | 182 | 154 724 | 1,2 |
| 62 | Intel Core Ultra 5 125U (Graphics 4-Core iGPU) | 15- | 12/14 | 3,6/4,3 | 65 | 64 | 53 | 182 | 57 648 | 3,2 |
| 63 | Intel Core i5-1245U (Iris Xe G7 80EUs) | 15- | 10/12 | 1,2/4,4 | 70 | 67 | 41 | 178 | 183 512 | 1,0 |
| 64 | Intel Core i5-13450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 10/16 | 1,8/4,6 | 73 | 93 | $${\color{red}12}$$ | 178 | 97 957 | 1,8 |
| 65 | Intel Core i5-1335U (Iris Xe G7 80EUs) | 15- | 10/12 | 0,9/4,6 | 69 | 61 | 41 | 171 | 37 388 | 4,6 |
| 66 | Intel Core i5-1240P (Iris Xe G7 80EUs) | 28- | 12/16 | 1,2/4,4 | 66 | 64 | 41 | 171 | 63 479 | 2,7 |
| 67 | Intel Core i5-1345U (Iris Xe G7 80EUs) | 15- | 10/12 | 1,2/4,7 | 68 | 60 | 41 | 169 | 164 284 | 1,0 |
| 68 | AMD Ryzen 5 6600H (Radeon 660M) | $${\color{red}45}$$- | 6/12 | 3,3/4,5 | 61 | 60 | 48 | 169 | 60 820 | 2,8 |
| 69 | AMD Ryzen 5 7535HS (Radeon 660M) | $${\color{red}35}$$- | 6/12 | 3,3/4,6 | 62 | 58 | 48 | 168 | 65 298 | 2,6 |
| 70 | AMD Ryzen 7 7730U (Vega 8) | 15- | 8/16 | 2,0/4,5 | 61 | 59 | $${\color{red}38}$$ | 158 | 47 664 | 3,3 |
| 71 | AMD Ryzen 5 7535U (Radeon 660M) | 28- | 6/12 | 2,9/4,6 | 60 | 50 | 48 | 158 | 51 672 | 3,1 |
| 72 | Intel Core i7-1185G7 (Iris Xe G7 96EUs) | 28- | 4/8 | 3,0/4,8 | 63 | 43 | 52 | 158 | 120 982 | 1,3 |
| 73 | Intel Core 3 100U (UHD Graphics 64EUs) | 15-55 | 6/8 | 0,9/4,7 | 67 | 48 | 40 | 155 | 38 846 | 4,0 |
| 74 | Intel Core i7-1165G7 (Iris Xe G7 96EUs) | 28- | 4/8 | 2,8/4,7 | 63 | 40 | 52 | 155 | 50 985 | 3,0 |
| 75 | Intel Core i5-11320H (Iris Xe G7 96EUs) | $${\color{red}35}$$- | 4/8 | 3,2/4,5 | 62 | 41 | 52 | 155 | 66 395 | 2,3 |
| 76 | Intel Core i5-1235U (Iris Xe G7 80EUs) | 15- | 10/12 | 0,9/4,4 | 66 | 47 | 41 | 154 | 28 739 | 5,4 |
| 77 | Intel Core i5-1334U (Iris Xe G7 80EUs) | 15- | 10/12 | 0,9/4,6 | 65 | 48 | 41 | 154 | 58 608 | 2,6 |
| 78 | AMD Ryzen 7 5825U (Vega 8) | 15- | 8/16 | 2,0/4,5 | 61 | 55 | $${\color{red}38}$$ | 154 | 37 635 | 4,1 |
| 79 | Intel Core i5-13420H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,6 | 69 | 61 | $${\color{red}24}$$ | 154 | 38 409 | 4,0 |
| 80 | Intel Core 5 210H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,6/4,8 | 69 | 61 | $${\color{red}24}$$ | 154 | 103 386 | 1,5 |
| 81 | AMD Ryzen 7 5800U (Vega 8) | 25- | 8/16 | 1,9/4,4 | 59 | 52 | $${\color{red}38}$$ | 149 | 44 749 | 3,3 |
| 82 | Intel Core i5-12450H (UHD Graphics Xe G4 48EUs) | $${\color{red}45}$$- | 8/12 | 1,5/4,4 | 68 | 56 | $${\color{red}24}$$ | 148 | 32 286 | 4,6 |
| 83 | Intel Core i5-1155G7 (Iris Xe G7 80EUs) | 28- | 4/8 | 2,5/4,5 | 61 | 45 | 41 | 147 | 55 899 | 2,6 |
| 84 | Intel Core i3-1220P (UHD Graphics 64EUs) | 28- | 10/12 | 1,1/4,4 | 58 | 48 | 40 | 146 | 45 556 | 3,2 |
| 85 | Intel Core i3-1215U (UHD Graphics 64EUs) | 15- | 6/8 | 0,9/4,4 | 64 | 41 | 40 | 145 | 24 266 | 6,0 |
| 86 | AMD Ryzen 5 7530U (Vega 7) | 15- | 6/12 | 2,0/4,5 | 61 | 49 | $${\color{red}34}$$ | 144 | 46 352 | 3,1 |
| 87 | AMD Ryzen 5 5600H (Vega 7) | $${\color{red}45}$$- | 6/12 | 3,3/4,2 | 59 | 51 | $${\color{red}34}$$ | 144 | 49 194 | 2,9 |
| 88 | Intel Core i3-1315U (UHD Graphics 64EUs) | 15- | 6/8 | 0,9/4,5 | 62 | 41 | 40 | 143 | 32 578 | 4,4 |
| 89 | Qualcomm Snapdragon X Plus X1P-42-100 (SD X Adreno X1-45 1.7 TFLOPS) | $${\color{red}30}$$- | 8/8 | 3,4 | 63 | 41 | $${\color{red}38}$$ | 142 | 89 862 | 1,6 |
| 90 | AMD Ryzen 5 7430U (Vega 7) | 15- | 6/12 | 2,3/4,3 | 59 | 47 | $${\color{red}34}$$ | 140 | 40 333 | 3,5 |
| 91 | AMD Ryzen 5 5625U (Vega 7) | 15- | 6/12 | 2,3/4,3 | 59 | 46 | $${\color{red}34}$$ | 139 | 34 698 | 4,0 |
| 92 | AMD Ryzen 5 5600U (Vega 7) | 25- | 6/12 | 2,3/4,2 | 58 | 45 | $${\color{red}34}$$ | 137 | 34 983 | 3,9 |
| 93 | Intel Core i5-11300H (Iris Xe G7 80EUs) | $${\color{red}35}$$- | 4/8 | 3,1/4,4 | 58 | $${\color{red}37}$$ | 41 | 136 | 92 922 | 1,5 |
| 94 | AMD Ryzen 7 5700U (Vega 8) | 25- | 8/16 | 1,8/4,3 | 49 | 48 | $${\color{red}38}$$ | 135 | 34 400 | 3,9 |
| 95 | Intel Core i5-1135G7 (Iris Xe G7 80EUs) | 28- | 4/8 | 2,4/4,2 | 57 | $${\color{red}36}$$ | 41 | 134 | 28 964 | 4,6 |
| 96 | AMD Ryzen 7 7435H () | $${\color{red}45}$$- | 8/16 | 3,1/4,5 | 65 | 66 | $${\color{red}0}$$ | 131 | 72 927 | 1,8 |
| 97 | AMD Ryzen 5 PRO 5675U (Vega 7) | 15- | 6/12 | 2,3/4,3 | 56 | 40 | $${\color{red}34}$$ | 130 | 41 688 | 3,1 |
| 98 | AMD Ryzen 7 PRO 4750U (Vega 7) | 15- | 8/16 | 1,7/4,1 | 47 | 48 | $${\color{red}34}$$ | 129 | 45 550 | 2,8 |
| 99 | Intel Core i3-1305U (UHD Graphics 64EUs) | 15- | 5/6 | 1,2/4,5 | 59 | $${\color{red}29}$$ | 40 | 128 | 32 796 | 3,9 |
| 100 | AMD Ryzen 5 5560U (Vega 6) | 25- | 6/12 | 2,3/4,0 | 54 | 46 | $${\color{red}28}$$ | 128 | 45 551 | 2,8 |
| 101 | AMD Ryzen 5 5500U (Vega 7) | 25- | 6/12 | 2,1/4,0 | 46 | 42 | $${\color{red}34}$$ | 122 | 36 628 | 3,3 |
| 102 | AMD Ryzen 5 4600H (Vega 6) | $${\color{red}45}$$- | 6/12 | 3,0/4,0 | 46 | 47 | $${\color{red}28}$$ | 121 | 32 828 | 3,7 |
| 103 | AMD Ryzen 3 7335U (Radeon 660M) | 28- | 4/8 | 3,0/4,3 | $${\color{red}36}$$ | $${\color{red}30}$$ | 48 | 114 | 36 513 | 3,1 |
| 104 | Intel Core i5-12450HX (UHD Graphics Xe 16EUs) | $${\color{red}55}$$- | 8/12 | 1,8/4,4 | $${\color{red}39}$$ | 59 | $${\color{red}12}$$ | 110 | 57 808 | 1,9 |
| 105 | Intel Core i3-1125G4 (UHD Graphics Xe G4 48EUs) | 28- | 4/8 | 2,0/3,7 | 50 | $${\color{red}29}$$ | $${\color{red}24}$$ | 103 | 79 788 | 1,3 |
| 106 | Intel Core i3-N305 (UHD Graphics Xe 750 32EUs) | 15- | 8/8 | 1,8/3,8 | 44 | $${\color{red}36}$$ | $${\color{red}22}$$ | 102 | 31 121 | 3,3 |
| 107 | AMD Ryzen 3 7330U (Vega 6) | 15- | 4/8 | 2,3/4,3 | 48 | $${\color{red}24}$$ | $${\color{red}28}$$ | 100 | 33 599 | 3,0 |
| 108 | AMD Ryzen 3 5425U (Vega 6) | 15- | 4/8 | 2,7/4,1 | 48 | $${\color{red}24}$$ | $${\color{red}28}$$ | 100 | 35 085 | 2,9 |
| 109 | Intel Core i3-1115G4 (UHD Graphics Xe G4 48EUs) | 28- | 2/4 | 3,0/4,1 | 54 | $${\color{red}20}$$ | $${\color{red}24}$$ | 98 | 29 444 | 3,3 |
| 110 | AMD Ryzen 5 7520U (Radeon 610M) | 15- | 4/8 | 2,8/4,3 | 44 | $${\color{red}30}$$ | $${\color{red}22}$$ | 96 | 27 907 | 3,4 |
| 111 | AMD Ryzen 3 7320U (Radeon 610M) | 15- | 4/8 | 2,4/4,1 | 44 | $${\color{red}30}$$ | $${\color{red}22}$$ | 96 | 28 539 | 3,4 |
| 112 | Intel Core i5-1035G1 (UHD Graphics G1) | 15- | 4/8 | 1,0/3,6 | 50 | $${\color{red}30}$$ | $${\color{red}15}$$ | 95 | 29 007 | 3,3 |
| 113 | Intel Core i5-1030NG7 (Iris Plus Graphics G7) | 10- | 4/8 | 1,1/3,5 | 45 | $${\color{red}21}$$ | $${\color{red}28}$$ | 94 | 32 360 | 2,9 |
| 114 | Intel Core i5-8259U (Iris Plus Graphics 655) | 28- | 4/8 | 2,3/3,8 | $${\color{red}39}$$ | $${\color{red}28}$$ | $${\color{red}20}$$ | 87 | 24 779 | 3,5 |
| 115 | Intel Core i5-10210U (UHD Graphics 620) | 15- | 4/8 | 1,6/4,2 | 45 | $${\color{red}29}$$ | $${\color{red}12}$$ | 86 | 73 723 | 1,2 |
| 116 | AMD Ryzen 5 3500U (Vega 8) | 15- | 4/8 | 2,1/3,7 | $${\color{red}37}$$ | $${\color{red}24}$$ | $${\color{red}24}$$ | 85 | 25 072 | 3,4 |
| 117 | Intel Core i3-1000NG4 (Iris Plus Graphics G4) | 9- | 2/4 | 1,1/3,2 | 45 | $${\color{red}16}$$ | $${\color{red}22}$$ | 83 | 26 494 | 3,1 |
| 118 | Intel Core i3-1005G1 (UHD Graphics G1) | 15- | 2/4 | 1,2/3,4 | 48 | $${\color{red}19}$$ | $${\color{red}15}$$ | 82 | 33 015 | 2,5 |
| 119 | Intel Processor N97 (UHD Graphics 24EUs) | 12- | 4/4 | 3,6 | 44 | $${\color{red}21}$$ | $${\color{red}12}$$ | 77 | 30 756 | 2,5 |
| 120 | Intel Core i3-1000G1 (UHD Graphics G1) | 9- | 2/4 | 1,1/3,2 | 45 | $${\color{red}16}$$ | $${\color{red}15}$$ | 76 | 27 491 | 2,8 |
| 121 | Intel Processor N100 (UHD Graphics 24EUs) | 6- | 4/4 | 1,0/3,4 | 41 | $${\color{red}22}$$ | $${\color{red}12}$$ | 75 | 24 142 | 3,1 |
| 122 | Intel Processor N95 (UHD Graphics Xe 16EUs) | 15- | 4/4 | 3,4 | 41 | $${\color{red}20}$$ | $${\color{red}12}$$ | 73 | 23 497 | 3,1 |
| 123 | Intel Processor N200 (UHD Graphics Xe 750 32EUs) | 6- | 4/4 | 1,0/3,7 | $${\color{red}38}$$ | $${\color{red}12}$$ | $${\color{red}22}$$ | 72 | 26 275 | 2,7 |
| 124 | Intel Core i3-10110U (UHD Graphics 620) | 15- | 2/4 | 2,1/4,1 | 41 | $${\color{red}16}$$ | $${\color{red}12}$$ | 69 | 28 621 | 2,4 |
| 125 | Intel Core i3-N300 (UHD Graphics Xe 750 32EUs) | 7- | 8/8 | 3,8 | $${\color{red}26}$$ | $${\color{red}21}$$ | $${\color{red}22}$$ | 69 | 35 721 | 1,9 |
| 126 | AMD Ryzen 3 3250U (Vega 3) | 15- | 2/4 | 2,6/3,5 | $${\color{red}34}$$ | $${\color{red}13}$$ | $${\color{red}12}$$ | 59 | 29 233 | 2,0 |
| 127 | AMD Ryzen 3 3200U (Vega 3) | 15- | 2/4 | 2,6/3,5 | $${\color{red}33}$$ | $${\color{red}13}$$ | $${\color{red}12}$$ | 58 | 24 233 | 2,4 |
| 128 | Intel Core m3-8100Y (UHD Graphics 615) | 5- | 2/4 | 1,1/3,4 | $${\color{red}35}$$ | $${\color{red}11}$$ | $${\color{red}8}$$ | 54 | 29 080 | 1,9 |
| 129 | Qualcomm Snapdragon 8cx (Adreno 680) | 7- | 8/8 | 2,8 | $${\color{red}29}$$ | $${\color{red}21}$$ | $${\color{red}0}$$ | 50 | 22 022 | 2,3 |
| 130 | Qualcomm Snapdragon 850 (Adreno 630) | 0- | 8/8 | 2,8/3,0 | $${\color{red}20}$$ | $${\color{red}15}$$ | $${\color{red}8}$$ | 43 | 36 420 | 1,2 |
| 131 | Intel Celeron N4500 (UHD Graphics) | 6- | 2/2 | 1,1/2,8 | $${\color{red}25}$$ | $${\color{red}8}$$ | $${\color{red}7}$$ | 40 | 22 812 | 1,8 |
| 132 | Intel Celeron N4020 (UHD Graphics 600) | 6-15 | 2/2 | 1,1/2,8 | $${\color{red}19}$$ | $${\color{red}6}$$ | $${\color{red}4}$$ | 29 | 16 107 | 1,8 |
| 133 | Intel Celeron N4000 (UHD Graphics 600) | 6- | 2/2 | 1,1/2,6 | $${\color{red}18}$$ | $${\color{red}6}$$ | $${\color{red}4}$$ | 28 | 18 075 | 1,5 |


# Laptop СPU rating (AI generated)
> I have only one question: why do I need a laptop if I already have one.

It is difficult to determine the processor performance by its number. A newer processor may be weaker and more expensive. The speed of a laptop is a subjective characteristic and may be related not only to the processor, but also to the SSD and memory. Another important part of the processor is the graphics core.

This article is an attempt to make a summary table from which it will be clear what characteristics the processor has and what performance it has according to tests. I am only interested in those processors with which laptops can be bought cheaply in Russia.

Test results from Cinenbench 23R Single and Multi Core, 3D Mark Time Spy. CPU sorted by Single Core Score. Only 400- USD processors with less than 100 Watt max TDP.

| <h4>CPU (iGPU)</h4> | **Core/Threads** | **Freq GHz** | **L2+L3** | **TDP** | **CB23 SC** | **CB23 MC** | **Time Spy GPU** | **Price (USD)** |
|------------------------------------|-----------|-----------|----------|-------|---------|---------|--------------|-------|
| Intel Core i7-13700H (Iris Xe 96EU)| 14(6P+8E)/20 | 2.4/5.0 | 12+24 | $${\color{red}45-95}$$ | $${\color{green}1750}$$ | $${\color{green}23000}$$ | $${\color{green}1700}$$ | $${\color{red}400}$$   |
| Intel Core i7-1360P (Iris Xe 96EU) | 12(4P+8E)/16 | 2.2/5.0 | 12+18 | 28 | $${\color{green}1750}$$  | $${\color{green}12000}$$ | $${\color{green}1800}$$  | $${\color{red}350}$$   |
| Intel Core Ultra 7 155U (Arc 4X) | 12(2P+8E)/14  | 1.7/4.8 | 12+12 | $${\color{green}15}$$ | $${\color{green}1650}$$  | 9500 | $${\color{green}2000}$$ | $${\color{red}400}$$ |
| Intel Core i7-1260P (Iris Xe 96EU) | 12(4P+8E)/16 | 2.1/4.7   | 12+18 | 28 | $${\color{green}1650}$$    | $${\color{green}11000}$$   | $${\color{green}1700}$$  | $${\color{red}320}$$   |
| AMD Ryzen 7 8845HS (780M)  | 8/16 | 3.8/5.1 | 8+16  | 35-54 | $${\color{green}1600}$$    | $${\color{green}15500}$$   | $${\color{green}3200}$$  | $${\color{red}400}$$ |
| Intel Core i5-1340P (Iris Xe 80EU) | 12(4P+8E)/16 | 1.9/4.6   | 12+18 | 28 | $${\color{green}1600}$$    | $${\color{green}10500}$$   | $${\color{green}1500}$$         | 280   |
| AMD Ryzen 7 7840HS (780M)  | 8/16 | 3.8/5.1 | 8+16  | 35-54 | $${\color{green}1580}$$    | $${\color{green}15000}$$   | $${\color{green}3000}$$ | $${\color{red}380}$$ |
| <h4 align="center">CPU (iGPU)</h4>  | **Core/Threads** | **Freq GHz** | **L2+L3** | **TDP** | **CB23 SC** | **CB23 MC** | **Time Spy GPU** | **Price (USD)** |
| AMD Ryzen 7 7735HS (680M)  | 8/16  | 3.2/4.75 | 4+16  | 35-54 | $${\color{green}1520}$$    | $${\color{green}14000}$$   | $${\color{green}2200}$$ | $${\color{red}300}$$ |
| AMD Ryzen 7 7735U (680M)  | 8/16  | 2.7/4.75 | 4+16  | 15-28 | $${\color{green}1520}$$    | $${\color{green}11500}$$   | $${\color{green}2200}$$ | $${\color{red}350}$$ |
| Intel Core i5-1240P (Iris Xe 80EU) | 12(4P+8E)/16            | 1.7/4.4   | 12+18 | 28    | $${\color{green}1500}$$    | 9500    | $${\color{green}1400}$$         | 250   |
| AMD Ryzen 7 6800H (680M)  | 8/16  | 3.2/4.7 | 4+16  | 35-45 | $${\color{green}1480}$$    | $${\color{green}13500}$$   | $${\color{green}2100}$$ | 250   |
| Intel Core i5-13500H (Iris Xe 80EU)| 12(4P+8E)/16 | 2.6/4.7   | 9+18  | $${\color{red}45-95}$$ | $${\color{green}1450}$$    | $${\color{green}16500}$$ | $${\color{green}1400}$$ | $${\color{red}300}$$ |
| AMD Ryzen 7 7730U (680M) | 8/16  | 2.0/4.5   | 4+16 | $${\color{green}15}$$  | $${\color{green}1450}$$    | $${\color{green}10000}$$    | $${\color{green}1400}$$  | 250   |
| Intel Core i7-1355U (Iris Xe 96EU) | 10(2P+8E)/12  | 1.7/5.0   | 10+12 | $${\color{green}15}$$  | $${\color{green}1450}$$    | 7500    | $${\color{green}1700}$$  | $${\color{red}300}$$   |
| <h4 align="center">CPU (iGPU)</h4>  | **Core/Threads** | **Freq GHz** | **L2+L3** | **TDP** | **CB23 SC** | **CB23 MC** | **Time Spy GPU** | **Price (USD)** |
| AMD Ryzen 5 7640HS (760M)   | 6/12  | 4.3/5.0   | 6+16  | 35-54 | $${\color{green}1420}$$    | $${\color{green}12000}$$   | $${\color{green}2700}$$  | 250   |
| AMD Ryzen 5 6600H (660M) | 6/12   | 3.3/4.5  | 3+16  | 35-45 | $${\color{green}1420}$$   | $${\color{green}11000}$$   | $${\color{green}1900}$$         | 230   |
| Intel Core i5-12500H (Iris Xe 80EU)| 12(4P+8E)/16 | 2.5/4.5| 9+18  | $${\color{red}45-95}$$ | $${\color{green}1400}$$    | $${\color{green}16000}$$   | 1300  | 200 |
| AMD Ryzen 7 5825U (Vega 8)   | 8/16   | 2.0/4.5   | 4+16  | $${\color{green}15}$$    | $${\color{green}1400}$$    | $${\color{green}10500}$$   | 1100  | $${\color{green}180}$$ |
| Intel Core i7-1255U (Iris Xe 96EU) | 10(2P+8E)/12            | 1.7/4.7   | 10+12 | $${\color{green}15}$$    | $${\color{green}1400}$$    | 7000    | 1250         | 280   |
| Intel Core Ultra 5 125U (Arc 4X)   | 10(2P+8E)/12            | 1.2/4.3   | 10+12 | $${\color{green}15}$$    | $${\color{green}1400}$$    | 8000    | 1600         | $${\color{red}320}$$   |
| AMD Ryzen 5 7535HS (Radeon 660M) | 6/12    | 3.3/4.6   | 3+16  | 35  | $${\color{green}1380}$$    | $${\color{green}10000}$$   | $${\color{green}1900}$$  | 220   |
| <h4 align="center">CPU (iGPU)</h4>  | **Core/Threads** | **Freq GHz** | **L2+L3** | **TDP** | **CB23 SC** | **CB23 MC** | **Time Spy GPU** | **Price (USD)** |
| AMD Ryzen 7 5800U (Vega 8)     | 8/16      | 1.9/4.4   | 4+16  | $${\color{green}15}$$    | $${\color{green}1350}$$    | $${\color{green}10000}$$   | 1050  | $${\color{green}160}$$ |
| Intel Core i5-1335U (Iris Xe 80EU) | 10(2P+8E)/12            | 1.3/4.6   | 10+12 | $${\color{green}15}$$    | $${\color{green}1350}$$    | 6500    | 1200         | 220   |
| Intel Core i5-13420H (UHD 48EU)| 8(4P+4E)/12  | 2.1/4.6   | 8+12  | $${\color{red}45-95}$$ | $${\color{green}1300}$$    | 9000   | 900    | 220   |
| Intel Core i5-1235U (Iris Xe 80EU) | 10(2P+8E)/12            | 1.3/4.4   | 10+12 | $${\color{green}15}$$    | $${\color{green}1300}$$    | 6000    | 1150         | 200   |
| AMD Ryzen 7 5700U (Vega 8)     | 8/16      | 1.8/4.3   | 4+8   | $${\color{green}15}$$    | $${\color{green}1250}$$    | 8500    | 1000  | $${\color{green}140}$$   |
| AMD Ryzen 5 5650U (Vega 7)     | 6/12      | 2.3/4.2   | 3+16  | $${\color{green}15}$$    | $${\color{green}1200}$$    | 7500    | 900   | $${\color{green}150}$$   |
| AMD Ryzen 7 4750U (Vega 7)     | 8/16      | 1.7/4.1   | 4+8   | $${\color{green}15}$$    | $${\color{green}1200}$$    | 9000    | 950    | $${\color{green}100}$$   |
| <h4 align="center">CPU (iGPU)</h4>  | **Core/Threads** | **Freq GHz** | **L2+L3** | **TDP** | **CB23 SC** | **CB23 MC** | **Time Spy GPU** | **Price (USD)** |
| AMD Ryzen 5 5600U (Vega 7)     | 6/12      | 2.3/4.2   | 3+16  | $${\color{green}15}$$    | $${\color{green}1150}$$    | 7000    | 850    | $${\color{green}130}$$   |
| AMD Ryzen 5 5500U (Vega 7)       | 6/12  | 2.1/4.0   | 3+8   | $${\color{green}15}$$    | $${\color{green}1100}$$    | 6500    | 800      | $${\color{green}120}$$   |
| Intel Core i3-1315U (UHD 64EU) | 6(2P+4E)/8 | 1.2/4.5   | 5+10  | $${\color{green}15}$$    | 1100     | $${\color{red}4500}$$    | 800   | $${\color{green}150}$$   |
| AMD Ryzen 5 4600H (Vega 6)     | 6/12    | 3.0/4.0   | 3+8   | 35-45 | 1000    | 7500    | 800          | $${\color{green}100}$$   |
| Intel Core i3-1215U (UHD 64EU) | 6(2P+4E)/8 | 1.2/4.4   | 5+10  | $${\color{green}15}$$    | 1000     | $${\color{red}4000}$$    | $${\color{red}750}$$      | $${\color{green}90}$$    |
| AMD Ryzen 3 7520U (610M) | 4/8 | 2.8/4.3   | 2+8   | $${\color{green}8-15}$$  | 850     | $${\color{red}4000}$$    | $${\color{red}600}$$          | $${\color{green}80}$$    |
| AMD Ryzen 3 7320U (610M) | 4/8  | 2.4/4.1   | 2+4   | $${\color{green}15}$$    | 800     | $${\color{red}3800}$$    | $${\color{red}550}$$          | $${\color{green}70}$$    |
| <h4 align="center">CPU (iGPU)</h4>  | **Core/Threads** | **Freq GHz** | **L2+L3** | **TDP** | **CB23 SC** | **CB23 MC** | **Time Spy GPU** | **Price (USD)** |
| Intel Core i5-8265U (UHD 620) | 4/8 | 1.6/3.9 | 1+6 | $${\color{green}15}$$ | 800   | $${\color{red}3500}$$ | $${\color{red}450}$$  | $${\color{green}70}$$ |
| AMD Ryzen 3 3200U (Vega 3) | 2/4 | 2.6/3.5 | 1+4 | $${\color{green}15}$$ | $${\color{red}600}$$ | $${\color{red}1800}$$ | $${\color{red}350}$$ | $${\color{green}50}$$ |
| Intel N305 (UHD 24EU) | 8/8 | 1.8/3.8 | 2+6 | $${\color{green}15}$$ | $${\color{red}550}$$ | $${\color{red}2200}$$ | $${\color{red}300}$$   | $${\color{green}40}$$ |
| Intel N300 (UHD 32EU)  | 8/8 | 1.0/3.8 | 2+6 | $${\color{green}7-15}$$ | $${\color{red}500}$$ | $${\color{red}2000}$$ | $${\color{red}350}$$ | $${\color{green}35}$$ |
| Intel N200 (UHD 24EU) | 4/4  | 1.0/3.7 | 2+6 | $${\color{green}6-15}$$ | $${\color{red}450}$$ | $${\color{red}1800}$$ | $${\color{red}250}$$ | $${\color{green}30}$$ |
| Intel N5095 (UHD 16EU) | 4/4  | 2.0/2.9 | 2+4 | $${\color{green}15}$$ | $${\color{red}450}$$ | $${\color{red}1500}$$ | $${\color{red}220}$$ | $${\color{green}30}$$ |
| Intel N95 (UHD 16EU) | 4/4  | 1.4/3.4 | 2+6 | $${\color{green}12-15}$$ | $${\color{red}420}$$ | $${\color{red}1600}$$ | $${\color{red}180}$$ | $${\color{green}20}$$ |
| <h4 align="center">CPU (iGPU)</h4>  | **Core/Threads** | **Freq GHz** | **L2+L3** | **TDP** | **CB23 SC** | **CB23 MC** | **Time Spy GPU** | **Price (USD)** |
| Intel N100 (UHD 24EU) | 4/4 | 0.8/3.4 | 2+6 | $${\color{green}6-15}$$ | $${\color{red}400}$$ | $${\color{red}1500}$$ | $${\color{red}200}$$ | $${\color{green}25}$$  |
| Intel N4500 (UHD 16EU) | 4/4 | 1.1/2.8 | 1+4 | $${\color{green}6}$$ | $${\color{red}400}$$ | $${\color{red}1200}$$ | $${\color{red}200}$$ | $${\color{green}25}$$  |
| Intel N4000 (UHD 600)| 2/2 | 1.1/2.6 | 1+4 | $${\color{green}6}$$  | $${\color{red}350}$$ | $${\color{red}1000}$$  | $${\color{red}150}$$  | $${\color{green}20}$$ |
| Intel N4020 (UHD 600)| 2/2 | 1.1/2.8  | 1+4 | $${\color{green}6}$$ | $${\color{red}350}$$  | $${\color{red}900}$$ | $${\color{red}140}$$  | $${\color{green}20}$$    |
| Intel J3710 (HD 405) | 4/4 | 1.6/2.6  | 2+2  | $${\color{green}6}$$ | $${\color{red}250}$$  | $${\color{red}800}$$ | $${\color{red}80}$$ | $${\color{green}10}$$    |

Most balanced (4 green): 5825U, 5800U, 7730U.  
Without red good cpu and gpu: 6800H, 6600H, 7640HS, 1340P, 7735HS.

## Top 10 Mobile CPU from DeepSeek
Best performance + Best GPU + Energy efficiency
1.  AMD Ryzen 7 7840U/HS (Zen 4, Radeon 780M)
1.  AMD Ryzen 7 7735U/HS (Zen 3+, Radeon 680M)
1.  Intel Core Ultra 7 155H (Meteor Lake, Arc Xe-LPG)
1.  AMD Ryzen 5 7640U/HS (Zen 4, Radeon 760M)
1.  Apple M3 (8-core GPU)
1.  AMD Ryzen 7 6800U/HS (Zen 3+, Radeon 680M)
1.  AMD Ryzen 5 7535U/HS (Zen 3+, Radeon 660M)
1.  Intel Core i7-1360P (Raptor Lake, Iris Xe 96EU)
1.  AMD Ryzen 7 5825U (Zen 3, Vega 8)
1.  AMD Ryzen 5 5625U (Zen 3, Vega 7)

## Top Mobile CPU by Total Rating (Single-Core + Multi-Core + GPU) in percents (AI Generated)

Weak processor ratings are incorrectly shown higher than they actually are.  


| #  | Processor (GPU)                     | Single-Core (%) | Multi-Core (%) | GPU | Sum  | Note Price ($) | Perf / Price |
|----|-------------------------------------|------------|----------------|---------|-----------|----------|-------------------|
| 1  | AMD Ryzen 9 7940HS (Radeon 780M)    | 98         | 98             | 95      | 291       | 1800     | 142               |
| 2  | AMD Ryzen 7 8845HS (Radeon 780M)    | 95         | 94             | 90      | 279       | 1650     | 147               |
| 3  | AMD Ryzen 7 7840HS (Radeon 780M)    | 94         | 93             | 92      | 279       | 1550     | 156               |
| 4  | AMD Ryzen 9 6900HX (Radeon 680M)    | 92         | 91             | 85      | 268       | 1700     | 137               |
| 5  | AMD Ryzen 7 7735HS (Radeon 680M)    | 91         | 90             | 80      | 261       | 1500     | 150               |
| 6 | AMD Ryzen 7 6800H (Radeon 680M)     | 90         | 89             | 82      | 261       | 1400     | 160               |
| 7  | Intel Core i9-13900H (Iris Xe 96EU) | 93         | 92             | 68      | 253       | 1850     | 119               |
| 8 | AMD Ryzen 5 7640HS (Radeon 760M)    | 87         | 86             | 75      | 248       | 1300     | 165               |
| 9 | Intel Core i7-13700H (Iris Xe 96EU) | 89         | 88             | 65      | 242       | 1600     | 132               |
| 10 | Intel Core i5-13500H (Iris Xe 80EU) | 84         | 83             | 62      | 229       | 1250     | 158               |
| 11 | AMD Ryzen 5 6600H (Radeon 660M)     | 82         | 81             | 58      | 221       | 1200     | 158               |
| 12 | AMD Ryzen 7 5800H (Radeon Vega 8)   | 88         | 87             | 45      | 220       | 1200     | 158               |
| 13 | Intel Core i5-12500H (Iris Xe 80EU) | 80         | 79             | 60      | 219       | 1100     | 170               |
| 14  | Intel Core i9-13980HX (Iris Xe 32EU)| 97         | 97             | 25      | 219       | 1950     | 98                |
| 15  | AMD Ryzen 9 7945HX (Radeon 610M)    | 100        | 100            | 18      | 218       | 1900     | 100               |
| 16 | AMD Ryzen 7 5825U (Radeon Vega 8)   | 86         | 85             | 43      | 214       | 1100     | 167               |
| 17 | Intel Core Ultra 5 125H (Arc 7EU)   | 81         | 80             | 52      | 213       | 1150     | 160               |
| 18 | AMD Ryzen 5 7535HS (Radeon 660M)    | 79         | 78             | 55      | 212       | 1050     | 172               |
| 19 | AMD Ryzen 7 5850U (Radeon Vega 8)   | 85         | 84             | 42      | 211       | 1050     | 172               |
| 20 | AMD Ryzen 9 7845HX (Radeon 610M)    | 96         | 96             | 18      | 210       | 1750     | 105               |
| 21 | AMD Ryzen 7 5800U (Radeon Vega 8)   | 83         | 82             | 40      | 205       | 1000     | 175               |
| 22 | Intel Core i3-1215U (Iris Xe 64EU)  | 77         | 76             | 45      | 198       | 900      | 190               |
| 23 | AMD Ryzen 5 5625U (Radeon Vega 7)   | 78         | 77             | 40      | 195       | 950      | 178               |
| 24 | Intel Core i3-1115G4 (Iris Xe 48EU) | 75         | 74             | 42      | 191       | 800      | 205               |
| 25 | AMD Ryzen 3 5425U (Radeon Vega 6)   | 76         | 75             | 35      | 186       | 850      | 190               |
| 26 | Intel Pentium Gold 7505 (Iris Xe 48)| 73         | 72             | 38      | 183       | 700      | 225               |
| 27 | AMD Ryzen 3 5300U (Radeon Vega 6)   | 74         | 73             | 33      | 180       | 750      | 208               |
| 28 | AMD Ryzen 7 4750U (Vega 7)          | 65         | 64             | 35      | 164       | 700      | 200               |
| 29 | AMD Ryzen 5 4600H (Vega 6)          | 67         | 66             | 30      | 163       | 650      | 215               |
| 30 | AMD Ryzen 3 3250U (Radeon Vega 3)   | 72         | 71             | 18      | 161       | 600      | 235               |
| 31 | Intel N305 (UHD Graphics)           | 71         | 70             | 15      | 156       | 550      | 245               |
| 32 | Intel N300 (UHD Graphics)           | 70         | 69             | 14      | 153       | 500      | 265               |
| 33 | Intel N100 (UHD Graphics)           | 69         | 68             | 13      | 150       | 450      | 290               |
| 34 | Intel N95 (UHD Graphics)            | 68         | 67             | 12      | 147       | 400      | 315               |
| 35 | Intel Core i3-1210U (Iris Xe 64EU)  | 54         | 53             | 40      | 147       | 600      | 210               |
| 36 | Intel Celeron N5095 (UHD Graphics)  | 66         | 65             | 14      | 145       | 350      | 355               |
| 37 | Intel Core i3-1110G4 (Iris Xe 48EU) | 53         | 52             | 38      | 143       | 550      | 225               |
| 38 | Intel Pentium Silver N6000 (UHD)    | 64         | 63             | 12      | 139       | 380      | 315               |
| 39 | Intel Celeron N5105 (UHD Graphics)  | 63         | 62             | 13      | 138       | 320      | 365               |
| 40 | Intel Pentium Gold 7505 (Iris Xe 48)| 52         | 51             | 35      | 138       | 500      | 235               |
| 41 | AMD Athlon Gold 3150U (Vega 3)      | 62         | 61             | 15      | 138       | 300      | 395               |
| 42 | Intel Celeron N4500 (UHD Graphics)  | 61         | 60             | 10      | 131       | 280      | 405               |
| 43 | Intel Pentium Silver N5030 (UHD)    | 60         | 59             | 11      | 130       | 260      | 430               |
| 44 | AMD Ryzen 3 3200U (Vega 3)          | 59         | 58             | 12      | 129       | 400      | 275               |
| 45 | Intel Celeron N4120 (UHD 600)       | 58         | 57             | 9       | 124       | 240      | 450               |
| 46 | Intel Celeron N4020 (UHD 600)       | 57         | 56             | 8       | 121       | 220      | 475               |
| 47 | Intel Celeron N4000 (UHD 600)       | 56         | 55             | 7       | 118       | 200      | 510               |
| 48 | AMD A6-9220e (Radeon R4)            | 55         | 54             | 6       | 115       | 180      | 550               |
| 49 | Intel Celeron N3350 (HD 500)        | 51         | 50             | 7       | 108       | 150      | 620               |
| 50 | AMD A4-9120 (Radeon R3)             | 50         | 49             | 5       | 104       | 130      | 680               |
| 51 | Intel Pentium N4200 (HD 505)        | 48         | 47             | 8       | 103       | 140      | 630               |
| 52 | Intel Atom x5-Z8350 (HD 400)        | 49         | 48             | 4       | 101       | 120      | 720               |
| 53 | AMD E2-9010 (Radeon R2)             | 47         | 46             | 5       | 98        | 100      | 820               |
| 54 | Intel Atom x7-Z8700 (HD 405)        | 46         | 45             | 3       | 94        | 90       | 900               |
| 55 | Intel Celeron N3060 (HD 400)        | 45         | 44             | 4       | 93        | 80       | 980               |
| 56 | Intel Atom x5-Z8300 (HD 400)        | 44         | 43             | 3       | 90        | 70       | 1100              |
| 57 | AMD E1-6010 (Radeon R2)             | 43         | 42             | 3       | 88        | 60       | 1250              |
| 58 | Intel Celeron N2840 (HD Graphics)   | 42         | 41             | 3       | 86        | 50       | 1450              |
| 59 | Intel Atom Z3735F (HD Graphics)     | 41         | 40             | 2       | 83        | 40       | 1750              |
| 60 | AMD C-60 (Radeon HD 6290)           | 40         | 39             | 2       | 81        | 30       | 2250              |
