using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200014D RID: 333
	public class SelectionBaseAttribute : Attribute
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x00009D08 File Offset: 0x00007F08
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionBaseAttribute()
		{
			Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SelectionBaseAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr);
			SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr, 100666759);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00076080 File Offset: 0x00074280
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionBaseAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00009D41 File Offset: 0x00007F41
		public SelectionBaseAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
