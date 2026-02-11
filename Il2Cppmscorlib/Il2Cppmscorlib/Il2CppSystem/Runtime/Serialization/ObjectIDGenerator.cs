using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000328 RID: 808
	[Serializable]
	public class ObjectIDGenerator : Object
	{
		// Token: 0x06003138 RID: 12600 RVA: 0x000FA2F8 File Offset: 0x000F84F8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectIDGenerator()
		{
			Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectIDGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr);
			ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_currentCount");
			ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_currentSize");
			ObjectIDGenerator.NativeFieldInfoPtr_m_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_ids");
			ObjectIDGenerator.NativeFieldInfoPtr_m_objs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_objs");
			ObjectIDGenerator.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "sizes");
			ObjectIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671039);
			ObjectIDGenerator.NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671040);
			ObjectIDGenerator.NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671041);
			ObjectIDGenerator.NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671042);
			ObjectIDGenerator.NativeMethodInfoPtr_Rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671043);
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000FA3F0 File Offset: 0x000F85F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385239, RefRangeEnd = 1385241, XrefRangeStart = 1385224, XrefRangeEnd = 1385239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectIDGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x000FA42C File Offset: 0x000F862C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1385243, RefRangeEnd = 1385246, XrefRangeStart = 1385241, XrefRangeEnd = 1385243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindElement(Object obj, out bool found)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &found;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x000FA488 File Offset: 0x000F8688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385246, XrefRangeEnd = 1385251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long GetId(Object obj, out bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectIDGenerator.NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x000FA4F0 File Offset: 0x000F86F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385251, XrefRangeEnd = 1385252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long HasId(Object obj, out bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectIDGenerator.NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x000FA558 File Offset: 0x000F8758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385275, RefRangeEnd = 1385276, XrefRangeStart = 1385252, XrefRangeEnd = 1385275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr_Rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x00010F1F File Offset: 0x0000F11F
		public ObjectIDGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x000FA58C File Offset: 0x000F878C
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x00010F28 File Offset: 0x0000F128
		public unsafe int m_currentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount)) = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x000FA5B4 File Offset: 0x000F87B4
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x00010F43 File Offset: 0x0000F143
		public unsafe int m_currentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize)) = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x000FA5DC File Offset: 0x000F87DC
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x00010F5E File Offset: 0x0000F15E
		public unsafe Il2CppStructArray<long> m_ids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_ids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x000FA60C File Offset: 0x000F880C
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x00010F7D File Offset: 0x0000F17D
		public unsafe Il2CppReferenceArray<Object> m_objs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_objs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_objs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x000FA63C File Offset: 0x000F883C
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x00010F9C File Offset: 0x0000F19C
		public unsafe static Il2CppStructArray<int> sizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectIDGenerator.NativeFieldInfoPtr_sizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectIDGenerator.NativeFieldInfoPtr_sizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeFieldInfoPtr_m_currentCount;

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeFieldInfoPtr_m_currentSize;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeFieldInfoPtr_m_ids;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeFieldInfoPtr_m_objs;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeMethodInfoPtr_Rehash_Private_Void_0;
	}
}
