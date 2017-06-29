integer inventorycnt;
integer notecardlinecnt;
integer notecardlinenumber;
string notecardname;
key linenumberid;
key lineid;
key target;

getnextnotecardlinenumber()
{
    inventorycnt++;
    if (inventorycnt < llGetInventoryNumber(INVENTORY_NOTECARD))
    {
        notecardname = llGetInventoryName(INVENTORY_NOTECARD,inventorycnt);
        linenumberid = llGetNumberOfNotecardLines(notecardname);
    }
    else
        llOwnerSay("Done.");
}
 
getnextnotecardline()
{
    notecardlinecnt++;
    if (notecardlinecnt < notecardlinenumber)
        lineid = llGetNotecardLine(notecardname,notecardlinecnt);
    else
        getnextnotecardlinenumber();
}
 
default
{

    state_entry()
    {
            llMessageLinked(LINK_THIS, 0, llDetectedName(0), llDetectedKey(0));
    }


   link_message(integer source, integer num, string str, key id)
    {

     

          
            if (llDetectedKey(0) != llGetOwner()) return; // allow owner only            
                    inventorycnt = -1;
                    getnextnotecardlinenumber();
    }


 
    dataserver(key queryid,string data)
    {
        if (queryid == linenumberid) // this was a line number lookup
        {
            linenumberid = NULL_KEY;
            notecardlinenumber = (integer)data;
            if (notecardlinenumber == 0)
                getnextnotecardlinenumber();
            else
            {
                notecardlinecnt = -1;
                getnextnotecardline();
            }
        }
        else if (queryid == lineid) 
        {

            

            lineid = NULL_KEY;
            list names = llParseString2List(data,[","],[]); 
            integer len = llGetListLength(names); 
            integer cnt;
            for (cnt = 0; cnt < len; cnt++)
            {
                string name = llDumpList2String(llParseString2List(llList2String(names,cnt),[" "],[])," "); 
                if (llGetListLength(llParseString2List(name,[" "],[])) == 2)  
                    llOwnerSay(notecardname + ": " + name);
            } 
            getnextnotecardline();
        }
    }
}