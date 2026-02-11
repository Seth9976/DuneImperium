using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000109 RID: 265
	public sealed class EditorAttribute : Attribute
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x0005AC20 File Offset: 0x00058E20
		// Note: this type is marked as 'beforefieldinit'.
		static EditorAttribute()
		{
			Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EditorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr);
			EditorAttribute.NativeFieldInfoPtr__typeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, "_typeId");
			EditorAttribute.NativeFieldInfoPtr__EditorBaseTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, "<EditorBaseTypeName>k__BackingField");
			EditorAttribute.NativeFieldInfoPtr__EditorTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, "<EditorTypeName>k__BackingField");
			EditorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, 100665686);
			EditorAttribute.NativeMethodInfoPtr_get_EditorBaseTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, 100665687);
			EditorAttribute.NativeMethodInfoPtr_get_EditorTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, 100665688);
			EditorAttribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, 100665689);
			EditorAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, 100665690);
			EditorAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr, 100665691);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0005AD04 File Offset: 0x00058F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458966, XrefRangeEnd = 458975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorAttribute(string typeName, string baseTypeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseTypeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0005AD64 File Offset: 0x00058F64
		public unsafe string EditorBaseTypeName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorAttribute.NativeMethodInfoPtr_get_EditorBaseTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0005AD9C File Offset: 0x00058F9C
		public unsafe string EditorTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorAttribute.NativeMethodInfoPtr_get_EditorTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0005ADD4 File Offset: 0x00058FD4
		public unsafe override Object TypeId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458975, XrefRangeEnd = 458980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorAttribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0005AE14 File Offset: 0x00059014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458980, XrefRangeEnd = 458984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0005AE64 File Offset: 0x00059064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00007E2A File Offset: 0x0000602A
		public EditorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0005AEA0 File Offset: 0x000590A0
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x00007E33 File Offset: 0x00006033
		public unsafe string _typeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorAttribute.NativeFieldInfoPtr__typeId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorAttribute.NativeFieldInfoPtr__typeId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x0005AEC8 File Offset: 0x000590C8
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x00007E52 File Offset: 0x00006052
		public unsafe string _EditorBaseTypeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorAttribute.NativeFieldInfoPtr__EditorBaseTypeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorAttribute.NativeFieldInfoPtr__EditorBaseTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0005AEF0 File Offset: 0x000590F0
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00007E71 File Offset: 0x00006071
		public unsafe string _EditorTypeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorAttribute.NativeFieldInfoPtr__EditorTypeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorAttribute.NativeFieldInfoPtr__EditorTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr__typeId;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr__EditorBaseTypeName_k__BackingField;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr__EditorTypeName_k__BackingField;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_get_EditorBaseTypeName_Public_get_String_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_get_EditorTypeName_Public_get_String_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
