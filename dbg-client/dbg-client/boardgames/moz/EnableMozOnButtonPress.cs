using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x02000112 RID: 274
	public class EnableMozOnButtonPress : MonoBehaviour
	{
		// Token: 0x06000C68 RID: 3176 RVA: 0x00044C50 File Offset: 0x00042E50
		// Note: this type is marked as 'beforefieldinit'.
		static EnableMozOnButtonPress()
		{
			Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "EnableMozOnButtonPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr);
			EnableMozOnButtonPress.NativeFieldInfoPtr_currentlySelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, "currentlySelected");
			EnableMozOnButtonPress.NativeFieldInfoPtr_mozObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, "mozObject");
			EnableMozOnButtonPress.NativeFieldInfoPtr_mozActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, "mozActive");
			EnableMozOnButtonPress.NativeFieldInfoPtr_mozManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, "mozManager");
			EnableMozOnButtonPress.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, 100665113);
			EnableMozOnButtonPress.NativeMethodInfoPtr_Event_ToggleMozSelectedObjectOnButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, 100665114);
			EnableMozOnButtonPress.NativeMethodInfoPtr_Event_ToggleEnableMoz_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, 100665115);
			EnableMozOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr, 100665116);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00044D20 File Offset: 0x00042F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509789, XrefRangeEnd = 509802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableMozOnButtonPress.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00044D54 File Offset: 0x00042F54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509842, RefRangeEnd = 509844, XrefRangeStart = 509802, XrefRangeEnd = 509842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleMozSelectedObjectOnButtonPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableMozOnButtonPress.NativeMethodInfoPtr_Event_ToggleMozSelectedObjectOnButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00044D88 File Offset: 0x00042F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509844, XrefRangeEnd = 509849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleEnableMoz(bool toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toggle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableMozOnButtonPress.NativeMethodInfoPtr_Event_ToggleEnableMoz_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00044DC8 File Offset: 0x00042FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509850, RefRangeEnd = 509851, XrefRangeStart = 509849, XrefRangeEnd = 509850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnableMozOnButtonPress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnableMozOnButtonPress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableMozOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00008019 File Offset: 0x00006219
		public EnableMozOnButtonPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00044E04 File Offset: 0x00043004
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00008022 File Offset: 0x00006222
		public unsafe GameObject currentlySelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_currentlySelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_currentlySelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00044E34 File Offset: 0x00043034
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00008041 File Offset: 0x00006241
		public unsafe BaseMoz mozObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_mozObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseMoz>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_mozObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00044E64 File Offset: 0x00043064
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00008060 File Offset: 0x00006260
		public unsafe bool mozActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_mozActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_mozActive)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00044E8C File Offset: 0x0004308C
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0000807B File Offset: 0x0000627B
		public unsafe MozManager mozManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_mozManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableMozOnButtonPress.NativeFieldInfoPtr_mozManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_currentlySelected;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_mozObject;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_mozActive;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_mozManager;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleMozSelectedObjectOnButtonPress_Public_Void_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleEnableMoz_Public_Void_Boolean_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
