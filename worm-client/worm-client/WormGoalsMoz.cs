using System;
using boardgames.hints;
using boardgames.match.behaviours;
using boardgames.moz;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000011 RID: 17
public class WormGoalsMoz : BaseMoz
{
	// Token: 0x06000082 RID: 130 RVA: 0x0001A3D0 File Offset: 0x000185D0
	// Note: this type is marked as 'beforefieldinit'.
	static WormGoalsMoz()
	{
		Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormGoalsMoz");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr);
		WormGoalsMoz.NativeFieldInfoPtr_goalHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "goalHints");
		WormGoalsMoz.NativeFieldInfoPtr_hintManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "hintManager");
		WormGoalsMoz.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "entitiesProvider");
		WormGoalsMoz.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "provider");
		WormGoalsMoz.NativeFieldInfoPtr_hintedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "hintedEntities");
		WormGoalsMoz.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "<Data>k__BackingField");
		WormGoalsMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663377);
		WormGoalsMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663378);
		WormGoalsMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663379);
		WormGoalsMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663380);
		WormGoalsMoz.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663381);
		WormGoalsMoz.NativeMethodInfoPtr_set_Data_Private_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663382);
		WormGoalsMoz.NativeMethodInfoPtr_Republish_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663383);
		WormGoalsMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663384);
		WormGoalsMoz.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663385);
		WormGoalsMoz.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, 100663386);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0001A540 File Offset: 0x00018740
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687352, XrefRangeEnd = 687362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGoalsMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0001A57C File Offset: 0x0001877C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687362, XrefRangeEnd = 687458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void initMoz(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGoalsMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0001A5CC File Offset: 0x000187CC
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void updateMoz()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGoalsMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0001A608 File Offset: 0x00018808
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687458, XrefRangeEnd = 687464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void endMoz()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGoalsMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000087 RID: 135 RVA: 0x0001A644 File Offset: 0x00018844
	// (set) Token: 0x06000088 RID: 136 RVA: 0x0001A684 File Offset: 0x00018884
	public unsafe virtual DataComposition Data
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.NativeMethodInfoPtr_set_Data_Private_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0001A6C8 File Offset: 0x000188C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687464, XrefRangeEnd = 687465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Republish()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.NativeMethodInfoPtr_Republish_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0001A6FC File Offset: 0x000188FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687465, XrefRangeEnd = 687473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormGoalsMoz()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0001A738 File Offset: 0x00018938
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Transform dwd_core_data_composition_subscription_ISubscriber_get_transform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0001A778 File Offset: 0x00018978
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687473, XrefRangeEnd = 687474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002445 File Offset: 0x00000645
	public WormGoalsMoz(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600008E RID: 142 RVA: 0x0001A7AC File Offset: 0x000189AC
	// (set) Token: 0x0600008F RID: 143 RVA: 0x0000244E File Offset: 0x0000064E
	public unsafe List<WormGoalsMoz.GoalHint> goalHints
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_goalHints);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormGoalsMoz.GoalHint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_goalHints), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000090 RID: 144 RVA: 0x0001A7DC File Offset: 0x000189DC
	// (set) Token: 0x06000091 RID: 145 RVA: 0x0000246D File Offset: 0x0000066D
	public unsafe DBGHintManager hintManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_hintManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHintManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_hintManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000092 RID: 146 RVA: 0x0001A80C File Offset: 0x00018A0C
	// (set) Token: 0x06000093 RID: 147 RVA: 0x0000248C File Offset: 0x0000068C
	public unsafe DBGEntitiesProvider entitiesProvider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_entitiesProvider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000094 RID: 148 RVA: 0x0001A83C File Offset: 0x00018A3C
	// (set) Token: 0x06000095 RID: 149 RVA: 0x000024AB File Offset: 0x000006AB
	public unsafe SubscriptionProvider provider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_provider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000096 RID: 150 RVA: 0x0001A86C File Offset: 0x00018A6C
	// (set) Token: 0x06000097 RID: 151 RVA: 0x000024CA File Offset: 0x000006CA
	public unsafe List<EntityID> hintedEntities
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_hintedEntities);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr_hintedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000098 RID: 152 RVA: 0x0001A89C File Offset: 0x00018A9C
	// (set) Token: 0x06000099 RID: 153 RVA: 0x000024E9 File Offset: 0x000006E9
	public unsafe DataComposition _Data_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr__Data_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeFieldInfoPtr_goalHints;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeFieldInfoPtr_hintManager;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeFieldInfoPtr_provider;

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeFieldInfoPtr_hintedEntities;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_DataComposition_0;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeMethodInfoPtr_set_Data_Private_set_Void_DataComposition_0;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeMethodInfoPtr_Republish_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_get_transform_Private_Virtual_Final_New_Transform_0;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate_Private_Virtual_Final_New_Void_0;

	// Token: 0x020002B0 RID: 688
	[Serializable]
	public sealed class GoalHint : ValueType
	{
		// Token: 0x06001C1B RID: 7195 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
		// Note: this type is marked as 'beforefieldinit'.
		static GoalHint()
		{
			Il2CppClassPointerStore<WormGoalsMoz.GoalHint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "GoalHint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGoalsMoz.GoalHint>.NativeClassPtr);
			WormGoalsMoz.GoalHint.NativeFieldInfoPtr_goalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz.GoalHint>.NativeClassPtr, "goalID");
			WormGoalsMoz.GoalHint.NativeFieldInfoPtr_archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz.GoalHint>.NativeClassPtr, "archetypes");
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0001029A File Offset: 0x0000E49A
		public GoalHint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000102A3 File Offset: 0x0000E4A3
		public GoalHint()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGoalsMoz.GoalHint>.NativeClassPtr))
		{
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0006E934 File Offset: 0x0006CB34
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x000102B5 File Offset: 0x0000E4B5
		public unsafe int goalID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.GoalHint.NativeFieldInfoPtr_goalID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.GoalHint.NativeFieldInfoPtr_goalID)) = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0006E95C File Offset: 0x0006CB5C
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x000102D0 File Offset: 0x0000E4D0
		public unsafe Il2CppReferenceArray<ArchetypeID> archetypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.GoalHint.NativeFieldInfoPtr_archetypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.GoalHint.NativeFieldInfoPtr_archetypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_goalID;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_archetypes;
	}

	// Token: 0x020002B1 RID: 689
	[ObfuscatedName("WormGoalsMoz+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06001C22 RID: 7202 RVA: 0x0006E98C File Offset: 0x0006CB8C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr);
			WormGoalsMoz.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr, "<>9");
			WormGoalsMoz.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr, "<>9__7_0");
			WormGoalsMoz.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr, "<>9__7_3");
			WormGoalsMoz.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr, 100663388);
			WormGoalsMoz.__c.NativeMethodInfoPtr__initMoz_b__7_0_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr, 100663389);
			WormGoalsMoz.__c.NativeMethodInfoPtr__initMoz_b__7_3_Internal_EntityID_KeyValuePair_2_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr, 100663390);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0006EA30 File Offset: 0x0006CC30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGoalsMoz.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0006EA6C File Offset: 0x0006CC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687330, XrefRangeEnd = 687333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _initMoz_b__7_0(DataComposition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.__c.NativeMethodInfoPtr__initMoz_b__7_0_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0006EABC File Offset: 0x0006CCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687333, XrefRangeEnd = 687334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID _initMoz_b__7_3(KeyValuePair<EntityID, EntityComponent> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.__c.NativeMethodInfoPtr__initMoz_b__7_3_Internal_EntityID_KeyValuePair_2_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000102EF File Offset: 0x0000E4EF
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0006EB14 File Offset: 0x0006CD14
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x000102F8 File Offset: 0x0000E4F8
		public unsafe static WormGoalsMoz.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGoalsMoz.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGoalsMoz.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGoalsMoz.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0006EB3C File Offset: 0x0006CD3C
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0001030A File Offset: 0x0000E50A
		public unsafe static Func<DataComposition, bool> __9__7_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGoalsMoz.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataComposition, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGoalsMoz.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0006EB64 File Offset: 0x0006CD64
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0001031C File Offset: 0x0000E51C
		public unsafe static Func<KeyValuePair<EntityID, EntityComponent>, EntityID> __9__7_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGoalsMoz.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, EntityComponent>, EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGoalsMoz.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr__initMoz_b__7_0_Internal_Boolean_DataComposition_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr__initMoz_b__7_3_Internal_EntityID_KeyValuePair_2_EntityID_EntityComponent_0;
	}

	// Token: 0x020002B2 RID: 690
	[ObfuscatedName("WormGoalsMoz+<>c__DisplayClass7_0")]
	public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C2D RID: 7213 RVA: 0x0006EB8C File Offset: 0x0006CD8C
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass7_0()
		{
			Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "<>c__DisplayClass7_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_0>.NativeClassPtr);
			WormGoalsMoz.__c__DisplayClass7_0.NativeFieldInfoPtr_objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_0>.NativeClassPtr, "objective");
			WormGoalsMoz.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_0>.NativeClassPtr, 100663391);
			WormGoalsMoz.__c__DisplayClass7_0.NativeMethodInfoPtr__initMoz_b__1_Internal_Boolean_GoalHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_0>.NativeClassPtr, 100663392);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0006EBF4 File Offset: 0x0006CDF4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass7_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0006EC30 File Offset: 0x0006CE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687334, XrefRangeEnd = 687337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _initMoz_b__1(WormGoalsMoz.GoalHint hint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hint));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.__c__DisplayClass7_0.NativeMethodInfoPtr__initMoz_b__1_Internal_Boolean_GoalHint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0001032E File Offset: 0x0000E52E
		public __c__DisplayClass7_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0006EC84 File Offset: 0x0006CE84
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x00010337 File Offset: 0x0000E537
		public unsafe DataComposition objective
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.__c__DisplayClass7_0.NativeFieldInfoPtr_objective);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.__c__DisplayClass7_0.NativeFieldInfoPtr_objective), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeFieldInfoPtr_objective;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr__initMoz_b__1_Internal_Boolean_GoalHint_0;
	}

	// Token: 0x020002B3 RID: 691
	[ObfuscatedName("WormGoalsMoz+<>c__DisplayClass7_1")]
	public sealed class __c__DisplayClass7_1 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C33 RID: 7219 RVA: 0x0006ECB4 File Offset: 0x0006CEB4
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass7_1()
		{
			Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGoalsMoz>.NativeClassPtr, "<>c__DisplayClass7_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_1>.NativeClassPtr);
			WormGoalsMoz.__c__DisplayClass7_1.NativeFieldInfoPtr_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_1>.NativeClassPtr, "hint");
			WormGoalsMoz.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_1>.NativeClassPtr, 100663393);
			WormGoalsMoz.__c__DisplayClass7_1.NativeMethodInfoPtr__initMoz_b__2_Internal_Boolean_KeyValuePair_2_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_1>.NativeClassPtr, 100663394);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0006ED1C File Offset: 0x0006CF1C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass7_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGoalsMoz.__c__DisplayClass7_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0006ED58 File Offset: 0x0006CF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687337, XrefRangeEnd = 687352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _initMoz_b__2(KeyValuePair<EntityID, EntityComponent> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGoalsMoz.__c__DisplayClass7_1.NativeMethodInfoPtr__initMoz_b__2_Internal_Boolean_KeyValuePair_2_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00010356 File Offset: 0x0000E556
		public __c__DisplayClass7_1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0006EDAC File Offset: 0x0006CFAC
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0001035F File Offset: 0x0000E55F
		public WormGoalsMoz.GoalHint hint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.__c__DisplayClass7_1.NativeFieldInfoPtr_hint);
				return new WormGoalsMoz.GoalHint(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormGoalsMoz.GoalHint>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGoalsMoz.__c__DisplayClass7_1.NativeFieldInfoPtr_hint), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormGoalsMoz.GoalHint>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_hint;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr__initMoz_b__2_Internal_Boolean_KeyValuePair_2_EntityID_EntityComponent_0;
	}
}
