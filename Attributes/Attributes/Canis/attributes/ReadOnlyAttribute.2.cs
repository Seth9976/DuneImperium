using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x0200001E RID: 30
	[Serializable]
	public sealed class ReadOnlyAttribute<V> : ReadOnlyAttribute
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00009C9C File Offset: 0x00007E9C
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttribute()
		{
			Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "ReadOnlyAttribute`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr);
			ReadOnlyAttribute<V>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, "source");
			ReadOnlyAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_Int32_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663478);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663479);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_Name_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663480);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663481);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663482);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663483);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663484);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_objectValue_Protected_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663485);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_objectModValue_Protected_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663486);
			ReadOnlyAttribute<V>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr, 100663487);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00009DE4 File Offset: 0x00007FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217539, XrefRangeEnd = 1217570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute(int key, V value, V modValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(V).IsValueType)
			{
				V v = value;
				intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(V).IsValueType)
			{
				V v2 = modValue;
				intPtr2 = ((v2 is string) ? IL2CPP.ManagedStringToIl2Cpp(v2 as string) : IL2CPP.Il2CppObjectBaseToPtr(v2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref modValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_Int32_V_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00009EBC File Offset: 0x000080BC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute(IAttribute<V> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttribute<V>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00009F08 File Offset: 0x00008108
		public unsafe override int Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217570, XrefRangeEnd = 1217606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_Name_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00009F44 File Offset: 0x00008144
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217606, XrefRangeEnd = 1217621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00009F80 File Offset: 0x00008180
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217621, XrefRangeEnd = 1217659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00009FC0 File Offset: 0x000081C0
		public new unsafe V Value
		{
			[CallerCount(326)]
			[CachedScanResults(RefRangeStart = 1217666, RefRangeEnd = 1217992, XrefRangeStart = 1217659, XrefRangeEnd = 1217666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00009FFC File Offset: 0x000081FC
		public new unsafe V ModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217992, XrefRangeEnd = 1217997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000A038 File Offset: 0x00008238
		public unsafe override Object objectValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217997, XrefRangeEnd = 1218000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_objectValue_Protected_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000A078 File Offset: 0x00008278
		public unsafe override Object objectModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218000, XrefRangeEnd = 1218003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_get_objectModValue_Protected_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000A0B8 File Offset: 0x000082B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 549125, RefRangeEnd = 549132, XrefRangeStart = 549125, XrefRangeEnd = 549132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute<V>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002C8B File Offset: 0x00000E8B
		public ReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000A0F0 File Offset: 0x000082F0
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002C94 File Offset: 0x00000E94
		public unsafe IAttribute<V> source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttribute<V>.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttribute<V>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_V_V_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_V_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_Int32_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_V_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_V_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_objectValue_Protected_Virtual_get_Object_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_get_objectModValue_Protected_Virtual_get_Object_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
