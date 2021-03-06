/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Operation.def
	public class EntityBaseEntityCall_OperationBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityBaseEntityCall_OperationBase(UInt16 ecpID, Int32 eid) : base(eid, "Operation")
		{
			entityComponentPropertyID = ecpID;
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

		public void reqCreateRoom()
		{
			Bundle pBundle = newCall("reqCreateRoom", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqEnterRoom(UInt64 arg1)
		{
			Bundle pBundle = newCall("reqEnterRoom", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			sendCall(null);
		}

		public void reqRoomList()
		{
			Bundle pBundle = newCall("reqRoomList", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}

	public class EntityCellEntityCall_OperationBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityCellEntityCall_OperationBase(UInt16 ecpID, Int32 eid) : base(eid, "Operation")
		{
			entityComponentPropertyID = ecpID;
			className = "Operation";
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void reqGameBegin()
		{
			Bundle pBundle = newCall("reqGameBegin", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqLeaveRoom()
		{
			Bundle pBundle = newCall("reqLeaveRoom", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqTrueSyncData(Byte arg1, byte[] arg2)
		{
			Bundle pBundle = newCall("reqTrueSyncData", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint8(arg1);
			bundle.writeBlob(arg2);
			sendCall(null);
		}

	}
	}
