using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200020E RID: 526
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06001AA6 RID: 6822 RVA: 0x0007FC00 File Offset: 0x0007DE00
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100668138);
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x0007FC50 File Offset: 0x0007DE50
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

	// Token: 0x06001AA8 RID: 6824 RVA: 0x00008BA9 File Offset: 0x00006DA9
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0007FC94 File Offset: 0x0007DE94
	// (set) Token: 0x06001AAA RID: 6826 RVA: 0x00008BB2 File Offset: 0x00006DB2
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9, (void*)(&valueTypeNPrivateSealedUnique));
			return valueTypeNPrivateSealedUnique;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9, (void*)(&value));
		}
	}

	// Token: 0x04001F9F RID: 8095
	private static readonly IntPtr NativeFieldInfoPtr_B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9;

	// Token: 0x04001FA0 RID: 8096
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x020002B2 RID: 690
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=5")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedUnique
	{
		// Token: 0x06002324 RID: 8996 RVA: 0x0000EA15 File Offset: 0x0000CC15
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedUnique()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=5");
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0000EA2B File Offset: 0x0000CC2B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
		}
	}
}
