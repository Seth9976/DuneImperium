using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000018 RID: 24
	public static class AlignmentUtils : Object
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00021598 File Offset: 0x0001F798
		// Note: this type is marked as 'beforefieldinit'.
		static AlignmentUtils()
		{
			Il2CppClassPointerStore<AlignmentUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "AlignmentUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlignmentUtils>.NativeClassPtr);
			AlignmentUtils.NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignmentUtils>.NativeClassPtr, 100663469);
			AlignmentUtils.NativeMethodInfoPtr_CeilToPixelGrid_Internal_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignmentUtils>.NativeClassPtr, 100663470);
			AlignmentUtils.NativeMethodInfoPtr_RoundToPanelPixelSize_Internal_Static_Single_VisualElement_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignmentUtils>.NativeClassPtr, 100663471);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00021604 File Offset: 0x0001F804
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 283217, RefRangeEnd = 283221, XrefRangeStart = 283216, XrefRangeEnd = 283217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset = 0.02f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlignmentUtils.NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00021660 File Offset: 0x0001F860
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 283222, RefRangeEnd = 283226, XrefRangeStart = 283221, XrefRangeEnd = 283222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset = -0.02f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlignmentUtils.NativeMethodInfoPtr_CeilToPixelGrid_Internal_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000216BC File Offset: 0x0001F8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283228, RefRangeEnd = 283229, XrefRangeStart = 283226, XrefRangeEnd = 283228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RoundToPanelPixelSize(this VisualElement ve, float v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlignmentUtils.NativeMethodInfoPtr_RoundToPanelPixelSize_Internal_Static_Single_VisualElement_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000262C File Offset: 0x0000082C
		public AlignmentUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0002170C File Offset: 0x0001F90C
		public static float FloorToPixelGrid(float v, float pixelsPerPoint, [Optional] float offset)
		{
			return Mathf.Floor(v * pixelsPerPoint + offset) / pixelsPerPoint;
		}

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_Single_Single_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_CeilToPixelGrid_Internal_Static_Single_Single_Single_Single_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_RoundToPanelPixelSize_Internal_Static_Single_VisualElement_Single_0;
	}
}
