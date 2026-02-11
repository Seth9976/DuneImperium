using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200013E RID: 318
	public class Datatype_dateTime : Datatype_dateTimeBase
	{
		// Token: 0x06001B87 RID: 7047 RVA: 0x0000BAD9 File Offset: 0x00009CD9
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTime()
		{
			Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr);
			Datatype_dateTime.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr, 100667426);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00089C98 File Offset: 0x00087E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394359, XrefRangeEnd = 394363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTime()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTime.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0000BB12 File Offset: 0x00009D12
		public Datatype_dateTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
