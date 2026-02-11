using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.CodeAnalysis
{
	// Token: 0x02000002 RID: 2
	public sealed class EmbeddedAttribute : Attribute
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// Note: this type is marked as 'beforefieldinit'.
		static EmbeddedAttribute()
		{
			Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "Microsoft.CodeAnalysis", "EmbeddedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr);
			EmbeddedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr, 100663297);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00018B24 File Offset: 0x00016D24
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmbeddedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002089 File Offset: 0x00000289
		public EmbeddedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
