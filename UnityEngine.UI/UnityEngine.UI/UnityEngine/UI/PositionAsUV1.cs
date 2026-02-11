using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000044 RID: 68
	public class PositionAsUV1 : BaseMeshEffect
	{
		// Token: 0x06000833 RID: 2099 RVA: 0x00027170 File Offset: 0x00025370
		// Note: this type is marked as 'beforefieldinit'.
		static PositionAsUV1()
		{
			Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "PositionAsUV1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr);
			PositionAsUV1.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr, 100664631);
			PositionAsUV1.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr, 100664632);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000271C8 File Offset: 0x000253C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionAsUV1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionAsUV1.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00027204 File Offset: 0x00025404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093960, XrefRangeEnd = 1093964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionAsUV1.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00004D49 File Offset: 0x00002F49
		public PositionAsUV1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
