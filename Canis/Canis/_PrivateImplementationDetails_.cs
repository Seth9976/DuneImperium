using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000235 RID: 565
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06001779 RID: 6009 RVA: 0x00077938 File Offset: 0x00075B38
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__373498FF0A1F42C8B688C475AB9DE1E283A3B35DCDBD61ABB67DDA0B770309F5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "373498FF0A1F42C8B688C475AB9DE1E283A3B35DCDBD61ABB67DDA0B770309F5");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F7A954E9E578F8637B63CD61C4A81035F4BDE2310EC81E36F62569B007AC22AE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "F7A954E9E578F8637B63CD61C4A81035F4BDE2310EC81E36F62569B007AC22AE");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100668738);
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x0007799C File Offset: 0x00075B9C
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

	// Token: 0x0600177B RID: 6011 RVA: 0x0000B315 File Offset: 0x00009515
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x0600177C RID: 6012 RVA: 0x000779E0 File Offset: 0x00075BE0
	// (set) Token: 0x0600177D RID: 6013 RVA: 0x0000B31E File Offset: 0x0000951E
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _373498FF0A1F42C8B688C475AB9DE1E283A3B35DCDBD61ABB67DDA0B770309F5
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__373498FF0A1F42C8B688C475AB9DE1E283A3B35DCDBD61ABB67DDA0B770309F5, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__373498FF0A1F42C8B688C475AB9DE1E283A3B35DCDBD61ABB67DDA0B770309F5, (void*)(&value));
		}
	}

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x0600177E RID: 6014 RVA: 0x000779FC File Offset: 0x00075BFC
	// (set) Token: 0x0600177F RID: 6015 RVA: 0x0000B32C File Offset: 0x0000952C
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 F7A954E9E578F8637B63CD61C4A81035F4BDE2310EC81E36F62569B007AC22AE
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F7A954E9E578F8637B63CD61C4A81035F4BDE2310EC81E36F62569B007AC22AE, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F7A954E9E578F8637B63CD61C4A81035F4BDE2310EC81E36F62569B007AC22AE, (void*)(&value));
		}
	}

	// Token: 0x04000F0D RID: 3853
	private static readonly IntPtr NativeFieldInfoPtr__373498FF0A1F42C8B688C475AB9DE1E283A3B35DCDBD61ABB67DDA0B770309F5;

	// Token: 0x04000F0E RID: 3854
	private static readonly IntPtr NativeFieldInfoPtr_F7A954E9E578F8637B63CD61C4A81035F4BDE2310EC81E36F62569B007AC22AE;

	// Token: 0x04000F0F RID: 3855
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000488 RID: 1160
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=22621")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x060034BA RID: 13498 RVA: 0x000197AA File Offset: 0x000179AA
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=22621");
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x000197C0 File Offset: 0x000179C0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000489 RID: 1161
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=23937")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x060034BC RID: 13500 RVA: 0x000197D2 File Offset: 0x000179D2
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=23937");
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000197E8 File Offset: 0x000179E8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}
}
