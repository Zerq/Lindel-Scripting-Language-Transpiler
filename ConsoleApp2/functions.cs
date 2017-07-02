
using LSL;




namespace Codegen
{
    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class FunctionName : System.Attribute
    {
        public string Original { get; set; }
    }

  

    public class Vector {
        public Vector(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public static Vector operator *(Vector a, Vector b) {
            return new Vector(
                a.x * b.x,
                a.y * b.y, 
                a.z * b.z
                );
        }
    }

    public class Rotation {
        public Rotation(float x, float y, float z, float s)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.s = s;
        }
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public float s { get; set; }
        public static Rotation operator *(Rotation a, Rotation b)
        {
            return new Rotation(
                a.x * b.x,
                a.y * b.y, 
                a.z * b.z,
                a.s * b.s
                );
        }
        public static Rotation operator +(Rotation a, Rotation b)
        {
            return new Rotation(
                a.x + b.x,
                a.y + b.y,
                a.z + b.z,
                a.s + b.s
                );
        }
        public static Rotation operator -(Rotation a, Rotation b)
        {
            return new Rotation(
                a.x - b.x,
                a.y - b.y,
                a.z - b.z,
                a.s - b.s
                );
        }
    }


    public class Math
    {

        [FunctionName(Original = "llAbs")]
        public static int Abs(int val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAcos")]
        public static float Acos(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAsin")]
        public static float Asin(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAtan2")]
        public static float Atan2(float y, float x)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSqrt")]
        public static float Sqrt(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCeil")]
        public static int Ceil(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llLog")]
        public static float Log(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llLog10")]
        public static float Log10(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListStatistics")]
        public static float ListStatistics(int operation, List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRound")]
        public static int Round(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llFabs")]
        public static float Fabs(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llFloor")]
        public static int Floor(float val)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llFrand")]
        public static float Frand(float mag)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llPow")]
        public static float Pow(float baze, float exponent)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llModPow")]
        public static int ModPow(int a, int b, int c)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCos")]
        public static float Cos(float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSin")]
        public static float Sin(float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }
  
    public class List
    {
        private string v1;
        private int v2;
        private Vector vector;

        public List(params object[] parameters)
        {
            bool result = true;
            foreach (var item in parameters) {
                if (!ReflectionHelper.IsValidType(item.GetType())) {
                    result = false;
                    throw new System.InvalidCastException($"List cannot use {item.GetType().Name} as a variable");
                }
            }
      
        }

        [FunctionName(Original = "llDumpList2string")]
        public static string DumpList2string(List src, string separator)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCSV2List")]
        public static List CSV2List(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2CSV")]
        public static string List2CSV(List src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2float")]
        public static float List2float(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2int")]
        public static int List2int(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2Json")]
        public static string List2Json(string type, List values)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2Key")]
        public static System.Guid List2Key(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2List")]
        public static List List2List(List src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2ListStrided")]
        public static List List2ListStrided(List src, int start, int end, int stride)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2Rot")]
        public static Rotation List2Rot(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2string")]
        public static string List2string(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llList2Vector")]
        public static Vector List2Vector(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }

    public class Land
    {
        [FunctionName(Original = "llAllowInventoryDrop")]
        public static void AllowInventoryDrop(int add)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llAddToLandBanList")]
        public static void AddToLandBanList(Key avatar, float hours)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAddToLandPassList")]
        public static void AddToLandPassList(Key avatar, float hours)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTeleportAgent")]
        public static void TeleportAgent(Key avatar, string landmark, Vector position, Vector look_at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llResetLandBanList")]
        public static void ResetLandBanList()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llResetLandPassList")]
        public static void ResetLandPassList()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRemoveFromLandBanList")]
        public static void RemoveFromLandBanList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRemoveFromLandPassList")]
        public static void RemoveFromLandPassList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llModifyLand")]
        public static void ModifyLand(int action, int brush)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llEjectFromLand")]
        public static void EjectFromLand(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetLandOwnerAt")]
        public static System.Guid GetLandOwnerAt(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llOverMyLand")]
        public static int OverMyLand(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llWater")]
        public static float Water(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llWind")]
        public static Vector Wind(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCloud")]
        public static float Cloud(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llEdgeOfWorld")]
        public static int EdgeOfWorld(Vector pos, Vector dir)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }

    public class Media
    {
        [FunctionName(Original = "llPlaySound")]
        public static void PlaySound(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llPlaySoundSlave")]
        public static void PlaySoundSlave(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llPreloadSound")]
        public static void PreloadSound(string sound)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAdjustSoundVolume")]
        public static void AdjustSoundVolume(float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCollisionSound")]
        public static void CollisionSound(string impact_sound, float impact_volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llLoopSound")]
        public static void LoopSound(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llLoopSoundMaster")]
        public static void LoopSoundMaster(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llLoopSoundSlave")]
        public static void LoopSoundSlave(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetSoundQueueing")]
        public static void SetSoundQueueing(int queue)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetSoundRadius")]
        public static void SetSoundRadius(float radius)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSound")]
        public static void Sound(string sound, float volume, int queue, int loop)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSoundPreload")]
        public static void SoundPreload(string sound)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llStopSound")]
        public static void StopSound()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTriggerSound")]
        public static void TriggerSound(string sound, float volume)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTriggerSoundLimited")]
        public static void TriggerSoundLimited(string sound, float volume, Vector top_north_east, Vector bottom_south_west)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Communication
    {
        [FunctionName(Original = "llEscapeURL")]
        public static string EscapeURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListen")]
        public static int Listen(int channel, string name, System.Guid id, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llWhisper")]
        public static void Whisper(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llEmail")]
        public static void Email(string address, string subject, string message)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSay")]
        public static void Say(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llShout")]
        public static void Shout(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRegionSay")]
        public static void RegionSay(int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRegionSayTo")]
        public static void RegionSayTo(Key target, int channel, string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llOwnerSay")]
        public static void OwnerSay(string msg)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llCloseRemoteDataChannel")]
        public static void CloseRemoteDataChannel(Key channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDialog")]
        public static void Dialog(Key avatar, string message, List buttons, int channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llOpenRemoteDataChannel")]
        public static void OpenRemoteDataChannel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRemoteDataReply")]
        public static void RemoteDataReply(Key channel, System.Guid message_id, string sdata, int idata)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSendRemoteData")]
        public static System.Guid SendRemoteData(Key channel, string dest, int idata, string sdata)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTextBox")]
        public static void TextBox(Key avatar, string message, int channel)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Base64
    {
        [FunctionName(Original = "llBase64Toint")]
        public static int Base64Toint(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llBase64Tostring")]
        public static string Base64Tostring(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llintToBase64")]
        public static string intToBase64(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llstringToBase64")]
        public static string stringToBase64(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llXorBase64")]
        public static string XorBase64(string str1, string str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llXorBase64strings")]
        public static string XorBase64strings(string str1, string str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llXorBase64stringsCorrect")]
        public static string XorBase64stringsCorrect(string str1, string str2)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Spacial
    {
        [FunctionName(Original = "llAngleBetween")]
        public static float AngleBetween(Rotation a, Rotation b)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llEuler2Rot")]
        public static Rotation Euler2Rot(Vector v)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAxes2Rot")]
        public static Rotation Axes2Rot(Vector fwd, Vector left, Vector up)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAxisAngle2Rot")]
        public static Rotation AxisAngle2Rot(Vector axis, float angle)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetLocalPos")]
        public static Vector GetLocalPos()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetLocalRot")]
        public static Rotation GetLocalRot()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetPos")]
        public static Vector GetPos()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRootPosition")]
        public static Vector GetRootPosition()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRootRotation")]
        public static Rotation GetRootRotation()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRot")]
        public static Rotation GetRot()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetScale")]
        public static Vector GetScale()
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Key
    {   

        [FunctionName(Original = "llGetOwner")]
        public static System.Guid GetOwner()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetOwnerKey")]
        public static System.Guid GetOwnerKey(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetInventoryCreator")]
        public static System.Guid GetInventoryCreator(string item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetInventoryKey")]
        public static System.Guid GetInventoryKey(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetPermissionsKey")]
        public static System.Guid GetPermissionsKey()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetCreator")]
        public static System.Guid GetCreator()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetKey")]
        public static System.Guid GetKey()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGenerateKey")]
        public static System.Guid GenerateKey()
        {
            throw new System.NotImplementedException("placeholder");
        }

    }
    public class Inventory
    {
        [FunctionName(Original = "llSetInventoryPermMask")]
        public static void SetInventoryPermMask(string item, int category, int value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRezAtRoot")]
        public static void RezAtRoot(string inventory, Vector position, Vector velocity, Rotation rot, int param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRezObject")]
        public static void RezObject(string inventory, Vector pos, Vector vel, Rotation rot, int param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRequestInventoryData")]
        public static System.Guid RequestInventoryData(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRemoveInventory")]
        public static void RemoveInventory(string item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGiveInventory")]
        public static void GiveInventory(Key destination, string inventory)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGiveInventoryList")]
        public static void GiveInventoryList(Key target, string folder, List inventory)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGodLikeRezObject")]
        public static void GodLikeRezObject(Key inventory, Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGiveMoney")]
        public static int GiveMoney(Key destination, int amount)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetInventoryName")]
        public static string GetInventoryName(int type, int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetInventoryNumber")]
        public static int GetInventoryNumber(int type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetInventoryPermMask")]
        public static int GetInventoryPermMask(string item, int category)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetInventoryType")]
        public static int GetInventoryType(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }

    }
    public class Physics
    {
        [FunctionName(Original = "llApplyImpulse")]
        public static void ApplyImpulse(Vector momentum, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llApplyRotationalImpulse")]
        public static void ApplyRotationalImpulse(Vector force, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCollisionFilter")]
        public static void CollisionFilter(string name, System.Guid id, int accept)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCollisionSprite")]
        public static void CollisionSprite(string impact_sprite)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAccel")]
        public static Vector GetAccel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetBoundingBox")]
        public static List GetBoundingBox(Key obj3ct)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Permission
    {
        [FunctionName(Original = "llGetPermissions")]
        public static int GetPermissions()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRequestPermissions")]
        public static void RequestPermissions(Key agent, int permissions)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRequestExperiencePermissions")]
        public static void RequestExperiencePermissions(Key agent, string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }

    public class Agent
    {
        [FunctionName(Original = "llAgentInExperience")]
        public static int AgentInExperience(Key agent)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAgentInfo")]
        public static int GetAgentInfo(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAgentLanguage")]
        public static string GetAgentLanguage(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAgentList")]
        public static List GetAgentList(int scope, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAgentSize")]
        public static Vector GetAgentSize(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRegionAgentCount")]
        public static int GetRegionAgentCount()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRequestAgentData")]
        public static System.Guid RequestAgentData(Key id, int data)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTeleportAgentGlobalCoords")]
        public static void TeleportAgentGlobalCoords(Key agent, Vector global_coordinates, Vector region_coordinates, Vector look_at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTeleportAgentHome")]
        public static void TeleportAgentHome(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }
    public class Detection
    {
        [FunctionName(Original = "llDetectedOwner")]
        public static System.Guid DetectedOwner(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedKey")]
        public static System.Guid DetectedKey(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llVolumeDetect")]
        public static void VolumeDetect(int detect)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedGrab")]
        public static Vector DetectedGrab(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedGroup")]
        public static int DetectedGroup(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedLinkNumber")]
        public static int DetectedLinkNumber(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedName")]
        public static string DetectedName(int item)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedPos")]
        public static Vector DetectedPos(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedRot")]
        public static Rotation DetectedRot(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedTouchBinormal")]
        public static Vector DetectedTouchBinormal(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedTouchFace")]
        public static int DetectedTouchFace(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedTouchNormal")]
        public static Vector DetectedTouchNormal(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedTouchPos")]
        public static Vector DetectedTouchPos(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedTouchST")]
        public static Vector DetectedTouchST(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedTouchUV")]
        public static Vector DetectedTouchUV(int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedType")]
        public static int DetectedType(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetectedVel")]
        public static Vector DetectedVel(int number)
        {
            throw new System.NotImplementedException("placeholder");
        }
    }
    public class Misc
    {

        [FunctionName(Original = "llAttachToAvatar")]
        public static void AttachToAvatar(int attach_point)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAttachToAvatarTemp")]
        public static void AttachToAvatarTemp(int attach_point)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAvatarOnLinkSitTarget")]
        public static System.Guid AvatarOnLinkSitTarget(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llAvatarOnSitTarget")]
        public static System.Guid AvatarOnSitTarget()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llBreakAllLinks")]
        public static void BreakAllLinks()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llBreakLink")]
        public static void BreakLink(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCastRay")]
        public static List CastRay(Vector start, Vector end, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llClearCameraParams")]
        public static void ClearCameraParams()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llClearLinkMedia")]
        public static int ClearLinkMedia(int link, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llClearPrimMedia")]
        public static int ClearPrimMedia(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llCreateCharacter")]
        public static void CreateCharacter(List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCreateKeyValue")]
        public static System.Guid CreateKeyValue(string k, string v)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llCreateLink")]
        public static void CreateLink(Key target, int parent)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llDataSizeKeyValue")]
        public static System.Guid DataSizeKeyValue()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDeleteCharacter")]
        public static void DeleteCharacter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDeleteKeyValue")]
        public static System.Guid DeleteKeyValue(string k)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDeleteSubList")]
        public static List DeleteSubList(List src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDeleteSubstring")]
        public static string DeleteSubstring(string src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llDetachFromAvatar")]
        public static void DetachFromAvatar()
        {
            throw new System.NotImplementedException("placeholder");
        }


        [FunctionName(Original = "llDie")]
        public static void Die()
        {
            throw new System.NotImplementedException("placeholder");
        }



        [FunctionName(Original = "llEvade")]
        public static void Evade(Key target, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llExecCharacterCmd")]
        public static void ExecCharacterCmd(int command, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llFleeFrom")]
        public static void FleeFrom(Vector position, float distance, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llForceMouselook")]
        public static void ForceMouselook(int mouselook)
        {
            throw new System.NotImplementedException("placeholder");
        }



        [FunctionName(Original = "llGetAlpha")]
        public static float GetAlpha(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAndResetTime")]
        public static float GetAndResetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAnimation")]
        public static string GetAnimation(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAnimationList")]
        public static List GetAnimationList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAnimationOverride")]
        public static string GetAnimationOverride(string anim_state)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAttached")]
        public static int GetAttached()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetAttachedList")]
        public static List GetAttachedList(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetCameraPos")]
        public static Vector GetCameraPos()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetCameraRot")]
        public static Rotation GetCameraRot()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetCenterOfMass")]
        public static Vector GetCenterOfMass()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetClosestNavPoint")]
        public static List GetClosestNavPoint(Vector point, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetColor")]
        public static Vector GetColor(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetDate")]
        public static string GetDate()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetDisplayName")]
        public static string GetDisplayName(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetEnergy")]
        public static float GetEnergy()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetEnv")]
        public static string GetEnv(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetExperienceDetails")]
        public static List GetExperienceDetails(Key experience_id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetExperienceErrorMessage")]
        public static string GetExperienceErrorMessage(int error)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetForce")]
        public static Vector GetForce()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetFreeMemory")]
        public static int GetFreeMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetFreeURLs")]
        public static int GetFreeURLs()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetGeometricCenter")]
        public static Vector GetGeometricCenter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetGMTclock")]
        public static float GetGMTclock()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetHTTPHeader")]
        public static string GetHTTPHeader(Key request_id, string header)
        {
            throw new System.NotImplementedException("placeholder");
        }


        [FunctionName(Original = "llGetLinkKey")]
        public static System.Guid GetLinkKey(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetLinkMedia")]
        public static List GetLinkMedia(int link, int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetLinkName")]
        public static string GetLinkName(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetLinkNumber")]
        public static int GetLinkNumber()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetLinkNumberOfSides")]
        public static int GetLinkNumberOfSides(int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetListEntryType")]
        public static int GetListEntryType(List src, int index)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetListLength")]
        public static int GetListLength(List src)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetMass")]
        public static float GetMass()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetMassMKS")]
        public static float GetMassMKS()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetMaxScaleFactor")]
        public static float GetMaxScaleFactor()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetMemoryLimit")]
        public static int GetMemoryLimit()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetMinScaleFactor")]
        public static float GetMinScaleFactor()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetNextEmail")]
        public static void GetNextEmail(string address, string subject)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetNotecardLine")]
        public static System.Guid GetNotecardLine(string name, int line)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetNumberOfNotecardLines")]
        public static System.Guid GetNumberOfNotecardLines(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetNumberOfPrims")]
        public static int GetNumberOfPrims()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetNumberOfSides")]
        public static int GetNumberOfSides()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetObjectDesc")]
        public static string GetObjectDesc()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetObjectDetails")]
        public static List GetObjectDetails(Key id, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetObjectMass")]
        public static float GetObjectMass(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetObjectName")]
        public static string GetObjectName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetObjectPermMask")]
        public static int GetObjectPermMask(int category)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetObjectPrimCount")]
        public static int GetObjectPrimCount(Key prim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetOmega")]
        public static Vector GetOmega()
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetParcelDetails")]
        public static List GetParcelDetails(Vector pos, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetParcelFlags")]
        public static int GetParcelFlags(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetParcelMaxPrims")]
        public static int GetParcelMaxPrims(Vector pos, int sim_wide)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetParcelMusicURL")]
        public static string GetParcelMusicURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetParcelPrimCount")]
        public static int GetParcelPrimCount(Vector pos, int category, int sim_wide)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetParcelPrimOwners")]
        public static List GetParcelPrimOwners(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetPhysicsMaterial")]
        public static List GetPhysicsMaterial()
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetPrimMediaParams")]
        public static List GetPrimMediaParams(int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetRegionCorner")]
        public static Vector GetRegionCorner()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRegionFlags")]
        public static int GetRegionFlags()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRegionFPS")]
        public static float GetRegionFPS()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRegionName")]
        public static string GetRegionName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetRegionTimeDilation")]
        public static float GetRegionTimeDilation()
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGetScriptName")]
        public static string GetScriptName()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetScriptState")]
        public static int GetScriptState(string script)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetSimStats")]
        public static float GetSimStats(int stat_type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetSimulatorHostname")]
        public static string GetSimulatorHostname()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetSPMaxMemory")]
        public static int GetSPMaxMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetStartParameter")]
        public static int GetStartParameter()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetStaticPath")]
        public static List GetStaticPath(Vector start, Vector end, float radius, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetStatus")]
        public static int GetStatus(int status)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetSubstring")]
        public static string GetSubstring(string src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetSunDirection")]
        public static Vector GetSunDirection()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTexture")]
        public static string GetTexture(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTextureOffset")]
        public static Vector GetTextureOffset(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTextureRot")]
        public static float GetTextureRot(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTextureScale")]
        public static Vector GetTextureScale(int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTime")]
        public static float GetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTimeOfDay")]
        public static float GetTimeOfDay()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTimestamp")]
        public static string GetTimestamp()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetTorque")]
        public static Vector GetTorque()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetUnixTime")]
        public static int GetUnixTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetUsedMemory")]
        public static int GetUsedMemory()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetUsername")]
        public static string GetUsername(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetVel")]
        public static Vector GetVel()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGetWallclock")]
        public static float GetWallclock()
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llGround")]
        public static float Ground(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGroundContour")]
        public static Vector GroundContour(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGroundNormal")]
        public static Vector GroundNormal(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGroundRepel")]
        public static void GroundRepel(float height, int water, float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llGroundSlope")]
        public static Vector GroundSlope(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llHTTPRequest")]
        public static System.Guid HTTPRequest(string url, List parameters, string body)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llHTTPResponse")]
        public static void HTTPResponse(Key request_id, int status, string body)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llInsertstring")]
        public static string Insertstring(string dst, int pos, string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llInstantMessage")]
        public static void InstantMessage(Key user, string message)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llJson2List")]
        public static List Json2List(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llJsonGetValue")]
        public static string JsonGetValue(string json, List specifiers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llJsonSetValue")]
        public static string JsonSetValue(string json, List specifiers, string value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llJsonValueType")]
        public static string JsonValueType(string json, List specifiers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llKey2Name")]
        public static string Key2Name(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llKeyCountKeyValue")]
        public static System.Guid KeyCountKeyValue()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llKeysKeyValue")]
        public static System.Guid KeysKeyValue(int first, int count)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llLinkSitTarget")]
        public static void LinkSitTarget(int link, Vector offset, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llListenControl")]
        public static void ListenControl(int handle, int active)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListenRemove")]
        public static void ListenRemove(int handle)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListFindList")]
        public static int ListFindList(List src, List test)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListInsertList")]
        public static List ListInsertList(List dest, List src, int start)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListRandomize")]
        public static List ListRandomize(List src, int stride)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListReplaceList")]
        public static List ListReplaceList(List dest, List src, int start, int end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llListSort")]
        public static List ListSort(List src, int stride, int ascending)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llLoadURL")]
        public static void LoadURL(Key avatar, string message, string url)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llLookAt")]
        public static void LookAt(Vector target, float strength, float damping)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llMakeExplosion")]
        public static void MakeExplosion(int particles, float scale, float vel, float lifetime, float arc, string texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llMakeFire")]
        public static void MakeFire(int particles, float scale, float vel, float lifetime, float arc, string texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llMakeFountain")]
        public static void MakeFountain(int particles, float scale, float vel, float lifetime, float arc, int bounce, string texture, Vector offset, float bounce_offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llMakeSmoke")]
        public static void MakeSmoke(int particles, float scale, float vel, float lifetime, float arc, string texture, Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llManageEstateAccess")]
        public static int ManageEstateAccess(int action, System.Guid avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llMapDestination")]
        public static void MapDestination(string simname, Vector pos, Vector look_at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llMD5string")]
        public static string MD5string(string src, int nonce)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llMessageLinked")]
        public static void MessageLinked(int link, int num, string str, System.Guid id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llMinEventDelay")]
        public static void MinEventDelay(float delay)
        {
            throw new System.NotImplementedException("placeholder");
        }


        [FunctionName(Original = "llMoveToTarget")]
        public static void MoveToTarget(Vector target, float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llNavigateTo")]
        public static void NavigateTo(Vector pos, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llOffsetTexture")]
        public static void OffsetTexture(float u, float v, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llParcelMediaCommandList")]
        public static void ParcelMediaCommandList(List commandList)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llParcelMediaQuery")]
        public static List ParcelMediaQuery(List query)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llParsestring2List")]
        public static List Parsestring2List(string src, List separators, List spacers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llParsestringKeepNulls")]
        public static List ParsestringKeepNulls(string src, List separators, List spacers)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llPassCollisions")]
        public static void PassCollisions(int pass)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llPassTouches")]
        public static void PassTouches(int pass)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llPatrolPoints")]
        public static void PatrolPoints(List patrolPoints, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llPointAt")]
        public static void PointAt(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llPursue")]
        public static void Pursue(Key target, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llPushObject")]
        public static void PushObject(Key target, Vector impulse, Vector ang_impulse, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llReadKeyValue")]
        public static System.Guid ReadKeyValue(string k)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRefreshPrimURL")]
        public static void RefreshPrimURL()
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llReleaseCamera")]
        public static void ReleaseCamera(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llReleaseControls")]
        public static void ReleaseControls()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llReleaseURL")]
        public static void ReleaseURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llRemoteDataSetRegion")]
        public static void RemoteDataSetRegion()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRemoteLoadScript")]
        public static void RemoteLoadScript(Key target, string name, int running, int start_param)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRemoteLoadScriptPin")]
        public static void RemoteLoadScriptPin(Key target, string name, int pin, int running, int start_param)
        {
            throw new System.NotImplementedException("placeholder");
        }


        [FunctionName(Original = "llRemoveVehicleFlags")]
        public static void RemoveVehicleFlags(int flags)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llRequestDisplayName")]
        public static System.Guid RequestDisplayName(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }



        [FunctionName(Original = "llRequestSecureURL")]
        public static System.Guid RequestSecureURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRequestSimulatorData")]
        public static System.Guid RequestSimulatorData(string region, int data)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRequestURL")]
        public static System.Guid RequestURL()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRequestUsername")]
        public static System.Guid RequestUsername(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llResetAnimationOverride")]
        public static void ResetAnimationOverride(string anim_state)
        {
            throw new System.NotImplementedException("placeholder");
        }



        [FunctionName(Original = "llResetOtherScript")]
        public static void ResetOtherScript(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llResetScript")]
        public static void ResetScript()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llResetTime")]
        public static void ResetTime()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llReturnObjectsByID")]
        public static int ReturnObjectsByID(List objects)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llReturnObjectsByOwner")]
        public static int ReturnObjectsByOwner(Key owner, int scope)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llRot2Angle")]
        public static float Rot2Angle(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRot2Axis")]
        public static Vector Rot2Axis(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRot2Euler")]
        public static Vector Rot2Euler(Rotation quat)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRot2Fwd")]
        public static Vector Rot2Fwd(Rotation q)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRot2Left")]
        public static Vector Rot2Left(Rotation q)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRot2Up")]
        public static Vector Rot2Up(Rotation q)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRotateTexture")]
        public static void RotateTexture(float angle, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRotBetween")]
        public static Rotation RotBetween(Vector start, Vector end)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRotLookAt")]
        public static void RotLookAt(Rotation target_direction, float strength, float damping)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRotTarget")]
        public static int RotTarget(Rotation rot, float error)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llRotTargetRemove")]
        public static void RotTargetRemove(int handle)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llSameGroup")]
        public static int SameGroup(Key uuid)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llScaleByFactor")]
        public static int ScaleByFactor(float scaling_factor)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llScaleTexture")]
        public static void ScaleTexture(float u, float v, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llScriptDanger")]
        public static int ScriptDanger(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llScriptProfiler")]
        public static void ScriptProfiler(int flags)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llSensor")]
        public static void Sensor(string name, System.Guid id, int type, float radius, float arc)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSensorRemove")]
        public static void SensorRemove()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSensorRepeat")]
        public static void SensorRepeat(string name, System.Guid id, int type, float range, float arc, float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetAlpha")]
        public static void SetAlpha(float alpha, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetAngularVelocity")]
        public static void SetAngularVelocity(Vector initial_omega, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetAnimationOverride")]
        public static void SetAnimationOverride(string anim_state, string anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetBuoyancy")]
        public static void SetBuoyancy(float buoyancy)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetCameraAtOffset")]
        public static void SetCameraAtOffset(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetCameraEyeOffset")]
        public static void SetCameraEyeOffset(Vector offset)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetCameraParams")]
        public static void SetCameraParams(List rules)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetClickAction")]
        public static void SetClickAction(int action)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetColor")]
        public static void SetColor(Vector color, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetContentType")]
        public static void SetContentType(Key request_id, int content_type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetDamage")]
        public static void SetDamage(float damage)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetForce")]
        public static void SetForce(Vector force, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetForceAndTorque")]
        public static void SetForceAndTorque(Vector force, Vector torque, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetHoverHeight")]
        public static void SetHoverHeight(float height, int water, float tau)
        {
            throw new System.NotImplementedException("placeholder");
        }



        [FunctionName(Original = "llSetKeyframedMotion")]
        public static void SetKeyframedMotion(List keyframes, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetLinkAlpha")]
        public static void SetLinkAlpha(int link, float alpha, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetLinkCamera")]
        public static void SetLinkCamera(int link, Vector eye, Vector at)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetLinkColor")]
        public static void SetLinkColor(int link, Vector color, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetLinkMedia")]
        public static int SetLinkMedia(int link, int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetLinkTexture")]
        public static void SetLinkTexture(int link, string texture, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetLinkTextureAnim")]
        public static void SetLinkTextureAnim(int link, int mode, int face, int sizex, int sizey, float start, float length, float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetLocalRot")]
        public static void SetLocalRot(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetMemoryLimit")]
        public static int SetMemoryLimit(int limit)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetObjectDesc")]
        public static void SetObjectDesc(string description)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetObjectName")]
        public static void SetObjectName(string name)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetObjectPermMask")]
        public static void SetObjectPermMask(int mask, int value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetParcelMusicURL")]
        public static void SetParcelMusicURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetPayPrice")]
        public static void SetPayPrice(int price, List quick_pay_buttons)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetPhysicsMaterial")]
        public static void SetPhysicsMaterial(int mask, float gravity_multiplier, float restitution, float friction, float density)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetPos")]
        public static void SetPos(Vector pos)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetPrimMediaParams")]
        public static int SetPrimMediaParams(int face, List paramz)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetPrimURL")]
        public static void SetPrimURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetRegionPos")]
        public static int SetRegionPos(Vector position)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetRemoteScriptAccessPin")]
        public static void SetRemoteScriptAccessPin(int pin)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetRot")]
        public static void SetRot(Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetScale")]
        public static void SetScale(Vector size)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetScriptState")]
        public static void SetScriptState(string name, int running)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetSitText")]
        public static void SetSitText(string text)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llSetStatus")]
        public static void SetStatus(int status, int value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetText")]
        public static void SetText(string text, Vector color, float alpha)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetTexture")]
        public static void SetTexture(string texture, int face)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetTextureAnim")]
        public static void SetTextureAnim(int mode, int face, int sizex, int sizey, float start, float length, float rate)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetTimerEvent")]
        public static void SetTimerEvent(float sec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetTorque")]
        public static void SetTorque(Vector torque, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetTouchText")]
        public static void SetTouchText(string text)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetVehicleFlags")]
        public static void SetVehicleFlags(int flags)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetVehiclefloatParam")]
        public static void SetVehiclefloatParam(int param, float value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetVehicleRotationParam")]
        public static void SetVehicleRotationParam(int param, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetVehicleType")]
        public static void SetVehicleType(int type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetVehicleVectorParam")]
        public static void SetVehicleVectorParam(int param, Vector vec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSetVelocity")]
        public static void SetVelocity(Vector force, int local)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSHA1string")]
        public static string SHA1string(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llSitOnLink")]
        public static int SitOnLink(Key agent_id, int link)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSitTarget")]
        public static void SitTarget(Vector offset, Rotation rot)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSleep")]
        public static void Sleep(float sec)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llStartAnimation")]
        public static void StartAnimation(string anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llStopAnimation")]
        public static void StopAnimation(string anim)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llStopHover")]
        public static void StopHover()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llStopLookAt")]
        public static void StopLookAt()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llStopMoveToTarget")]
        public static void StopMoveToTarget()
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llStopPointAt")]
        public static void StopPointAt()
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llstringLength")]
        public static int stringLength(string str)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llstringTrim")]
        public static string stringTrim(string src, int type)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llSubstringIndex")]
        public static int SubstringIndex(string source, string pattern)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTakeCamera")]
        public static void TakeCamera(Key avatar)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTakeControls")]
        public static void TakeControls(int controls, int accept, int pass_on)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTan")]
        public static float Tan(float theta)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTarget")]
        public static int Target(Vector position, float range)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTargetOmega")]
        public static void TargetOmega(Vector axis, float spinrate, float gain)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTargetRemove")]
        public static void TargetRemove(int handle)
        {
            throw new System.NotImplementedException("placeholder");
        }





        [FunctionName(Original = "llToLower")]
        public static string ToLower(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llToUpper")]
        public static string ToUpper(string src)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llTransferLindenDollars")]
        public static System.Guid TransferLindenDollars(Key destination, int amount)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llUnescapeURL")]
        public static string UnescapeURL(string url)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llUnSit")]
        public static void UnSit(Key id)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llUpdateCharacter")]
        public static void UpdateCharacter(List options)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llUpdateKeyValue")]
        public static System.Guid UpdateKeyValue(string k, string v, int ch3cked, string original_value)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llVecDist")]
        public static float VecDist(Vector vec_a, Vector vec_b)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llVecMag")]
        public static float VecMag(Vector vec)
        {
            throw new System.NotImplementedException("placeholder");
        }
        [FunctionName(Original = "llVecNorm")]
        public static Vector VecNorm(Vector vec)
        {
            throw new System.NotImplementedException("placeholder");
        }

        [FunctionName(Original = "llWanderWithin")]
        public static void WanderWithin(Vector origin, Vector dist, List options)
        {
            throw new System.NotImplementedException("placeholder");
        }



    }
}