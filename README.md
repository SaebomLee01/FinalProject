## 모바일 콘텐츠 기말 프로젝트           
# <NON-Fiction 좀비 게임>
문화테크노학과 20190262 정지영 20190677 이새봄

## 1. 기획 배경  
지금까지 배웠던 유니티 프로그램의 기능과 코딩을 활용하여 서바이벌 생존 게임을 제작하고자 함. 좀비를 주제로 하였으나 음산한 분위기보다는 실제 도시 느낌을 살려 제작하여 현실감을 느낄 수 있고 다양한 연령층이 플레이할 수 있도록 하였음.

## 2. 게임 개요  
**개발 환경:** 유니티 3D  
**설치 환경:** Window  
**사용 라이브러리:** 에셋 스토어 프리 에셋, 참조 강좌 첨부파일, 직접 제작 이미지  
**라이센스:** 개인  
**게임 기능**   
* 방향키를 이용한 캐릭터 이동-걷기, 달리기
* 점프
* 웅크리기
* 아이템 획득
* 총 발사
* 총 정조준 
* 재장전
* 플레이어 스탯(HP, Hungry, Thirsty, SP)구현
* 낮과 밤 전환
* 좀비 랜덤 생성
* 물에 빠졌을 때

## 3. 시나리오  
### 1)스토리  
평화로웠던 평화 도시에 좀비 떼가 우르르 몰려왔어요. 낮과 밤에 활동하는 좀비들로 인해 도시는 일상생활이 마비되었고 주민들은 좀비와 마주치지 않으려 벌벌 떨면서 생활하고 있어요. 주민들은 좀비들의 위협을 무릅쓰고 물과 식량을 직접 구해야 해요. 과연 그들은 좀비로부터 안전한 베이스캠프에 무사히 도착할 수 있을까요?

### 2)좀비 특징  
![zombie](https://postfiles.pstatic.net/MjAyMTA2MTNfMTY3/MDAxNjIzNTU1OTM1MzM5.jvOGzcL4pAiiKTnPAAXfr4DD49_40oKplbmlsDJJczEg.iTssFPxS3sh6ApDWZ4AHVz6HNsgl6SmXZZcC0hoQhO4g.PNG.dltoqha684/zombie.png?type=w966)  
* 물에 한 번 닿으면 바로 죽기 때문에 물을 싫어함
* 총에 맞으면 한 번에 죽지 않고 두 번 공격 당해야 죽음 
* 낮과 밤 모두 활동

### 3)도시 특징  
![city](https://postfiles.pstatic.net/MjAyMTA2MTNfMTk5/MDAxNjIzNTU1Mzc0OTM1.MZn5fNEpk4KQN4CL45oEy_mYF0cjtIRoHOTWOsPDeBQg.kZZ0N1e1uHDfnTGeosg1KS7T0LWyzuxBPmqH533Jhicg.PNG.dltoqha684/city.png?type=w966)  
* 마트나 약국 등 생활용품을 구할 수 있는 곳이 한정적임 
* 도시 안에 물을 구할 수 있는 호수가 있음
* 좀비로부터 안전한 베이스캠프가 인근에 위치함  

### 4)플레이어 특징  
![player](https://blogfiles.pstatic.net/MjAyMTA2MTNfNTAg/MDAxNjIzNTU1OTM1MzM0.58uu2kWA6qc3vLHmYWqHaCKav13aTZ02SMtELs7R-gwg.Prz25Omh17XvzCcl3sQwU_FMfskizFibcM-7bDgbiesg.PNG.dltoqha684/player.png)  
* 좀비에게 공격을 당할 시 HP가 줄어들고 약을 먹으면 회복이 가능함
* 다만, 좀비에 세 번 이상 공격당할 시 바로 죽음 
* 물에 빠졌을 때, HP가 천천히 줄어듦
* 스탯-HP, Hungry, Thirsty, SP 게이지를 지니고 있음  

## 4. 게임 제작 과정  
### 1)콘텐츠 리소스  
<Asset Store Free Asset & 참조 강좌에서 다운>
1) 캐릭터 – 플레이어, 좀비 2) 도시 3) 물 4) 마트
5) 식량 6) 약국 7) 약 포지션 8) HP, Hungry, Thirsty, SP 이미지 10) 총

<SCENE 제작>
1) GAME START SCENE    
![start](https://blogfiles.pstatic.net/MjAyMTA2MTNfOTUg/MDAxNjIzNTU1OTM1MzAy.73OIS_NlW4u8BTi1thXzzhJEdp4a-6SaPEm3W6o5hGog.-O5EoAB234ab2pLdPonSs9jWqUV0g9e8QiQp2Jnzxygg.PNG.dltoqha684/start.png)    
2) GAME OVER SCENE  
![over](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjM1/MDAxNjIzNTU1OTM1Mjk3.g_gwHFmqw-9ygubQGIjdtgGb_diyJKtzmdIdFXdTO88g.Dm2-0spdlxhghoSWTSP9dkbeYb7nJ6e7A_LDcOPO5ZEg.PNG.dltoqha684/over.png)    
3) GAME CLEAR SCENE    
![clear](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjAg/MDAxNjIzNTU1OTM1Mjk3.NpAKQyQGRbbO2kiq5cn-xUkJ81txO-xFTCPHiu1rB_wg.fjHBUEWXrVeS0iBShuG_3BRFFOoUVibkuqTTzOTDtF4g.PNG.dltoqha684/clear.png)    

<>


 
