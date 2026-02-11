using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000043 RID: 67
	public class Outline : Shadow
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x0002708C File Offset: 0x0002528C
		// Note: this type is marked as 'beforefieldinit'.
		static Outline()
		{
			Il2CppClassPointerStore<Outline>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Outline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Outline>.NativeClassPtr);
			Outline.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outline>.NativeClassPtr, 100664629);
			Outline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outline>.NativeClassPtr, 100664630);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000270E4 File Offset: 0x000252E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093928, XrefRangeEnd = 1093929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Outline()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Outline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outline.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00027120 File Offset: 0x00025320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093929, XrefRangeEnd = 1093960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Outline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00004D40 File Offset: 0x00002F40
		public Outline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
