using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000338 RID: 824
	public sealed class OnDeserializedAttribute : Attribute
	{
		// Token: 0x06003236 RID: 12854 RVA: 0x00011689 File Offset: 0x0000F889
		// Note: this type is marked as 'beforefieldinit'.
		static OnDeserializedAttribute()
		{
			Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnDeserializedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr);
			OnDeserializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr, 100671158);
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x000FDE10 File Offset: 0x000FC010
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDeserializedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDeserializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000116C2 File Offset: 0x0000F8C2
		public OnDeserializedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
