using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000223 RID: 547
	public static class VisualElementExtensions : Object
	{
		// Token: 0x06002918 RID: 10520 RVA: 0x000B3FC4 File Offset: 0x000B21C4
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementExtensions()
		{
			Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr);
			VisualElementExtensions.NativeMethodInfoPtr_StretchToParentSize_Public_Static_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100669476);
			VisualElementExtensions.NativeMethodInfoPtr_AddManipulator_Public_Static_Void_VisualElement_IManipulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100669477);
			VisualElementExtensions.NativeMethodInfoPtr_RemoveManipulator_Public_Static_Void_VisualElement_IManipulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100669478);
			VisualElementExtensions.NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100669479);
			VisualElementExtensions.NativeMethodInfoPtr_LocalToWorld_Public_Static_Vector2_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100669480);
			VisualElementExtensions.NativeMethodInfoPtr_WorldToLocal_Public_Static_Rect_VisualElement_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100669481);
			VisualElementExtensions.NativeMethodInfoPtr_ChangeCoordinatesTo_Public_Static_Vector2_VisualElement_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100669482);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000B4080 File Offset: 0x000B2280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346184, RefRangeEnd = 346185, XrefRangeStart = 346165, XrefRangeEnd = 346184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StretchToParentSize(this VisualElement elem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_StretchToParentSize_Public_Static_Void_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000B40B8 File Offset: 0x000B22B8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 346188, RefRangeEnd = 346203, XrefRangeStart = 346185, XrefRangeEnd = 346188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddManipulator(this VisualElement ele, IManipulator manipulator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manipulator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_AddManipulator_Public_Static_Void_VisualElement_IManipulator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000B4100 File Offset: 0x000B2300
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 346206, RefRangeEnd = 346216, XrefRangeStart = 346203, XrefRangeEnd = 346206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveManipulator(this VisualElement ele, IManipulator manipulator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manipulator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_RemoveManipulator_Public_Static_Void_VisualElement_IManipulator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000B4148 File Offset: 0x000B2348
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 346220, RefRangeEnd = 346227, XrefRangeStart = 346216, XrefRangeEnd = 346220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 WorldToLocal(this VisualElement ele, Vector2 p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_VisualElement_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000B4198 File Offset: 0x000B2398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346227, XrefRangeEnd = 346231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 LocalToWorld(this VisualElement ele, Vector2 p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_LocalToWorld_Public_Static_Vector2_VisualElement_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000B41E8 File Offset: 0x000B23E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346236, RefRangeEnd = 346240, XrefRangeStart = 346231, XrefRangeEnd = 346236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect WorldToLocal(this VisualElement ele, Rect r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_WorldToLocal_Public_Static_Rect_VisualElement_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000B4238 File Offset: 0x000B2438
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 346248, RefRangeEnd = 346253, XrefRangeStart = 346240, XrefRangeEnd = 346248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ChangeCoordinatesTo(this VisualElement src, VisualElement dest, Vector2 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_ChangeCoordinatesTo_Public_Static_Vector2_VisualElement_VisualElement_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00010963 File Offset: 0x0000EB63
		public VisualElementExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000B429C File Offset: 0x000B249C
		public static void StretchToParentWidth(VisualElement elem)
		{
			bool flag = elem == null;
			if (flag)
			{
				throw new ArgumentNullException("elem");
			}
			IStyle style = elem.style;
			style.position = Position.Absolute;
			style.left = 0f;
			style.right = 0f;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000B42F4 File Offset: 0x000B24F4
		public static Rect LocalToWorld(VisualElement ele, Rect r)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			return VisualElement.CalculateConservativeRect(ele.worldTransformRef, r);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000B4328 File Offset: 0x000B2528
		public static Rect ChangeCoordinatesTo(VisualElement src, VisualElement dest, Rect rect)
		{
			return dest.WorldToLocal(VisualElementExtensions.LocalToWorld(src, rect));
		}

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_StretchToParentSize_Public_Static_Void_VisualElement_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_AddManipulator_Public_Static_Void_VisualElement_IManipulator_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_RemoveManipulator_Public_Static_Void_VisualElement_IManipulator_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_VisualElement_Vector2_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_LocalToWorld_Public_Static_Vector2_VisualElement_Vector2_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_WorldToLocal_Public_Static_Rect_VisualElement_Rect_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCoordinatesTo_Public_Static_Vector2_VisualElement_VisualElement_Vector2_0;
	}
}
