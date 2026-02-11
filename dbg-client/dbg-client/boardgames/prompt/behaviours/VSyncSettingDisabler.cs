using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.prompt.behaviours
{
	// Token: 0x02000107 RID: 263
	public class VSyncSettingDisabler : MonoBehaviour
	{
		// Token: 0x06000BA5 RID: 2981 RVA: 0x000425AC File Offset: 0x000407AC
		// Note: this type is marked as 'beforefieldinit'.
		static VSyncSettingDisabler()
		{
			Il2CppClassPointerStore<VSyncSettingDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompt.behaviours", "VSyncSettingDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VSyncSettingDisabler>.NativeClassPtr);
			VSyncSettingDisabler.NativeFieldInfoPtr_vsyncToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VSyncSettingDisabler>.NativeClassPtr, "vsyncToggle");
			VSyncSettingDisabler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncSettingDisabler>.NativeClassPtr, 100664991);
			VSyncSettingDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncSettingDisabler>.NativeClassPtr, 100664992);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00042618 File Offset: 0x00040818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508757, XrefRangeEnd = 508773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VSyncSettingDisabler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0004264C File Offset: 0x0004084C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VSyncSettingDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VSyncSettingDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VSyncSettingDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00007967 File Offset: 0x00005B67
		public VSyncSettingDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00042688 File Offset: 0x00040888
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00007970 File Offset: 0x00005B70
		public unsafe Toggle vsyncToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VSyncSettingDisabler.NativeFieldInfoPtr_vsyncToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VSyncSettingDisabler.NativeFieldInfoPtr_vsyncToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_vsyncToggle;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
