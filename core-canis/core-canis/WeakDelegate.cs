using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

// Token: 0x0200002E RID: 46
public sealed class WeakDelegate : Object
{
	// Token: 0x0600043B RID: 1083 RVA: 0x00024014 File Offset: 0x00022214
	// Note: this type is marked as 'beforefieldinit'.
	static WeakDelegate()
	{
		Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "WeakDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr);
		WeakDelegate.NativeFieldInfoPtr_WeakReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, "WeakReference");
		WeakDelegate.NativeFieldInfoPtr_Method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, "Method");
		WeakDelegate.NativeFieldInfoPtr_WithParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, "WithParam");
		WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, 100663896);
		WeakDelegate.NativeMethodInfoPtr_GetStrongRef_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, 100663897);
		WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, 100663898);
		WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, 100663899);
		WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, 100663900);
		WeakDelegate.NativeMethodInfoPtr_Equals_Public_Boolean_Delegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, 100663901);
		WeakDelegate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr, 100663902);
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x0002410C File Offset: 0x0002230C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856379, XrefRangeEnd = 856388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeakDelegate(Delegate d, bool withParam)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakDelegate>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00024168 File Offset: 0x00022368
	[CallerCount(0)]
	public unsafe Object GetStrongRef()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakDelegate.NativeMethodInfoPtr_GetStrongRef_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x0600043E RID: 1086 RVA: 0x000241A8 File Offset: 0x000223A8
	public unsafe bool IsAlive
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 856393, RefRangeEnd = 856396, XrefRangeStart = 856388, XrefRangeEnd = 856393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x000241E4 File Offset: 0x000223E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856399, RefRangeEnd = 856400, XrefRangeStart = 856396, XrefRangeEnd = 856399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Invoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00024218 File Offset: 0x00022418
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856403, RefRangeEnd = 856404, XrefRangeStart = 856400, XrefRangeEnd = 856403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Invoke(Il2CppReferenceArray<Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x0002425C File Offset: 0x0002245C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856404, XrefRangeEnd = 856406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Delegate @delegate, bool withParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@delegate);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakDelegate.NativeMethodInfoPtr_Equals_Public_Boolean_Delegate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x000242B8 File Offset: 0x000224B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856406, XrefRangeEnd = 856437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakDelegate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00003A03 File Offset: 0x00001C03
	public WeakDelegate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000444 RID: 1092 RVA: 0x000242F0 File Offset: 0x000224F0
	// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003A0C File Offset: 0x00001C0C
	public unsafe WeakReference WeakReference
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakDelegate.NativeFieldInfoPtr_WeakReference);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakDelegate.NativeFieldInfoPtr_WeakReference), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000446 RID: 1094 RVA: 0x00024320 File Offset: 0x00022520
	// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003A2B File Offset: 0x00001C2B
	public unsafe MethodInfo Method
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakDelegate.NativeFieldInfoPtr_Method);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakDelegate.NativeFieldInfoPtr_Method), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000448 RID: 1096 RVA: 0x00024350 File Offset: 0x00022550
	// (set) Token: 0x06000449 RID: 1097 RVA: 0x00003A4A File Offset: 0x00001C4A
	public unsafe bool WithParam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakDelegate.NativeFieldInfoPtr_WithParam);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakDelegate.NativeFieldInfoPtr_WithParam)) = value;
		}
	}

	// Token: 0x04000319 RID: 793
	private static readonly IntPtr NativeFieldInfoPtr_WeakReference;

	// Token: 0x0400031A RID: 794
	private static readonly IntPtr NativeFieldInfoPtr_Method;

	// Token: 0x0400031B RID: 795
	private static readonly IntPtr NativeFieldInfoPtr_WithParam;

	// Token: 0x0400031C RID: 796
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_Boolean_0;

	// Token: 0x0400031D RID: 797
	private static readonly IntPtr NativeMethodInfoPtr_GetStrongRef_Private_Object_0;

	// Token: 0x0400031E RID: 798
	private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

	// Token: 0x0400031F RID: 799
	private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

	// Token: 0x04000320 RID: 800
	private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000321 RID: 801
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Delegate_Boolean_0;

	// Token: 0x04000322 RID: 802
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
