

default {
state_entry(){
            
            list strs =  List.Parse( "bob", [","],[]);         // llParseString2List   
            strs.Add("Zog"); // strs += "Zog";
            strs.Add(FALSE);
            strs.Add(5);       
            strs.Remove(0); //  ListStridedRemove(strs, 0, 0, integer stride );

            strs[0] = "Goz";

            strs.ForEach((item:integer)=>{
                llOwnerSay((string)item);
            }); /*
            for (i=0; i < llGetListLength(strs); i++){
             integer item = LlList2Integer(strs,i);

            }
            */
            
    }
}