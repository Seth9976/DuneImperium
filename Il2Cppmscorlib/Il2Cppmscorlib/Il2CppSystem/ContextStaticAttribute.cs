using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200012F RID: 303
	[Serializable]
	public class ContextStaticAttribute : Attribute
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x00006640 File Offset: 0x00004840
		// Note: this type is marked as 'beforefieldinit'.
		static ContextStaticAttribute()
		{
			Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ContextStaticAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr);
			ContextStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr, 100666860);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0008715C File Offset: 0x0008535C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextStaticAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00006679 File Offset: 0x00004879
		public ContextStaticAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
