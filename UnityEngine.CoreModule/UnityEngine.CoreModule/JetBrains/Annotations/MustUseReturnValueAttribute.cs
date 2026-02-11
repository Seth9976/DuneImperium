using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x0200005F RID: 95
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		// Token: 0x06000314 RID: 788 RVA: 0x000039A3 File Offset: 0x00001BA3
		// Note: this type is marked as 'beforefieldinit'.
		static MustUseReturnValueAttribute()
		{
			Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "MustUseReturnValueAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr);
			MustUseReturnValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr, 100663586);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0001EB9C File Offset: 0x0001CD9C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MustUseReturnValueAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MustUseReturnValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000039DC File Offset: 0x00001BDC
		public MustUseReturnValueAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000039E5 File Offset: 0x00001BE5
		public string Justification
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
