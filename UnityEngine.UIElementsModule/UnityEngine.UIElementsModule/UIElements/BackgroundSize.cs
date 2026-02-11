using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000020 RID: 32
	[StructLayout(2)]
	public struct BackgroundSize
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00022F54 File Offset: 0x00021154
		// Note: this type is marked as 'beforefieldinit'.
		static BackgroundSize()
		{
			Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BackgroundSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr);
			BackgroundSize.NativeFieldInfoPtr_m_SizeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, "m_SizeType");
			BackgroundSize.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, "m_X");
			BackgroundSize.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, "m_Y");
			BackgroundSize.NativeMethodInfoPtr_get_sizeType_Public_get_BackgroundSizeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663530);
			BackgroundSize.NativeMethodInfoPtr_set_sizeType_Public_set_Void_BackgroundSizeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663531);
			BackgroundSize.NativeMethodInfoPtr_get_x_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663532);
			BackgroundSize.NativeMethodInfoPtr_set_x_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663533);
			BackgroundSize.NativeMethodInfoPtr_get_y_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663534);
			BackgroundSize.NativeMethodInfoPtr_set_y_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663535);
			BackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_Length_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663536);
			BackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_BackgroundSizeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663537);
			BackgroundSize.NativeMethodInfoPtr_Initial_Internal_Static_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663538);
			BackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663539);
			BackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663540);
			BackgroundSize.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663541);
			BackgroundSize.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundSize_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663542);
			BackgroundSize.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundSize_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663543);
			BackgroundSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, 100663544);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000230EC File Offset: 0x000212EC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0002311C File Offset: 0x0002131C
		public unsafe BackgroundSizeType sizeType
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_get_sizeType_Public_get_BackgroundSizeType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283872, RefRangeEnd = 283873, XrefRangeStart = 283870, XrefRangeEnd = 283872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_set_sizeType_Public_set_Void_BackgroundSizeType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00023150 File Offset: 0x00021350
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00023180 File Offset: 0x00021380
		public unsafe Length x
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 283873, RefRangeEnd = 283893, XrefRangeStart = 283873, XrefRangeEnd = 283873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_get_x_Public_get_Length_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 283893, RefRangeEnd = 283896, XrefRangeStart = 283893, XrefRangeEnd = 283893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_set_x_Public_set_Void_Length_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000231B4 File Offset: 0x000213B4
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x000231E4 File Offset: 0x000213E4
		public unsafe Length y
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 283896, RefRangeEnd = 283911, XrefRangeStart = 283896, XrefRangeEnd = 283896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_get_y_Public_get_Length_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283911, RefRangeEnd = 283913, XrefRangeStart = 283911, XrefRangeEnd = 283911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_set_y_Public_set_Void_Length_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00023218 File Offset: 0x00021418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283913, RefRangeEnd = 283915, XrefRangeStart = 283913, XrefRangeEnd = 283913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundSize(Length sizeX, Length sizeY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sizeX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_Length_Length_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00023258 File Offset: 0x00021458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283872, RefRangeEnd = 283873, XrefRangeStart = 283872, XrefRangeEnd = 283873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundSize(BackgroundSizeType sizeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sizeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_BackgroundSizeType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0002328C File Offset: 0x0002148C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283915, XrefRangeEnd = 283917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundSize Initial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_Initial_Internal_Static_BackgroundSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000232BC File Offset: 0x000214BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283917, XrefRangeEnd = 283922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00023300 File Offset: 0x00021500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283922, XrefRangeEnd = 283924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BackgroundSize other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundSize_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00023340 File Offset: 0x00021540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283927, RefRangeEnd = 283929, XrefRangeStart = 283924, XrefRangeEnd = 283927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00023370 File Offset: 0x00021570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283931, RefRangeEnd = 283934, XrefRangeStart = 283929, XrefRangeEnd = 283931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BackgroundSize style1, BackgroundSize style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundSize_BackgroundSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000233BC File Offset: 0x000215BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283936, RefRangeEnd = 283938, XrefRangeStart = 283934, XrefRangeEnd = 283936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BackgroundSize style1, BackgroundSize style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundSize_BackgroundSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00023408 File Offset: 0x00021608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283938, XrefRangeEnd = 283949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000027CE File Offset: 0x000009CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BackgroundSize>.NativeClassPtr, ref this));
		}

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_m_SizeType;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeType_Public_get_BackgroundSizeType_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_set_sizeType_Public_set_Void_BackgroundSizeType_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Length_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Length_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Length_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Length_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Length_Length_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BackgroundSizeType_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_Initial_Internal_Static_BackgroundSize_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundSize_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundSize_BackgroundSize_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundSize_BackgroundSize_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000188 RID: 392
		[FieldOffset(0)]
		public BackgroundSizeType m_SizeType;

		// Token: 0x04000189 RID: 393
		[FieldOffset(4)]
		public Length m_X;

		// Token: 0x0400018A RID: 394
		[FieldOffset(12)]
		public Length m_Y;
	}
}
