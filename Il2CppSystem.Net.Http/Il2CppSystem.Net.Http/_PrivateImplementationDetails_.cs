using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200003B RID: 59
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x060003BC RID: 956 RVA: 0x00013EB4 File Offset: 0x000120B4
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "", "<PrivateImplementationDetails>");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr);
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100663923);
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00013F0C File Offset: 0x0001210C
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

	// Token: 0x060003BE RID: 958 RVA: 0x00003493 File Offset: 0x00001693
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x060003BF RID: 959 RVA: 0x00013F50 File Offset: 0x00012150
	// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000349C File Offset: 0x0000169C
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique _1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729, (void*)(&valueTypeNPrivateSealedUnique));
			return valueTypeNPrivateSealedUnique;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729, (void*)(&value));
		}
	}

	// Token: 0x040002C9 RID: 713
	private static readonly IntPtr NativeFieldInfoPtr__1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729;

	// Token: 0x040002CA RID: 714
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000065 RID: 101
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=127")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedUnique
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x000042C4 File Offset: 0x000024C4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedUnique()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=127");
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000042DA File Offset: 0x000024DA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
		}
	}
}
