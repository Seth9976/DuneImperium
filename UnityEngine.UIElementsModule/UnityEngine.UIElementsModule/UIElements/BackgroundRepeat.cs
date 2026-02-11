using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct BackgroundRepeat
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x00022C74 File Offset: 0x00020E74
		// Note: this type is marked as 'beforefieldinit'.
		static BackgroundRepeat()
		{
			Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BackgroundRepeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr);
			BackgroundRepeat.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, "x");
			BackgroundRepeat.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, "y");
			BackgroundRepeat.NativeMethodInfoPtr__ctor_Public_Void_Repeat_Repeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663522);
			BackgroundRepeat.NativeMethodInfoPtr_Initial_Internal_Static_BackgroundRepeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663523);
			BackgroundRepeat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663524);
			BackgroundRepeat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundRepeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663525);
			BackgroundRepeat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663526);
			BackgroundRepeat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundRepeat_BackgroundRepeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663527);
			BackgroundRepeat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundRepeat_BackgroundRepeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663528);
			BackgroundRepeat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, 100663529);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00022D6C File Offset: 0x00020F6C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundRepeat(Repeat repeatX, Repeat repeatY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref repeatX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr__ctor_Public_Void_Repeat_Repeat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00022DAC File Offset: 0x00020FAC
		[CallerCount(0)]
		public unsafe static BackgroundRepeat Initial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr_Initial_Internal_Static_BackgroundRepeat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00022DDC File Offset: 0x00020FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283616, XrefRangeEnd = 283619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00022E20 File Offset: 0x00021020
		[CallerCount(0)]
		public unsafe bool Equals(BackgroundRepeat other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundRepeat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00022E60 File Offset: 0x00021060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283621, RefRangeEnd = 283622, XrefRangeStart = 283619, XrefRangeEnd = 283621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00022E90 File Offset: 0x00021090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283622, RefRangeEnd = 283623, XrefRangeStart = 283622, XrefRangeEnd = 283622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BackgroundRepeat style1, BackgroundRepeat style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundRepeat_BackgroundRepeat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00022EDC File Offset: 0x000210DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283623, RefRangeEnd = 283626, XrefRangeStart = 283623, XrefRangeEnd = 283623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BackgroundRepeat style1, BackgroundRepeat style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundRepeat_BackgroundRepeat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00022F28 File Offset: 0x00021128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283626, XrefRangeEnd = 283634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundRepeat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000027BC File Offset: 0x000009BC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BackgroundRepeat>.NativeClassPtr, ref this));
		}

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Repeat_Repeat_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_Initial_Internal_Static_BackgroundRepeat_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundRepeat_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundRepeat_BackgroundRepeat_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundRepeat_BackgroundRepeat_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000174 RID: 372
		[FieldOffset(0)]
		public Repeat x;

		// Token: 0x04000175 RID: 373
		[FieldOffset(4)]
		public Repeat y;
	}
}
