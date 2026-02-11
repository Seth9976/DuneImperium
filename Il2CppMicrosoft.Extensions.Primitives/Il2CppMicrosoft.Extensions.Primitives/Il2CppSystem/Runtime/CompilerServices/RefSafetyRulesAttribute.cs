using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000006 RID: 6
	public sealed class RefSafetyRulesAttribute : Attribute
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002568 File Offset: 0x00000768
		// Note: this type is marked as 'beforefieldinit'.
		static RefSafetyRulesAttribute()
		{
			Il2CppClassPointerStore<RefSafetyRulesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Primitives.dll", "System.Runtime.CompilerServices", "RefSafetyRulesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefSafetyRulesAttribute>.NativeClassPtr);
			RefSafetyRulesAttribute.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefSafetyRulesAttribute>.NativeClassPtr, "Version");
			RefSafetyRulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefSafetyRulesAttribute>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000025C0 File Offset: 0x000007C0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RefSafetyRulesAttribute(int A_1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefSafetyRulesAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefSafetyRulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002102 File Offset: 0x00000302
		public RefSafetyRulesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000210B File Offset: 0x0000030B
		public unsafe int Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefSafetyRulesAttribute.NativeFieldInfoPtr_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefSafetyRulesAttribute.NativeFieldInfoPtr_Version)) = value;
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
