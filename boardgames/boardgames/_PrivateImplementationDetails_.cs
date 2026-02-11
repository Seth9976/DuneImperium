using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200018A RID: 394
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x0600133C RID: 4924 RVA: 0x0004C96C File Offset: 0x0004AB6C
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__4B388DB2D83BEC96C3195A62E43FC90622B65C461440076AA040B0C77BD6016E = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "4B388DB2D83BEC96C3195A62E43FC90622B65C461440076AA040B0C77BD6016E");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F41497B6A66E6354082A8CCAF0498E4E31F8CDCC031E6AE839CF48E891878E08 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "F41497B6A66E6354082A8CCAF0498E4E31F8CDCC031E6AE839CF48E891878E08");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100666117);
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x0004C9D0 File Offset: 0x0004ABD0
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

	// Token: 0x0600133E RID: 4926 RVA: 0x0000AF78 File Offset: 0x00009178
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x0600133F RID: 4927 RVA: 0x0004CA14 File Offset: 0x0004AC14
	// (set) Token: 0x06001340 RID: 4928 RVA: 0x0000AF81 File Offset: 0x00009181
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _4B388DB2D83BEC96C3195A62E43FC90622B65C461440076AA040B0C77BD6016E
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__4B388DB2D83BEC96C3195A62E43FC90622B65C461440076AA040B0C77BD6016E, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__4B388DB2D83BEC96C3195A62E43FC90622B65C461440076AA040B0C77BD6016E, (void*)(&value));
		}
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x06001341 RID: 4929 RVA: 0x0004CA30 File Offset: 0x0004AC30
	// (set) Token: 0x06001342 RID: 4930 RVA: 0x0000AF8F File Offset: 0x0000918F
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 F41497B6A66E6354082A8CCAF0498E4E31F8CDCC031E6AE839CF48E891878E08
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F41497B6A66E6354082A8CCAF0498E4E31F8CDCC031E6AE839CF48E891878E08, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_F41497B6A66E6354082A8CCAF0498E4E31F8CDCC031E6AE839CF48E891878E08, (void*)(&value));
		}
	}

	// Token: 0x04000BB1 RID: 2993
	private static readonly IntPtr NativeFieldInfoPtr__4B388DB2D83BEC96C3195A62E43FC90622B65C461440076AA040B0C77BD6016E;

	// Token: 0x04000BB2 RID: 2994
	private static readonly IntPtr NativeFieldInfoPtr_F41497B6A66E6354082A8CCAF0498E4E31F8CDCC031E6AE839CF48E891878E08;

	// Token: 0x04000BB3 RID: 2995
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000299 RID: 665
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=17293")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x06001E50 RID: 7760 RVA: 0x000103EF File Offset: 0x0000E5EF
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=17293");
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00010405 File Offset: 0x0000E605
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x0200029A RID: 666
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=28567")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x06001E52 RID: 7762 RVA: 0x00010417 File Offset: 0x0000E617
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=28567");
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0001042D File Offset: 0x0000E62D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}
}
