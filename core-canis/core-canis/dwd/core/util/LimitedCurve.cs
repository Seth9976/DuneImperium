using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x0200008E RID: 142
	public class LimitedCurve : PropertyAttribute
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x0003A350 File Offset: 0x00038550
		// Note: this type is marked as 'beforefieldinit'.
		static LimitedCurve()
		{
			Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "LimitedCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr);
			LimitedCurve.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr, "Rect");
			LimitedCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr, 100664709);
			LimitedCurve.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr, 100664710);
			LimitedCurve.NativeMethodInfoPtr__ctor_Private_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr, 100664711);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0003A3D0 File Offset: 0x000385D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862603, XrefRangeEnd = 862604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LimitedCurve()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LimitedCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0003A40C File Offset: 0x0003860C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862604, XrefRangeEnd = 862605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LimitedCurve(float left, float top, float width, float height)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LimitedCurve.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0003A480 File Offset: 0x00038680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862605, XrefRangeEnd = 862606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LimitedCurve(Rect rect)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimitedCurve>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LimitedCurve.NativeMethodInfoPtr__ctor_Private_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0000596F File Offset: 0x00003B6F
		public LimitedCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0003A4C8 File Offset: 0x000386C8
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00005978 File Offset: 0x00003B78
		public unsafe Rect Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LimitedCurve.NativeFieldInfoPtr_Rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LimitedCurve.NativeFieldInfoPtr_Rect)) = value;
			}
		}

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Rect_0;
	}
}
