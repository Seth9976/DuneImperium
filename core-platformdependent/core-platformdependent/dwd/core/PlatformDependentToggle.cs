using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core
{
	// Token: 0x02000008 RID: 8
	public class PlatformDependentToggle : MonoBehaviour
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003690 File Offset: 0x00001890
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentToggle()
		{
			Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core", "PlatformDependentToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr);
			PlatformDependentToggle.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr, "Platform");
			PlatformDependentToggle.NativeFieldInfoPtr_enabledObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr, "enabledObject");
			PlatformDependentToggle.NativeFieldInfoPtr_disableInstead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr, "disableInstead");
			PlatformDependentToggle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr, 100663307);
			PlatformDependentToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003724 File Offset: 0x00001924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238753, XrefRangeEnd = 1238762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentToggle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003758 File Offset: 0x00001958
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002183 File Offset: 0x00000383
		public PlatformDependentToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003794 File Offset: 0x00001994
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000218C File Offset: 0x0000038C
		public unsafe uint Platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentToggle.NativeFieldInfoPtr_Platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentToggle.NativeFieldInfoPtr_Platform)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000037BC File Offset: 0x000019BC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000021A7 File Offset: 0x000003A7
		public unsafe GameObject enabledObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentToggle.NativeFieldInfoPtr_enabledObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentToggle.NativeFieldInfoPtr_enabledObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000037EC File Offset: 0x000019EC
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000021C6 File Offset: 0x000003C6
		public unsafe bool disableInstead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentToggle.NativeFieldInfoPtr_disableInstead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentToggle.NativeFieldInfoPtr_disableInstead)) = value;
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_Platform;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_enabledObject;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_disableInstead;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
