using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000337 RID: 823
	public sealed class OnDeserializingAttribute : Attribute
	{
		// Token: 0x06003233 RID: 12851 RVA: 0x00011647 File Offset: 0x0000F847
		// Note: this type is marked as 'beforefieldinit'.
		static OnDeserializingAttribute()
		{
			Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnDeserializingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr);
			OnDeserializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr, 100671157);
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x000FDDD4 File Offset: 0x000FBFD4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDeserializingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDeserializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00011680 File Offset: 0x0000F880
		public OnDeserializingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
