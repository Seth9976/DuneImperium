using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000042 RID: 66
	public sealed class MemberNotNullWhenAttribute : Attribute
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0000F420 File Offset: 0x0000D620
		// Note: this type is marked as 'beforefieldinit'.
		static MemberNotNullWhenAttribute()
		{
			Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "System.Diagnostics.CodeAnalysis", "MemberNotNullWhenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr);
			MemberNotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, "<ReturnValue>k__BackingField");
			MemberNotNullWhenAttribute.NativeFieldInfoPtr__Members_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, "<Members>k__BackingField");
			MemberNotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, 100663911);
			MemberNotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, 100663912);
			MemberNotNullWhenAttribute.NativeMethodInfoPtr_get_ReturnValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, 100663913);
			MemberNotNullWhenAttribute.NativeMethodInfoPtr_get_Members_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr, 100663914);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184729, XrefRangeEnd = 1184737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600029C RID: 668 RVA: 0x0000F524 File Offset: 0x0000D724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184737, XrefRangeEnd = 1184739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberNotNullWhenAttribute(bool returnValue, [Optional] Il2CppStringArray members)
		{
			if (members == null)
			{
				members = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberNotNullWhenAttribute>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref returnValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberNotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000F58C File Offset: 0x0000D78C
		public unsafe bool ReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberNotNullWhenAttribute.NativeMethodInfoPtr_get_ReturnValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		public unsafe Il2CppStringArray Members
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberNotNullWhenAttribute.NativeMethodInfoPtr_get_Members_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002C76 File Offset: 0x00000E76
		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
			: this(returnValue, new Il2CppStringArray(members))
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002C85 File Offset: 0x00000E85
		public MemberNotNullWhenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000F608 File Offset: 0x0000D808
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00002C8E File Offset: 0x00000E8E
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000F630 File Offset: 0x0000D830
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00002CA9 File Offset: 0x00000EA9
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

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr__ReturnValue_k__BackingField;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr__Members_k__BackingField;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStringArray_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_get_Boolean_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Public_get_Il2CppStringArray_0;
	}
}
