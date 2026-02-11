using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000A RID: 10
	public sealed class MemberNotNullWhenAttribute : Attribute
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002D44 File Offset: 0x00000F44
		// Note: this type is marked as 'beforefieldinit'.
		static MemberNotNullWhenAttribute()
		{
			Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "System.Diagnostics.CodeAnalysis", "MemberNotNullWhenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr);
			MemberNotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, "<ReturnValue>k__BackingField");
			MemberNotNullWhenAttribute.NativeFieldInfoPtr__Members_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, "<Members>k__BackingField");
			MemberNotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002DB0 File Offset: 0x00000FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265616, XrefRangeEnd = 1265624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberNotNullWhenAttribute(bool returnValue, string member)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref returnValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberNotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002153 File Offset: 0x00000353
		public MemberNotNullWhenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002E0C File Offset: 0x0000100C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000215C File Offset: 0x0000035C
		public unsafe bool _ReturnValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberNotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberNotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002E34 File Offset: 0x00001034
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002177 File Offset: 0x00000377
		public unsafe Il2CppStringArray _Members_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberNotNullWhenAttribute.NativeFieldInfoPtr__Members_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberNotNullWhenAttribute.NativeFieldInfoPtr__Members_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr__ReturnValue_k__BackingField;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr__Members_k__BackingField;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;
	}
}
