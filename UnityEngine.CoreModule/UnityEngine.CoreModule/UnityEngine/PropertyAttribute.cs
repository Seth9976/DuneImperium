using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200010D RID: 269
	public class PropertyAttribute : Attribute
	{
		// Token: 0x0600167C RID: 5756 RVA: 0x00008D6F File Offset: 0x00006F6F
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAttribute()
		{
			Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr);
			PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr, 100666425);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0006C9B4 File Offset: 0x0006ABB4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00008DA8 File Offset: 0x00006FA8
		public PropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00008DB1 File Offset: 0x00006FB1
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x00008DBE File Offset: 0x00006FBE
		public int order
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
