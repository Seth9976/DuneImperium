using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000034 RID: 52
	public sealed class WriteOnlyAttribute : Attribute
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00003006 File Offset: 0x00001206
		// Note: this type is marked as 'beforefieldinit'.
		static WriteOnlyAttribute()
		{
			Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "WriteOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr);
			WriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr, 100663428);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001ACE0 File Offset: 0x00018EE0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteOnlyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000303F File Offset: 0x0000123F
		public WriteOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
