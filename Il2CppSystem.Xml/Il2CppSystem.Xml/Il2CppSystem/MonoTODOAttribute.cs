using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000005 RID: 5
	public class MonoTODOAttribute : Attribute
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000020FA File Offset: 0x000002FA
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTODOAttribute()
		{
			Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System", "MonoTODOAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr);
			MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr, 100663301);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000164B4 File Offset: 0x000146B4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTODOAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002133 File Offset: 0x00000333
		public MonoTODOAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
