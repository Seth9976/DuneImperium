using System;
using Canis.messages;
using Canis.messages.sequence;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.match.behaviours
{
	// Token: 0x02000131 RID: 305
	public class DBGMatchHub : MonoBehaviour
	{
		// Token: 0x06000FF4 RID: 4084 RVA: 0x00041E40 File Offset: 0x00040040
		// Note: this type is marked as 'beforefieldinit'.
		static DBGMatchHub()
		{
			Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match.behaviours", "DBGMatchHub");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr);
			DBGMatchHub.NativeFieldInfoPtr__MatchData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, "<MatchData>k__BackingField");
			DBGMatchHub.NativeFieldInfoPtr_sessionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, "sessionProvider");
			DBGMatchHub.NativeFieldInfoPtr__PassTurnBegin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, "<PassTurnBegin>k__BackingField");
			DBGMatchHub.NativeFieldInfoPtr__PassTurnEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, "<PassTurnEnd>k__BackingField");
			DBGMatchHub.NativeFieldInfoPtr_dataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, "dataProvider");
			DBGMatchHub.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665593);
			DBGMatchHub.NativeMethodInfoPtr_get_MatchData_Public_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665594);
			DBGMatchHub.NativeMethodInfoPtr_set_MatchData_Private_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665595);
			DBGMatchHub.NativeMethodInfoPtr_get_PassTurnBegin_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665596);
			DBGMatchHub.NativeMethodInfoPtr_get_PassTurnEnd_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665597);
			DBGMatchHub.NativeMethodInfoPtr_get_NeverSave_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665598);
			DBGMatchHub.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665599);
			DBGMatchHub.NativeMethodInfoPtr_SetGameData_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665600);
			DBGMatchHub.NativeMethodInfoPtr_handle_Private_Void_SequenceMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665601);
			DBGMatchHub.NativeMethodInfoPtr_Initialize_Public_Void_SerializedGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665602);
			DBGMatchHub.NativeMethodInfoPtr_Uninitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665603);
			DBGMatchHub.NativeMethodInfoPtr_InGame_Public_Boolean_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665604);
			DBGMatchHub.NativeMethodInfoPtr_GetResignConfirmationWarning_Public_Virtual_New_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665605);
			DBGMatchHub.NativeMethodInfoPtr_uninitialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665606);
			DBGMatchHub.NativeMethodInfoPtr_createEntities_Protected_Abstract_Virtual_New_Entities_SerializedGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665607);
			DBGMatchHub.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr, 100665608);
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00042014 File Offset: 0x00040214
		public unsafe bool Initialized
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 434802, RefRangeEnd = 434827, XrefRangeStart = 434802, XrefRangeEnd = 434827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00042050 File Offset: 0x00040250
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x00042090 File Offset: 0x00040290
		public unsafe DataComposition MatchData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_get_MatchData_Public_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_set_MatchData_Private_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000420D4 File Offset: 0x000402D4
		public unsafe UnityEvent PassTurnBegin
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_get_PassTurnBegin_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00042114 File Offset: 0x00040314
		public unsafe UnityEvent PassTurnEnd
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_get_PassTurnEnd_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00042154 File Offset: 0x00040354
		public unsafe virtual bool NeverSave
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGMatchHub.NativeMethodInfoPtr_get_NeverSave_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0004219C File Offset: 0x0004039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998420, XrefRangeEnd = 998433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x000421D0 File Offset: 0x000403D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 998440, RefRangeEnd = 998441, XrefRangeStart = 998433, XrefRangeEnd = 998440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_SetGameData_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00042214 File Offset: 0x00040414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998441, XrefRangeEnd = 998496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handle(SequenceMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_handle_Private_Void_SequenceMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00042258 File Offset: 0x00040458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998496, XrefRangeEnd = 998505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(SerializedGameState gameState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_Initialize_Public_Void_SerializedGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004229C File Offset: 0x0004049C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998505, XrefRangeEnd = 998520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_Uninitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000422D0 File Offset: 0x000404D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998520, XrefRangeEnd = 998527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InGame(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr_InGame_Public_Boolean_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00042320 File Offset: 0x00040520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998527, XrefRangeEnd = 998530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LocalizedString GetResignConfirmationWarning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGMatchHub.NativeMethodInfoPtr_GetResignConfirmationWarning_Public_Virtual_New_LocalizedString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0004236C File Offset: 0x0004056C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGMatchHub.NativeMethodInfoPtr_uninitialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000423A8 File Offset: 0x000405A8
		[CallerCount(0)]
		public unsafe virtual Entities createEntities(SerializedGameState gameState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGMatchHub.NativeMethodInfoPtr_createEntities_Protected_Abstract_Virtual_New_Entities_SerializedGameState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr3) : null;
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00042404 File Offset: 0x00040604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 998540, RefRangeEnd = 998541, XrefRangeStart = 998530, XrefRangeEnd = 998540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGMatchHub()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGMatchHub>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchHub.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0000965C File Offset: 0x0000785C
		public DBGMatchHub(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x00042440 File Offset: 0x00040640
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00009665 File Offset: 0x00007865
		public unsafe DataComposition _MatchData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr__MatchData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr__MatchData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00042470 File Offset: 0x00040670
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00009684 File Offset: 0x00007884
		public unsafe SessionProvider sessionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr_sessionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr_sessionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x000424A0 File Offset: 0x000406A0
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x000096A3 File Offset: 0x000078A3
		public unsafe UnityEvent _PassTurnBegin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr__PassTurnBegin_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr__PassTurnBegin_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x000424D0 File Offset: 0x000406D0
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x000096C2 File Offset: 0x000078C2
		public unsafe UnityEvent _PassTurnEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr__PassTurnEnd_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr__PassTurnEnd_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00042500 File Offset: 0x00040700
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x000096E1 File Offset: 0x000078E1
		public unsafe SubscriptionProvider dataProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr_dataProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchHub.NativeFieldInfoPtr_dataProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeFieldInfoPtr__MatchData_k__BackingField;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeFieldInfoPtr_sessionProvider;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeFieldInfoPtr__PassTurnBegin_k__BackingField;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr__PassTurnEnd_k__BackingField;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_dataProvider;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchData_Public_get_DataComposition_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchData_Private_set_Void_DataComposition_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_get_PassTurnBegin_Public_get_UnityEvent_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_get_PassTurnEnd_Public_get_UnityEvent_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_get_NeverSave_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_SetGameData_Public_Void_DataComposition_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_handle_Private_Void_SequenceMessage_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_SerializedGameState_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Public_Void_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_InGame_Public_Boolean_GameID_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_GetResignConfirmationWarning_Public_Virtual_New_LocalizedString_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_uninitialize_Protected_Virtual_New_Void_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_createEntities_Protected_Abstract_Virtual_New_Entities_SerializedGameState_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
