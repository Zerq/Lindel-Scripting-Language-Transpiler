





namespace Codegen
{


   


    public class Vector { }
    public class Rotation { }
 

    public class Math {

        public static int llAbs(int val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llAcos(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llAsin(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llAtan2(float y, float x)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llSqrt(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llCeil(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llLog(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llLog10(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llListStatistics(int operation, List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llRound(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llFabs(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llFloor(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llFrand(float mag)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llPow(float baze, float exponent)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llModPow(int a, int b, int c)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llCos(float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llSin(float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class List {

        public static string llDumpList2string(List src, string separator)
        {
            throw new System.NotImplementedException("placeholder");
        }



        public static List llCSV2List(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llList2CSV(List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llList2float(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llList2int(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llList2Json(string type, List values)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llList2Key(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llList2List(List src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llList2ListStrided(List src, int start, int end, int stride)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llList2Rot(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llList2string(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llList2Vector(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }

    public class Land {
        public static void llAllowInventoryDrop(int add)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llAddToLandBanList(Key avatar, float hours)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llAddToLandPassList(Key avatar, float hours)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTeleportAgent(Key avatar, string landmark, Vector position, Vector look_at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llResetLandBanList()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llResetLandPassList()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoveFromLandBanList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoveFromLandPassList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llModifyLand(int action, int brush)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llEjectFromLand(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetLandOwnerAt(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llOverMyLand(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llWater(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llWind(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llCloud(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llEdgeOfWorld(Vector pos, Vector dir)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }

    public class Sound
    {
        public static void llPlaySound(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPlaySoundSlave(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPreloadSound(string sound)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llAdjustSoundVolume(float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCollisionSound(string impact_sound, float impact_volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLoopSound(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLoopSoundMaster(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLoopSoundSlave(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetSoundQueueing(int queue)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetSoundRadius(float radius)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSound(string sound, float volume, int queue, int loop)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSoundPreload(string sound)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopSound()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTriggerSound(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTriggerSoundLimited(string sound, float volume, Vector top_north_east, Vector bottom_south_west)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Communication
    {
        public static string llEscapeURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llListen(int channel, string name, Key id, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llWhisper(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llEmail(string address, string subject, string message)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSay(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llShout(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRegionSay(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRegionSayTo(Key target, int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llOwnerSay(string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llCloseRemoteDataChannel(Key channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llDialog(Key avatar, string message, List buttons, int channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llOpenRemoteDataChannel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoteDataReply(Key channel, Key message_id, string sdata, int idata)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llSendRemoteData(Key channel, string dest, int idata, string sdata)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTextBox(Key avatar, string message, int channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Base64 {
        public static int llBase64Toint(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llBase64Tostring(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llintToBase64(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llstringToBase64(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llXorBase64(string str1, string str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llXorBase64strings(string str1, string str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llXorBase64stringsCorrect(string str1, string str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Spacial {
        public static float llAngleBetween(Rotation a, Rotation b)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llEuler2Rot(Vector v)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llAxes2Rot(Vector fwd, Vector left, Vector up)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llAxisAngle2Rot(Vector axis, float angle)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetLocalPos()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llGetLocalRot()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetPos()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetRootPosition()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llGetRootRotation()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llGetRot()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetScale()
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Key {
        public static Key llGetOwner()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetOwnerKey(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetInventoryCreator(string item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetInventoryKey(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetPermissionsKey()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetCreator()
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static Key llGetKey()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGenerateKey()
        {
            throw new System.NotImplementedException("placeholder");
        }

    }
    public class Inventory {
        public static void llSetInventoryPermMask(string item, int category, int value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRezAtRoot(string inventory, Vector position, Vector velocity, Rotation rot, int param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRezObject(string inventory, Vector pos, Vector vel, Rotation rot, int param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llRequestInventoryData(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoveInventory(string item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGiveInventory(Key destination, string inventory)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGiveInventoryList(Key target, string folder, List inventory)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGodLikeRezObject(Key inventory, Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGiveMoney(Key destination, int amount)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetInventoryName(int type, int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetInventoryNumber(int type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetInventoryPermMask(string item, int category)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetInventoryType(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }
    public class Physics {
        public static void llApplyImpulse(Vector momentum, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llApplyRotationalImpulse(Vector force, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCollisionFilter(string name, Key id, int accept)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCollisionSprite(string impact_sprite)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetAccel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetBoundingBox(Key obj3ct)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Permission {
        public static int llGetPermissions()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRequestPermissions(Key agent, int permissions)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRequestExperiencePermissions(Key agent, string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Agent {
        public static int llAgentInExperience(Key agent)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetAgentInfo(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetAgentLanguage(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetAgentList(int scope, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetAgentSize(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetRegionAgentCount()
        {
            throw new System.NotImplementedException("placeholder");
        }   
        public static Key llRequestAgentData(Key id, int data)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTeleportAgentGlobalCoords(Key agent, Vector global_coordinates, Vector region_coordinates, Vector look_at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTeleportAgentHome(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }
    public class Detection {
        public static Key llDetectedOwner(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llDetectedKey(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llVolumeDetect(int detect)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedGrab(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llDetectedGroup(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llDetectedLinkNumber(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llDetectedName(int item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedPos(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llDetectedRot(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchBinormal(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llDetectedTouchFace(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchNormal(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchPos(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchST(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchUV(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llDetectedType(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedVel(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }
    public  class Misc
    {
 
        public static void llAttachToAvatar(int attach_point)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llAttachToAvatarTemp(int attach_point)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llAvatarOnLinkSitTarget(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llAvatarOnSitTarget()
        {
            throw new System.NotImplementedException("placeholder");
        }   
        public static void llBreakAllLinks()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llBreakLink(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llCastRay(Vector start, Vector end, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }    
        public static void llClearCameraParams()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llClearLinkMedia(int link, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llClearPrimMedia(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llCreateCharacter(List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llCreateKeyValue(string k, string v)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCreateLink(Key target, int parent)
        {
            throw new System.NotImplementedException("placeholder");
        }
   
        public static Key llDataSizeKeyValue()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llDeleteCharacter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llDeleteKeyValue(string k)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llDeleteSubList(List src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llDeleteSubstring(string src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llDetachFromAvatar()
        {
            throw new System.NotImplementedException("placeholder");
        }
     

        public static void llDie()
        {
            throw new System.NotImplementedException("placeholder");
        }
      
   
        
        public static void llEvade(Key target, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llExecCharacterCmd(int command, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llFleeFrom(Vector position, float distance, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static void llForceMouselook(int mouselook)
        {
            throw new System.NotImplementedException("placeholder");
        }

     

        public static float llGetAlpha(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetAndResetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetAnimation(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetAnimationList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetAnimationOverride(string anim_state)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetAttached()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetAttachedList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static Vector llGetCameraPos()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llGetCameraRot()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetCenterOfMass()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetClosestNavPoint(Vector point, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetColor(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static string llGetDate()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetDisplayName(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetEnergy()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetEnv(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetExperienceDetails(Key experience_id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetExperienceErrorMessage(int error)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetForce()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetFreeMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetFreeURLs()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetGeometricCenter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetGMTclock()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetHTTPHeader(Key request_id, string header)
        {
            throw new System.NotImplementedException("placeholder");
        }


        public static Key llGetLinkKey(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetLinkMedia(int link, int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetLinkName(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetLinkNumber()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetLinkNumberOfSides(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetListEntryType(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetListLength(List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
       
        public static float llGetMass()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetMassMKS()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetMaxScaleFactor()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetMemoryLimit()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetMinScaleFactor()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGetNextEmail(string address, string subject)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetNotecardLine(string name, int line)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetNumberOfNotecardLines(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetNumberOfPrims()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetNumberOfSides()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetObjectDesc()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetObjectDetails(Key id, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetObjectMass(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetObjectName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetObjectPermMask(int category)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetObjectPrimCount(Key prim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetOmega()
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static List llGetParcelDetails(Vector pos, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetParcelFlags(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetParcelMaxPrims(Vector pos, int sim_wide)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetParcelMusicURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetParcelPrimCount(Vector pos, int category, int sim_wide)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetParcelPrimOwners(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
   
        public static List llGetPhysicsMaterial()
        {
            throw new System.NotImplementedException("placeholder");
        }
        
        public static List llGetPrimMediaParams(int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
   
        public static Vector llGetRegionCorner()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetRegionFlags()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetRegionFPS()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetRegionName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetRegionTimeDilation()
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static string llGetScriptName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetScriptState(string script)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetSimStats(int stat_type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetSimulatorHostname()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetSPMaxMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetStartParameter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetStaticPath(Vector start, Vector end, float radius, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetStatus(int status)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetSubstring(string src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetSunDirection()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetTexture(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetTextureOffset(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetTextureRot(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetTextureScale(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetTimeOfDay()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetTimestamp()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetTorque()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetUnixTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llGetUsedMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llGetUsername(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetVel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llGetWallclock()
        {
            throw new System.NotImplementedException("placeholder");
        }
        
        public static float llGround(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGroundContour(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGroundNormal(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGroundRepel(float height, int water, float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGroundSlope(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llHTTPRequest(string url, List parameters, string body)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llHTTPResponse(Key request_id, int status, string body)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llInsertstring(string dst, int pos, string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llInstantMessage(Key user, string message)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static List llJson2List(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llJsonGetValue(string json, List specifiers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llJsonSetValue(string json, List specifiers, string value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llJsonValueType(string json, List specifiers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llKey2Name(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llKeyCountKeyValue()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llKeysKeyValue(int first, int count)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLinkSitTarget(int link, Vector offset, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static void llListenControl(int handle, int active)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llListenRemove(int handle)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llListFindList(List src, List test)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListInsertList(List dest, List src, int start)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListRandomize(List src, int stride)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListReplaceList(List dest, List src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListSort(List src, int stride, int ascending)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llLoadURL(Key avatar, string message, string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llLookAt(Vector target, float strength, float damping)
        {
            throw new System.NotImplementedException("placeholder");
        }
       
        public static void llMakeExplosion(int particles, float scale, float vel, float lifetime, float arc, string texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMakeFire(int particles, float scale, float vel, float lifetime, float arc, string texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMakeFountain(int particles, float scale, float vel, float lifetime, float arc, int bounce, string texture, Vector offset, float bounce_offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMakeSmoke(int particles, float scale, float vel, float lifetime, float arc, string texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llManageEstateAccess(int action, Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMapDestination(string simname, Vector pos, Vector look_at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llMD5string(string src, int nonce)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMessageLinked(int link, int num, string str, Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMinEventDelay(float delay)
        {
            throw new System.NotImplementedException("placeholder");
        }
   

        public static void llMoveToTarget(Vector target, float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llNavigateTo(Vector pos, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llOffsetTexture(float u, float v, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llParcelMediaCommandList(List commandList)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llParcelMediaQuery(List query)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llParsestring2List(string src, List separators, List spacers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llParsestringKeepNulls(string src, List separators, List spacers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPassCollisions(int pass)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPassTouches(int pass)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPatrolPoints(List patrolPoints, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static void llPointAt(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llPursue(Key target, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPushObject(Key target, Vector impulse, Vector ang_impulse, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llReadKeyValue(string k)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRefreshPrimURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static void llReleaseCamera(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llReleaseControls()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llReleaseURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
  
        public static void llRemoteDataSetRegion()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoteLoadScript(Key target, string name, int running, int start_param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoteLoadScriptPin(Key target, string name, int pin, int running, int start_param)
        {
            throw new System.NotImplementedException("placeholder");
        }

     
        public static void llRemoveVehicleFlags(int flags)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static Key llRequestDisplayName(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
       

       
        public static Key llRequestSecureURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llRequestSimulatorData(string region, int data)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llRequestURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llRequestUsername(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llResetAnimationOverride(string anim_state)
        {
            throw new System.NotImplementedException("placeholder");
        }
      


        public static void llResetOtherScript(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llResetScript()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llResetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llReturnObjectsByID(List objects)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llReturnObjectsByOwner(Key owner, int scope)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static float llRot2Angle(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llRot2Axis(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llRot2Euler(Rotation quat)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llRot2Fwd(Rotation q)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llRot2Left(Rotation q)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llRot2Up(Rotation q)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRotateTexture(float angle, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llRotBetween(Vector start, Vector end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRotLookAt(Rotation target_direction, float strength, float damping)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llRotTarget(Rotation rot, float error)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRotTargetRemove(int handle)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static int llSameGroup(Key uuid)
        {
            throw new System.NotImplementedException("placeholder");
        }
       
        public static int llScaleByFactor(float scaling_factor)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llScaleTexture(float u, float v, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llScriptDanger(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llScriptProfiler(int flags)
        {
            throw new System.NotImplementedException("placeholder");
        }
     
        public static void llSensor(string name, Key id, int type, float radius, float arc)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSensorRemove()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSensorRepeat(string name, Key id, int type, float range, float arc, float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetAlpha(float alpha, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetAngularVelocity(Vector initial_omega, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetAnimationOverride(string anim_state, string anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetBuoyancy(float buoyancy)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetCameraAtOffset(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetCameraEyeOffset(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetCameraParams(List rules)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetClickAction(int action)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetColor(Vector color, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetContentType(Key request_id, int content_type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetDamage(float damage)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetForce(Vector force, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetForceAndTorque(Vector force, Vector torque, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetHoverHeight(float height, int water, float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }



        public static void llSetKeyframedMotion(List keyframes, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkAlpha(int link, float alpha, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkCamera(int link, Vector eye, Vector at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkColor(int link, Vector color, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llSetLinkMedia(int link, int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkTexture(int link, string texture, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkTextureAnim(int link, int mode, int face, int sizex, int sizey, float start, float length, float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLocalRot(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llSetMemoryLimit(int limit)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetObjectDesc(string description)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetObjectName(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetObjectPermMask(int mask, int value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetParcelMusicURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPayPrice(int price, List quick_pay_buttons)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPhysicsMaterial(int mask, float gravity_multiplier, float restitution, float friction, float density)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPos(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llSetPrimMediaParams(int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPrimURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llSetRegionPos(Vector position)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetRemoteScriptAccessPin(int pin)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetRot(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetScale(Vector size)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetScriptState(string name, int running)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetSitText(string text)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llSetStatus(int status, int value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetText(string text, Vector color, float alpha)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTexture(string texture, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTextureAnim(int mode, int face, int sizex, int sizey, float start, float length, float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTimerEvent(float sec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTorque(Vector torque, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTouchText(string text)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleFlags(int flags)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehiclefloatParam(int param, float value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleRotationParam(int param, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleType(int type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleVectorParam(int param, Vector vec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVelocity(Vector force, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llSHA1string(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static int llSitOnLink(Key agent_id, int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSitTarget(Vector offset, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSleep(float sec)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llStartAnimation(string anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopAnimation(string anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopHover()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopLookAt()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopMoveToTarget()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopPointAt()
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static int llstringLength(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static string llstringTrim(string src, int type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llSubstringIndex(string source, string pattern)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTakeCamera(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTakeControls(int controls, int accept, int pass_on)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llTan(float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static int llTarget(Vector position, float range)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTargetOmega(Vector axis, float spinrate, float gain)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTargetRemove(int handle)
        {
            throw new System.NotImplementedException("placeholder");
        }
       




        public static string llToLower(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static string llToUpper(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llTransferLindenDollars(Key destination, int amount)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static string llUnescapeURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llUnSit(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llUpdateCharacter(List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llUpdateKeyValue(string k, string v, int ch3cked, string original_value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llVecDist(Vector vec_a, Vector vec_b)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static float llVecMag(Vector vec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llVecNorm(Vector vec)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llWanderWithin(Vector origin, Vector dist, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
    


    }
}