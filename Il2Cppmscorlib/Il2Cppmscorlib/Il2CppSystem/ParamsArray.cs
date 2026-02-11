using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D6 RID: 214
	public sealed class ParamsArray : ValueType
	{
		// Token: 0x06000DD0 RID: 3536 RVA: 0x00066964 File Offset: 0x00064B64
		// Note: this type is marked as 'beforefieldinit'.
		static ParamsArray()
		{
			Il2CppClassPointerStore<ParamsArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParamsArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr);
			ParamsArray.NativeFieldInfoPtr_s_oneArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "s_oneArgArray");
			ParamsArray.NativeFieldInfoPtr_s_twoArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "s_twoArgArray");
			ParamsArray.NativeFieldInfoPtr_s_threeArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "s_threeArgArray");
			ParamsArray.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "_arg0");
			ParamsArray.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "_arg1");
			ParamsArray.NativeFieldInfoPtr__arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "_arg2");
			ParamsArray.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "_args");
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665728);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665729);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665730);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665731);
			ParamsArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665732);
			ParamsArray.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665733);
			ParamsArray.NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665734);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00066AAC File Offset: 0x00064CAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1318321, RefRangeEnd = 1318325, XrefRangeStart = 1318313, XrefRangeEnd = 1318321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00066AFC File Offset: 0x00064CFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1318333, RefRangeEnd = 1318336, XrefRangeStart = 1318325, XrefRangeEnd = 1318333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0, Object arg1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00066B60 File Offset: 0x00064D60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1318344, RefRangeEnd = 1318347, XrefRangeStart = 1318336, XrefRangeEnd = 1318344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0, Object arg1, Object arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00066BD4 File Offset: 0x00064DD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1318356, RefRangeEnd = 1318359, XrefRangeStart = 1318347, XrefRangeEnd = 1318356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Il2CppReferenceArray<Object> args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00066C24 File Offset: 0x00064E24
		public unsafe int Length
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 428718, RefRangeEnd = 428731, XrefRangeStart = 428718, XrefRangeEnd = 428731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022E RID: 558
		public unsafe Object this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1318360, RefRangeEnd = 1318361, XrefRangeStart = 1318359, XrefRangeEnd = 1318360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00066CBC File Offset: 0x00064EBC
		[CallerCount(0)]
		public unsafe Object GetAtSlow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00005523 File Offset: 0x00003723
		public ParamsArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000552C File Offset: 0x0000372C
		public ParamsArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00066D10 File Offset: 0x00064F10
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x0000553E File Offset: 0x0000373E
		public unsafe static Il2CppReferenceArray<Object> s_oneArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_s_oneArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_s_oneArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00066D38 File Offset: 0x00064F38
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00005550 File Offset: 0x00003750
		public unsafe static Il2CppReferenceArray<Object> s_twoArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_s_twoArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_s_twoArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00066D60 File Offset: 0x00064F60
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00005562 File Offset: 0x00003762
		public unsafe static Il2CppReferenceArray<Object> s_threeArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_s_threeArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_s_threeArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00066D88 File Offset: 0x00064F88
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00005574 File Offset: 0x00003774
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00066DB8 File Offset: 0x00064FB8
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00005593 File Offset: 0x00003793
		public unsafe Object _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00066DE8 File Offset: 0x00064FE8
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x000055B2 File Offset: 0x000037B2
		public unsafe Object _arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00066E18 File Offset: 0x00065018
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x000055D1 File Offset: 0x000037D1
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_s_oneArgArray;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_s_twoArgArray;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr_s_threeArgArray;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr__arg2;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0;
	}
}
