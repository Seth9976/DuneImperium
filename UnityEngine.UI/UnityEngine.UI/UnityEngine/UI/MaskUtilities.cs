using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200002C RID: 44
	public class MaskUtilities : Object
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x0001B518 File Offset: 0x00019718
		// Note: this type is marked as 'beforefieldinit'.
		static MaskUtilities()
		{
			Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MaskUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr);
			MaskUtilities.NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664152);
			MaskUtilities.NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664153);
			MaskUtilities.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664154);
			MaskUtilities.NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664155);
			MaskUtilities.NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664156);
			MaskUtilities.NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664157);
			MaskUtilities.NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664158);
			MaskUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664159);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0001B5E8 File Offset: 0x000197E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1089900, RefRangeEnd = 1089904, XrefRangeStart = 1089862, XrefRangeEnd = 1089900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Notify2DMaskStateChanged(Component mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0001B620 File Offset: 0x00019820
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1089942, RefRangeEnd = 1089946, XrefRangeStart = 1089904, XrefRangeEnd = 1089942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyStencilStateChanged(Component mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0001B658 File Offset: 0x00019858
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1089971, RefRangeEnd = 1089975, XrefRangeStart = 1089946, XrefRangeEnd = 1089971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRootSortOverrideCanvas(Transform start)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001B69C File Offset: 0x0001989C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1090015, RefRangeEnd = 1090019, XrefRangeStart = 1089975, XrefRangeEnd = 1090015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stopAfter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001B6F0 File Offset: 0x000198F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1090039, RefRangeEnd = 1090041, XrefRangeStart = 1090019, XrefRangeEnd = 1090039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(father);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001B744 File Offset: 0x00019944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1090098, RefRangeEnd = 1090099, XrefRangeStart = 1090041, XrefRangeEnd = 1090098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr3) : null;
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0001B788 File Offset: 0x00019988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1090153, RefRangeEnd = 1090154, XrefRangeStart = 1090099, XrefRangeEnd = 1090153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clipper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(masks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001B7D0 File Offset: 0x000199D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00003C48 File Offset: 0x00001E48
		public MaskUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
