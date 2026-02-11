using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000101 RID: 257
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06000C68 RID: 3176 RVA: 0x000380B0 File Offset: 0x000362B0
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__135B12FDF553BD6E1375E0A638A4C34562481339040F9FFF533F8291196C099C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "135B12FDF553BD6E1375E0A638A4C34562481339040F9FFF533F8291196C099C");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__7120394F626BBF1FA0CBCCC594E26088288785E527E95DF88B22A147DD1E1350 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "7120394F626BBF1FA0CBCCC594E26088288785E527E95DF88B22A147DD1E1350");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_CFA2525D6ECFADBF5D00E90ABDEEDC48B4E30548C0AF1D158202364CF7A0F0FD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "CFA2525D6ECFADBF5D00E90ABDEEDC48B4E30548C0AF1D158202364CF7A0F0FD");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100665348);
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00038128 File Offset: 0x00036328
	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 282344, RefRangeEnd = 282378, XrefRangeStart = 282344, XrefRangeEnd = 282378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeStringHash(string s)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x0000736D File Offset: 0x0000556D
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0003816C File Offset: 0x0003636C
	// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00007376 File Offset: 0x00005576
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _135B12FDF553BD6E1375E0A638A4C34562481339040F9FFF533F8291196C099C
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__135B12FDF553BD6E1375E0A638A4C34562481339040F9FFF533F8291196C099C, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__135B12FDF553BD6E1375E0A638A4C34562481339040F9FFF533F8291196C099C, (void*)(&value));
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00038188 File Offset: 0x00036388
	// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00007384 File Offset: 0x00005584
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _7120394F626BBF1FA0CBCCC594E26088288785E527E95DF88B22A147DD1E1350
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__7120394F626BBF1FA0CBCCC594E26088288785E527E95DF88B22A147DD1E1350, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__7120394F626BBF1FA0CBCCC594E26088288785E527E95DF88B22A147DD1E1350, (void*)(&value));
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x06000C6F RID: 3183 RVA: 0x000381A4 File Offset: 0x000363A4
	// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00007392 File Offset: 0x00005592
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 CFA2525D6ECFADBF5D00E90ABDEEDC48B4E30548C0AF1D158202364CF7A0F0FD
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_CFA2525D6ECFADBF5D00E90ABDEEDC48B4E30548C0AF1D158202364CF7A0F0FD, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_CFA2525D6ECFADBF5D00E90ABDEEDC48B4E30548C0AF1D158202364CF7A0F0FD, (void*)(&value));
		}
	}

	// Token: 0x040008AB RID: 2219
	private static readonly IntPtr NativeFieldInfoPtr__135B12FDF553BD6E1375E0A638A4C34562481339040F9FFF533F8291196C099C;

	// Token: 0x040008AC RID: 2220
	private static readonly IntPtr NativeFieldInfoPtr__7120394F626BBF1FA0CBCCC594E26088288785E527E95DF88B22A147DD1E1350;

	// Token: 0x040008AD RID: 2221
	private static readonly IntPtr NativeFieldInfoPtr_CFA2525D6ECFADBF5D00E90ABDEEDC48B4E30548C0AF1D158202364CF7A0F0FD;

	// Token: 0x040008AE RID: 2222
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x0200018B RID: 395
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=16")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x0600101B RID: 4123 RVA: 0x00008C7C File Offset: 0x00006E7C
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=16");
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00008C92 File Offset: 0x00006E92
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x0200018C RID: 396
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=16952")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x0600101D RID: 4125 RVA: 0x00008CA4 File Offset: 0x00006EA4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=16952");
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00008CBA File Offset: 0x00006EBA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x0200018D RID: 397
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=17811")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed2
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x00008CCC File Offset: 0x00006ECC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed2()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=17811");
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00008CE2 File Offset: 0x00006EE2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr, ref this));
		}
	}
}
