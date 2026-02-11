using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000038 RID: 56
	public sealed class NativeDisableParallelForRestrictionAttribute : Attribute
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x000030D2 File Offset: 0x000012D2
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableParallelForRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeDisableParallelForRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr);
			NativeDisableParallelForRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr, 100663429);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001AD1C File Offset: 0x00018F1C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableParallelForRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableParallelForRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000310B File Offset: 0x0000130B
		public NativeDisableParallelForRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
