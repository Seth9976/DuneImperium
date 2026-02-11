using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C1 RID: 193
	public class SerializationSource : Object
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x00068884 File Offset: 0x00066A84
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationSource()
		{
			Il2CppClassPointerStore<SerializationSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "SerializationSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationSource>.NativeClassPtr);
			SerializationSource.NativeFieldInfoPtr_includedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationSource>.NativeClassPtr, "includedTypes");
			SerializationSource.NativeFieldInfoPtr_namspace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationSource>.NativeClassPtr, "namspace");
			SerializationSource.NativeFieldInfoPtr_canBeGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationSource>.NativeClassPtr, "canBeGenerated");
			SerializationSource.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationSource>.NativeClassPtr, 100666368);
			SerializationSource.NativeMethodInfoPtr_BaseEquals_Protected_Boolean_SerializationSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationSource>.NativeClassPtr, 100666369);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00068918 File Offset: 0x00066B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384001, XrefRangeEnd = 384004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationSource(string namspace, Il2CppReferenceArray<Type> includedTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationSource>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namspace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(includedTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationSource.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00068978 File Offset: 0x00066B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384004, XrefRangeEnd = 384006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BaseEquals(SerializationSource other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationSource.NativeMethodInfoPtr_BaseEquals_Protected_Boolean_SerializationSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00007F3B File Offset: 0x0000613B
		public SerializationSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000689C8 File Offset: 0x00066BC8
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x00007F44 File Offset: 0x00006144
		public unsafe Il2CppReferenceArray<Type> includedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationSource.NativeFieldInfoPtr_includedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationSource.NativeFieldInfoPtr_includedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x000689F8 File Offset: 0x00066BF8
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x00007F63 File Offset: 0x00006163
		public unsafe string namspace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationSource.NativeFieldInfoPtr_namspace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationSource.NativeFieldInfoPtr_namspace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00068A20 File Offset: 0x00066C20
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00007F82 File Offset: 0x00006182
		public unsafe bool canBeGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationSource.NativeFieldInfoPtr_canBeGenerated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationSource.NativeFieldInfoPtr_canBeGenerated)) = value;
			}
		}

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeFieldInfoPtr_includedTypes;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeFieldInfoPtr_namspace;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeFieldInfoPtr_canBeGenerated;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_BaseEquals_Protected_Boolean_SerializationSource_0;
	}
}
