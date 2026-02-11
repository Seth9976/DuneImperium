using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000041 RID: 65
	public sealed class MemberNotNullAttribute : Attribute
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0000F28C File Offset: 0x0000D48C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberNotNullAttribute()
		{
			Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "System.Diagnostics.CodeAnalysis", "MemberNotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr);
			MemberNotNullAttribute.NativeFieldInfoPtr__Members_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr, "<Members>k__BackingField");
			MemberNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr, 100663908);
			MemberNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr, 100663909);
			MemberNotNullAttribute.NativeMethodInfoPtr_get_Members_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr, 100663910);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000F30C File Offset: 0x0000D50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184721, XrefRangeEnd = 1184729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000294 RID: 660 RVA: 0x0000F358 File Offset: 0x0000D558
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberNotNullAttribute([Optional] Il2CppStringArray members)
		{
			if (members == null)
			{
				members = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberNotNullAttribute>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
		public unsafe Il2CppStringArray Members
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberNotNullAttribute.NativeMethodInfoPtr_get_Members_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002C40 File Offset: 0x00000E40
		public MemberNotNullAttribute(params string[] members)
			: this(new Il2CppStringArray(members))
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002C4E File Offset: 0x00000E4E
		public MemberNotNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002C57 File Offset: 0x00000E57
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

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr__Members_k__BackingField;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Public_get_Il2CppStringArray_0;
	}
}
