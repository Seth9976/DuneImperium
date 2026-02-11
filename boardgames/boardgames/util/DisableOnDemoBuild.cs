using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.util
{
	// Token: 0x02000106 RID: 262
	public class DisableOnDemoBuild : MonoBehaviour
	{
		// Token: 0x06000CBE RID: 3262 RVA: 0x00039624 File Offset: 0x00037824
		// Note: this type is marked as 'beforefieldinit'.
		static DisableOnDemoBuild()
		{
			Il2CppClassPointerStore<DisableOnDemoBuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.util", "DisableOnDemoBuild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableOnDemoBuild>.NativeClassPtr);
			DisableOnDemoBuild.NativeFieldInfoPtr_ShouldDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableOnDemoBuild>.NativeClassPtr, "ShouldDestroy");
			DisableOnDemoBuild.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableOnDemoBuild>.NativeClassPtr, 100665292);
			DisableOnDemoBuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableOnDemoBuild>.NativeClassPtr, 100665293);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00039690 File Offset: 0x00037890
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableOnDemoBuild.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000396C4 File Offset: 0x000378C4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisableOnDemoBuild()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableOnDemoBuild>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableOnDemoBuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00007E44 File Offset: 0x00006044
		public DisableOnDemoBuild(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00039700 File Offset: 0x00037900
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00007E4D File Offset: 0x0000604D
		public unsafe bool ShouldDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableOnDemoBuild.NativeFieldInfoPtr_ShouldDestroy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableOnDemoBuild.NativeFieldInfoPtr_ShouldDestroy)) = value;
			}
		}

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_ShouldDestroy;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
