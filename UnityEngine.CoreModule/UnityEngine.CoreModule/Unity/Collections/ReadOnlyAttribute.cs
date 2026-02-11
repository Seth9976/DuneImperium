using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000033 RID: 51
	public sealed class ReadOnlyAttribute : Attribute
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00002FC4 File Offset: 0x000011C4
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttribute()
		{
			Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "ReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr);
			ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100663427);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001ACA4 File Offset: 0x00018EA4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002FFD File Offset: 0x000011FD
		public ReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
