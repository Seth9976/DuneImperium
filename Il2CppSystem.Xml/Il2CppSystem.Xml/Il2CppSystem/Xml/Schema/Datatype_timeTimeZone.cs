using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000140 RID: 320
	public class Datatype_timeTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x0000BB5D File Offset: 0x00009D5D
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_timeTimeZone()
		{
			Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_timeTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr);
			Datatype_timeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr, 100667428);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00089D10 File Offset: 0x00087F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394367, XrefRangeEnd = 394371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_timeTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_timeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0000BB96 File Offset: 0x00009D96
		public Datatype_timeTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
