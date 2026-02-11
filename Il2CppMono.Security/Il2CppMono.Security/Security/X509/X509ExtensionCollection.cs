using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000010 RID: 16
	public sealed class X509ExtensionCollection : CollectionBase
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00009530 File Offset: 0x00007730
		// Note: this type is marked as 'beforefieldinit'.
		static X509ExtensionCollection()
		{
			Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509ExtensionCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr);
			X509ExtensionCollection.NativeFieldInfoPtr_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, "readOnly");
			X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663504);
			X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663505);
			X509ExtensionCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663506);
			X509ExtensionCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663507);
			X509ExtensionCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Extension_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663508);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000095D8 File Offset: 0x000077D8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 385162, RefRangeEnd = 385185, XrefRangeStart = 385162, XrefRangeEnd = 385185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ExtensionCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00009614 File Offset: 0x00007814
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1148094, RefRangeEnd = 1148098, XrefRangeStart = 1148086, XrefRangeEnd = 1148094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ExtensionCollection(ASN1 asn1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00009660 File Offset: 0x00007860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148098, XrefRangeEnd = 1148102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string oid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000096B0 File Offset: 0x000078B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 451031, RefRangeEnd = 451039, XrefRangeStart = 451031, XrefRangeEnd = 451039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000072 RID: 114
		public unsafe X509Extension this[string oid]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1148108, RefRangeEnd = 1148111, XrefRangeStart = 1148102, XrefRangeEnd = 1148108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Extension_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Extension>(intPtr3) : null;
				}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000028AD File Offset: 0x00000AAD
		public X509ExtensionCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00009740 File Offset: 0x00007940
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000028B6 File Offset: 0x00000AB6
		public unsafe bool readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ExtensionCollection.NativeFieldInfoPtr_readOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ExtensionCollection.NativeFieldInfoPtr_readOnly)) = value;
			}
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_readOnly;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509Extension_String_0;
	}
}
