using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000054 RID: 84
public class MonoPInvokeCallbackAttribute : Attribute
{
	// Token: 0x0600064D RID: 1613 RVA: 0x0002D314 File Offset: 0x0002B514
	// Note: this type is marked as 'beforefieldinit'.
	static MonoPInvokeCallbackAttribute()
	{
		Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "MonoPInvokeCallbackAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr);
		MonoPInvokeCallbackAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr, "type");
		MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr, 100664259);
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x0002D36C File Offset: 0x0002B56C
	[CallerCount(96)]
	[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoPInvokeCallbackAttribute(Type t)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00004123 File Offset: 0x00002323
	public MonoPInvokeCallbackAttribute(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000650 RID: 1616 RVA: 0x0002D3B8 File Offset: 0x0002B5B8
	// (set) Token: 0x06000651 RID: 1617 RVA: 0x0000412C File Offset: 0x0000232C
	public unsafe Type type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPInvokeCallbackAttribute.NativeFieldInfoPtr_type);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPInvokeCallbackAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004C2 RID: 1218
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x040004C3 RID: 1219
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
}
