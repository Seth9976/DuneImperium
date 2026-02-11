using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032E RID: 814
	public class ObjectHolderList : Object
	{
		// Token: 0x060031E5 RID: 12773 RVA: 0x000FCF0C File Offset: 0x000FB10C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolderList()
		{
			Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolderList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr);
			ObjectHolderList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, "m_values");
			ObjectHolderList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, "m_count");
			ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671129);
			ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671130);
			ObjectHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671131);
			ObjectHolderList.NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671132);
			ObjectHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671133);
			ObjectHolderList.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671134);
			ObjectHolderList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671135);
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000FCFF0 File Offset: 0x000FB1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385905, XrefRangeEnd = 1385910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x000FD02C File Offset: 0x000FB22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385910, XrefRangeEnd = 1385915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000FD074 File Offset: 0x000FB274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385915, XrefRangeEnd = 1385923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(ObjectHolder value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000FD0C4 File Offset: 0x000FB2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385923, XrefRangeEnd = 1385928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderListEnumerator GetFixupEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolderListEnumerator>(intPtr3) : null;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000FD104 File Offset: 0x000FB304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385928, XrefRangeEnd = 1385934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x000FD138 File Offset: 0x000FB338
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x000FD174 File Offset: 0x000FB374
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00011377 File Offset: 0x0000F577
		public ObjectHolderList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x000FD1B0 File Offset: 0x000FB3B0
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x00011380 File Offset: 0x0000F580
		public unsafe Il2CppReferenceArray<ObjectHolder> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x000FD1E0 File Offset: 0x000FB3E0
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x0001139F File Offset: 0x0000F59F
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
	}
}
