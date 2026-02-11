using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000372 RID: 882
	public sealed class NameCache : Object
	{
		// Token: 0x060036F7 RID: 14071 RVA: 0x0010E0A4 File Offset: 0x0010C2A4
		// Note: this type is marked as 'beforefieldinit'.
		static NameCache()
		{
			Il2CppClassPointerStore<NameCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "NameCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameCache>.NativeClassPtr);
			NameCache.NativeFieldInfoPtr_ht = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameCache>.NativeClassPtr, "ht");
			NameCache.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameCache>.NativeClassPtr, "name");
			NameCache.NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100671579);
			NameCache.NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100671580);
			NameCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100671581);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x0010E138 File Offset: 0x0010C338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391132, RefRangeEnd = 1391133, XrefRangeStart = 1391124, XrefRangeEnd = 1391132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetCachedValue(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x0010E188 File Offset: 0x0010C388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391151, RefRangeEnd = 1391152, XrefRangeStart = 1391133, XrefRangeEnd = 1391151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCachedValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x0010E1CC File Offset: 0x0010C3CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00013F70 File Offset: 0x00012170
		public NameCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x0010E208 File Offset: 0x0010C408
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x00013F79 File Offset: 0x00012179
		public unsafe static ConcurrentDictionary<string, Object> ht
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameCache.NativeFieldInfoPtr_ht, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameCache.NativeFieldInfoPtr_ht, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x0010E230 File Offset: 0x0010C430
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x00013F8B File Offset: 0x0001218B
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameCache.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameCache.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeFieldInfoPtr_ht;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
