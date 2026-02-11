using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200001A RID: 26
	public class MyIntersectNodeSort : Object
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00018C9C File Offset: 0x00016E9C
		// Note: this type is marked as 'beforefieldinit'.
		static MyIntersectNodeSort()
		{
			Il2CppClassPointerStore<MyIntersectNodeSort>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "MyIntersectNodeSort");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyIntersectNodeSort>.NativeClassPtr);
			MyIntersectNodeSort.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IntersectNode_IntersectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyIntersectNodeSort>.NativeClassPtr, 100663429);
			MyIntersectNodeSort.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyIntersectNodeSort>.NativeClassPtr, 100663430);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00018CF4 File Offset: 0x00016EF4
		[CallerCount(0)]
		public unsafe virtual int Compare(IntersectNode node1, IntersectNode node2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyIntersectNodeSort.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IntersectNode_IntersectNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00018D54 File Offset: 0x00016F54
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MyIntersectNodeSort()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyIntersectNodeSort>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyIntersectNodeSort.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000282E File Offset: 0x00000A2E
		public MyIntersectNodeSort(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IntersectNode_IntersectNode_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
