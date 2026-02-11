using System;
using dwd.core.match.data;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace boardgames.moz
{
	// Token: 0x02000110 RID: 272
	public class DBGTooltip : MozDisplayObject
	{
		// Token: 0x06000C3C RID: 3132 RVA: 0x0004446C File Offset: 0x0004266C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGTooltip()
		{
			Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "DBGTooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr);
			DBGTooltip.NativeFieldInfoPtr_OnCreateTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "OnCreateTooltip");
			DBGTooltip.NativeFieldInfoPtr_tooltipInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "tooltipInstance");
			DBGTooltip.NativeFieldInfoPtr_fallbackTooltipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "fallbackTooltipPrefab");
			DBGTooltip.NativeFieldInfoPtr_tooltipLookupFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "tooltipLookupFlavors");
			DBGTooltip.NativeFieldInfoPtr_tooltipPrefabLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "tooltipPrefabLookup");
			DBGTooltip.NativeFieldInfoPtr_localizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "localizationKey");
			DBGTooltip.NativeFieldInfoPtr_optionalImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "optionalImage");
			DBGTooltip.NativeFieldInfoPtr_WarnIfEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "WarnIfEmpty");
			DBGTooltip.NativeFieldInfoPtr_placement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "placement");
			DBGTooltip.NativeFieldInfoPtr_disableWithPref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "disableWithPref");
			DBGTooltip.NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "mainCamera");
			DBGTooltip.NativeFieldInfoPtr_tooltipSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "tooltipSource");
			DBGTooltip.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, "entitiesProvider");
			DBGTooltip.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665101);
			DBGTooltip.NativeMethodInfoPtr_setLocKey_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665102);
			DBGTooltip.NativeMethodInfoPtr_setOptionalImage_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665103);
			DBGTooltip.NativeMethodInfoPtr_getLocKey_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665104);
			DBGTooltip.NativeMethodInfoPtr_GetLoc_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665105);
			DBGTooltip.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665106);
			DBGTooltip.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665107);
			DBGTooltip.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665108);
			DBGTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr, 100665109);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00044654 File Offset: 0x00042854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509581, XrefRangeEnd = 509589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTooltip.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00044688 File Offset: 0x00042888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setLocKey(string newKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTooltip.NativeMethodInfoPtr_setLocKey_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000446CC File Offset: 0x000428CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setOptionalImage(Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTooltip.NativeMethodInfoPtr_setOptionalImage_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00044710 File Offset: 0x00042910
		[CallerCount(0)]
		public unsafe string getLocKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTooltip.NativeMethodInfoPtr_getLocKey_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00044748 File Offset: 0x00042948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509595, RefRangeEnd = 509596, XrefRangeStart = 509589, XrefRangeEnd = 509595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetLoc(out string loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DBGTooltip.NativeMethodInfoPtr_GetLoc_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				loc = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000447A0 File Offset: 0x000429A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509729, RefRangeEnd = 509730, XrefRangeStart = 509596, XrefRangeEnd = 509729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTooltip.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000447F0 File Offset: 0x000429F0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTooltip.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0004482C File Offset: 0x00042A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509730, XrefRangeEnd = 509747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTooltip.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00044868 File Offset: 0x00042A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509775, RefRangeEnd = 509776, XrefRangeStart = 509747, XrefRangeEnd = 509775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGTooltip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTooltip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00007E5D File Offset: 0x0000605D
		public DBGTooltip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x000448A4 File Offset: 0x00042AA4
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00007E66 File Offset: 0x00006066
		public unsafe UnityEvent<GameObject> OnCreateTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_OnCreateTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_OnCreateTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x000448D4 File Offset: 0x00042AD4
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00007E85 File Offset: 0x00006085
		public unsafe GameObject tooltipInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00044904 File Offset: 0x00042B04
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00007EA4 File Offset: 0x000060A4
		public unsafe GameObject fallbackTooltipPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_fallbackTooltipPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_fallbackTooltipPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00044934 File Offset: 0x00042B34
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00007EC3 File Offset: 0x000060C3
		public unsafe List<string> tooltipLookupFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipLookupFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipLookupFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00044964 File Offset: 0x00042B64
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00007EE2 File Offset: 0x000060E2
		public unsafe PrefabByFlavorLookup tooltipPrefabLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipPrefabLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLookup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipPrefabLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00044994 File Offset: 0x00042B94
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00007F01 File Offset: 0x00006101
		public unsafe string localizationKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_localizationKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_localizationKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x000449BC File Offset: 0x00042BBC
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00007F20 File Offset: 0x00006120
		public unsafe Sprite optionalImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_optionalImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_optionalImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000449EC File Offset: 0x00042BEC
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00007F3F File Offset: 0x0000613F
		public unsafe bool WarnIfEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_WarnIfEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_WarnIfEmpty)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00044A14 File Offset: 0x00042C14
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00007F5A File Offset: 0x0000615A
		public unsafe Transform placement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_placement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_placement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00044A44 File Offset: 0x00042C44
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00007F79 File Offset: 0x00006179
		public unsafe bool disableWithPref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_disableWithPref);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_disableWithPref)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00044A6C File Offset: 0x00042C6C
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00007F94 File Offset: 0x00006194
		public unsafe Camera mainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_mainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00044A9C File Offset: 0x00042C9C
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00007FB3 File Offset: 0x000061B3
		public unsafe ITooltipSource tooltipSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITooltipSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_tooltipSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00044ACC File Offset: 0x00042CCC
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00007FD2 File Offset: 0x000061D2
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTooltip.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_OnCreateTooltip;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_tooltipInstance;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_fallbackTooltipPrefab;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_tooltipLookupFlavors;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_tooltipPrefabLookup;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_localizationKey;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_optionalImage;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_WarnIfEmpty;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_placement;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_disableWithPref;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_mainCamera;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_tooltipSource;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_setLocKey_Public_Void_String_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_setOptionalImage_Public_Void_Sprite_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_getLocKey_Public_String_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_GetLoc_Public_Boolean_byref_String_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
