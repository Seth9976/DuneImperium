using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000CF RID: 207
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x0004FC94 File Offset: 0x0004DE94
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateCollection()
		{
			Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509CertificateCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr);
			X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100665287);
			X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100665288);
			X509CertificateCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100665289);
			X509CertificateCollection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100665290);
			X509CertificateCollection.NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100665291);
			X509CertificateCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100665292);
			X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100665293);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0004FD50 File Offset: 0x0004DF50
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 385162, RefRangeEnd = 385185, XrefRangeStart = 385162, XrefRangeEnd = 385185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0004FD8C File Offset: 0x0004DF8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454245, RefRangeEnd = 454246, XrefRangeStart = 454241, XrefRangeEnd = 454245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateCollection(X509CertificateCollection value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700042D RID: 1069
		public unsafe X509Certificate this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454248, RefRangeEnd = 454250, XrefRangeStart = 454246, XrefRangeEnd = 454248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0004FE24 File Offset: 0x0004E024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454257, RefRangeEnd = 454258, XrefRangeStart = 454250, XrefRangeEnd = 454257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(X509Certificate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0004FE74 File Offset: 0x0004E074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454261, RefRangeEnd = 454262, XrefRangeStart = 454258, XrefRangeEnd = 454261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(X509CertificateCollection value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454270, RefRangeEnd = 454272, XrefRangeStart = 454262, XrefRangeEnd = 454270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection.X509CertificateEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454272, XrefRangeEnd = 454273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00007018 File Offset: 0x00005218
		public X509CertificateCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020002D5 RID: 725
		public class X509CertificateEnumerator : Object
		{
			// Token: 0x06002BED RID: 11245 RVA: 0x000C1F08 File Offset: 0x000C0108
			// Note: this type is marked as 'beforefieldinit'.
			static X509CertificateEnumerator()
			{
				Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, "X509CertificateEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr);
				X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, "enumerator");
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100665294);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100665295);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100665296);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100665297);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100665298);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100665299);
			}

			// Token: 0x06002BEE RID: 11246 RVA: 0x000C1FC0 File Offset: 0x000C01C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454210, XrefRangeEnd = 454216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509CertificateEnumerator(X509CertificateCollection mappings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mappings);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000DCC RID: 3532
			// (get) Token: 0x06002BEF RID: 11247 RVA: 0x000C200C File Offset: 0x000C020C
			public unsafe X509Certificate Current
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 454221, RefRangeEnd = 454223, XrefRangeStart = 454216, XrefRangeEnd = 454221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
				}
			}

			// Token: 0x17000DCD RID: 3533
			// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000C204C File Offset: 0x000C024C
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454223, XrefRangeEnd = 454227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BF1 RID: 11249 RVA: 0x000C208C File Offset: 0x000C028C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454227, XrefRangeEnd = 454231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002BF2 RID: 11250 RVA: 0x000C20C8 File Offset: 0x000C02C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454231, XrefRangeEnd = 454235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BF3 RID: 11251 RVA: 0x000C20FC File Offset: 0x000C02FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454239, RefRangeEnd = 454241, XrefRangeStart = 454235, XrefRangeEnd = 454239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002BF4 RID: 11252 RVA: 0x00013CA7 File Offset: 0x00011EA7
			public X509CertificateEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DCB RID: 3531
			// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000C2138 File Offset: 0x000C0338
			// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x00013CB0 File Offset: 0x00011EB0
			public unsafe IEnumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022C5 RID: 8901
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x040022C6 RID: 8902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0;

			// Token: 0x040022C7 RID: 8903
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0;

			// Token: 0x040022C8 RID: 8904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022C9 RID: 8905
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022CA RID: 8906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022CB RID: 8907
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
		}
	}
}
