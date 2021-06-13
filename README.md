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

### 2)프로그래밍 요소  
* 플레이어
  * 걷기, 달리기, 점프, 웅크리기
  * 좀비와 충돌하거나, 물에 빠졌을 때 HP 깎임
  * 좀비와 세 번 충돌 시 게임 오버
  * 스탯 - HP, Hugry, Thirsty, SP 게이지 구현  
* 카메라 무빙(1인칭 시점)
  * 상하 좌우 회전   
* 총
  * 총알 발사
  * 정조준 상태
  * 재장전

* 좀비
  * 랜덤 생성
  * 총알에 두 번 맞으면 죽음
  * 물에 닿으면 죽음

* 아이템
  * 약, 음식, 물 획득  

* 물
  * 물에 빠지면 플레이어 HP 깎임
  * 색 변화  

* 기타 게임 시스템
  * 마우스 커서 숨기기
  * 씬 전환 - start/over/clear, 마트, 약국  

### 3)순서도  
#### (1)플레이어_좀비 충돌  
![player_zombie](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTQ0/MDAxNjIzNTU3NjUzNDkx.tSK_U9U2EGGLC6Zy0t45CLyg61PIe0vygxehNkrEYNYg.bOfBFhCNt0GRtzFhCGdOMZy-ElPI467dthPKfMY-WSQg.PNG.dltoqha684/player_zombie.png)   
#### (2)좀비_공격  
![attack](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjc1/MDAxNjIzNTU3NjUzODc2.hMimM2xrwWQ1WF-UtVBZ_k4Z4VLCqprBcTKK4cSlpsEg.xob4jCba_-CxDTQ-DVF5ZJdQtRugmNja9G6m2rAUWPwg.PNG.dltoqha684/%EC%A2%80%EB%B9%84%EA%B3%B5%EA%B2%A9.png)   
#### (3)음식 섭취  
![food](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjcw/MDAxNjIzNTU3NjUzNTAy.1hFrvRS3_2IfRS5bEtJtp-mK7AeNlspQl6nJU-dlOkUg.FJFqFIOLf9P_F7oLVGfriIn-0AwyFE5IYqKibGemll0g.PNG.dltoqha684/%EC%9D%8C%EC%8B%9D%EC%84%AD%EC%B7%A8.png)   
#### (4)물 섭취  
![water](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTE0/MDAxNjIzNTU3NjUzNDky.-CGVKUs3Hoe9ygGUE_j036bCc4eoi5OaGXRGOqWHDXgg.mJSRA_dslAHUDkhIR_5sGN7uVxdNqUeOezkRLWTEzZwg.PNG.dltoqha684/%EB%AC%BC_%EC%84%AD%EC%B7%A8.png)   
#### (5)약 획득  
![potion](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTUz/MDAxNjIzNTU3NjUzNTAy.FM7eRHcw9yqpez65T1S-e5mP0BMPTICbtG8Me0ulAHYg.vxTpCcdvHVTfS_RUzLgafgXhmEH2mrekDhxHNwDQ_GYg.PNG.dltoqha684/%EC%95%BD_%ED%9A%8D%EB%93%9D.png)   
#### (6)좀비_물  
![zombie_water](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTU0/MDAxNjIzNTU3NjUzNTA1.kuzvqs3RzgDQLCkjJapFQCOWs_0kjiE2-dRDaF3f5EUg.aUOjKi9FnUm6chMXpDNvW9N5bk7VqvgumLkEPgzV9Qwg.PNG.dltoqha684/%EC%A2%80%EB%B9%84_%EB%AC%BC.png)   
#### (7)개임 클리어  
![gameclear](https://blogfiles.pstatic.net/MjAyMTA2MTNfNzcg/MDAxNjIzNTU3NjUzOTAw.nhmTJcrPCziu2-OL0wCnp_aQQDo-sHYQDTnB33OehRIg.LHUr2vcuDboOr1Fa_7DhjNIyyxHp3vsySY_sbgImxvEg.PNG.dltoqha684/%ED%81%B4%EB%A6%AC%EC%96%B4.png)   
#### (8)플레이어_물에 빠졌을 때  
![drawn](https://blogfiles.pstatic.net/MjAyMTA2MTNfOTgg/MDAxNjIzNTU3NjUzNDk0.EfeP4Uzs0tvfUO78aBZfFkTb0B3W5MMUvhSAJsLvDygg.1x0R_T5pywF092AdWihcK00-Lf29Ge6uKHBAE2osWr8g.PNG.dltoqha684/%EB%AC%BC%EC%97%90%EB%B9%A0%EC%A1%8C%EC%9D%84%EB%95%8C.png)   

### 4)소스 코드  
GitHub 업로드 파일로 대체  

### 5)게임 완성  
(1)게임 클리어    
![day](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjM3/MDAxNjIzNTU4MzQ1NjE3.qDTUZPVm3Qm5sv57DFyNf7e2WUY0QQV_t-Ec8xtrvqkg.IxDYlXrRPl7crGw_ewN3pUOQSaXna98c9gQBpSP3Gowg.PNG.dltoqha684/%EB%82%AE.png) ![sunset](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTE1/MDAxNjIzNTU4MzEwMjA0.dtq4-bpaPiFhSzstghGyNBh_ORsYZ58DdIBMyCz3DDkg.F_3CSJv0S4NA5m2lg6Y0iThC_htdDzggRpyp-xM7Caog.PNG.dltoqha684/%EB%85%B8%EC%9D%84.png) ![night](https://postfiles.pstatic.net/MjAyMTA2MTNfMjI3/MDAxNjIzNTU4MzEwMjAy.vM21Qq8H1dMjo-NX1LWMvNqVIG5c_23Asi15G3J7inQg.R6-ub2aLZGk1MjW2ig7Ot5nnc6ocoaWGojz8CSlPEGYg.PNG.dltoqha684/%EB%B0%A4.png?type=w966)  
* 낮~밤 변화  

![play](https://blogfiles.pstatic.net/MjAyMTA2MTNfNTIg/MDAxNjIzNTU4MzcxMDk5.UES8U5Y7ZMkwjmTNFeJ6viYrzHjNeIwp_2cC01BOjxAg.A8vYbap62hQOuWDQy9b0gmhKjbQnTQFLa2p1DxpLcWEg.PNG.dltoqha684/%EC%99%84%EC%84%B12.png)  
* 처음 Hugry, Thirsty 게이지는 0  
* 마우스 움직임으로 캐릭터 시점 이동(상하 좌우)  
* 스페이스바를 누르면 점프  
* 컨트롤 키를 누르면 웅크리기 모드(다시 누르면 원상태로 돌아옴)  
* 쉬프트 키를 누르면 달리기 모드  

![attack](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTk1/MDAxNjIzNTU4MzkzODkw.lH-CScGeSkbV0ADhrjUgbZwmwjRaNRt9m59MBPG69qAg.9BmpwzklSvpRpfNWwT-1Tr_IcuLfiNQwOSDVnq8JfQsg.PNG.dltoqha684/%EC%99%84%EC%84%B13.png)  
* 좀비에게 공격당할 시 HP 게이지 깎임  

![gun](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTg4/MDAxNjIzNTU4NDE3NDgy.Z1XSko1mtPuTg6NPnQi7CgABdhYznA5QJQSvOHoULqYg.X0_-Xha71pcNvuARwpDSOxl5V9wvEkRo1WBR4PnfOIcg.PNG.dltoqha684/%EC%99%84%EC%84%B15.png) ![fine](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTYg/MDAxNjIzNTU4MjM1Mzgy.Fi_93Hxgt5qJSsYY0qlbrKgK-VxT7lGpgGNeDRAq33Ug.b7XfMKM9eVt4s3Weq6O6W4aXTh0Vzn3cMiSlAqg60EQg.PNG.dltoqha684/%EC%99%84%EC%84%B16.png)  
* R 키를 누르면 정조준 상태로 전환  
* 마우스 왼쪽 버튼을 클릭하면 이펙트와 함께 총알 발사  
* 좀비가 총알에 두 번 맞을 시 사망  

![mart](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTk2/MDAxNjIzNTU4MjM1NDIy.Y71WgtQCUAFBvsfQYqqTyjSPfHmaGzazvX_4TysA_uUg.7kqVkL5CXrdIZl0Fb4dBF4PX4DnhP01S7_VDySdA_yYg.PNG.dltoqha684/%EC%99%84%EC%84%B17.png)  
* 마트  

![food1](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjkw/MDAxNjIzNTU4MjM1Mzk3.PKGBVr_HD1xm9gL-6WBGfl0gW56spNWL45nwSwmJ3zYg.XaLBsrovz69TiY4-rnFcneiFYqTItk9VQzNwGlZzKTYg.PNG.dltoqha684/%EC%99%84%EC%84%B18.png)  

![food2](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTUy/MDAxNjIzNTU4MjM1MzQ3.IK0LqIS0siK9NFHVk7vZ7l3QScaiuLayl8sEkED0Okgg.6ZC81kiKj6bO4iqs_esGST25WlAg8nH0aycIe1DsoL8g.PNG.dltoqha684/%EC%99%84%EC%84%B19.png) ![food3](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjUz/MDAxNjIzNTU4MjM1NDE1.UDRfueVQNbJAD546cr8Ii2Jd685B5altbx4LXX7oPlgg.25We0R6iY5kx5Zr-vbbnC4DfVM7Dd9Qssfnk1eM0Ekkg.PNG.dltoqha684/%EC%99%84%EC%84%B110.png)  
* 음식을 섭취하면 Hungry 게이지 채워짐  

![pharmacy](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTM1/MDAxNjIzNTU4MjM1NDQ2.ijDOfXdDc6zFXI8ZGg4ysDsHGNVaewcHYpfJxEPpZtMg.IlNc6t-AtFELzKsEQUcMFMacgmaXsyoT8LLypTbOvVQg.PNG.dltoqha684/%EC%99%84%EC%84%B111.png)  
* 약국  
![potion](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjcw/MDAxNjIzNTU4MjM1NTYx.u1D8JI_i94ovQBMmM6PboGJz0F5U50HRENeUhz6GWocg.5dldl3mXHJiy3gEgl1FQhXPFn6B1jDtk7RGPabk1ZCAg.PNG.dltoqha684/%EC%99%84%EC%84%B112.png)  
![potion2](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjA1/MDAxNjIzNTU4MjM1NjYw.w2hAxkw-6rAEf7nF3iuFIQf9nItie8ekW7ASUx0c01Ug.x5Ve69EEnt5NrRsjGKK2Acf__h5IVobMsmCcA8RoRawg.PNG.dltoqha684/%EC%99%84%EC%84%B113.png)  
* 약 아이템을 먹으면 HP 게이지가 회복됨  

![waterItem](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjky/MDAxNjIzNTU4MjM1NzAx.R29qRlVCoL1dsYG_eViLvnqM4Yg9o7btJiaEED30Z9gg.FcAk1bpcIQVASjFiSdtXQt-CmIa6F64BYkZoP_hvtcIg.PNG.dltoqha684/%EC%99%84%EC%84%B115.png)  
* 물을 구하기 위해 호수로 이동  

![waterItem2](https://blogfiles.pstatic.net/MjAyMTA2MTNfMzkg/MDAxNjIzNTU4MjM1NjQ4.HoNjyIlWRAYFRazjzqI7KNFc6WMy8OJ9mip_hijPshog.N53-nMrRYbMe-04efpkniaC6EjlKXnTbpcAB8D3b3tYg.PNG.dltoqha684/%EC%99%84%EC%84%B116.png) ![waterItem3](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjE0/MDAxNjIzNTU4MjM1Njk4.Rtb2cqCt-gRJja9QnAN1rkxcTgrBEE0GLnQMEFk854Ig._bSBSNNwuwcKq6Q9zLw1nH6ffeAeUNgXTMHlSV7UDM8g.PNG.dltoqha684/%EC%99%84%EC%84%B117.png)    
* 물을 섭취하면 Thirsty 게이지가 채워짐  

![drawn](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjgg/MDAxNjIzNTU4MjM1ODI0.I-W_hrgtPa1iANp2r-Kilj7dOli_AtxH3PNxkw3jN7Yg.Z3-m67njnPp5MgFL7ZJxKl6iFlCu4_xa_qTmodxk5qMg.PNG.dltoqha684/%EC%99%84%EC%84%B118.png)  
* 물에 빠지면 HP 게이지가 천천히 줄어듦  

![basecamp](https://blogfiles.pstatic.net/MjAyMTA2MTNfMjc0/MDAxNjIzNTU4MjM1ODMz.Y7Zndd2tbMR4IGfrGFkMEJOeC5bJu7Z3msWYM3l0zlQg.0wpMGDlxT_qwSeWzOOVg_3QK69n0mqykQYK_1xXHFBIg.PNG.dltoqha684/%EC%99%84%EC%84%B119.png)  
![basecamp2](https://blogfiles.pstatic.net/MjAyMTA2MTNfMSAg/MDAxNjIzNTU4MjM1ODg5.ydhXhGSloElcs9-HKWzrpBCBRWtwLJZymzI6PHpbafQg.ul5bsCfT6zCHG20GD4VQhwUq2MROkfdAdeUinIDe8-4g.PNG.dltoqha684/%EC%99%84%EC%84%B120.png) ![basecamp](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTM1/MDAxNjIzNTU4MjM1ODgx.bE6TBUuGwGO_s-p2Tvqtnyc_21KpAdUg_8kV52N7LnMg.yIlDzh2vl_4iKUTMHBb_SRbP4U_X3CbORwOYNGC5FBog.PNG.dltoqha684/%EC%99%84%EC%84%B121.png)  
* 안전하게 베이스 캠프에 들어가면 게임 클리어  

<게임 오버>  
![over](https://blogfiles.pstatic.net/MjAyMTA2MTNfMTY5/MDAxNjIzNTU4MjM1OTI2.pLyDmW5nFgD7XQuOvfR1cJFBvicQf_zBuLjXyMCq0Asg.axSavA57YuJQSAV1hjJW16J6zN4p9uz0_p8qYiRTL0Mg.PNG.dltoqha684/%EC%99%84%EC%84%B122.png)  
* 좀비에게 세 번 공격 받으면 바로 게임 오버  
* HP 게이지가 0이 되면 게임 오버  
* 마우스 왼쪽 버튼 클릭 시 시작 씬으로 전환되며 재시작할 수 있음  










 
