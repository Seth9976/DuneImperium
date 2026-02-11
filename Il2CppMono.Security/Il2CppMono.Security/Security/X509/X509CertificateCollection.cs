using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		// Token: 0x06000112 RID: 274 RVA: 0x0000875C File Offset: 0x0000695C
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateCollection()
		{
			Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509CertificateCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr);
			X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663467);
			X509CertificateCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663468);
			X509CertificateCollection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663469);
			X509CertificateCollection.NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663470);
			X509CertificateCollection.NativeMethodInfoPtr_Contains_Public_Boolean_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663471);
			X509CertificateCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663472);
			X509CertificateCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663473);
			X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663474);
			X509CertificateCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663475);
			X509CertificateCollection.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663476);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008854 File Offset: 0x00006A54
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

		// Token: 0x17000064 RID: 100
		public unsafe X509Certificate this[int index]
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1147799, RefRangeEnd = 1147804, XrefRangeStart = 1147797, XrefRangeEnd = 1147799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000115 RID: 277 RVA: 0x000088DC File Offset: 0x00006ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147804, XrefRangeEnd = 1147811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000116 RID: 278 RVA: 0x0000892C File Offset: 0x00006B2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1147814, RefRangeEnd = 1147817, XrefRangeStart = 1147811, XrefRangeEnd = 1147814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000117 RID: 279 RVA: 0x00008970 File Offset: 0x00006B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147817, XrefRangeEnd = 1147818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(X509Certificate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_Contains_Public_Boolean_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000089C0 File Offset: 0x00006BC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1147826, RefRangeEnd = 1147832, XrefRangeStart = 1147818, XrefRangeEnd = 1147826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000119 RID: 281 RVA: 0x00008A00 File Offset: 0x00006C00
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 451031, RefRangeEnd = 451039, XrefRangeStart = 451031, XrefRangeEnd = 451039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008A40 File Offset: 0x00006C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008A88 File Offset: 0x00006C88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1147838, RefRangeEnd = 1147842, XrefRangeStart = 1147832, XrefRangeEnd = 1147838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(X509Certificate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[CallerCount(0)]
		public unsafe bool Compare(Il2CppStructArray<byte> array1, Il2CppStructArray<byte> array2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000027A2 File Offset: 0x000009A2
		public X509CertificateCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_X509Certificate_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_X509Certificate_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0200004B RID: 75
		public class X509CertificateEnumerator : Object
		{
			// Token: 0x060004A4 RID: 1188 RVA: 0x00014FD4 File Offset: 0x000131D4
			// Note: this type is marked as 'beforefieldinit'.
			static X509CertificateEnumerator()
			{
				Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, "X509CertificateEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr);
				X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, "enumerator");
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663477);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663478);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663479);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663480);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663481);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663482);
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x0001508C File Offset: 0x0001328C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147753, XrefRangeEnd = 1147759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000150D8 File Offset: 0x000132D8
			public unsafe X509Certificate Current
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 1147764, RefRangeEnd = 1147775, XrefRangeStart = 1147759, XrefRangeEnd = 1147764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00015118 File Offset: 0x00013318
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147775, XrefRangeEnd = 1147779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060004A8 RID: 1192 RVA: 0x00015158 File Offset: 0x00013358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147779, XrefRangeEnd = 1147783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x00015194 File Offset: 0x00013394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147783, XrefRangeEnd = 1147787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004AA RID: 1194 RVA: 0x000151C8 File Offset: 0x000133C8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1147791, RefRangeEnd = 1147797, XrefRangeStart = 1147787, XrefRangeEnd = 1147791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x00003FC0 File Offset: 0x000021C0
			public X509CertificateEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x060004AC RID: 1196 RVA: 0x00015204 File Offset: 0x00013404
			// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003FC9 File Offset: 0x000021C9
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

			// Token: 0x04000469 RID: 1129
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x0400046A RID: 1130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0;

			// Token: 0x0400046B RID: 1131
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0;

			// Token: 0x0400046C RID: 1132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400046D RID: 1133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400046E RID: 1134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400046F RID: 1135
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
		}
	}
}
