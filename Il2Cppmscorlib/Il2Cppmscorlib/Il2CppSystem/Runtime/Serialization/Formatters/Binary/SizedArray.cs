using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000370 RID: 880
	[Serializable]
	public sealed class SizedArray : Object
	{
		// Token: 0x060036DE RID: 14046 RVA: 0x0010DAA4 File Offset: 0x0010BCA4
		// Note: this type is marked as 'beforefieldinit'.
		static SizedArray()
		{
			Il2CppClassPointerStore<SizedArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SizedArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SizedArray>.NativeClassPtr);
			SizedArray.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, "objects");
			SizedArray.NativeFieldInfoPtr_negObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, "negObjects");
			SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100671566);
			SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100671567);
			SizedArray.NativeMethodInfoPtr__ctor_Private_Void_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100671568);
			SizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100671569);
			SizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100671570);
			SizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100671571);
			SizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100671572);
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0010DB88 File Offset: 0x0010BD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1390983, XrefRangeEnd = 1390991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SizedArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SizedArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0010DBC4 File Offset: 0x0010BDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1390991, XrefRangeEnd = 1390999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SizedArray(int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SizedArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x0010DC0C File Offset: 0x0010BE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1390999, XrefRangeEnd = 1391010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SizedArray(SizedArray sizedArray)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SizedArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sizedArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr__ctor_Private_Void_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0010DC58 File Offset: 0x0010BE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391010, XrefRangeEnd = 1391023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000CDD RID: 3293
		public unsafe Object this[int index]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1391023, RefRangeEnd = 1391027, XrefRangeStart = 1391023, XrefRangeEnd = 1391023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1391039, RefRangeEnd = 1391042, XrefRangeStart = 1391027, XrefRangeEnd = 1391039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x0010DD34 File Offset: 0x0010BF34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1391059, RefRangeEnd = 1391061, XrefRangeStart = 1391042, XrefRangeEnd = 1391059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00013EE2 File Offset: 0x000120E2
		public SizedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x0010DD74 File Offset: 0x0010BF74
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x00013EEB File Offset: 0x000120EB
		public unsafe Il2CppReferenceArray<Object> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x0010DDA4 File Offset: 0x0010BFA4
		// (set) Token: 0x060036EA RID: 14058 RVA: 0x00013F0A File Offset: 0x0001210A
		public unsafe Il2CppReferenceArray<Object> negObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_negObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_negObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CA0 RID: 11424
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeFieldInfoPtr_negObjects;

		// Token: 0x04002CA2 RID: 11426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002CA3 RID: 11427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002CA4 RID: 11428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SizedArray_0;

		// Token: 0x04002CA5 RID: 11429
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04002CA6 RID: 11430
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0;

		// Token: 0x04002CA7 RID: 11431
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0;

		// Token: 0x04002CA8 RID: 11432
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0;
	}
}
