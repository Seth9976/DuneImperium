using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000080 RID: 128
	public class HWStack : Object
	{
		// Token: 0x06000F3A RID: 3898 RVA: 0x00058D0C File Offset: 0x00056F0C
		// Note: this type is marked as 'beforefieldinit'.
		static HWStack()
		{
			Il2CppClassPointerStore<HWStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "HWStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HWStack>.NativeClassPtr);
			HWStack.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HWStack>.NativeClassPtr, "stack");
			HWStack.NativeFieldInfoPtr_growthRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HWStack>.NativeClassPtr, "growthRate");
			HWStack.NativeFieldInfoPtr_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HWStack>.NativeClassPtr, "used");
			HWStack.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HWStack>.NativeClassPtr, "size");
			HWStack.NativeFieldInfoPtr_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HWStack>.NativeClassPtr, "limit");
			HWStack.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665809);
			HWStack.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665810);
			HWStack.NativeMethodInfoPtr_Push_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665811);
			HWStack.NativeMethodInfoPtr_Pop_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665812);
			HWStack.NativeMethodInfoPtr_Peek_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665813);
			HWStack.NativeMethodInfoPtr_AddToTop_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665814);
			HWStack.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665815);
			HWStack.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665816);
			HWStack.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665817);
			HWStack.NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_Object_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665818);
			HWStack.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HWStack>.NativeClassPtr, 100665819);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00058E7C File Offset: 0x0005707C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 376172, RefRangeEnd = 376181, XrefRangeStart = 376167, XrefRangeEnd = 376172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HWStack(int GrowthRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HWStack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref GrowthRate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00058EC4 File Offset: 0x000570C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376181, XrefRangeEnd = 376186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HWStack(int GrowthRate, int limit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HWStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref GrowthRate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref limit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00058F1C File Offset: 0x0005711C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 376191, RefRangeEnd = 376199, XrefRangeStart = 376186, XrefRangeEnd = 376191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_Push_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00058F5C File Offset: 0x0005715C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 376199, RefRangeEnd = 376211, XrefRangeStart = 376199, XrefRangeEnd = 376199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_Pop_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00058F9C File Offset: 0x0005719C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 376211, RefRangeEnd = 376216, XrefRangeStart = 376211, XrefRangeEnd = 376211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_Peek_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00058FDC File Offset: 0x000571DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 376218, RefRangeEnd = 376222, XrefRangeStart = 376216, XrefRangeEnd = 376218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToTop(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_AddToTop_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700052F RID: 1327
		public unsafe Object this[int index]
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 376222, RefRangeEnd = 376241, XrefRangeStart = 376222, XrefRangeEnd = 376222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 376252, RefRangeEnd = 376256, XrefRangeStart = 376241, XrefRangeEnd = 376252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000590BC File Offset: 0x000572BC
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000590F8 File Offset: 0x000572F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376256, XrefRangeEnd = 376258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HWStack(Il2CppReferenceArray<Object> stack, int growthRate, int used, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HWStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthRate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref used;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_Object_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00059170 File Offset: 0x00057370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376258, XrefRangeEnd = 376268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HWStack.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00006EF7 File Offset: 0x000050F7
		public HWStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000591B0 File Offset: 0x000573B0
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00006F00 File Offset: 0x00005100
		public unsafe Il2CppReferenceArray<Object> stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000591E0 File Offset: 0x000573E0
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00006F1F File Offset: 0x0000511F
		public unsafe int growthRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_growthRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_growthRate)) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00059208 File Offset: 0x00057408
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00006F3A File Offset: 0x0000513A
		public unsafe int used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_used)) = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00059230 File Offset: 0x00057430
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00006F55 File Offset: 0x00005155
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00059258 File Offset: 0x00057458
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00006F70 File Offset: 0x00005170
		public unsafe int limit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_limit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HWStack.NativeFieldInfoPtr_limit)) = value;
			}
		}

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_growthRate;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeFieldInfoPtr_used;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_limit;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_Push_Internal_Object_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Internal_Object_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Internal_Object_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_AddToTop_Internal_Void_Object_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_Object_Int32_Int32_Int32_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
	}
}
