using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D8 RID: 216
	public class ObjectMap : Object
	{
		// Token: 0x06001420 RID: 5152 RVA: 0x00008992 File Offset: 0x00006B92
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectMap()
		{
			Il2CppClassPointerStore<ObjectMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ObjectMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr);
			ObjectMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100666510);
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0006D034 File Offset: 0x0006B234
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x000089CB File Offset: 0x00006BCB
		public ObjectMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
