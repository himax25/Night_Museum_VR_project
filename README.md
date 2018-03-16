# Udacity VR: 5th project - Night_Museum
This is 5th project for Udacity's VR Nanodegree. This mobile virtual reality experience with the topic 
of 'Space' obtained the basic idea and knowledge from the VR application company such as FUERO Games 
company with Samsung VR. Base on the research on VR companies and applications, the main theme of my 
Night Museum VR project is Hologram based VR experience to get educational knowledge from Solar System.
![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/Screenshot_Museum.png)

## Night Museum: providing 5 kind topics based information booths with VR.
This is an Aerospace Museum consists of 5 kinds of topic-based stations. Each station provides some educational
information regarding 8 planets in the Solar syetem. 
![youtubelink](https://github.com/himax25/Night_Museum_VR_project/blob/master/VR_YouTubu.JPG)[For playing Youtubu video here](https://youtu.be/g_r-LVPNa4I)

# Design and Development
## Persona: a typical user
I assume the target audience of this museum VR user, as the followings:
* **Hilary Lee**, 12, a Girl, Middle School student.
> Hilary is very excited to play a mobile game at these days.Especially she loves to learn something from VR. 
  She thinks it is easy to understand something both none-visual and untouchable stuff related information thru 
  VR clearly sometimes.
  
## Each station layout with UI sketches
There are 5 stations in the Museum. I initially designed each station with the following layout order: 
* Station 1. **Solar System**
* Station 2. **Satellite with EARTH**
* Station 3. **Space Shuttle**
* Station 4. **Project MARS**
* Station 5. **Cinema Hole**

![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/Design_Rev1.jpg)

During building up Solar System's animation, such animation was too big to fit into the station 1 layout in 
the Museum. I revised the initial design with enhanced the layout with the order of each station as the followings:
* Station 1. **Satellite with EARTH**
* Station 2. **Space Shuttle**
* Station 3. **Project MARS**
* Station 4. **Cinema Hole**
* Station 5. **Solar System**, The animation will perform at the sky of the station 5.

![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/Design_Rev2.jpg)

## Story of this process
The user is able to move around any station in the Aerospace Museum by following waypoints. These waypoints take 
the user to move from a station to another station after watching videoes. The user is able to play and pause 
any video by clicking on the screen at each station.

# User testing, feedbacking and changes
## User testing for this VR Museum navigation
I asked the 1st user to play this VR Museum and get some feedback from the user after trying this VR.
* **Feedback:** the user had unexpected media playing in the middle of movement with waypoints.
* **Enhancing:** I found there is the wrong mechanism of detection Raycaster with the anti-blocking 3D object. I have updated Bocking Object value in Graphic Raycaster at all media playing Canvas  from "None" to "Three D" as the following: 

![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/update1.JPG)

# Breakdown of each station
## Station 1. **Satellite with EARTH**
There is a Satellite showcase with a media to play in the Station 1. The user is able to play and pause the media anytime.
* The name of video is "NASA Earth Observing Feet" from NASA. [here](https://svs.gsfc.nasa.gov/4274)
> ![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/ss1.JPG)

There is a screenshot poster with audio narration contents at the across the Station 1 entrance regarding the information of VR application. The user is able to listen to the narration by clicking on the poster.
This company, Privy.com, provides Visualization experience with VR application. 
> ![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/VR_company1.JPG)

## Station 2. **Space Shuttle**
There is a Space Shuttle animation showcase with a media to play in the Station 2. The user is able to play and pause the media anytime.
* The name of video is "Space Ship" from NASA. [here](http://www.esa.int/spaceinvideos/Videos/2011/07/STS-135_Space_Shuttle_Launch)
> ![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/st2.JPG)

## Station 3. **Project MARS**
There is a MARS ground scene with a media to play in the Station 3. The user is able to play and pause the media anytime.
* The name of video is "Mars Science Laboratory Mission Animation" from NASA.[here](https://www.jpl.nasa.gov/video/details.php?id=979)
> ![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/st3.JPG)

## Station 4. **Cinema Hole**
There is a Theater Scene with a media to play in the Station 4. The user is able to play and pause the media anytime.
* The name of video is Cinema Space Tribute" short movie. [here](https://vimeo.com/113142476)
> ![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/st4.JPG)

## Station 5. **Solar System**
There is a Space Scene with media to play in the the Station 5. There is another Solar System animation at the sky of the station.
* The name of video is "Solar System 101" from National Geographic. [here](https://mobwona.mobi/video/solar-system-101-national-geographic/libKVRa01L8)
> ![screenshut](https://github.com/himax25/Night_Museum_VR_project/blob/master/st5.JPG)

# Conclusion
This VR Museum consists of several videos and some Unity-particle effect based animation to demonstrate how to use VR in the education industry. It will be a nice VR educational material if there is a plug-in function for 3D VR based internet browser with this VR tool later. 

## Next steps
The 2nd edition of this VR Museum will have 360 VR View station to be added.

## **Author of this coding**
* Hyo Lee, linkedin [here](https://www.linkedin.com/in/hyo-max-lee-61241b13/)
* Unity 2017.2.0f3, GVR Unity SDK v1.60.0
* March 13, 2018.
