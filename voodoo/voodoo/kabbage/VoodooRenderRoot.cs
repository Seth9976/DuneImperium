using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x02000029 RID: 41
	public class VoodooRenderRoot : MonoBehaviour
	{
		// Token: 0x06000199 RID: 409 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooRenderRoot()
		{
			Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "VoodooRenderRoot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr);
			VoodooRenderRoot.NativeFieldInfoPtr_staticPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, "staticPath");
			VoodooRenderRoot.NativeFieldInfoPtr_initialConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, "initialConfig");
			VoodooRenderRoot.NativeFieldInfoPtr__Transform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, "<Transform>k__BackingField");
			VoodooRenderRoot.NativeFieldInfoPtr_modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, "modules");
			VoodooRenderRoot.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, "started");
			VoodooRenderRoot.NativeMethodInfoPtr_get_StaticPath_Public_get_VoodooStaticPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663476);
			VoodooRenderRoot.NativeMethodInfoPtr_get_InitialConfig_Public_get_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663477);
			VoodooRenderRoot.NativeMethodInfoPtr_set_InitialConfig_Public_set_Void_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663478);
			VoodooRenderRoot.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663479);
			VoodooRenderRoot.NativeMethodInfoPtr_set_Transform_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663480);
			VoodooRenderRoot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663481);
			VoodooRenderRoot.NativeMethodInfoPtr_UpdateConfig_Public_Void_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663482);
			VoodooRenderRoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr, 100663483);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000E120 File Offset: 0x0000C320
		public unsafe VoodooStaticPath StaticPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr_get_StaticPath_Public_get_VoodooStaticPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooStaticPath>(intPtr3) : null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000E160 File Offset: 0x0000C360
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
		public unsafe VisibilityConfiguration InitialConfig
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr_get_InitialConfig_Public_get_VisibilityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisibilityConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107583, XrefRangeEnd = 1107589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr_set_InitialConfig_Public_set_Void_VisibilityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000E224 File Offset: 0x0000C424
		public unsafe Transform Transform
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr_set_Transform_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000E268 File Offset: 0x0000C468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107589, XrefRangeEnd = 1107598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000E29C File Offset: 0x0000C49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107598, XrefRangeEnd = 1107610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConfig(UnitView unit, VisibilityConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr_UpdateConfig_Public_Void_UnitView_VisibilityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooRenderRoot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooRenderRoot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderRoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002E76 File Offset: 0x00001076
		public VoodooRenderRoot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000E32C File Offset: 0x0000C52C
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002E7F File Offset: 0x0000107F
		public unsafe VoodooStaticPath staticPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_staticPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooStaticPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_staticPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000E35C File Offset: 0x0000C55C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002E9E File Offset: 0x0000109E
		public unsafe VisibilityConfiguration initialConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_initialConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_initialConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000E38C File Offset: 0x0000C58C
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002EBD File Offset: 0x000010BD
		public unsafe Transform _Transform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr__Transform_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr__Transform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002EDC File Offset: 0x000010DC
		public unsafe Il2CppReferenceArray<VoodooRootModule> modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VoodooRootModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002EFB File Offset: 0x000010FB
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderRoot.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_staticPath;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_initialConfig;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr__Transform_k__BackingField;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_modules;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticPath_Public_get_VoodooStaticPath_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialConfig_Public_get_VisibilityConfiguration_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_set_InitialConfig_Public_set_Void_VisibilityConfiguration_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_Transform_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_set_Transform_Private_set_Void_Transform_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Void_UnitView_VisibilityConfiguration_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
