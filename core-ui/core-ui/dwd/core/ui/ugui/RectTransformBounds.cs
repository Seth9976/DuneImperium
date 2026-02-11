using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.ui.ugui
{
	// Token: 0x02000016 RID: 22
	public class RectTransformBounds : MonoBounds
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00005780 File Offset: 0x00003980
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformBounds()
		{
			Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui.ugui", "RectTransformBounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr);
			RectTransformBounds.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr, "rt");
			RectTransformBounds.NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr, 100663410);
			RectTransformBounds.NativeMethodInfoPtr_get_Bounds_Public_Virtual_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr, 100663411);
			RectTransformBounds.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr, 100663412);
			RectTransformBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr, 100663413);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005814 File Offset: 0x00003A14
		public unsafe RectTransform RectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254309, XrefRangeEnd = 1254319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformBounds.NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00005854 File Offset: 0x00003A54
		public unsafe override Bounds Bounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254319, XrefRangeEnd = 1254335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectTransformBounds.NativeMethodInfoPtr_get_Bounds_Public_Virtual_get_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000589C File Offset: 0x00003A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254335, XrefRangeEnd = 1254341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds CalculateBounds(RectTransform rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformBounds.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000058E0 File Offset: 0x00003AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254341, XrefRangeEnd = 1254342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransformBounds()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransformBounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000262B File Offset: 0x0000082B
		public RectTransformBounds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000591C File Offset: 0x00003B1C
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002634 File Offset: 0x00000834
		public unsafe RectTransform rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBounds.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBounds.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_Bounds_Public_Virtual_get_Bounds_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_RectTransform_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
