using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000335 RID: 821
	public sealed class OnSerializingAttribute : Attribute
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x000115C3 File Offset: 0x0000F7C3
		// Note: this type is marked as 'beforefieldinit'.
		static OnSerializingAttribute()
		{
			Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnSerializingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr);
			OnSerializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr, 100671155);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000FDD5C File Offset: 0x000FBF5C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnSerializingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnSerializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000115FC File Offset: 0x0000F7FC
		public OnSerializingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
