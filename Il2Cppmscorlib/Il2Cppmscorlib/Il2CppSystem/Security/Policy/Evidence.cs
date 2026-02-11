using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Policy
{
	// Token: 0x0200022A RID: 554
	[Serializable]
	public sealed class Evidence : Object
	{
		// Token: 0x060024C6 RID: 9414 RVA: 0x000CC3A8 File Offset: 0x000CA5A8
		// Note: this type is marked as 'beforefieldinit'.
		static Evidence()
		{
			Il2CppClassPointerStore<Evidence>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Policy", "Evidence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evidence>.NativeClassPtr);
			Evidence.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "_locked");
			Evidence.NativeFieldInfoPtr_hostEvidenceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "hostEvidenceList");
			Evidence.NativeFieldInfoPtr_assemblyEvidenceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "assemblyEvidenceList");
			Evidence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100669470);
			Evidence.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100669471);
			Evidence.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100669472);
			Evidence.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100669473);
			Evidence.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100669474);
			Evidence.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100669475);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000CC48C File Offset: 0x000CA68C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Evidence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evidence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000CC4C8 File Offset: 0x000CA6C8
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x000CC504 File Offset: 0x000CA704
		public unsafe bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000CC540 File Offset: 0x000CA740
		public unsafe Object SyncRoot
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x000CC580 File Offset: 0x000CA780
		[CallerCount(0)]
		public unsafe void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000CC5D0 File Offset: 0x000CA7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370594, XrefRangeEnd = 1370601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0000BD5B File Offset: 0x00009F5B
		public Evidence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x000CC610 File Offset: 0x000CA810
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0000BD64 File Offset: 0x00009F64
		public unsafe bool _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000CC638 File Offset: 0x000CA838
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x0000BD7F File Offset: 0x00009F7F
		public unsafe ArrayList hostEvidenceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_hostEvidenceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_hostEvidenceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000CC668 File Offset: 0x000CA868
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0000BD9E File Offset: 0x00009F9E
		public unsafe ArrayList assemblyEvidenceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_assemblyEvidenceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_assemblyEvidenceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeFieldInfoPtr_hostEvidenceList;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeFieldInfoPtr_assemblyEvidenceList;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200065F RID: 1631
		public class EvidenceEnumerator : Object
		{
			// Token: 0x06005A78 RID: 23160 RVA: 0x0019D73C File Offset: 0x0019B93C
			// Note: this type is marked as 'beforefieldinit'.
			static EvidenceEnumerator()
			{
				Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "EvidenceEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr);
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "currentEnum");
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "hostEnum");
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "assemblyEnum");
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100669476);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100669477);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100669478);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100669479);
			}

			// Token: 0x06005A79 RID: 23161 RVA: 0x0019D7F4 File Offset: 0x0019B9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370573, XrefRangeEnd = 1370577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hostenum);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyenum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A7A RID: 23162 RVA: 0x0019D854 File Offset: 0x0019BA54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370577, XrefRangeEnd = 1370583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A7B RID: 23163 RVA: 0x0019D890 File Offset: 0x0019BA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370583, XrefRangeEnd = 1370590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700171C RID: 5916
			// (get) Token: 0x06005A7C RID: 23164 RVA: 0x0019D8C4 File Offset: 0x0019BAC4
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370590, XrefRangeEnd = 1370594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A7D RID: 23165 RVA: 0x00020794 File Offset: 0x0001E994
			public EvidenceEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001719 RID: 5913
			// (get) Token: 0x06005A7E RID: 23166 RVA: 0x0019D904 File Offset: 0x0019BB04
			// (set) Token: 0x06005A7F RID: 23167 RVA: 0x0002079D File Offset: 0x0001E99D
			public unsafe IEnumerator currentEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700171A RID: 5914
			// (get) Token: 0x06005A80 RID: 23168 RVA: 0x0019D934 File Offset: 0x0019BB34
			// (set) Token: 0x06005A81 RID: 23169 RVA: 0x000207BC File Offset: 0x0001E9BC
			public unsafe IEnumerator hostEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700171B RID: 5915
			// (get) Token: 0x06005A82 RID: 23170 RVA: 0x0019D964 File Offset: 0x0019BB64
			// (set) Token: 0x06005A83 RID: 23171 RVA: 0x000207DB File Offset: 0x0001E9DB
			public unsafe IEnumerator assemblyEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040049FD RID: 18941
			private static readonly IntPtr NativeFieldInfoPtr_currentEnum;

			// Token: 0x040049FE RID: 18942
			private static readonly IntPtr NativeFieldInfoPtr_hostEnum;

			// Token: 0x040049FF RID: 18943
			private static readonly IntPtr NativeFieldInfoPtr_assemblyEnum;

			// Token: 0x04004A00 RID: 18944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0;

			// Token: 0x04004A01 RID: 18945
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004A02 RID: 18946
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004A03 RID: 18947
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
