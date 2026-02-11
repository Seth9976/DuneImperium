using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200013D RID: 317
	public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x0000BA97 File Offset: 0x00009C97
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTimeTimeZone()
		{
			Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTimeTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr);
			Datatype_dateTimeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr, 100667425);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00089C5C File Offset: 0x00087E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394355, XrefRangeEnd = 394359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTimeTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTimeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0000BAD0 File Offset: 0x00009CD0
		public Datatype_dateTimeTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
