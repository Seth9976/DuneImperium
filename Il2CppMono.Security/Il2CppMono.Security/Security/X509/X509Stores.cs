using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000013 RID: 19
	public class X509Stores : Object
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00009FAC File Offset: 0x000081AC
		// Note: this type is marked as 'beforefieldinit'.
		static X509Stores()
		{
			Il2CppClassPointerStore<X509Stores>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Stores");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Stores>.NativeClassPtr);
			X509Stores.NativeFieldInfoPtr__storePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, "_storePath");
			X509Stores.NativeFieldInfoPtr__newFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, "_newFormat");
			X509Stores.NativeFieldInfoPtr__trusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, "_trusted");
			X509Stores.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, 100663525);
			X509Stores.NativeMethodInfoPtr_get_TrustedRoot_Public_get_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, 100663526);
			X509Stores.NativeMethodInfoPtr_Open_Public_X509Store_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, 100663527);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000A054 File Offset: 0x00008254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Stores(string path, bool newFormat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Stores>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Stores.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000A0B0 File Offset: 0x000082B0
		public unsafe X509Store TrustedRoot
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1148437, RefRangeEnd = 1148439, XrefRangeStart = 1148425, XrefRangeEnd = 1148437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Stores.NativeMethodInfoPtr_get_TrustedRoot_Public_get_X509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr3) : null;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000A0F0 File Offset: 0x000082F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148445, RefRangeEnd = 1148446, XrefRangeStart = 1148439, XrefRangeEnd = 1148445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Store Open(string storeName, bool create)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Stores.NativeMethodInfoPtr_Open_Public_X509Store_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr3) : null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000029E2 File Offset: 0x00000BE2
		public X509Stores(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000A150 File Offset: 0x00008350
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000029EB File Offset: 0x00000BEB
		public unsafe string _storePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Stores.NativeFieldInfoPtr__storePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Stores.NativeFieldInfoPtr__storePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000A178 File Offset: 0x00008378
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002A0A File Offset: 0x00000C0A
		public unsafe bool _newFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Stores.NativeFieldInfoPtr__newFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Stores.NativeFieldInfoPtr__newFormat)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000A1A0 File Offset: 0x000083A0
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002A25 File Offset: 0x00000C25
		public unsafe X509Store _trusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Stores.NativeFieldInfoPtr__trusted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Stores.NativeFieldInfoPtr__trusted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr__storePath;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr__newFormat;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr__trusted;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_get_TrustedRoot_Public_get_X509Store_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_X509Store_String_Boolean_0;
	}
}
