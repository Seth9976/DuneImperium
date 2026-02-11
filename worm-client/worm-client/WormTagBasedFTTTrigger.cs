using System;
using boardgames.match.behaviours;
using boardgames.moz;
using dwd.core.eventTriggers;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using worm.canis.data.enums;

// Token: 0x02000015 RID: 21
public class WormTagBasedFTTTrigger : MonoBehaviour
{
	// Token: 0x060000B1 RID: 177 RVA: 0x0001AD34 File Offset: 0x00018F34
	// Note: this type is marked as 'beforefieldinit'.
	static WormTagBasedFTTTrigger()
	{
		Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormTagBasedFTTTrigger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr);
		WormTagBasedFTTTrigger.NativeFieldInfoPtr_mozManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, "mozManager");
		WormTagBasedFTTTrigger.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, "entitiesProvider");
		WormTagBasedFTTTrigger.NativeFieldInfoPtr_clientEventResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, "clientEventResponder");
		WormTagBasedFTTTrigger.NativeFieldInfoPtr__LastTriggerCard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, "<LastTriggerCard>k__BackingField");
		WormTagBasedFTTTrigger.NativeMethodInfoPtr_get_EventName_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663405);
		WormTagBasedFTTTrigger.NativeMethodInfoPtr_get_Tag_Protected_Virtual_New_get_CardTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663406);
		WormTagBasedFTTTrigger.NativeMethodInfoPtr_get_LastTriggerCard_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663407);
		WormTagBasedFTTTrigger.NativeMethodInfoPtr_set_LastTriggerCard_Private_set_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663408);
		WormTagBasedFTTTrigger.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663409);
		WormTagBasedFTTTrigger.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663410);
		WormTagBasedFTTTrigger.NativeMethodInfoPtr_HandleMoz_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663411);
		WormTagBasedFTTTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, 100663412);
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x0001AE54 File Offset: 0x00019054
	public unsafe virtual string EventName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687522, XrefRangeEnd = 687524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTagBasedFTTTrigger.NativeMethodInfoPtr_get_EventName_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000B3 RID: 179 RVA: 0x0001AE98 File Offset: 0x00019098
	public unsafe virtual CardTags Tag
	{
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTagBasedFTTTrigger.NativeMethodInfoPtr_get_Tag_Protected_Virtual_New_get_CardTags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x0001AEE0 File Offset: 0x000190E0
	// (set) Token: 0x060000B5 RID: 181 RVA: 0x0001AF20 File Offset: 0x00019120
	public unsafe EntityComponent LastTriggerCard
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger.NativeMethodInfoPtr_get_LastTriggerCard_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger.NativeMethodInfoPtr_set_LastTriggerCard_Private_set_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0001AF64 File Offset: 0x00019164
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687524, XrefRangeEnd = 687529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0001AFA4 File Offset: 0x000191A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687529, XrefRangeEnd = 687542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0001AFD8 File Offset: 0x000191D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687542, XrefRangeEnd = 687580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleMoz(string entityIDString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(entityIDString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger.NativeMethodInfoPtr_HandleMoz_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0001B01C File Offset: 0x0001921C
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormTagBasedFTTTrigger()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000257D File Offset: 0x0000077D
	public WormTagBasedFTTTrigger(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000BB RID: 187 RVA: 0x0001B058 File Offset: 0x00019258
	// (set) Token: 0x060000BC RID: 188 RVA: 0x00002586 File Offset: 0x00000786
	public unsafe MozManager mozManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr_mozManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr_mozManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000BD RID: 189 RVA: 0x0001B088 File Offset: 0x00019288
	// (set) Token: 0x060000BE RID: 190 RVA: 0x000025A5 File Offset: 0x000007A5
	public unsafe DBGEntitiesProvider entitiesProvider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr_entitiesProvider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000BF RID: 191 RVA: 0x0001B0B8 File Offset: 0x000192B8
	// (set) Token: 0x060000C0 RID: 192 RVA: 0x000025C4 File Offset: 0x000007C4
	public unsafe ClientEventResponder clientEventResponder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr_clientEventResponder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponder>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr_clientEventResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x0001B0E8 File Offset: 0x000192E8
	// (set) Token: 0x060000C2 RID: 194 RVA: 0x000025E3 File Offset: 0x000007E3
	public unsafe EntityComponent _LastTriggerCard_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr__LastTriggerCard_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger.NativeFieldInfoPtr__LastTriggerCard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000067 RID: 103
	private static readonly IntPtr NativeFieldInfoPtr_mozManager;

	// Token: 0x04000068 RID: 104
	private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

	// Token: 0x04000069 RID: 105
	private static readonly IntPtr NativeFieldInfoPtr_clientEventResponder;

	// Token: 0x0400006A RID: 106
	private static readonly IntPtr NativeFieldInfoPtr__LastTriggerCard_k__BackingField;

	// Token: 0x0400006B RID: 107
	private static readonly IntPtr NativeMethodInfoPtr_get_EventName_Protected_Virtual_New_get_String_0;

	// Token: 0x0400006C RID: 108
	private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Protected_Virtual_New_get_CardTags_0;

	// Token: 0x0400006D RID: 109
	private static readonly IntPtr NativeMethodInfoPtr_get_LastTriggerCard_Public_get_EntityComponent_0;

	// Token: 0x0400006E RID: 110
	private static readonly IntPtr NativeMethodInfoPtr_set_LastTriggerCard_Private_set_Void_EntityComponent_0;

	// Token: 0x0400006F RID: 111
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x04000070 RID: 112
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000071 RID: 113
	private static readonly IntPtr NativeMethodInfoPtr_HandleMoz_Private_Void_String_0;

	// Token: 0x04000072 RID: 114
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002B4 RID: 692
	[ObfuscatedName("WormTagBasedFTTTrigger+<Start>d__11")]
	public sealed class _Start_d__11 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C39 RID: 7225 RVA: 0x0006EDDC File Offset: 0x0006CFDC
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__11()
		{
			Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTagBasedFTTTrigger>.NativeClassPtr, "<Start>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr);
			WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, "<>1__state");
			WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, "<>2__current");
			WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, "<>4__this");
			WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, 100663413);
			WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, 100663414);
			WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, 100663415);
			WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, 100663416);
			WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, 100663417);
			WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr, 100663418);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0006EEBC File Offset: 0x0006D0BC
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__11(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTagBasedFTTTrigger._Start_d__11>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0006EF04 File Offset: 0x0006D104
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0006EF38 File Offset: 0x0006D138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687505, XrefRangeEnd = 687517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0006EF74 File Offset: 0x0006D174
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0006EFB4 File Offset: 0x0006D1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687517, XrefRangeEnd = 687522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0006EFE8 File Offset: 0x0006D1E8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTagBasedFTTTrigger._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0001038D File Offset: 0x0000E58D
		public _Start_d__11(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x0006F028 File Offset: 0x0006D228
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x00010396 File Offset: 0x0000E596
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0006F050 File Offset: 0x0006D250
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x000103B1 File Offset: 0x0000E5B1
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x0006F080 File Offset: 0x0006D280
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x000103D0 File Offset: 0x0000E5D0
		public unsafe WormTagBasedFTTTrigger __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTagBasedFTTTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTagBasedFTTTrigger._Start_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
