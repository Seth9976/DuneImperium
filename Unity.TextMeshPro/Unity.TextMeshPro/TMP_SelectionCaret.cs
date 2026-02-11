using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200004F RID: 79
	public class TMP_SelectionCaret : MaskableGraphic
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x00025DB4 File Offset: 0x00023FB4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SelectionCaret()
		{
			Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SelectionCaret");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr);
			TMP_SelectionCaret.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr, 100664266);
			TMP_SelectionCaret.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr, 100664267);
			TMP_SelectionCaret.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr, 100664268);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00025E20 File Offset: 0x00024020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044910, XrefRangeEnd = 1044912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SelectionCaret.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00025E78 File Offset: 0x00024078
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SelectionCaret.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00025EB4 File Offset: 0x000240B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044912, XrefRangeEnd = 1044913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SelectionCaret()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SelectionCaret.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00005DE3 File Offset: 0x00003FE3
		public TMP_SelectionCaret(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
