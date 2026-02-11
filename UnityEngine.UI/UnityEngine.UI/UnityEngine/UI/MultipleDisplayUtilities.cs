using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200002F RID: 47
	public static class MultipleDisplayUtilities : Object
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x0001B930 File Offset: 0x00019B30
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleDisplayUtilities()
		{
			Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MultipleDisplayUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr);
			MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664163);
			MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForRaycast_Internal_Static_Vector3_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664164);
			MultipleDisplayUtilities.NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664165);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001B99C File Offset: 0x00019B9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1090189, RefRangeEnd = 1090193, XrefRangeStart = 1090187, XrefRangeEnd = 1090189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001B9EC File Offset: 0x00019BEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1090196, RefRangeEnd = 1090199, XrefRangeStart = 1090193, XrefRangeEnd = 1090196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForRaycast_Internal_Static_Vector3_PointerEventData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0001BA30 File Offset: 0x00019C30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1090238, RefRangeEnd = 1090241, XrefRangeStart = 1090199, XrefRangeEnd = 1090238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleDisplayUtilities.NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00003C92 File Offset: 0x00001E92
		public MultipleDisplayUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeMousePositionForRaycast_Internal_Static_Vector3_PointerEventData_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_Int32_0;
	}
}
