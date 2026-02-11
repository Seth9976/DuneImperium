using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200013C RID: 316
	public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x0000BA55 File Offset: 0x00009C55
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTimeNoTimeZone()
		{
			Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTimeNoTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr);
			Datatype_dateTimeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr, 100667424);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00089C20 File Offset: 0x00087E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394351, XrefRangeEnd = 394355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTimeNoTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTimeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000BA8E File Offset: 0x00009C8E
		public Datatype_dateTimeNoTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
