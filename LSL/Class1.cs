





namespace Codegen
{

    public class Integer { }
    public class Float { }
    public class Vector { }
    public class Rotation { }
    public class Void { }

    public class String { }

    public class Math {

        public static Integer llAbs(Integer val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llAcos(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llAsin(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llAtan2(Float y, Float x)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llSqrt(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llCeil(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llLog(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llLog10(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llListStatistics(Integer operation, List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llRound(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llFabs(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llFloor(Float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llFrand(Float mag)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llPow(Float baze, Float exponent)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llModPow(Integer a, Integer b, Integer c)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llCos(Float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llSin(Float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class List {

        public static String llDumpList2String(List src, String separator)
        {
            throw new System.NotImplementedException("placeholder");
        }



        public static List llCSV2List(String src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llList2CSV(List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llList2Float(List src, Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llList2Integer(List src, Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llList2Json(String type, List values)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llList2Key(List src, Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llList2List(List src, Integer start, Integer end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llList2ListStrided(List src, Integer start, Integer end, Integer stride)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llList2Rot(List src, Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llList2String(List src, Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llList2Vector(List src, Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }

    public class Land {
        public static void llAllowInventoryDrop(Integer add)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llAddToLandBanList(Key avatar, Float hours)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llAddToLandPassList(Key avatar, Float hours)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTeleportAgent(Key avatar, String landmark, Vector position, Vector look_at)
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
        public static void llModifyLand(Integer action, Integer brush)
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
        public static Integer llOverMyLand(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llWater(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llWind(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llCloud(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llEdgeOfWorld(Vector pos, Vector dir)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }

    public class Sound
    {
        public static void llPlaySound(String sound, Float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPlaySoundSlave(String sound, Float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPreloadSound(String sound)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llAdjustSoundVolume(Float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCollisionSound(String impact_sound, Float impact_volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLoopSound(String sound, Float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLoopSoundMaster(String sound, Float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLoopSoundSlave(String sound, Float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetSoundQueueing(Integer queue)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetSoundRadius(Float radius)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSound(String sound, Float volume, Integer queue, Integer loop)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSoundPreload(String sound)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopSound()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTriggerSound(String sound, Float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTriggerSoundLimited(String sound, Float volume, Vector top_north_east, Vector bottom_south_west)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Communication
    {
        public static String llEscapeURL(String url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llListen(Integer channel, String name, Key id, String msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llWhisper(Integer channel, String msg)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llEmail(String address, String subject, String message)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSay(Integer channel, String msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llShout(Integer channel, String msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRegionSay(Integer channel, String msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRegionSayTo(Key target, Integer channel, String msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llOwnerSay(String msg)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llCloseRemoteDataChannel(Key channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llDialog(Key avatar, String message, List buttons, Integer channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llOpenRemoteDataChannel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoteDataReply(Key channel, Key message_id, String sdata, Integer idata)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llSendRemoteData(Key channel, String dest, Integer idata, String sdata)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTextBox(Key avatar, String message, Integer channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Base64 {
        public static Integer llBase64ToInteger(String str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llBase64ToString(String str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llIntegerToBase64(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llStringToBase64(String str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llXorBase64(String str1, String str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llXorBase64Strings(String str1, String str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llXorBase64StringsCorrect(String str1, String str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Spacial {
        public static Float llAngleBetween(Rotation a, Rotation b)
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
        public static Rotation llAxisAngle2Rot(Vector axis, Float angle)
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
        public static Key llGetInventoryCreator(String item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetInventoryKey(String name)
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
        public static void llSetInventoryPermMask(String item, Integer category, Integer value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRezAtRoot(String inventory, Vector position, Vector velocity, Rotation rot, Integer param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRezObject(String inventory, Vector pos, Vector vel, Rotation rot, Integer param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llRequestInventoryData(String name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoveInventory(String item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGiveInventory(Key destination, String inventory)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGiveInventoryList(Key target, String folder, List inventory)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGodLikeRezObject(Key inventory, Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGiveMoney(Key destination, Integer amount)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetInventoryName(Integer type, Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetInventoryNumber(Integer type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetInventoryPermMask(String item, Integer category)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetInventoryType(String name)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }
    public class Physics {
        public static void llApplyImpulse(Vector momentum, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llApplyRotationalImpulse(Vector force, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCollisionFilter(String name, Key id, Integer accept)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCollisionSprite(String impact_sprite)
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
        public static Integer llGetPermissions()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRequestPermissions(Key agent, Integer permissions)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRequestExperiencePermissions(Key agent, String name)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Agent {
        public static Integer llAgentInExperience(Key agent)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetAgentInfo(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetAgentLanguage(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetAgentList(Integer scope, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetAgentSize(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetRegionAgentCount()
        {
            throw new System.NotImplementedException("placeholder");
        }   
        public static Key llRequestAgentData(Key id, Integer data)
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
        public static Key llDetectedOwner(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llDetectedKey(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llVolumeDetect(Integer detect)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedGrab(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llDetectedGroup(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llDetectedLinkNumber(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llDetectedName(Integer item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedPos(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llDetectedRot(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchBinormal(Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llDetectedTouchFace(Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchNormal(Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchPos(Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchST(Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedTouchUV(Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llDetectedType(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llDetectedVel(Integer number)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }
    public  class Misc
    {
 
        public static void llAttachToAvatar(Integer attach_point)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llAttachToAvatarTemp(Integer attach_point)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llAvatarOnLinkSitTarget(Integer link)
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
        public static void llBreakLink(Integer link)
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
        public static Integer llClearLinkMedia(Integer link, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llClearPrimMedia(Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llCreateCharacter(List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llCreateKeyValue(String k, String v)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llCreateLink(Key target, Integer parent)
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
        public static Key llDeleteKeyValue(String k)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llDeleteSubList(List src, Integer start, Integer end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llDeleteSubString(String src, Integer start, Integer end)
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
        public static void llExecCharacterCmd(Integer command, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llFleeFrom(Vector position, Float distance, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static void llForceMouselook(Integer mouselook)
        {
            throw new System.NotImplementedException("placeholder");
        }

     

        public static Float llGetAlpha(Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetAndResetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetAnimation(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetAnimationList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetAnimationOverride(String anim_state)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetAttached()
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
        public static Vector llGetColor(Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static String llGetDate()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetDisplayName(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetEnergy()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetEnv(String name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetExperienceDetails(Key experience_id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetExperienceErrorMessage(Integer error)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetForce()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetFreeMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetFreeURLs()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetGeometricCenter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetGMTclock()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetHTTPHeader(Key request_id, String header)
        {
            throw new System.NotImplementedException("placeholder");
        }


        public static Key llGetLinkKey(Integer link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetLinkMedia(Integer link, Integer face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetLinkName(Integer link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetLinkNumber()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetLinkNumberOfSides(Integer link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetListEntryType(List src, Integer index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetListLength(List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
       
        public static Float llGetMass()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetMassMKS()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetMaxScaleFactor()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetMemoryLimit()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetMinScaleFactor()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llGetNextEmail(String address, String subject)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetNotecardLine(String name, Integer line)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llGetNumberOfNotecardLines(String name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetNumberOfPrims()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetNumberOfSides()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetObjectDesc()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetObjectDetails(Key id, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetObjectMass(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetObjectName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetObjectPermMask(Integer category)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetObjectPrimCount(Key prim)
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
        public static Integer llGetParcelFlags(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetParcelMaxPrims(Vector pos, Integer sim_wide)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetParcelMusicURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetParcelPrimCount(Vector pos, Integer category, Integer sim_wide)
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
        
        public static List llGetPrimMediaParams(Integer face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
   
        public static Vector llGetRegionCorner()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetRegionFlags()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetRegionFPS()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetRegionName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetRegionTimeDilation()
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static String llGetScriptName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetScriptState(String script)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetSimStats(Integer stat_type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetSimulatorHostname()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetSPMaxMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetStartParameter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llGetStaticPath(Vector start, Vector end, Float radius, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetStatus(Integer status)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetSubString(String src, Integer start, Integer end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetSunDirection()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetTexture(Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetTextureOffset(Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetTextureRot(Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetTextureScale(Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetTimeOfDay()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetTimestamp()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetTorque()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetUnixTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llGetUsedMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llGetUsername(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGetVel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llGetWallclock()
        {
            throw new System.NotImplementedException("placeholder");
        }
        
        public static Float llGround(Vector offset)
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
        public static void llGroundRepel(Float height, Integer water, Float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Vector llGroundSlope(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llHTTPRequest(String url, List parameters, String body)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llHTTPResponse(Key request_id, Integer status, String body)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llInsertString(String dst, Integer pos, String src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llInstantMessage(Key user, String message)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static List llJson2List(String src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llJsonGetValue(String json, List specifiers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llJsonSetValue(String json, List specifiers, String value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llJsonValueType(String json, List specifiers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llKey2Name(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llKeyCountKeyValue()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llKeysKeyValue(Integer first, Integer count)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llLinkSitTarget(Integer link, Vector offset, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static void llListenControl(Integer handle, Integer active)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llListenRemove(Integer handle)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llListFindList(List src, List test)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListInsertList(List dest, List src, Integer start)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListRandomize(List src, Integer stride)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListReplaceList(List dest, List src, Integer start, Integer end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llListSort(List src, Integer stride, Integer ascending)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llLoadURL(Key avatar, String message, String url)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llLookAt(Vector target, Float strength, Float damping)
        {
            throw new System.NotImplementedException("placeholder");
        }
       
        public static void llMakeExplosion(Integer particles, Float scale, Float vel, Float lifetime, Float arc, String texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMakeFire(Integer particles, Float scale, Float vel, Float lifetime, Float arc, String texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMakeFountain(Integer particles, Float scale, Float vel, Float lifetime, Float arc, Integer bounce, String texture, Vector offset, Float bounce_offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMakeSmoke(Integer particles, Float scale, Float vel, Float lifetime, Float arc, String texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llManageEstateAccess(Integer action, Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMapDestination(String simname, Vector pos, Vector look_at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llMD5String(String src, Integer nonce)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMessageLinked(Integer link, Integer num, String str, Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llMinEventDelay(Float delay)
        {
            throw new System.NotImplementedException("placeholder");
        }
   

        public static void llMoveToTarget(Vector target, Float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llNavigateTo(Vector pos, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llOffsetTexture(Float u, Float v, Integer face)
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
        public static List llParseString2List(String src, List separators, List spacers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static List llParseStringKeepNulls(String src, List separators, List spacers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPassCollisions(Integer pass)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llPassTouches(Integer pass)
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
        public static void llPushObject(Key target, Vector impulse, Vector ang_impulse, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llReadKeyValue(String k)
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
        public static void llReleaseURL(String url)
        {
            throw new System.NotImplementedException("placeholder");
        }
  
        public static void llRemoteDataSetRegion()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoteLoadScript(Key target, String name, Integer running, Integer start_param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRemoteLoadScriptPin(Key target, String name, Integer pin, Integer running, Integer start_param)
        {
            throw new System.NotImplementedException("placeholder");
        }

     
        public static void llRemoveVehicleFlags(Integer flags)
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
        public static Key llRequestSimulatorData(String region, Integer data)
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
        public static void llResetAnimationOverride(String anim_state)
        {
            throw new System.NotImplementedException("placeholder");
        }
      


        public static void llResetOtherScript(String name)
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
        public static Integer llReturnObjectsByID(List objects)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llReturnObjectsByOwner(Key owner, Integer scope)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static Float llRot2Angle(Rotation rot)
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
        public static void llRotateTexture(Float angle, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Rotation llRotBetween(Vector start, Vector end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRotLookAt(Rotation target_direction, Float strength, Float damping)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llRotTarget(Rotation rot, Float error)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llRotTargetRemove(Integer handle)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static Integer llSameGroup(Key uuid)
        {
            throw new System.NotImplementedException("placeholder");
        }
       
        public static Integer llScaleByFactor(Float scaling_factor)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llScaleTexture(Float u, Float v, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llScriptDanger(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llScriptProfiler(Integer flags)
        {
            throw new System.NotImplementedException("placeholder");
        }
     
        public static void llSensor(String name, Key id, Integer type, Float radius, Float arc)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSensorRemove()
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSensorRepeat(String name, Key id, Integer type, Float range, Float arc, Float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetAlpha(Float alpha, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetAngularVelocity(Vector initial_omega, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetAnimationOverride(String anim_state, String anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetBuoyancy(Float buoyancy)
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
        public static void llSetClickAction(Integer action)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetColor(Vector color, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetContentType(Key request_id, Integer content_type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetDamage(Float damage)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetForce(Vector force, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetForceAndTorque(Vector force, Vector torque, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetHoverHeight(Float height, Integer water, Float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }



        public static void llSetKeyframedMotion(List keyframes, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkAlpha(Integer link, Float alpha, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkCamera(Integer link, Vector eye, Vector at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkColor(Integer link, Vector color, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llSetLinkMedia(Integer link, Integer face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkTexture(Integer link, String texture, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLinkTextureAnim(Integer link, Integer mode, Integer face, Integer sizex, Integer sizey, Float start, Float length, Float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetLocalRot(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llSetMemoryLimit(Integer limit)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetObjectDesc(String description)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetObjectName(String name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetObjectPermMask(Integer mask, Integer value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetParcelMusicURL(String url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPayPrice(Integer price, List quick_pay_buttons)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPhysicsMaterial(Integer mask, Float gravity_multiplier, Float restitution, Float friction, Float density)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPos(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llSetPrimMediaParams(Integer face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetPrimURL(String url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llSetRegionPos(Vector position)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetRemoteScriptAccessPin(Integer pin)
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
        public static void llSetScriptState(String name, Integer running)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetSitText(String text)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static void llSetStatus(Integer status, Integer value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetText(String text, Vector color, Float alpha)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTexture(String texture, Integer face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTextureAnim(Integer mode, Integer face, Integer sizex, Integer sizey, Float start, Float length, Float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTimerEvent(Float sec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTorque(Vector torque, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetTouchText(String text)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleFlags(Integer flags)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleFloatParam(Integer param, Float value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleRotationParam(Integer param, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleType(Integer type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVehicleVectorParam(Integer param, Vector vec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSetVelocity(Vector force, Integer local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llSHA1String(String src)
        {
            throw new System.NotImplementedException("placeholder");
        }
    
        public static Integer llSitOnLink(Key agent_id, Integer link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSitTarget(Vector offset, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llSleep(Float sec)
        {
            throw new System.NotImplementedException("placeholder");
        }
 
        public static void llStartAnimation(String anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llStopAnimation(String anim)
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
 
        public static Integer llStringLength(String str)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static String llStringTrim(String src, Integer type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llSubStringIndex(String source, String pattern)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTakeCamera(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTakeControls(Integer controls, Integer accept, Integer pass_on)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llTan(Float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Integer llTarget(Vector position, Float range)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTargetOmega(Vector axis, Float spinrate, Float gain)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static void llTargetRemove(Integer handle)
        {
            throw new System.NotImplementedException("placeholder");
        }
       




        public static String llToLower(String src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static String llToUpper(String src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Key llTransferLindenDollars(Key destination, Integer amount)
        {
            throw new System.NotImplementedException("placeholder");
        }

        public static String llUnescapeURL(String url)
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
        public static Key llUpdateKeyValue(String k, String v, Integer ch3cked, String original_value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llVecDist(Vector vec_a, Vector vec_b)
        {
            throw new System.NotImplementedException("placeholder");
        }
        public static Float llVecMag(Vector vec)
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