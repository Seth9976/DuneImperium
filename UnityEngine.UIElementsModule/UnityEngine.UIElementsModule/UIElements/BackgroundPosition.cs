using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001D RID: 29
	[StructLayout(2)]
	public struct BackgroundPosition
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00022794 File Offset: 0x00020994
		// Note: this type is marked as 'beforefieldinit'.
		static BackgroundPosition()
		{
			Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BackgroundPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr);
			BackgroundPosition.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, "keyword");
			BackgroundPosition.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, "offset");
			BackgroundPosition.NativeMethodInfoPtr__ctor_Public_Void_BackgroundPositionKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663509);
			BackgroundPosition.NativeMethodInfoPtr__ctor_Public_Void_BackgroundPositionKeyword_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663510);
			BackgroundPosition.NativeMethodInfoPtr_Initial_Internal_Static_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663511);
			BackgroundPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663512);
			BackgroundPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663513);
			BackgroundPosition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663514);
			BackgroundPosition.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundPosition_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663515);
			BackgroundPosition.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundPosition_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663516);
			BackgroundPosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, 100663517);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000228A0 File Offset: 0x00020AA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 283481, RefRangeEnd = 283488, XrefRangeStart = 283480, XrefRangeEnd = 283481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundPosition(BackgroundPositionKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr__ctor_Public_Void_BackgroundPositionKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000228D4 File Offset: 0x00020AD4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 283488, RefRangeEnd = 283498, XrefRangeStart = 283488, XrefRangeEnd = 283488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundPosition(BackgroundPositionKeyword keyword, Length offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr__ctor_Public_Void_BackgroundPositionKeyword_Length_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00022914 File Offset: 0x00020B14
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 283499, RefRangeEnd = 283507, XrefRangeStart = 283498, XrefRangeEnd = 283499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundPosition Initial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr_Initial_Internal_Static_BackgroundPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00022944 File Offset: 0x00020B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283507, XrefRangeEnd = 283511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00022988 File Offset: 0x00020B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283511, XrefRangeEnd = 283512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BackgroundPosition other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundPosition_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000229C8 File Offset: 0x00020BC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283514, RefRangeEnd = 283516, XrefRangeStart = 283512, XrefRangeEnd = 283514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000229F8 File Offset: 0x00020BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283517, RefRangeEnd = 283519, XrefRangeStart = 283516, XrefRangeEnd = 283517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BackgroundPosition style1, BackgroundPosition style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundPosition_BackgroundPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00022A44 File Offset: 0x00020C44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 283520, RefRangeEnd = 283525, XrefRangeStart = 283519, XrefRangeEnd = 283520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BackgroundPosition style1, BackgroundPosition style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundPosition_BackgroundPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00022A90 File Offset: 0x00020C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283525, XrefRangeEnd = 283534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000027A1 File Offset: 0x000009A1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BackgroundPosition>.NativeClassPtr, ref this));
		}

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_keyword;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BackgroundPositionKeyword_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BackgroundPositionKeyword_Length_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_Initial_Internal_Static_BackgroundPosition_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BackgroundPosition_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BackgroundPosition_BackgroundPosition_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BackgroundPosition_BackgroundPosition_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000164 RID: 356
		[FieldOffset(0)]
		public BackgroundPositionKeyword keyword;

		// Token: 0x04000165 RID: 357
		[FieldOffset(4)]
		public Length offset;
	}
}
