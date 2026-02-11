using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x02000106 RID: 262
	public class AIValueDoubleCombiner : Object
	{
		// Token: 0x06000B9E RID: 2974 RVA: 0x0004AD60 File Offset: 0x00048F60
		// Note: this type is marked as 'beforefieldinit'.
		static AIValueDoubleCombiner()
		{
			Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIValueDoubleCombiner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr);
			AIValueDoubleCombiner.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, "values");
			AIValueDoubleCombiner.NativeMethodInfoPtr_AddOp_Private_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665801);
			AIValueDoubleCombiner.NativeMethodInfoPtr_SubOp_Private_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665802);
			AIValueDoubleCombiner.NativeMethodInfoPtr_MultOp_Private_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665803);
			AIValueDoubleCombiner.NativeMethodInfoPtr_DivOp_Private_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665804);
			AIValueDoubleCombiner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665805);
			AIValueDoubleCombiner.NativeMethodInfoPtr__ctor_Public_Void_AIValueDoubleCombiner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665806);
			AIValueDoubleCombiner.NativeMethodInfoPtr_get_Total_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665807);
			AIValueDoubleCombiner.NativeMethodInfoPtr_Combine_Public_Void_Double_String_CombineOp_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665808);
			AIValueDoubleCombiner.NativeMethodInfoPtr_Add_Public_Void_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665809);
			AIValueDoubleCombiner.NativeMethodInfoPtr_Subtract_Public_Void_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665810);
			AIValueDoubleCombiner.NativeMethodInfoPtr_Multiply_Public_Void_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665811);
			AIValueDoubleCombiner.NativeMethodInfoPtr_Divide_Public_Void_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665812);
			AIValueDoubleCombiner.NativeMethodInfoPtr_Append_Public_Void_AIValueDoubleCombiner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665813);
			AIValueDoubleCombiner.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665814);
			AIValueDoubleCombiner.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueDoubleCombiner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665815);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665816);
			AIValueDoubleCombiner.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665817);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665818);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665819);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665820);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665821);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665822);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665823);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665824);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665825);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665826);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665827);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665828);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665829);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665830);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665831);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665832);
			AIValueDoubleCombiner.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, 100665833);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0004B038 File Offset: 0x00049238
		[CallerCount(0)]
		public unsafe double AddOp(double a, double b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_AddOp_Private_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0004B090 File Offset: 0x00049290
		[CallerCount(0)]
		public unsafe double SubOp(double a, double b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_SubOp_Private_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0004B0E8 File Offset: 0x000492E8
		[CallerCount(0)]
		public unsafe double MultOp(double a, double b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_MultOp_Private_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0004B140 File Offset: 0x00049340
		[CallerCount(0)]
		public unsafe double DivOp(double a, double b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_DivOp_Private_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0004B198 File Offset: 0x00049398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570125, XrefRangeEnd = 570133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueDoubleCombiner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0004B1D4 File Offset: 0x000493D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570133, XrefRangeEnd = 570145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueDoubleCombiner(AIValueDoubleCombiner orig)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr__ctor_Public_Void_AIValueDoubleCombiner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0004B220 File Offset: 0x00049420
		public unsafe double Total
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 570162, RefRangeEnd = 570181, XrefRangeStart = 570145, XrefRangeEnd = 570162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_get_Total_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0004B25C File Offset: 0x0004945C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 570187, RefRangeEnd = 570191, XrefRangeStart = 570181, XrefRangeEnd = 570187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Combine(double value, string reason, AIValueDoubleCombiner.CombineOp op, string opString)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_Combine_Public_Void_Double_String_CombineOp_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0004B2D4 File Offset: 0x000494D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570191, XrefRangeEnd = 570202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(double value, string reason)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_Add_Public_Void_Double_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0004B324 File Offset: 0x00049524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570202, XrefRangeEnd = 570213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subtract(double value, string reason)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_Subtract_Public_Void_Double_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0004B374 File Offset: 0x00049574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570213, XrefRangeEnd = 570224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Multiply(double value, string reason)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_Multiply_Public_Void_Double_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0004B3C4 File Offset: 0x000495C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570224, XrefRangeEnd = 570235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Divide(double value, string reason)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_Divide_Public_Void_Double_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0004B414 File Offset: 0x00049614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570235, XrefRangeEnd = 570239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(AIValueDoubleCombiner other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_Append_Public_Void_AIValueDoubleCombiner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0004B458 File Offset: 0x00049658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570239, XrefRangeEnd = 570241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0004B48C File Offset: 0x0004968C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570241, XrefRangeEnd = 570255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(AIValueDoubleCombiner other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueDoubleCombiner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0004B4DC File Offset: 0x000496DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570255, XrefRangeEnd = 570310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIValueDoubleCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0004B520 File Offset: 0x00049720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeCode GetTypeCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0004B55C File Offset: 0x0004975C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570310, XrefRangeEnd = 570318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ToBoolean(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0004B5AC File Offset: 0x000497AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570318, XrefRangeEnd = 570326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual byte ToByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0004B5FC File Offset: 0x000497FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570326, XrefRangeEnd = 570334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToChar(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0004B64C File Offset: 0x0004984C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570334, XrefRangeEnd = 570342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DateTime ToDateTime(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0004B69C File Offset: 0x0004989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570342, XrefRangeEnd = 570350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal ToDecimal(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0004B6EC File Offset: 0x000498EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570350, XrefRangeEnd = 570358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double ToDouble(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0004B73C File Offset: 0x0004993C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570358, XrefRangeEnd = 570366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual short ToInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0004B78C File Offset: 0x0004998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570366, XrefRangeEnd = 570374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0004B7DC File Offset: 0x000499DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570374, XrefRangeEnd = 570382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long ToInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004B82C File Offset: 0x00049A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570382, XrefRangeEnd = 570390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual sbyte ToSByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0004B87C File Offset: 0x00049A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570390, XrefRangeEnd = 570398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ToSingle(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0004B8CC File Offset: 0x00049ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570398, XrefRangeEnd = 570403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0004B914 File Offset: 0x00049B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570403, XrefRangeEnd = 570411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0004B978 File Offset: 0x00049B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570411, XrefRangeEnd = 570419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ushort ToUInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0004B9C8 File Offset: 0x00049BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570419, XrefRangeEnd = 570427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint ToUInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0004BA18 File Offset: 0x00049C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570427, XrefRangeEnd = 570435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ulong ToUInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000063A2 File Offset: 0x000045A2
		public AIValueDoubleCombiner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0004BA68 File Offset: 0x00049C68
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x000063AB File Offset: 0x000045AB
		public unsafe List<AIValueDoubleCombiner.ValueReason> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AIValueDoubleCombiner.ValueReason>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_AddOp_Private_Double_Double_Double_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_SubOp_Private_Double_Double_Double_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_MultOp_Private_Double_Double_Double_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_DivOp_Private_Double_Double_Double_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIValueDoubleCombiner_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_get_Total_Public_get_Double_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Void_Double_String_CombineOp_String_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Double_String_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Void_Double_String_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Void_Double_String_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Void_Double_String_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_AIValueDoubleCombiner_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueDoubleCombiner_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x0200034A RID: 842
		public sealed class CombineOp : MulticastDelegate
		{
			// Token: 0x0600232A RID: 9002 RVA: 0x0009D6CC File Offset: 0x0009B8CC
			// Note: this type is marked as 'beforefieldinit'.
			static CombineOp()
			{
				Il2CppClassPointerStore<AIValueDoubleCombiner.CombineOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, "CombineOp");
				AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner.CombineOp>.NativeClassPtr, 100665834);
				AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner.CombineOp>.NativeClassPtr, 100665835);
				AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Double_Double_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner.CombineOp>.NativeClassPtr, 100665836);
				AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Double_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner.CombineOp>.NativeClassPtr, 100665837);
			}

			// Token: 0x0600232B RID: 9003 RVA: 0x0009D740 File Offset: 0x0009B940
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 570110, RefRangeEnd = 570111, XrefRangeStart = 570107, XrefRangeEnd = 570110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CombineOp(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueDoubleCombiner.CombineOp>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600232C RID: 9004 RVA: 0x0009D79C File Offset: 0x0009B99C
			[CallerCount(0)]
			public unsafe double Invoke(double a, double b)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600232D RID: 9005 RVA: 0x0009D7F4 File Offset: 0x0009B9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570111, XrefRangeEnd = 570117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(double a, double b, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Double_Double_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600232E RID: 9006 RVA: 0x0009D874 File Offset: 0x0009BA74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570117, XrefRangeEnd = 570119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.CombineOp.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Double_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600232F RID: 9007 RVA: 0x00010DFF File Offset: 0x0000EFFF
			public CombineOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002330 RID: 9008 RVA: 0x00010E08 File Offset: 0x0000F008
			public static implicit operator AIValueDoubleCombiner.CombineOp(Func<double, double, double> A_0)
			{
				return DelegateSupport.ConvertDelegate<AIValueDoubleCombiner.CombineOp>(A_0);
			}

			// Token: 0x06002331 RID: 9009 RVA: 0x00010E10 File Offset: 0x0000F010
			public static AIValueDoubleCombiner.CombineOp operator +(AIValueDoubleCombiner.CombineOp A_0, AIValueDoubleCombiner.CombineOp A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AIValueDoubleCombiner.CombineOp>();
			}

			// Token: 0x06002332 RID: 9010 RVA: 0x00010E1E File Offset: 0x0000F01E
			public static AIValueDoubleCombiner.CombineOp operator -(AIValueDoubleCombiner.CombineOp A_0, AIValueDoubleCombiner.CombineOp A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AIValueDoubleCombiner.CombineOp>();
				}
				return delegate2;
			}

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Double_Double_Double_0;

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Double_Double_AsyncCallback_Object_0;

			// Token: 0x04001619 RID: 5657
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Double_IAsyncResult_0;
		}

		// Token: 0x0200034B RID: 843
		public sealed class ValueReason : ValueType
		{
			// Token: 0x06002333 RID: 9011 RVA: 0x0009D8C4 File Offset: 0x0009BAC4
			// Note: this type is marked as 'beforefieldinit'.
			static ValueReason()
			{
				Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIValueDoubleCombiner>.NativeClassPtr, "ValueReason");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr);
				AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr, "Value");
				AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr, "Reason");
				AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr, "Op");
				AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_OpString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr, "OpString");
				AIValueDoubleCombiner.ValueReason.NativeMethodInfoPtr__ctor_Public_Void_Double_String_CombineOp_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr, 100665838);
				AIValueDoubleCombiner.ValueReason.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Double_byref_String_byref_CombineOp_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr, 100665839);
			}

			// Token: 0x06002334 RID: 9012 RVA: 0x0009D968 File Offset: 0x0009BB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570119, XrefRangeEnd = 570122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueReason(double value, string reason, AIValueDoubleCombiner.CombineOp op, string opString)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr))
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.ValueReason.NativeMethodInfoPtr__ctor_Public_Void_Double_String_CombineOp_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002335 RID: 9013 RVA: 0x0009D9EC File Offset: 0x0009BBEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570122, XrefRangeEnd = 570125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out double value, out string reason, out AIValueDoubleCombiner.CombineOp op, out string opString)
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
				IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(AIValueDoubleCombiner.ValueReason.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Double_byref_String_byref_CombineOp_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr5);
				Il2CppException.RaiseExceptionIfNecessary(intPtr5);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr6 = intPtr2;
				op = ((intPtr6 == 0) ? null : new AIValueDoubleCombiner.CombineOp(intPtr6));
				opString = IL2CPP.Il2CppStringToManaged(intPtr3);
			}

			// Token: 0x06002336 RID: 9014 RVA: 0x00010E2F File Offset: 0x0000F02F
			public ValueReason(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002337 RID: 9015 RVA: 0x00010E38 File Offset: 0x0000F038
			public ValueReason()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueDoubleCombiner.ValueReason>.NativeClassPtr))
			{
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06002338 RID: 9016 RVA: 0x0009DA88 File Offset: 0x0009BC88
			// (set) Token: 0x06002339 RID: 9017 RVA: 0x00010E4A File Offset: 0x0000F04A
			public unsafe double Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x0600233A RID: 9018 RVA: 0x0009DAB0 File Offset: 0x0009BCB0
			// (set) Token: 0x0600233B RID: 9019 RVA: 0x00010E65 File Offset: 0x0000F065
			public unsafe string Reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Reason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Reason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x0600233C RID: 9020 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
			// (set) Token: 0x0600233D RID: 9021 RVA: 0x00010E84 File Offset: 0x0000F084
			public unsafe AIValueDoubleCombiner.CombineOp Op
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Op);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIValueDoubleCombiner.CombineOp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_Op), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x0600233E RID: 9022 RVA: 0x0009DB08 File Offset: 0x0009BD08
			// (set) Token: 0x0600233F RID: 9023 RVA: 0x00010EA3 File Offset: 0x0000F0A3
			public unsafe string OpString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_OpString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueDoubleCombiner.ValueReason.NativeFieldInfoPtr_OpString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeFieldInfoPtr_Op;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeFieldInfoPtr_OpString;

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_String_CombineOp_String_0;

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Double_byref_String_byref_CombineOp_byref_String_0;
		}
	}
}
