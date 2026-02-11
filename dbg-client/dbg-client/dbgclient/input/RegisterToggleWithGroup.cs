using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dbgclient.input
{
	// Token: 0x020000B1 RID: 177
	public class RegisterToggleWithGroup : MonoBehaviour
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x00034030 File Offset: 0x00032230
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterToggleWithGroup()
		{
			Il2CppClassPointerStore<RegisterToggleWithGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.input", "RegisterToggleWithGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterToggleWithGroup>.NativeClassPtr);
			RegisterToggleWithGroup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterToggleWithGroup>.NativeClassPtr, 100664391);
			RegisterToggleWithGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterToggleWithGroup>.NativeClassPtr, 100664392);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00034088 File Offset: 0x00032288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504034, XrefRangeEnd = 504042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterToggleWithGroup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000340BC File Offset: 0x000322BC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterToggleWithGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterToggleWithGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterToggleWithGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00005450 File Offset: 0x00003650
		public RegisterToggleWithGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
