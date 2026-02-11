using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000478 RID: 1144
	public class HebrewNumber : Object
	{
		// Token: 0x06004513 RID: 17683 RVA: 0x00144604 File Offset: 0x00142804
		// Note: this type is marked as 'beforefieldinit'.
		static HebrewNumber()
		{
			Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr);
			HebrewNumber.NativeFieldInfoPtr_s_hebrewValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "s_hebrewValues");
			HebrewNumber.NativeFieldInfoPtr_s_maxHebrewNumberCh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "s_maxHebrewNumberCh");
			HebrewNumber.NativeFieldInfoPtr_s_numberPasingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "s_numberPasingState");
			HebrewNumber.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100673460);
			HebrewNumber.NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100673461);
			HebrewNumber.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100673462);
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x001446AC File Offset: 0x001428AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1408861, RefRangeEnd = 1408864, XrefRangeStart = 1408816, XrefRangeEnd = 1408861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int Number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x001446E4 File Offset: 0x001428E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408873, RefRangeEnd = 1408875, XrefRangeStart = 1408864, XrefRangeEnd = 1408873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00144730 File Offset: 0x00142930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408875, XrefRangeEnd = 1408881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x0001910A File Offset: 0x0001730A
		public HebrewNumber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x00144770 File Offset: 0x00142970
		// (set) Token: 0x06004519 RID: 17689 RVA: 0x00019113 File Offset: 0x00017313
		public unsafe static Il2CppStructArray<HebrewNumber.HebrewValue> s_hebrewValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_s_hebrewValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<HebrewNumber.HebrewValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_s_hebrewValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x00144798 File Offset: 0x00142998
		// (set) Token: 0x0600451B RID: 17691 RVA: 0x00019125 File Offset: 0x00017325
		public unsafe static char s_maxHebrewNumberCh
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_s_maxHebrewNumberCh, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_s_maxHebrewNumberCh, (void*)(&value));
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x001447B4 File Offset: 0x001429B4
		// (set) Token: 0x0600451D RID: 17693 RVA: 0x00019133 File Offset: 0x00017333
		public unsafe static Il2CppStructArray<HebrewNumber.HS> s_numberPasingState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_s_numberPasingState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<HebrewNumber.HS>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_s_numberPasingState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003906 RID: 14598
		private static readonly IntPtr NativeFieldInfoPtr_s_hebrewValues;

		// Token: 0x04003907 RID: 14599
		private static readonly IntPtr NativeFieldInfoPtr_s_maxHebrewNumberCh;

		// Token: 0x04003908 RID: 14600
		private static readonly IntPtr NativeFieldInfoPtr_s_numberPasingState;

		// Token: 0x04003909 RID: 14601
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;

		// Token: 0x0400390A RID: 14602
		private static readonly IntPtr NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0;

		// Token: 0x0400390B RID: 14603
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x020006CC RID: 1740
		public enum HebrewToken : short
		{
			// Token: 0x04004B5F RID: 19295
			Invalid = -1,
			// Token: 0x04004B60 RID: 19296
			Digit400,
			// Token: 0x04004B61 RID: 19297
			Digit200_300,
			// Token: 0x04004B62 RID: 19298
			Digit100,
			// Token: 0x04004B63 RID: 19299
			Digit10,
			// Token: 0x04004B64 RID: 19300
			Digit1,
			// Token: 0x04004B65 RID: 19301
			Digit6_7,
			// Token: 0x04004B66 RID: 19302
			Digit7,
			// Token: 0x04004B67 RID: 19303
			Digit9,
			// Token: 0x04004B68 RID: 19304
			SingleQuote,
			// Token: 0x04004B69 RID: 19305
			DoubleQuote
		}

		// Token: 0x020006CD RID: 1741
		[StructLayout(2)]
		public struct HebrewValue
		{
			// Token: 0x06005CDC RID: 23772 RVA: 0x001A4C28 File Offset: 0x001A2E28
			// Note: this type is marked as 'beforefieldinit'.
			static HebrewValue()
			{
				Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "HebrewValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr);
				HebrewNumber.HebrewValue.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, "token");
				HebrewNumber.HebrewValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, "value");
				HebrewNumber.HebrewValue.NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, 100673464);
			}

			// Token: 0x06005CDD RID: 23773 RVA: 0x001A4C90 File Offset: 0x001A2E90
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 438691, RefRangeEnd = 438696, XrefRangeStart = 438691, XrefRangeEnd = 438696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HebrewValue(HebrewNumber.HebrewToken token, short value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.HebrewValue.NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CDE RID: 23774 RVA: 0x00021BEC File Offset: 0x0001FDEC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, ref this));
			}

			// Token: 0x04004B6A RID: 19306
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x04004B6B RID: 19307
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04004B6C RID: 19308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int16_0;

			// Token: 0x04004B6D RID: 19309
			[FieldOffset(0)]
			public HebrewNumber.HebrewToken token;

			// Token: 0x04004B6E RID: 19310
			[FieldOffset(2)]
			public short value;
		}

		// Token: 0x020006CE RID: 1742
		public enum HS : sbyte
		{
			// Token: 0x04004B70 RID: 19312
			_err = -1,
			// Token: 0x04004B71 RID: 19313
			Start,
			// Token: 0x04004B72 RID: 19314
			S400,
			// Token: 0x04004B73 RID: 19315
			S400_400,
			// Token: 0x04004B74 RID: 19316
			S400_X00,
			// Token: 0x04004B75 RID: 19317
			S400_X0,
			// Token: 0x04004B76 RID: 19318
			X00_DQ,
			// Token: 0x04004B77 RID: 19319
			S400_X00_X0,
			// Token: 0x04004B78 RID: 19320
			X0_DQ,
			// Token: 0x04004B79 RID: 19321
			X,
			// Token: 0x04004B7A RID: 19322
			X0,
			// Token: 0x04004B7B RID: 19323
			X00,
			// Token: 0x04004B7C RID: 19324
			S400_DQ,
			// Token: 0x04004B7D RID: 19325
			S400_400_DQ,
			// Token: 0x04004B7E RID: 19326
			S400_400_100,
			// Token: 0x04004B7F RID: 19327
			S9,
			// Token: 0x04004B80 RID: 19328
			X00_S9,
			// Token: 0x04004B81 RID: 19329
			S9_DQ,
			// Token: 0x04004B82 RID: 19330
			END = 100
		}
	}
}
