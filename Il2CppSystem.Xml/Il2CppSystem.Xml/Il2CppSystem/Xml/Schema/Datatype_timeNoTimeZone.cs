using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200013F RID: 319
	public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06001B8A RID: 7050 RVA: 0x0000BB1B File Offset: 0x00009D1B
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_timeNoTimeZone()
		{
			Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_timeNoTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr);
			Datatype_timeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr, 100667427);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00089CD4 File Offset: 0x00087ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394363, XrefRangeEnd = 394367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_timeNoTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_timeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0000BB54 File Offset: 0x00009D54
		public Datatype_timeNoTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
