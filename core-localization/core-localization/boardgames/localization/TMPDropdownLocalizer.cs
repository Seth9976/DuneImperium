using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.localization
{
	// Token: 0x02000006 RID: 6
	public class TMPDropdownLocalizer : MonoBehaviour
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0000299C File Offset: 0x00000B9C
		// Note: this type is marked as 'beforefieldinit'.
		static TMPDropdownLocalizer()
		{
			Il2CppClassPointerStore<TMPDropdownLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "boardgames.localization", "TMPDropdownLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPDropdownLocalizer>.NativeClassPtr);
			TMPDropdownLocalizer.NativeFieldInfoPtr_dropdownKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPDropdownLocalizer>.NativeClassPtr, "dropdownKeys");
			TMPDropdownLocalizer.NativeFieldInfoPtr_localizedDropdownItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPDropdownLocalizer>.NativeClassPtr, "localizedDropdownItems");
			TMPDropdownLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPDropdownLocalizer>.NativeClassPtr, 100663303);
			TMPDropdownLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPDropdownLocalizer>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A1C File Offset: 0x00000C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266094, XrefRangeEnd = 1266112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPDropdownLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A50 File Offset: 0x00000C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266112, XrefRangeEnd = 1266120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMPDropdownLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPDropdownLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPDropdownLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public TMPDropdownLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe List<string> dropdownKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPDropdownLocalizer.NativeFieldInfoPtr_dropdownKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPDropdownLocalizer.NativeFieldInfoPtr_dropdownKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002ABC File Offset: 0x00000CBC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe bool localizedDropdownItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPDropdownLocalizer.NativeFieldInfoPtr_localizedDropdownItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPDropdownLocalizer.NativeFieldInfoPtr_localizedDropdownItems)) = value;
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_dropdownKeys;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_localizedDropdownItems;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
