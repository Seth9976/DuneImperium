using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x0200000B RID: 11
	public class OverrideAnimatorControllerForPlatform : MonoBehaviour
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003C30 File Offset: 0x00001E30
		// Note: this type is marked as 'beforefieldinit'.
		static OverrideAnimatorControllerForPlatform()
		{
			Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "OverrideAnimatorControllerForPlatform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr);
			OverrideAnimatorControllerForPlatform.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr, "entries");
			OverrideAnimatorControllerForPlatform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr, 100663327);
			OverrideAnimatorControllerForPlatform.NativeMethodInfoPtr_SetPlatformRuntimeAnimatorController_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr, 100663328);
			OverrideAnimatorControllerForPlatform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr, 100663329);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003CB0 File Offset: 0x00001EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238779, XrefRangeEnd = 1238788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideAnimatorControllerForPlatform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003CE4 File Offset: 0x00001EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlatformRuntimeAnimatorController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideAnimatorControllerForPlatform.NativeMethodInfoPtr_SetPlatformRuntimeAnimatorController_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003D18 File Offset: 0x00001F18
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverrideAnimatorControllerForPlatform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideAnimatorControllerForPlatform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000220E File Offset: 0x0000040E
		public OverrideAnimatorControllerForPlatform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003D54 File Offset: 0x00001F54
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002217 File Offset: 0x00000417
		public unsafe Il2CppReferenceArray<OverrideAnimatorControllerForPlatform.ControllerOverride> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideAnimatorControllerForPlatform.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OverrideAnimatorControllerForPlatform.ControllerOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideAnimatorControllerForPlatform.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformRuntimeAnimatorController_Public_Void_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000031 RID: 49
		[Serializable]
		public sealed class ControllerOverride : ValueType
		{
			// Token: 0x060001B6 RID: 438 RVA: 0x00008064 File Offset: 0x00006264
			// Note: this type is marked as 'beforefieldinit'.
			static ControllerOverride()
			{
				Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform.ControllerOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform>.NativeClassPtr, "ControllerOverride");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform.ControllerOverride>.NativeClassPtr);
				OverrideAnimatorControllerForPlatform.ControllerOverride.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform.ControllerOverride>.NativeClassPtr, "Platform");
				OverrideAnimatorControllerForPlatform.ControllerOverride.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform.ControllerOverride>.NativeClassPtr, "Controller");
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00002CC2 File Offset: 0x00000EC2
			public ControllerOverride(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x00002CCB File Offset: 0x00000ECB
			public ControllerOverride()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideAnimatorControllerForPlatform.ControllerOverride>.NativeClassPtr))
			{
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001B9 RID: 441 RVA: 0x000080B8 File Offset: 0x000062B8
			// (set) Token: 0x060001BA RID: 442 RVA: 0x00002CDD File Offset: 0x00000EDD
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideAnimatorControllerForPlatform.ControllerOverride.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideAnimatorControllerForPlatform.ControllerOverride.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001BB RID: 443 RVA: 0x000080E0 File Offset: 0x000062E0
			// (set) Token: 0x060001BC RID: 444 RVA: 0x00002CF8 File Offset: 0x00000EF8
			public unsafe RuntimeAnimatorController Controller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideAnimatorControllerForPlatform.ControllerOverride.NativeFieldInfoPtr_Controller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideAnimatorControllerForPlatform.ControllerOverride.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000F7 RID: 247
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x040000F8 RID: 248
			private static readonly IntPtr NativeFieldInfoPtr_Controller;
		}
	}
}
