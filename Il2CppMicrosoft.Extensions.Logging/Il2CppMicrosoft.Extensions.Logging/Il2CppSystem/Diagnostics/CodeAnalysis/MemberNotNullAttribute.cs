using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000A RID: 10
	public sealed class MemberNotNullAttribute : Attribute
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00003030 File Offset: 0x00001230
		// Note: this type is marked as 'beforefieldinit'.
		static MemberNotNullAttribute()
		{
			Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "System.Diagnostics.CodeAnalysis", "MemberNotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr);
			MemberNotNullAttribute.NativeFieldInfoPtr__Members_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr, "<Members>k__BackingField");
			MemberNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003088 File Offset: 0x00001288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263896, XrefRangeEnd = 1263904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberNotNullAttribute(string member)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002186 File Offset: 0x00000386
		public MemberNotNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000030D4 File Offset: 0x000012D4
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000218F File Offset: 0x0000038F
		public unsafe Il2CppStringArray _Members_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberNotNullAttribute.NativeFieldInfoPtr__Members_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberNotNullAttribute.NativeFieldInfoPtr__Members_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__Members_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
