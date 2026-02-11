using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class OnChangedCallAttribute : PropertyAttribute
{
	// Token: 0x060000A4 RID: 164 RVA: 0x0001F844 File Offset: 0x0001DA44
	// Note: this type is marked as 'beforefieldinit'.
	static OnChangedCallAttribute()
	{
		Il2CppClassPointerStore<OnChangedCallAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "OnChangedCallAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnChangedCallAttribute>.NativeClassPtr);
		OnChangedCallAttribute.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnChangedCallAttribute>.NativeClassPtr, "methodName");
		OnChangedCallAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnChangedCallAttribute>.NativeClassPtr, 100663422);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0001F89C File Offset: 0x0001DA9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495874, XrefRangeEnd = 495876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OnChangedCallAttribute(string methodNameNoArguments)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnChangedCallAttribute>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodNameNoArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnChangedCallAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002472 File Offset: 0x00000672
	public OnChangedCallAttribute(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x0001F8E8 File Offset: 0x0001DAE8
	// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000247B File Offset: 0x0000067B
	public unsafe string methodName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnChangedCallAttribute.NativeFieldInfoPtr_methodName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnChangedCallAttribute.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000064 RID: 100
	private static readonly IntPtr NativeFieldInfoPtr_methodName;

	// Token: 0x04000065 RID: 101
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
