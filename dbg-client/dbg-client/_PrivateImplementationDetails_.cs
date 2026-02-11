using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020002BE RID: 702
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x0600210D RID: 8461 RVA: 0x0008B690 File Offset: 0x00089890
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__7E4E245E6DB2201D803069DA43EF3F4C584455C8977877DF8AD49C8FB9D0F1E7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "7E4E245E6DB2201D803069DA43EF3F4C584455C8977877DF8AD49C8FB9D0F1E7");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F324754BF77A4D8217A65A93DDAEE357D2494A444E58C09D695212E002D04ADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "F324754BF77A4D8217A65A93DDAEE357D2494A444E58C09D695212E002D04ADE");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100668765);
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x0008B6F4 File Offset: 0x000898F4
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

	// Token: 0x0600210F RID: 8463 RVA: 0x00011481 File Offset: 0x0000F681
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170008C9 RID: 2249
	// (get) Token: 0x06002110 RID: 8464 RVA: 0x0008B738 File Offset: 0x00089938
	// (set) Token: 0x06002111 RID: 8465 RVA: 0x0001148A File Offset: 0x0000F68A
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _7E4E245E6DB2201D803069DA43EF3F4C584455C8977877DF8AD49C8FB9D0F1E7
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__7E4E245E6DB2201D803069DA43EF3F4C584455C8977877DF8AD49C8FB9D0F1E7, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__7E4E245E6DB2201D803069DA43EF3F4C584455C8977877DF8AD49C8FB9D0F1E7, (void*)(&value));
		}
	}

	// Token: 0x170008CA RID: 2250
	// (get) Token: 0x06002112 RID: 8466 RVA: 0x0008B754 File Offset: 0x00089954
	// (set) Token: 0x06002113 RID: 8467 RVA: 0x00011498 File Offset: 0x0000F698
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 F324754BF77A4D8217A65A93DDAEE357D2494A444E58C09D695212E002D04ADE
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F324754BF77A4D8217A65A93DDAEE357D2494A444E58C09D695212E002D04ADE, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F324754BF77A4D8217A65A93DDAEE357D2494A444E58C09D695212E002D04ADE, (void*)(&value));
		}
	}

	// Token: 0x040014D4 RID: 5332
	private static readonly IntPtr NativeFieldInfoPtr__7E4E245E6DB2201D803069DA43EF3F4C584455C8977877DF8AD49C8FB9D0F1E7;

	// Token: 0x040014D5 RID: 5333
	private static readonly IntPtr NativeFieldInfoPtr_F324754BF77A4D8217A65A93DDAEE357D2494A444E58C09D695212E002D04ADE;

	// Token: 0x040014D6 RID: 5334
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x020004A9 RID: 1193
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=35534")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x06003894 RID: 14484 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=35534");
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x0001D1C2 File Offset: 0x0001B3C2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x020004AA RID: 1194
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=48838")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x06003896 RID: 14486 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=48838");
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x0001D1EA File Offset: 0x0001B3EA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}
}
