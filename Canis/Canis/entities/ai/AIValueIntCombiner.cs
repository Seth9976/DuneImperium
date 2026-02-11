using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x02000107 RID: 263
	public class AIValueIntCombiner : Object
	{
		// Token: 0x06000BC3 RID: 3011 RVA: 0x0004BA98 File Offset: 0x00049C98
		// Note: this type is marked as 'beforefieldinit'.
		static AIValueIntCombiner()
		{
			Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIValueIntCombiner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr);
			AIValueIntCombiner.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, "values");
			AIValueIntCombiner.NativeMethodInfoPtr_AddOp_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665840);
			AIValueIntCombiner.NativeMethodInfoPtr_SubOp_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665841);
			AIValueIntCombiner.NativeMethodInfoPtr_MultOp_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665842);
			AIValueIntCombiner.NativeMethodInfoPtr_DivOp_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665843);
			AIValueIntCombiner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665844);
			AIValueIntCombiner.NativeMethodInfoPtr__ctor_Public_Void_AIValueIntCombiner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665845);
			AIValueIntCombiner.NativeMethodInfoPtr_get_Total_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665846);
			AIValueIntCombiner.NativeMethodInfoPtr_Combine_Public_Void_Int32_String_CombineOp_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665847);
			AIValueIntCombiner.NativeMethodInfoPtr_Add_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665848);
			AIValueIntCombiner.NativeMethodInfoPtr_Subtract_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665849);
			AIValueIntCombiner.NativeMethodInfoPtr_Multiply_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665850);
			AIValueIntCombiner.NativeMethodInfoPtr_Divide_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665851);
			AIValueIntCombiner.NativeMethodInfoPtr_Append_Public_Void_AIValueIntCombiner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665852);
			AIValueIntCombiner.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665853);
			AIValueIntCombiner.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueIntCombiner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665854);
			AIValueIntCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665855);
			AIValueIntCombiner.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665856);
			AIValueIntCombiner.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665857);
			AIValueIntCombiner.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665858);
			AIValueIntCombiner.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665859);
			AIValueIntCombiner.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665860);
			AIValueIntCombiner.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665861);
			AIValueIntCombiner.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665862);
			AIValueIntCombiner.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665863);
			AIValueIntCombiner.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665864);
			AIValueIntCombiner.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665865);
			AIValueIntCombiner.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665866);
			AIValueIntCombiner.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665867);
			AIValueIntCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665868);
			AIValueIntCombiner.NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665869);
			AIValueIntCombiner.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665870);
			AIValueIntCombiner.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665871);
			AIValueIntCombiner.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, 100665872);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0004BD70 File Offset: 0x00049F70
		[CallerCount(0)]
		public unsafe int AddOp(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_AddOp_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0004BDC8 File Offset: 0x00049FC8
		[CallerCount(0)]
		public unsafe int SubOp(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_SubOp_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0004BE20 File Offset: 0x0004A020
		[CallerCount(0)]
		public unsafe int MultOp(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_MultOp_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0004BE78 File Offset: 0x0004A078
		[CallerCount(0)]
		public unsafe int DivOp(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_DivOp_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0004BED0 File Offset: 0x0004A0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570449, XrefRangeEnd = 570457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueIntCombiner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0004BF0C File Offset: 0x0004A10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570457, XrefRangeEnd = 570469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueIntCombiner(AIValueIntCombiner orig)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr__ctor_Public_Void_AIValueIntCombiner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0004BF58 File Offset: 0x0004A158
		public unsafe int Total
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 570486, RefRangeEnd = 570505, XrefRangeStart = 570469, XrefRangeEnd = 570486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_get_Total_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0004BF94 File Offset: 0x0004A194
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 570511, RefRangeEnd = 570515, XrefRangeStart = 570505, XrefRangeEnd = 570511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Combine(int value, string reason, AIValueIntCombiner.CombineOp op, string opString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(opString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_Combine_Public_Void_Int32_String_CombineOp_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0004C00C File Offset: 0x0004A20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570515, XrefRangeEnd = 570526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(int value, string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_Add_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0004C05C File Offset: 0x0004A25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570526, XrefRangeEnd = 570537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subtract(int value, string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_Subtract_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0004C0AC File Offset: 0x0004A2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570537, XrefRangeEnd = 570548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Multiply(int value, string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_Multiply_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0004C0FC File Offset: 0x0004A2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570548, XrefRangeEnd = 570559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Divide(int value, string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_Divide_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0004C14C File Offset: 0x0004A34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570559, XrefRangeEnd = 570563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(AIValueIntCombiner other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_Append_Public_Void_AIValueIntCombiner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0004C190 File Offset: 0x0004A390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570563, XrefRangeEnd = 570565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0004C1C4 File Offset: 0x0004A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570565, XrefRangeEnd = 570579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(AIValueIntCombiner other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueIntCombiner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0004C214 File Offset: 0x0004A414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570579, XrefRangeEnd = 570634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIValueIntCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0004C258 File Offset: 0x0004A458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeCode GetTypeCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0004C294 File Offset: 0x0004A494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570634, XrefRangeEnd = 570642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ToBoolean(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0004C2E4 File Offset: 0x0004A4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570642, XrefRangeEnd = 570650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual byte ToByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0004C334 File Offset: 0x0004A534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570650, XrefRangeEnd = 570658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToChar(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0004C384 File Offset: 0x0004A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570658, XrefRangeEnd = 570666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DateTime ToDateTime(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0004C3D4 File Offset: 0x0004A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570666, XrefRangeEnd = 570674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal ToDecimal(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0004C424 File Offset: 0x0004A624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570674, XrefRangeEnd = 570682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double ToDouble(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0004C474 File Offset: 0x0004A674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570682, XrefRangeEnd = 570690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual short ToInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0004C4C4 File Offset: 0x0004A6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570690, XrefRangeEnd = 570698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0004C514 File Offset: 0x0004A714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570698, XrefRangeEnd = 570706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long ToInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0004C564 File Offset: 0x0004A764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570706, XrefRangeEnd = 570714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual sbyte ToSByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0004C5B4 File Offset: 0x0004A7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570714, XrefRangeEnd = 570722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ToSingle(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0004C604 File Offset: 0x0004A804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570722, XrefRangeEnd = 570727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0004C64C File Offset: 0x0004A84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570727, XrefRangeEnd = 570735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ToType(Type conversionType, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570735, XrefRangeEnd = 570743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ushort ToUInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0004C700 File Offset: 0x0004A900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570743, XrefRangeEnd = 570751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint ToUInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0004C750 File Offset: 0x0004A950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570751, XrefRangeEnd = 570759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ulong ToUInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000063CA File Offset: 0x000045CA
		public AIValueIntCombiner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x000063D3 File Offset: 0x000045D3
		public unsafe List<AIValueIntCombiner.ValueReason> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AIValueIntCombiner.ValueReason>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_AddOp_Private_Int32_Int32_Int32_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_SubOp_Private_Int32_Int32_Int32_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_MultOp_Private_Int32_Int32_Int32_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_DivOp_Private_Int32_Int32_Int32_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIValueIntCombiner_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_get_Total_Public_get_Int32_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Void_Int32_String_CombineOp_String_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Int32_String_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Void_Int32_String_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Void_Int32_String_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Void_Int32_String_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_AIValueIntCombiner_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueIntCombiner_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x0200034C RID: 844
		public sealed class CombineOp : MulticastDelegate
		{
			// Token: 0x06002340 RID: 9024 RVA: 0x0009DB30 File Offset: 0x0009BD30
			// Note: this type is marked as 'beforefieldinit'.
			static CombineOp()
			{
				Il2CppClassPointerStore<AIValueIntCombiner.CombineOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, "CombineOp");
				AIValueIntCombiner.CombineOp.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner.CombineOp>.NativeClassPtr, 100665873);
				AIValueIntCombiner.CombineOp.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner.CombineOp>.NativeClassPtr, 100665874);
				AIValueIntCombiner.CombineOp.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner.CombineOp>.NativeClassPtr, 100665875);
				AIValueIntCombiner.CombineOp.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner.CombineOp>.NativeClassPtr, 100665876);
			}

			// Token: 0x06002341 RID: 9025 RVA: 0x0009DBA4 File Offset: 0x0009BDA4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 570438, RefRangeEnd = 570440, XrefRangeStart = 570435, XrefRangeEnd = 570438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CombineOp(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueIntCombiner.CombineOp>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.CombineOp.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002342 RID: 9026 RVA: 0x0009DC00 File Offset: 0x0009BE00
			[CallerCount(0)]
			public unsafe int Invoke(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.CombineOp.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002343 RID: 9027 RVA: 0x0009DC58 File Offset: 0x0009BE58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570440, XrefRangeEnd = 570446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int a, int b, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.CombineOp.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002344 RID: 9028 RVA: 0x0009DCD8 File Offset: 0x0009BED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.CombineOp.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002345 RID: 9029 RVA: 0x00010EC2 File Offset: 0x0000F0C2
			public CombineOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002346 RID: 9030 RVA: 0x00010ECB File Offset: 0x0000F0CB
			public static implicit operator AIValueIntCombiner.CombineOp(Func<int, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<AIValueIntCombiner.CombineOp>(A_0);
			}

			// Token: 0x06002347 RID: 9031 RVA: 0x00010ED3 File Offset: 0x0000F0D3
			public static AIValueIntCombiner.CombineOp operator +(AIValueIntCombiner.CombineOp A_0, AIValueIntCombiner.CombineOp A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AIValueIntCombiner.CombineOp>();
			}

			// Token: 0x06002348 RID: 9032 RVA: 0x00010EE1 File Offset: 0x0000F0E1
			public static AIValueIntCombiner.CombineOp operator -(AIValueIntCombiner.CombineOp A_0, AIValueIntCombiner.CombineOp A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AIValueIntCombiner.CombineOp>();
				}
				return delegate2;
			}

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Int32_Int32_0;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x0200034D RID: 845
		public sealed class ValueReason : ValueType
		{
			// Token: 0x06002349 RID: 9033 RVA: 0x0009DD28 File Offset: 0x0009BF28
			// Note: this type is marked as 'beforefieldinit'.
			static ValueReason()
			{
				Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIValueIntCombiner>.NativeClassPtr, "ValueReason");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr);
				AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr, "Value");
				AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr, "Reason");
				AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr, "Op");
				AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_OpString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr, "OpString");
				AIValueIntCombiner.ValueReason.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_CombineOp_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr, 100665877);
				AIValueIntCombiner.ValueReason.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Int32_byref_String_byref_CombineOp_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr, 100665878);
			}

			// Token: 0x0600234A RID: 9034 RVA: 0x0009DDCC File Offset: 0x0009BFCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueReason(int value, string reason, AIValueIntCombiner.CombineOp op, string opString)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(opString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.ValueReason.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_CombineOp_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600234B RID: 9035 RVA: 0x0009DE50 File Offset: 0x0009C050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570446, XrefRangeEnd = 570449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out int value, out string reason, out AIValueIntCombiner.CombineOp op, out string opString)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &value;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr3 = 0;
				ptr4 = &intPtr3;
				IntPtr intPtr5;
				IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(AIValueIntCombiner.ValueReason.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Int32_byref_String_byref_CombineOp_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr5);
				Il2CppException.RaiseExceptionIfNecessary(intPtr5);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr6 = intPtr2;
				op = ((intPtr6 == 0) ? null : new AIValueIntCombiner.CombineOp(intPtr6));
				opString = IL2CPP.Il2CppStringToManaged(intPtr3);
			}

			// Token: 0x0600234C RID: 9036 RVA: 0x00010EF2 File Offset: 0x0000F0F2
			public ValueReason(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600234D RID: 9037 RVA: 0x00010EFB File Offset: 0x0000F0FB
			public ValueReason()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueIntCombiner.ValueReason>.NativeClassPtr))
			{
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x0600234E RID: 9038 RVA: 0x0009DEEC File Offset: 0x0009C0EC
			// (set) Token: 0x0600234F RID: 9039 RVA: 0x00010F0D File Offset: 0x0000F10D
			public unsafe int Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06002350 RID: 9040 RVA: 0x0009DF14 File Offset: 0x0009C114
			// (set) Token: 0x06002351 RID: 9041 RVA: 0x00010F28 File Offset: 0x0000F128
			public unsafe string Reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Reason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Reason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06002352 RID: 9042 RVA: 0x0009DF3C File Offset: 0x0009C13C
			// (set) Token: 0x06002353 RID: 9043 RVA: 0x00010F47 File Offset: 0x0000F147
			public unsafe AIValueIntCombiner.CombineOp Op
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Op);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIValueIntCombiner.CombineOp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_Op), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06002354 RID: 9044 RVA: 0x0009DF6C File Offset: 0x0009C16C
			// (set) Token: 0x06002355 RID: 9045 RVA: 0x00010F66 File Offset: 0x0000F166
			public unsafe string OpString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_OpString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueIntCombiner.ValueReason.NativeFieldInfoPtr_OpString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeFieldInfoPtr_Op;

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeFieldInfoPtr_OpString;

			// Token: 0x04001628 RID: 5672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_CombineOp_String_0;

			// Token: 0x04001629 RID: 5673
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Int32_byref_String_byref_CombineOp_byref_String_0;
		}
	}
}
