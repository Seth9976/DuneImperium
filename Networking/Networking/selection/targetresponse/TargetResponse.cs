using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetresponse
{
	// Token: 0x02000064 RID: 100
	public class TargetResponse : Object
	{
		// Token: 0x06000346 RID: 838 RVA: 0x000041C7 File Offset: 0x000023C7
		// Note: this type is marked as 'beforefieldinit'.
		static TargetResponse()
		{
			Il2CppClassPointerStore<TargetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetresponse", "TargetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetResponse>.NativeClassPtr);
			TargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponse>.NativeClassPtr, 100663472);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00004200 File Offset: 0x00002400
		public TargetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
