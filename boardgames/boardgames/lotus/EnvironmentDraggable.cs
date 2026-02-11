using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000D3 RID: 211
	public class EnvironmentDraggable : MonoBehaviour
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x000330F4 File Offset: 0x000312F4
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentDraggable()
		{
			Il2CppClassPointerStore<EnvironmentDraggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "EnvironmentDraggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentDraggable>.NativeClassPtr);
			EnvironmentDraggable.NativeMethodInfoPtr_CanDrag_Public_Virtual_New_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentDraggable>.NativeClassPtr, 100665025);
			EnvironmentDraggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentDraggable>.NativeClassPtr, 100665026);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003314C File Offset: 0x0003134C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanDrag(Transform childTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentDraggable.NativeMethodInfoPtr_CanDrag_Public_Virtual_New_Boolean_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000331A4 File Offset: 0x000313A4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentDraggable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentDraggable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentDraggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00006E4D File Offset: 0x0000504D
		public EnvironmentDraggable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_CanDrag_Public_Virtual_New_Boolean_Transform_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
