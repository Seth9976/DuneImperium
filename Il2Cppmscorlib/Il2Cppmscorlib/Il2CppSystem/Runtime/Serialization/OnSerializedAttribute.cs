using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000336 RID: 822
	public sealed class OnSerializedAttribute : Attribute
	{
		// Token: 0x06003230 RID: 12848 RVA: 0x00011605 File Offset: 0x0000F805
		// Note: this type is marked as 'beforefieldinit'.
		static OnSerializedAttribute()
		{
			Il2CppClassPointerStore<OnSerializedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnSerializedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnSerializedAttribute>.NativeClassPtr);
			OnSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnSerializedAttribute>.NativeClassPtr, 100671156);
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x000FDD98 File Offset: 0x000FBF98
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnSerializedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnSerializedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0001163E File Offset: 0x0000F83E
		public OnSerializedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
