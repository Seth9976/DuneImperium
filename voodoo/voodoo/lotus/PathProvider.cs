using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200006E RID: 110
	public class PathProvider : MonoBehaviour
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x0001E878 File Offset: 0x0001CA78
		// Note: this type is marked as 'beforefieldinit'.
		static PathProvider()
		{
			Il2CppClassPointerStore<PathProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PathProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathProvider>.NativeClassPtr);
			PathProvider.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathProvider>.NativeClassPtr, 100664172);
			PathProvider.NativeMethodInfoPtr_AddPathToContext_Public_Abstract_Virtual_New_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathProvider>.NativeClassPtr, 100664173);
			PathProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathProvider>.NativeClassPtr, 100664174);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001E8E4 File Offset: 0x0001CAE4
		[CallerCount(0)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathProvider.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001E920 File Offset: 0x0001CB20
		[CallerCount(0)]
		public unsafe virtual void AddPathToContext(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathProvider.NativeMethodInfoPtr_AddPathToContext_Public_Abstract_Virtual_New_Void_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001E970 File Offset: 0x0001CB70
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000052D5 File Offset: 0x000034D5
		public PathProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_AddPathToContext_Public_Abstract_Virtual_New_Void_MoveContext_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
