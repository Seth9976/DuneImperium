using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel.Design.Serialization
{
	// Token: 0x02000156 RID: 342
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x0006BFB4 File Offset: 0x0006A1B4
		// Note: this type is marked as 'beforefieldinit'.
		static RootDesignerSerializerAttribute()
		{
			Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design.Serialization", "RootDesignerSerializerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr);
			RootDesignerSerializerAttribute.NativeFieldInfoPtr__typeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, "_typeId");
			RootDesignerSerializerAttribute.NativeFieldInfoPtr__Reloadable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, "<Reloadable>k__BackingField");
			RootDesignerSerializerAttribute.NativeFieldInfoPtr__SerializerTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, "<SerializerTypeName>k__BackingField");
			RootDesignerSerializerAttribute.NativeFieldInfoPtr__SerializerBaseTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, "<SerializerBaseTypeName>k__BackingField");
			RootDesignerSerializerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, 100666397);
			RootDesignerSerializerAttribute.NativeMethodInfoPtr_get_SerializerBaseTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, 100666398);
			RootDesignerSerializerAttribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, 100666399);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0006C070 File Offset: 0x0006A270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466245, XrefRangeEnd = 466248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serializerTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseSerializerTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reloadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootDesignerSerializerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0006C0DC File Offset: 0x0006A2DC
		public unsafe string SerializerBaseTypeName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootDesignerSerializerAttribute.NativeMethodInfoPtr_get_SerializerBaseTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0006C114 File Offset: 0x0006A314
		public unsafe override Object TypeId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466248, XrefRangeEnd = 466253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootDesignerSerializerAttribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00009284 File Offset: 0x00007484
		public RootDesignerSerializerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0006C154 File Offset: 0x0006A354
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0000928D File Offset: 0x0000748D
		public unsafe string _typeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__typeId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__typeId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0006C17C File Offset: 0x0006A37C
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x000092AC File Offset: 0x000074AC
		public unsafe bool _Reloadable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__Reloadable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__Reloadable_k__BackingField)) = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0006C1A4 File Offset: 0x0006A3A4
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x000092C7 File Offset: 0x000074C7
		public unsafe string _SerializerTypeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__SerializerTypeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__SerializerTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0006C1CC File Offset: 0x0006A3CC
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x000092E6 File Offset: 0x000074E6
		public unsafe string _SerializerBaseTypeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__SerializerBaseTypeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr__SerializerBaseTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeFieldInfoPtr__typeId;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeFieldInfoPtr__Reloadable_k__BackingField;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeFieldInfoPtr__SerializerTypeName_k__BackingField;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeFieldInfoPtr__SerializerBaseTypeName_k__BackingField;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializerBaseTypeName_Public_get_String_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0;
	}
}
