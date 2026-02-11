using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000080 RID: 128
	[Serializable]
	public sealed class CLSCompliantAttribute : Attribute
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x00046308 File Offset: 0x00044508
		// Note: this type is marked as 'beforefieldinit'.
		static CLSCompliantAttribute()
		{
			Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CLSCompliantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr);
			CLSCompliantAttribute.NativeFieldInfoPtr__compliant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, "_compliant");
			CLSCompliantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, 100664505);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00046360 File Offset: 0x00044560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CLSCompliantAttribute(bool isCompliant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isCompliant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CLSCompliantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00004211 File Offset: 0x00002411
		public CLSCompliantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x000463A8 File Offset: 0x000445A8
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x0000421A File Offset: 0x0000241A
		public unsafe bool _compliant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CLSCompliantAttribute.NativeFieldInfoPtr__compliant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CLSCompliantAttribute.NativeFieldInfoPtr__compliant)) = value;
			}
		}

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr__compliant;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
