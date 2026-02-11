using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200013B RID: 315
	public class ExcludeFromObjectFactoryAttribute : Attribute
	{
		// Token: 0x0600184B RID: 6219 RVA: 0x00009A29 File Offset: 0x00007C29
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromObjectFactoryAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromObjectFactoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr);
			ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr, 100666604);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00072348 File Offset: 0x00070548
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromObjectFactoryAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00009A62 File Offset: 0x00007C62
		public ExcludeFromObjectFactoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
