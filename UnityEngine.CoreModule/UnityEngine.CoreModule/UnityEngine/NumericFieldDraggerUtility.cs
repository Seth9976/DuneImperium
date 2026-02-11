using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000108 RID: 264
	public class NumericFieldDraggerUtility : Object
	{
		// Token: 0x0600163E RID: 5694 RVA: 0x0006B7E4 File Offset: 0x000699E4
		// Note: this type is marked as 'beforefieldinit'.
		static NumericFieldDraggerUtility()
		{
			Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "NumericFieldDraggerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr);
			NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, "s_UseYSign");
			NumericFieldDraggerUtility.NativeMethodInfoPtr_Acceleration_Internal_Static_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666377);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_NiceDelta_Internal_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666378);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666379);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666380);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666381);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666382);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Private_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666383);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666384);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0006B8C8 File Offset: 0x00069AC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 659956, RefRangeEnd = 659964, XrefRangeStart = 659956, XrefRangeEnd = 659956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Acceleration(bool shiftPressed, bool altPressed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shiftPressed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altPressed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_Acceleration_Internal_Static_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0006B914 File Offset: 0x00069B14
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 659971, RefRangeEnd = 659979, XrefRangeStart = 659964, XrefRangeEnd = 659971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float NiceDelta(Vector2 deviceDelta, float acceleration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceDelta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceleration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_NiceDelta_Internal_Static_Single_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0006B960 File Offset: 0x00069B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 659984, RefRangeEnd = 659986, XrefRangeStart = 659979, XrefRangeEnd = 659984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CalculateFloatDragSensitivity(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0006B9A0 File Offset: 0x00069BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 659990, RefRangeEnd = 659991, XrefRangeStart = 659986, XrefRangeEnd = 659990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0006B9FC File Offset: 0x00069BFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 659992, RefRangeEnd = 659995, XrefRangeStart = 659991, XrefRangeEnd = 659992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CalculateIntDragSensitivity(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0006BA3C File Offset: 0x00069C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 659997, RefRangeEnd = 659998, XrefRangeStart = 659995, XrefRangeEnd = 659997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong CalculateIntDragSensitivity(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0006BA7C File Offset: 0x00069C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660003, RefRangeEnd = 660005, XrefRangeStart = 659998, XrefRangeEnd = 660003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CalculateIntDragSensitivity(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Private_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0006BABC File Offset: 0x00069CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 660009, RefRangeEnd = 660010, XrefRangeStart = 660005, XrefRangeEnd = 660009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CalculateIntDragSensitivity(long value, long minValue, long maxValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00008CFB File Offset: 0x00006EFB
		public NumericFieldDraggerUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x0006BB18 File Offset: 0x00069D18
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00008D04 File Offset: 0x00006F04
		public unsafe static bool s_UseYSign
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign, (void*)(&value));
			}
		}

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeFieldInfoPtr_s_UseYSign;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_Acceleration_Internal_Static_Single_Boolean_Boolean_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_NiceDelta_Internal_Static_Single_Vector2_Single_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_Double_Double_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_UInt64_UInt64_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Private_Static_Double_Double_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_Int64_Int64_0;

		// Token: 0x04001489 RID: 5257
		public const float kDragSensitivity = 0.03f;
	}
}
