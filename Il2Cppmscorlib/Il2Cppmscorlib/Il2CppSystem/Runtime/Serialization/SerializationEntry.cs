using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000319 RID: 793
	public sealed class SerializationEntry : ValueType
	{
		// Token: 0x06003093 RID: 12435 RVA: 0x000F7CFC File Offset: 0x000F5EFC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEntry()
		{
			Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr);
			SerializationEntry.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "_name");
			SerializationEntry.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "_value");
			SerializationEntry.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "_type");
			SerializationEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100670960);
			SerializationEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100670961);
			SerializationEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100670962);
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x000F7DA4 File Offset: 0x000F5FA4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338072, RefRangeEnd = 338082, XrefRangeStart = 338072, XrefRangeEnd = 338082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEntry(string entryName, Object entryValue, Type entryType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entryName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entryValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entryType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000F7E18 File Offset: 0x000F6018
		public unsafe Object Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x000F7E5C File Offset: 0x000F605C
		public unsafe string Name
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00010AED File Offset: 0x0000ECED
		public SerializationEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00010AF6 File Offset: 0x0000ECF6
		public SerializationEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x000F7E98 File Offset: 0x000F6098
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x00010B08 File Offset: 0x0000ED08
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000F7EC0 File Offset: 0x000F60C0
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x00010B27 File Offset: 0x0000ED27
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000F7EF0 File Offset: 0x000F60F0
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x00010B46 File Offset: 0x0000ED46
		public unsafe Type _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr__type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
	}
}
