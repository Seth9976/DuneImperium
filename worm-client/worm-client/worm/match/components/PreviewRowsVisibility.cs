using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001BB RID: 443
	public class PreviewRowsVisibility : MonoBehaviour
	{
		// Token: 0x0600138C RID: 5004 RVA: 0x00053814 File Offset: 0x00051A14
		// Note: this type is marked as 'beforefieldinit'.
		static PreviewRowsVisibility()
		{
			Il2CppClassPointerStore<PreviewRowsVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "PreviewRowsVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewRowsVisibility>.NativeClassPtr);
			PreviewRowsVisibility.NativeFieldInfoPtr_onVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewRowsVisibility>.NativeClassPtr, "onVisible");
			PreviewRowsVisibility.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewRowsVisibility>.NativeClassPtr, 100665975);
			PreviewRowsVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewRowsVisibility>.NativeClassPtr, 100665976);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00053880 File Offset: 0x00051A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713181, XrefRangeEnd = 713183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewRowsVisibility.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000538C0 File Offset: 0x00051AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713183, XrefRangeEnd = 713189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreviewRowsVisibility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewRowsVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewRowsVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0000C11D File Offset: 0x0000A31D
		public PreviewRowsVisibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x000538FC File Offset: 0x00051AFC
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x0000C126 File Offset: 0x0000A326
		public unsafe BoolUnityEvents onVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewRowsVisibility.NativeFieldInfoPtr_onVisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewRowsVisibility.NativeFieldInfoPtr_onVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_onVisible;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
