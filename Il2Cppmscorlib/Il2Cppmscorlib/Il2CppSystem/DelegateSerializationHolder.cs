using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200014B RID: 331
	[Serializable]
	public class DelegateSerializationHolder : Object
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00094C44 File Offset: 0x00092E44
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateSerializationHolder()
		{
			Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DelegateSerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr);
			DelegateSerializationHolder.NativeFieldInfoPtr__delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, "_delegate");
			DelegateSerializationHolder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100667359);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100667360);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100667361);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100667362);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00094CD8 File Offset: 0x00092ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346297, XrefRangeEnd = 1346327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00094D3C File Offset: 0x00092F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346327, XrefRangeEnd = 1346355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00094D9C File Offset: 0x00092F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346355, XrefRangeEnd = 1346360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00094DF8 File Offset: 0x00092FF8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0000760A File Offset: 0x0000580A
		public DelegateSerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00094E50 File Offset: 0x00093050
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x00007613 File Offset: 0x00005813
		public unsafe Delegate _delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.NativeFieldInfoPtr__delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.NativeFieldInfoPtr__delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeFieldInfoPtr__delegate;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x020005F4 RID: 1524
		[Serializable]
		public class DelegateEntry : Object
		{
			// Token: 0x0600579F RID: 22431 RVA: 0x00193BCC File Offset: 0x00191DCC
			// Note: this type is marked as 'beforefieldinit'.
			static DelegateEntry()
			{
				Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, "DelegateEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr);
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "type");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "assembly");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "target");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "targetTypeAssembly");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "targetTypeName");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "methodName");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "delegateEntry");
				DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, 100667363);
				DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, 100667364);
			}

			// Token: 0x060057A0 RID: 22432 RVA: 0x00193CAC File Offset: 0x00191EAC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1346260, RefRangeEnd = 1346263, XrefRangeStart = 1346251, XrefRangeEnd = 1346260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelegateEntry(Delegate del, string targetLabel)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057A1 RID: 22433 RVA: 0x00193D0C File Offset: 0x00191F0C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1346295, RefRangeEnd = 1346297, XrefRangeStart = 1346263, XrefRangeEnd = 1346295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Delegate DeserializeDelegate(SerializationInfo info, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}

			// Token: 0x060057A2 RID: 22434 RVA: 0x0001F23D File Offset: 0x0001D43D
			public DelegateEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001655 RID: 5717
			// (get) Token: 0x060057A3 RID: 22435 RVA: 0x00193D6C File Offset: 0x00191F6C
			// (set) Token: 0x060057A4 RID: 22436 RVA: 0x0001F246 File Offset: 0x0001D446
			public unsafe string type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001656 RID: 5718
			// (get) Token: 0x060057A5 RID: 22437 RVA: 0x00193D94 File Offset: 0x00191F94
			// (set) Token: 0x060057A6 RID: 22438 RVA: 0x0001F265 File Offset: 0x0001D465
			public unsafe string assembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001657 RID: 5719
			// (get) Token: 0x060057A7 RID: 22439 RVA: 0x00193DBC File Offset: 0x00191FBC
			// (set) Token: 0x060057A8 RID: 22440 RVA: 0x0001F284 File Offset: 0x0001D484
			public unsafe Object target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001658 RID: 5720
			// (get) Token: 0x060057A9 RID: 22441 RVA: 0x00193DEC File Offset: 0x00191FEC
			// (set) Token: 0x060057AA RID: 22442 RVA: 0x0001F2A3 File Offset: 0x0001D4A3
			public unsafe string targetTypeAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001659 RID: 5721
			// (get) Token: 0x060057AB RID: 22443 RVA: 0x00193E14 File Offset: 0x00192014
			// (set) Token: 0x060057AC RID: 22444 RVA: 0x0001F2C2 File Offset: 0x0001D4C2
			public unsafe string targetTypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700165A RID: 5722
			// (get) Token: 0x060057AD RID: 22445 RVA: 0x00193E3C File Offset: 0x0019203C
			// (set) Token: 0x060057AE RID: 22446 RVA: 0x0001F2E1 File Offset: 0x0001D4E1
			public unsafe string methodName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700165B RID: 5723
			// (get) Token: 0x060057AF RID: 22447 RVA: 0x00193E64 File Offset: 0x00192064
			// (set) Token: 0x060057B0 RID: 22448 RVA: 0x0001F300 File Offset: 0x0001D500
			public unsafe DelegateSerializationHolder.DelegateEntry delegateEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateSerializationHolder.DelegateEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004821 RID: 18465
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04004822 RID: 18466
			private static readonly IntPtr NativeFieldInfoPtr_assembly;

			// Token: 0x04004823 RID: 18467
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04004824 RID: 18468
			private static readonly IntPtr NativeFieldInfoPtr_targetTypeAssembly;

			// Token: 0x04004825 RID: 18469
			private static readonly IntPtr NativeFieldInfoPtr_targetTypeName;

			// Token: 0x04004826 RID: 18470
			private static readonly IntPtr NativeFieldInfoPtr_methodName;

			// Token: 0x04004827 RID: 18471
			private static readonly IntPtr NativeFieldInfoPtr_delegateEntry;

			// Token: 0x04004828 RID: 18472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0;

			// Token: 0x04004829 RID: 18473
			private static readonly IntPtr NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0;
		}
	}
}
