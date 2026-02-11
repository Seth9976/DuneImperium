using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002BA RID: 698
	public class DynamicPropertyCollection : Object
	{
		// Token: 0x06002CB5 RID: 11445 RVA: 0x000EA21C File Offset: 0x000E841C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicPropertyCollection()
		{
			Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "DynamicPropertyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr);
			DynamicPropertyCollection.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, "_properties");
			DynamicPropertyCollection.NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100670497);
			DynamicPropertyCollection.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100670498);
			DynamicPropertyCollection.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100670499);
			DynamicPropertyCollection.NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100670500);
			DynamicPropertyCollection.NativeMethodInfoPtr_FindProperty_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100670501);
			DynamicPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100670502);
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x000EA2D8 File Offset: 0x000E84D8
		public unsafe bool HasProperties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1380900, RefRangeEnd = 1380902, XrefRangeStart = 1380900, XrefRangeEnd = 1380900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000EA314 File Offset: 0x000E8514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380926, RefRangeEnd = 1380927, XrefRangeStart = 1380902, XrefRangeEnd = 1380926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterDynamicProperty(IDynamicProperty prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000EA364 File Offset: 0x000E8564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380932, RefRangeEnd = 1380933, XrefRangeStart = 1380927, XrefRangeEnd = 1380932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterDynamicProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000EA3B4 File Offset: 0x000E85B4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1380969, RefRangeEnd = 1380981, XrefRangeStart = 1380933, XrefRangeEnd = 1380969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyMessage(bool start, IMessage msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000EA420 File Offset: 0x000E8620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1380988, RefRangeEnd = 1380990, XrefRangeStart = 1380981, XrefRangeEnd = 1380988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_FindProperty_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x000EA470 File Offset: 0x000E8670
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1380996, RefRangeEnd = 1381002, XrefRangeStart = 1380990, XrefRangeEnd = 1380996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicPropertyCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0000EF5C File Offset: 0x0000D15C
		public DynamicPropertyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000EA4AC File Offset: 0x000E86AC
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x0000EF65 File Offset: 0x0000D165
		public unsafe ArrayList _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeMethodInfoPtr_FindProperty_Private_Int32_String_0;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000669 RID: 1641
		public class DynamicPropertyReg : Object
		{
			// Token: 0x06005B2E RID: 23342 RVA: 0x0019F2B0 File Offset: 0x0019D4B0
			// Note: this type is marked as 'beforefieldinit'.
			static DynamicPropertyReg()
			{
				Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, "DynamicPropertyReg");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr);
				DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, "Property");
				DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, "Sink");
				DynamicPropertyCollection.DynamicPropertyReg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, 100670503);
			}

			// Token: 0x06005B2F RID: 23343 RVA: 0x0019F318 File Offset: 0x0019D518
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicPropertyReg()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.DynamicPropertyReg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B30 RID: 23344 RVA: 0x00021056 File Offset: 0x0001F256
			public DynamicPropertyReg(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700175B RID: 5979
			// (get) Token: 0x06005B31 RID: 23345 RVA: 0x0019F354 File Offset: 0x0019D554
			// (set) Token: 0x06005B32 RID: 23346 RVA: 0x0002105F File Offset: 0x0001F25F
			public unsafe IDynamicProperty Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDynamicProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700175C RID: 5980
			// (get) Token: 0x06005B33 RID: 23347 RVA: 0x0019F384 File Offset: 0x0019D584
			// (set) Token: 0x06005B34 RID: 23348 RVA: 0x0002107E File Offset: 0x0001F27E
			public unsafe IDynamicMessageSink Sink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDynamicMessageSink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A59 RID: 19033
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x04004A5A RID: 19034
			private static readonly IntPtr NativeFieldInfoPtr_Sink;

			// Token: 0x04004A5B RID: 19035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
