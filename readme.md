update ->
6/4/2018 1:11:01 AM 

# 物理课期末作业---多米诺骨牌辅助系统（附小游戏） #


## 需求分析 ##

1. 老师上课演示关于多米诺骨牌的那些关于重量、大小、重心位置的实验过于浪费时间，直接放视频的话，又体现不出操作性，这个时候需要，一个可以自动生成不同大小、重量、重心位置、长度的多米诺程序，来方便教学演示。
2. 上课的时候，老师叫我们用多米诺堆一串字，往往每次只要一次失误，就要全部重头再来，这实在很痛苦好嘛，所以，需要一个可以在软件上进行多米诺骨牌的堆放的程序，如果出现失误，可以“回到上一次堆放”的状态。
3. 同时，提供自定义多米诺骨牌形状的功能，通过使用鼠标绘制一幅图像，将其解析成二维数组，然后使用深度优先搜索得到每块骨牌应该放置的位置，最后，生成一幅完整的多米诺骨牌图像。

## 功能分析 ##
1. 多米诺骨牌操作界面（UI）   √
2. 推动力的实现（顺滑自然一点的）  √
3. 自定义骨牌生成的形状（二维数组转变为多米诺骨牌  目前实现的只有四方向）√
4. 自定义骨牌生成的重量、大小（即长宽高）√
5. 一个彩蛋小游戏。


## 彩蛋游戏规划(版本一)##
进入标题界面，是一个小人跟开始物理实验（多米诺骨牌试验）的菜单按钮，等待数秒后，小人会开始在标题界面搬运多米诺骨牌，堆出的多米诺骨牌是一个开字，鼠标点击开字会蹦出“开始游戏”这几个字。  
**规则如下**：  
1. 游戏开始后，分为敌人和玩家两个小人，小人具有生命值与体力值  
2. 待着不动和行走都会逐步消耗体力（较缓慢）  
3. 小人可以拿起任何物体，并旋转它放置到指定位置（参见魔兽建造建筑）。（具有冷却时间，且消耗体力值）  
4. 小人最多可以推动<1kg的物体。（具有冷却时间，且消耗体力值）  
5. 小人可以通过堆砌多米诺骨牌推倒树木来获得食物，使用食物可以补充体力。    
6. 小人遭到物体碰撞时，生命值会减少  
7. 地图上随机产生多米诺骨牌（有些会连在一起）和障碍物    
8. 小人可以进行跳跃操作，但最多只能跳到一定的高度  
9. 体力值为0或生命值为0的一方游戏失败。  
10. 游戏目标是通过有计划的推动场景内的多米诺骨牌干翻敌人    

## 彩蛋游戏规划(版本二)##
**游戏背景**：  
一个人掉入荒岛，他需要利用物理知识（没办法。。。物理课作业。。。脑容量就这么大了，想不到什么好法子）避开或击杀岛上的野兽，并战胜饥饿的威胁，逃离这座小岛。  
在游戏中，玩家不具备任何杀伤能力，仅能推动<20kg的物体，并且拿起所有重量的多米诺骨牌，  
玩家可以通过推倒连续多米诺骨牌击杀野兽或者推倒树木获取食物，   
**规则如下**：  
1. 游戏开始后，玩家具有生命值与体力值  
2. 行走会逐步消耗体力，而站立不动可以恢复体力，体力不足20%时，无法进行奔跑行动  
3. 玩家可以拿起任何物体，并旋转它放置到指定位置（参见魔兽建造建筑）。（具有冷却时间，且消耗体力值）  
4. 玩家最多可以推动<20kg的物体。（具有冷却时间，且消耗体力值）  
5. 玩家可以通过堆砌多米诺骨牌推倒树木来获得食物，使用食物可以补充体力。
6. 玩家可以将得到的武平进行组合，比如将两块较小的多米诺骨牌合成为一块大的多米诺骨牌。    
7. 荒岛上有大量野兽，野兽具有自己的视线范围，当观察到玩家时会对玩家发起进攻，野兽在傍晚会陷入睡眠，同时，声响将会吸引野兽的注意力      
8. 地图上随机产生多米诺骨牌（有些会连在一起）和障碍物    
9. 游戏有多种胜利方式，其最终结果都为逃离小岛。  
10. 胜利方式包括（1.使用骨牌摆出SOS形状，2.使用木材制作小船逃离荒岛，3.食物储备大于x（也就是击杀岛上所有野兽或者推倒岛上所有木材））  
11. 生命值为0游戏失败。  

update -> 6/9/2018 0:09:57 AM 

## 彩蛋游戏规划(版本三)##
**游戏背景**：  
现在将游戏定义为"密室逃脱"类型的游戏，主角进入了一个密室，需要靠他的物理知识脱困。  
**规则如下**：  
1. 主角没有攻击能力，碰到任何具有杀伤能力的物体都是直接被一击必死  
2. 在任何事物面前，主角都可以使用键盘上的q键（待定），查看该物体的详细信息  
3. 使用q键同时可以触发其他事件，诸如：触发开关、拿起障碍物，推动某个物体、  
4. 游戏的最终目标是逃离密室，即到达一个固定的终点。  
5. 密室中，每个房间都有许多谜题和陷阱，需要依靠物理知识破解谜题和陷阱，到达下一个房间。   
### **关卡设计**：  
#### 第一关（要素:改变物体重心使其不会倒下）：   ####
　　有一个开关门，需要玩家斜着推开他离开房间，而开关门后面有怪物巡逻，怪物拥有视野和听觉，当开关门倒下并发出声响时，怪物会听到。正常情况下，只要玩家对开关门进行推操作，这个门都会倒下，并发出声响，吸引怪物。  
　　在这一关，玩家需要将一些重物放入开关门（中空的）中，使其重心降低，然后，再推开门的时候，门就不会倒下，而是像不倒翁一样摇摆，接着只要避开敌人的视线，就能离开这个房间。值得一提的是，在正常情况下，角色的跑步与行走不会被守卫听到，当角色拿起重物进行跑步时，会被守卫警觉。被守卫发现即游戏失败，重头开始。  
#### 第二关（要素:多米诺骨牌）：   ####
　　这是一个满是激光的房间，玩家不能直接通过房间，有一面颜色不同的墙，走进会提示玩家这墙可以推倒，但是凭玩家操纵的小人的力气无法推倒这面墙。这里需要用到在前一个房间摆放的一个个小立方体。  
　　将他们当做多米诺骨牌，按照质量从小到大的顺序摆放，利用多米诺骨牌的以小推大的特性，可以推开这面墙。
　　推开墙，进入一个密室，密室中是一些重箱子，玩家可以通过推开他们到激光处遮蔽激光，通过房间。  
#### 第三关（要素:模拟太阳系行星转动）： 
　　这个房间一进来，出口和入口都会关闭。  
　　在房间中央，放置一个模拟太阳的球体，同时其他星球也会围绕着太阳转，同时，这些球体都会对玩家释放引力（或斥力），吸引玩家到中央地带。如果释放的是斥力，玩家会被拍到墙上，而墙上有尖刺，被拍到也是死路一条。  
　　接近中央时，玩家会因为太阳的高温被杀死，同时，如果玩家被任何一个球体碰撞到，都会死亡。  
　　在每个星球差不多转3圈之后，出口打开，但球体不停止旋转，需要玩家想办法躲避球体并通过房间

update -> 6/10/2018 3:06:56 PM 

<br/>

<br/>

